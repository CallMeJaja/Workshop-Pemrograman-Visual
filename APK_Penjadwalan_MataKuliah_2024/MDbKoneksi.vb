Imports MySql.Data.MySqlClient

Module MDbKoneksi
    Public DBKoneksi As MySqlConnection
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public CMD As MySqlCommand
    Public DR As MySqlDataReader
    Public Hitung As Integer = 0
    Public Hasil As String
    Public Kode_Jurusan As String
    Public Kode_Semester As String
    Public Nomor As Integer
    Public isLogin As Boolean = False
    Public Nama_User As String
    Public Nama_Jurusan As String
    Public Role As String

    Public DBLokasi As String
    Public Query As String
    Public SQLInsert As String
    Public SQLUpdate As String
    Public SQLDelete As String
    Public Pesan As String
    Public PesanMkl As String
    Public PesanSmtr As String

    Public Sub KoneksiDB()
        Try
            DBLokasi = "Server=localhost;Uid=root;pwd='';Database=db_akademik24"

            DBKoneksi = New MySqlConnection(DBLokasi)
            If DBKoneksi.State = ConnectionState.Closed Then
                DBKoneksi.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal!", vbExclamation, "Koneksi Gagal")
        End Try
    End Sub

    Function DisconnectDB()
        DBKoneksi.Close()
        Return DBKoneksi
    End Function

    Public Function Rep(ByVal kata As String) As String
        Rep = Replace(kata, "'", "''")
        Return Rep
    End Function
End Module
