Imports MySql.Data.MySqlClient
Imports System.Configuration

''' <summary>
''' Database Helper Class - Handles all database operations with best practices
''' Features: Connection pooling, Parameterized queries, Auto-disposal, Error handling
''' </summary>
Public Class DatabaseHelper

#Region "Connection String Management"

    ' Private connection string - not exposed to other classes
    Private Shared ReadOnly ConnectionString As String = BuildConnectionString()

    ''' <summary>
    ''' Build connection string from config or hardcoded values
    ''' </summary>
    Private Shared Function BuildConnectionString() As String
        ' Option 1: From App.config (RECOMMENDED for production)
        ' Dim connStr As String = ConfigurationManager.ConnectionStrings("AkademikDB").ConnectionString
        ' Return connStr

        ' Option 2: Hardcoded (for development only)
        Dim builder As New MySqlConnectionStringBuilder With {
            .Server = "localhost",
            .Database = "db_akademik24",
            .UserID = "root",
            .Password = "",
            .Port = 3306,
            .Pooling = True,
            .MinimumPoolSize = 0,
            .MaximumPoolSize = 100,
            .ConnectionLifeTime = 0,
            .ConnectionTimeout = 30,
            .AllowUserVariables = True,
            .CharacterSet = "utf8mb4"
        }

        Return builder.ConnectionString
    End Function

    ''' <summary>
    ''' Test database connection
    ''' </summary>
    Public Shared Function TestConnection() As Boolean
        Try
            Using conn As New MySqlConnection(ConnectionString)
                conn.Open()
                Return conn.State = ConnectionState.Open
            End Using
        Catch ex As Exception
            MessageBox.Show("Koneksi database gagal: " & ex.Message,
                          "Error Koneksi",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
            Return False
        End Try
    End Function

#End Region

#Region "Execute Query Methods"

    ''' <summary>
    ''' Execute SELECT query and return DataTable
    ''' Usage: Dim dt = DatabaseHelper.ExecuteQuery("SELECT * FROM tbl_mahasiswa WHERE Kd_Prodi = @prodi", New MySqlParameter("@prodi", "04"))
    ''' </summary>
    Public Shared Function ExecuteQuery(query As String, ParamArray parameters() As MySqlParameter) As DataTable
        Dim dt As New DataTable()

        Try
            Using conn As New MySqlConnection(ConnectionString)
                Using cmd As New MySqlCommand(query, conn)
                    ' Add parameters if provided
                    If parameters IsNot Nothing AndAlso parameters.Length > 0 Then
                        cmd.Parameters.AddRange(parameters)
                    End If

                    conn.Open()

                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "MySQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Log error to file or logging system
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    ''' <summary>
    ''' Execute INSERT, UPDATE, DELETE and return affected rows count
    ''' Usage: Dim affected = DatabaseHelper.ExecuteNonQuery("INSERT INTO tbl_mahasiswa VALUES (@nim, @nama)", New MySqlParameter("@nim", "2025040001"), New MySqlParameter("@nama", "John"))
    ''' </summary>
    Public Shared Function ExecuteNonQuery(query As String, ParamArray parameters() As MySqlParameter) As Integer
        Dim affectedRows As Integer = 0

        Try
            Using conn As New MySqlConnection(ConnectionString)
                Using cmd As New MySqlCommand(query, conn)
                    ' Add parameters if provided
                    If parameters IsNot Nothing AndAlso parameters.Length > 0 Then
                        cmd.Parameters.AddRange(parameters)
                    End If

                    conn.Open()
                    affectedRows = cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "MySQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return affectedRows
    End Function

    ''' <summary>
    ''' Execute scalar query (return single value like COUNT, MAX, etc)
    ''' Usage: Dim count = DatabaseHelper.ExecuteScalar(Of Integer)("SELECT COUNT(*) FROM tbl_mahasiswa WHERE Kd_Prodi = @prodi", New MySqlParameter("@prodi", "04"))
    ''' </summary>
    Public Shared Function ExecuteScalar(Of T)(query As String, ParamArray parameters() As MySqlParameter) As T
        Dim result As Object = Nothing

        Try
            Using conn As New MySqlConnection(ConnectionString)
                Using cmd As New MySqlCommand(query, conn)
                    ' Add parameters if provided
                    If parameters IsNot Nothing AndAlso parameters.Length > 0 Then
                        cmd.Parameters.AddRange(parameters)
                    End If

                    conn.Open()
                    result = cmd.ExecuteScalar()
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "MySQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Safe type conversion
        If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
            Return CType(result, T)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' Execute query and return DataReader (for large datasets)
    ''' WARNING: Connection stays open until reader is closed - use with caution
    ''' </summary>
    Public Shared Function ExecuteReader(query As String, ParamArray parameters() As MySqlParameter) As MySqlDataReader
        Dim conn As New MySqlConnection(ConnectionString)
        Dim cmd As MySqlCommand = Nothing
        Dim reader As MySqlDataReader = Nothing

        Try
            cmd = New MySqlCommand(query, conn)

            ' Add parameters if provided
            If parameters IsNot Nothing AndAlso parameters.Length > 0 Then
                cmd.Parameters.AddRange(parameters)
            End If

            conn.Open()

            ' CommandBehavior.CloseConnection ensures connection closes when reader closes
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        Catch ex As Exception
            ' Clean up on error
            If conn IsNot Nothing Then conn.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return reader
    End Function

#End Region

#Region "Transaction Support"

    ''' <summary>
    ''' Execute multiple queries in a transaction (all or nothing)
    ''' Usage: See example below
    ''' </summary>
    Public Shared Function ExecuteTransaction(queries As List(Of String), parametersList As List(Of MySqlParameter())) As Boolean
        Dim success As Boolean = False

        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()

            Dim transaction As MySqlTransaction = conn.BeginTransaction()

            Try
                For i As Integer = 0 To queries.Count - 1
                    Using cmd As New MySqlCommand(queries(i), conn, transaction)
                        If parametersList IsNot Nothing AndAlso i < parametersList.Count Then
                            cmd.Parameters.AddRange(parametersList(i))
                        End If

                        cmd.ExecuteNonQuery()
                    End Using
                Next

                transaction.Commit()
                success = True

            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Transaction failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                success = False
            End Try
        End Using

        Return success
    End Function

#End Region

#Region "Helper Methods for Common Operations"

    ''' <summary>
    ''' Check if record exists
    ''' </summary>
    Public Shared Function RecordExists(tableName As String, whereClause As String, ParamArray parameters() As MySqlParameter) As Boolean
        Dim query As String = $"SELECT COUNT(*) FROM {tableName} WHERE {whereClause}"
        Dim count As Integer = ExecuteScalar(Of Integer)(query, parameters)
        Return count > 0
    End Function

    ''' <summary>
    ''' Get next auto-increment ID for custom ID generation
    ''' Example: Generate NIM with format TahunKodeProdiNomor
    ''' </summary>
    Public Shared Function GetNextSequence(tableName As String, columnName As String, prefix As String) As String
        Dim query As String = $"SELECT {columnName} FROM {tableName} WHERE {columnName} LIKE @prefix ORDER BY {columnName} DESC LIMIT 1"
        Dim param As New MySqlParameter("@prefix", prefix & "%")

        Dim lastID As String = ExecuteScalar(Of String)(query, param)

        If String.IsNullOrEmpty(lastID) Then
            ' First record
            Return prefix & "001"
        Else
            ' Extract number part and increment
            Dim numberPart As String = lastID.Substring(prefix.Length)
            Dim nextNumber As Integer = CInt(numberPart) + 1
            Return prefix & nextNumber.ToString().PadLeft(3, "0"c)
        End If
    End Function

    ''' <summary>
    ''' Fill ComboBox with data from database
    ''' </summary>
    Public Shared Sub FillComboBox(comboBox As ComboBox, query As String, displayMember As String, valueMember As String, ParamArray parameters() As MySqlParameter)
        Try
            Dim dt As DataTable = ExecuteQuery(query, parameters)

            comboBox.DataSource = dt
            comboBox.DisplayMember = displayMember
            comboBox.ValueMember = valueMember
            comboBox.SelectedIndex = -1 ' No selection

        Catch ex As Exception
            MessageBox.Show("Error filling ComboBox: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Fill DataGridView with data
    ''' </summary>
    Public Shared Sub FillDataGridView(dataGridView As DataGridView, query As String, ParamArray parameters() As MySqlParameter)
        Try
            Dim dt As DataTable = ExecuteQuery(query, parameters)
            dataGridView.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error filling DataGridView: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Validation Helpers"

    ''' <summary>
    ''' Validate required fields in form
    ''' </summary>
    Public Shared Function ValidateRequiredFields(ParamArray controls() As Control) As Boolean
        For Each ctrl As Control In controls
            If TypeOf ctrl Is TextBox Then
                If String.IsNullOrWhiteSpace(DirectCast(ctrl, TextBox).Text) Then
                    MessageBox.Show($"Field '{ctrl.Name}' tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ctrl.Focus()
                    Return False
                End If
            ElseIf TypeOf ctrl Is ComboBox Then
                If DirectCast(ctrl, ComboBox).SelectedIndex = -1 Then
                    MessageBox.Show($"Field '{ctrl.Name}' harus dipilih!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ctrl.Focus()
                    Return False
                End If
            End If
        Next

        Return True
    End Function

#End Region

End Class
