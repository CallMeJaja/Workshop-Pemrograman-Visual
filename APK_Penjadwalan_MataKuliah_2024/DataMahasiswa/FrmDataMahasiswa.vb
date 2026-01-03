Imports MySql.Data.MySqlClient

Public Class FrmDataMahasiswa
    Private Const SQL_SELECT_MAHASISWA As String = "SELECT DISTINCT
        tbl_mahasiswa.NIK_Mhs, 
        tbl_mahasiswa.Nm_Mhs, 
        tbl_mahasiswa.JK_Mhs, 
        tbl_mahasiswa.tmptlahir_Mhs, 
        tbl_mahasiswa.TglLahir_Mhs, 
        tbl_mahasiswa.Alamat_Mhs, 
        tbl_mahasiswa.Status_Mhs,
        tbl_prodi.Nm_Prodi
    FROM tbl_mahasiswa
    INNER JOIN tbl_prodi ON tbl_mahasiswa.Kd_Prodi = tbl_prodi.Kd_Prodi"

    Private isLoadingData As Boolean = False

    Private Sub FrmDataMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call KoneksiDB()
            Call FormNonAktif()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "ERROR")
        End Try
    End Sub

    Private Sub BtnCariData_Click(sender As Object, e As EventArgs) Handles BtnCariData.Click
        If BtnCariData.Text = "AKTIFKAN FORM" Then
            Call FormAktif()
        Else
            Call CariMahasiswa()
        End If
    End Sub

    Private Sub BtnTambahData_Click(sender As Object, e As EventArgs) Handles BtnTambahData.Click
        If Not ValidateTambahData() Then Exit Sub
        Try
            Me.Enabled = False
            Call BuatNIMMahasiswa(LblKdProdi.Text)
            Call ShowFormInput(isEditMode:=False)
        Catch ex As Exception
            Me.Enabled = True
            MsgBox("Error: " & ex.Message, vbCritical, "ERROR")
        End Try
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        If BtnKeluar.Text = "KELUAR" Then
            If MsgBox("Anda yakin ingin keluar?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
                Me.Close()
            End If
        Else
            Call FormNonAktif()
        End If
    End Sub

    Private Sub CbNamaJurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNamaJurusan.SelectedIndexChanged
        Try
            Call KoneksiDB()

            If CbNamaJurusan.SelectedIndex > 0 Then
                Call LoadKodeProdi()
                Call LoadTahunAngkatanByProdi()
            Else
                LblKdProdi.Text = ""
                Kode_Jurusan = ""
                Call LoadTahunAngkatan()
            End If

            Call FilterMahasiswa()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "ERROR")
        End Try
    End Sub

    Private Sub LoadTahunAngkatanByProdi()
        Try
            CmbTahunAngkatan.Items.Clear()
            CmbTahunAngkatan.Items.Add("SEMUA TAHUN")
            Dim SQLTahun As String = "SELECT DISTINCT LEFT(NIK_Mhs, 4) AS Tahun FROM tbl_mahasiswa INNER JOIN tbl_prodi ON tbl_mahasiswa.Kd_Prodi = tbl_prodi.Kd_Prodi WHERE tbl_prodi.Kd_Prodi = @KdProdi ORDER BY Tahun DESC"

            Dim CMDTahun As New MySqlCommand(SQLTahun, DBKoneksi)
            CMDTahun.Parameters.AddWithValue("@KdProdi", Kode_Jurusan)
            Dim DRTahun As MySqlDataReader = CMDTahun.ExecuteReader()

            While DRTahun.Read()
                CmbTahunAngkatan.Items.Add(DRTahun("Tahun").ToString())
            End While

            DRTahun.Close()
            CmbTahunAngkatan.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Error load tahun angkatan: " & ex.Message, vbCritical, "ERROR")
            CmbTahunAngkatan.Items.Clear()
            CmbTahunAngkatan.Items.Add("SEMUA TAHUN")
            CmbTahunAngkatan.SelectedIndex = 0
        End Try
    End Sub

    Private Sub CmbTahunAngkatan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTahunAngkatan.SelectedIndexChanged
        Try
            If CmbTahunAngkatan.SelectedIndex = -1 Then Exit Sub
            Call KoneksiDB()
            Call FilterMahasiswa()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "ERROR")
        End Try
    End Sub

    Private Sub TxtCariNama_TextChanged(sender As Object, e As EventArgs) Handles TxtCariNama.TextChanged
        If String.IsNullOrWhiteSpace(TxtCariNama.Text) Then
            If CbNamaJurusan.SelectedIndex <> -1 Then
                Call FilterMahasiswa()
            End If
        End If
    End Sub

    Private Sub TxtCariNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCariNama.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            If BtnCariData.Enabled Then BtnCariData.PerformClick()
        End If
    End Sub

    Private Sub DataGridMahasiswa_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridMahasiswa.CellMouseDoubleClick
        Try
            If e.RowIndex < 0 Then Exit Sub
            If Not ValidateGridSelection(e.RowIndex) Then Exit Sub

            Call LoadDataToFormInput(e.RowIndex)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "ERROR")
        End Try
    End Sub

    Sub TampilkanDataGridMahasiswa()
        Try
            Call KoneksiDB()
            Call LoadDataGrid(SQL_SELECT_MAHASISWA & " ORDER BY tbl_mahasiswa.NIK_Mhs")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "ERROR")
        End Try
    End Sub

    ' UPDATE: Method baru untuk filter gabungan Prodi + Tahun
    Sub FilterMahasiswa()
        Try
            If CbNamaJurusan.SelectedIndex = -1 Then Exit Sub

            Dim sqlFilter As String = SQL_SELECT_MAHASISWA
            Dim hasWhere As Boolean = False

            If CbNamaJurusan.SelectedIndex > 0 Then
                sqlFilter &= " WHERE tbl_prodi.Nm_Prodi = @NmProdi"
                hasWhere = True
            End If

            If CmbTahunAngkatan.SelectedIndex > 0 Then
                If hasWhere Then
                    sqlFilter &= " AND LEFT(tbl_mahasiswa.NIK_Mhs, 4) = @Tahun"
                Else
                    sqlFilter &= " WHERE LEFT(tbl_mahasiswa.NIK_Mhs, 4) = @Tahun"
                    hasWhere = True
                End If
            End If

            sqlFilter &= " ORDER BY tbl_mahasiswa.NIK_Mhs"

            DA = New MySqlDataAdapter(sqlFilter, DBKoneksi)

            If CbNamaJurusan.SelectedIndex > 0 Then
                DA.SelectCommand.Parameters.AddWithValue("@NmProdi", CbNamaJurusan.Text.Trim())
            End If

            If CmbTahunAngkatan.SelectedIndex > 0 Then
                DA.SelectCommand.Parameters.AddWithValue("@Tahun", CmbTahunAngkatan.Text)
            End If

            DS = New DataSet()
            Dim rowCount As Integer = DA.Fill(DS)

            If rowCount > 0 Then
                DataGridMahasiswa.DataSource = DS.Tables(0)
                DataGridMahasiswa.ReadOnly = True
                Call StyleDataGrid()
            Else
                MsgBox("Tidak ada data dengan filter yang dipilih!", vbInformation, "INFORMASI")
                DataGridMahasiswa.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "ERROR")
        End Try
    End Sub
    Sub TampilkanFilterDataProdi()
        Try
            Call KoneksiDB()

            Dim sqlProdi As String = "SELECT Nm_Prodi FROM tbl_prodi ORDER BY Nm_Prodi"
            CMD = New MySqlCommand(sqlProdi, DBKoneksi)
            DR = CMD.ExecuteReader()

            CbNamaJurusan.Items.Clear()
            CbNamaJurusan.Items.Add("SEMUA PRODI")

            While DR.Read()
                CbNamaJurusan.Items.Add(DR("Nm_Prodi").ToString())
            End While
            DR.Close()

            CbNamaJurusan.SelectedIndex = 0

        Catch ex As Exception
            If DR IsNot Nothing AndAlso Not DR.IsClosed Then DR.Close()
            MsgBox("Error: " & ex.Message, vbCritical, "ERROR")
        End Try
    End Sub

    Sub LoadTahunAngkatan()
        Try
            Call KoneksiDB()
            ' TODO: Ambil Tahun Angkatannya By Prodi
            Dim sqlTahun As String = "SELECT DISTINCT LEFT(NIK_Mhs, 4) AS Tahun FROM tbl_mahasiswa ORDER BY Tahun DESC"
            CMD = New MySqlCommand(sqlTahun, DBKoneksi)
            DR = CMD.ExecuteReader()

            CmbTahunAngkatan.Items.Clear()
            CmbTahunAngkatan.Items.Add("SEMUA TAHUN")

            While DR.Read()
                CmbTahunAngkatan.Items.Add(DR("Tahun").ToString())
            End While
            DR.Close()

            CmbTahunAngkatan.SelectedIndex = 0

        Catch ex As Exception
            If DR IsNot Nothing AndAlso Not DR.IsClosed Then DR.Close()
            MsgBox("Error load tahun: " & ex.Message, vbCritical, "ERROR")
        End Try
    End Sub

    Sub BuatNIMMahasiswa(kodeProdi As String)
        Try
            Call KoneksiDB()
            Dim tahunSekarang As String = Format(Date.Now, "yyyy")
            Dim prefix As String = tahunSekarang & kodeProdi

            Dim sqlNIM As String = "SELECT NIK_Mhs FROM tbl_mahasiswa WHERE NIK_Mhs LIKE @Prefix ORDER BY NIK_Mhs DESC LIMIT 1"
            CMD = New MySqlCommand(sqlNIM, DBKoneksi)
            CMD.Parameters.AddWithValue("@Prefix", prefix & "%")

            DR = CMD.ExecuteReader()
            Dim urutan As Integer = 1

            If DR.Read() Then
                Dim lastNIM As String = DR("NIK_Mhs").ToString()
                If lastNIM.Length >= 9 Then
                    urutan = CInt(Microsoft.VisualBasic.Right(lastNIM, 3)) + 1
                End If
            End If
            DR.Close()

            Dim nimBaru As String = prefix & urutan.ToString("000")
            FrmInputMahasiswa.LbNimVal.Text = nimBaru

        Catch ex As Exception
            If DR IsNot Nothing AndAlso Not DR.IsClosed Then DR.Close()
            MsgBox("Error membuat NIM: " & ex.Message, vbCritical, "ERROR")
        End Try
    End Sub

    Private Sub LoadDataGrid(sqlQuery As String, Optional paramValue As String = Nothing)
        DA = New MySqlDataAdapter(sqlQuery, DBKoneksi)
        If Not String.IsNullOrEmpty(paramValue) Then
            DA.SelectCommand.Parameters.AddWithValue("@NmProdi", paramValue.Trim())
        End If

        DS = New DataSet()
        DA.Fill(DS)

        DataGridMahasiswa.DataSource = DS.Tables(0)
        DataGridMahasiswa.ReadOnly = True
        Call StyleDataGrid()
    End Sub

    Private Sub StyleDataGrid()
        Try
            With DataGridMahasiswa
                If .Columns.Count = 0 Then Exit Sub

                .EnableHeadersVisualStyles = False
                .Font = New Font(.Font, FontStyle.Bold)
                .DefaultCellStyle.Font = New Font("Arial", 10)
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                .ColumnHeadersHeight = 35
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .RowHeadersVisible = False
                .MultiSelect = False

                Dim headers As String() = {"NIM", "NAMA", "JENIS KELAMIN", "TEMPAT LAHIR", "TANGGAL LAHIR", "ALAMAT", "STATUS", "PRODI"}
                Dim widths As Integer() = {120, 250, 130, 180, 120, 250, 150, 350}

                For i As Integer = 0 To Math.Min(.Columns.Count - 1, headers.Length - 1)
                    .Columns(i).HeaderText = headers(i)
                    .Columns(i).Width = widths(i)
                    .Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                Next

                If .Columns.Count > 4 Then
                    .Columns(4).DefaultCellStyle.Format = "dd/MM/yyyy"
                End If
            End With
        Catch ex As Exception
            MsgBox("Error styling grid: " & ex.Message, vbCritical, "ERROR")
        End Try
    End Sub
    Private Sub LoadKodeProdi()
        Try
            Dim sqlKode As String = "SELECT Kd_Prodi FROM tbl_prodi WHERE Nm_Prodi = @NmProdi"
            CMD = New MySqlCommand(sqlKode, DBKoneksi)
            CMD.Parameters.AddWithValue("@NmProdi", CbNamaJurusan.Text.Trim())

            DR = CMD.ExecuteReader()
            If DR.Read() Then
                Kode_Jurusan = DR("Kd_Prodi").ToString()
                LblKdProdi.Text = Microsoft.VisualBasic.Right(Kode_Jurusan, 2)
            End If
            DR.Close()
        Catch ex As Exception
            If DR IsNot Nothing AndAlso Not DR.IsClosed Then DR.Close()
            MsgBox("Error: " & ex.Message, vbCritical, "ERROR")
        End Try
    End Sub

    Private Sub CariMahasiswa()
        If Not ValidateCariData() Then Exit Sub

        Try
            Call KoneksiDB()
            Dim sqlCari As String = SQL_SELECT_MAHASISWA & " WHERE tbl_mahasiswa.Nm_Mhs LIKE @NmMhs"
            Dim hasWhere As Boolean = True

            If CbNamaJurusan.SelectedIndex > 0 Then
                sqlCari = SQL_SELECT_MAHASISWA & " WHERE tbl_prodi.Nm_Prodi = @NmProdi AND tbl_mahasiswa.Nm_Mhs LIKE @NmMhs"
            End If

            If CmbTahunAngkatan.SelectedIndex > 0 Then
                sqlCari &= " AND LEFT(tbl_mahasiswa.NIK_Mhs, 4) = @Tahun"
            End If

            sqlCari &= " ORDER BY tbl_mahasiswa.NIK_Mhs"

            DA = New MySqlDataAdapter(sqlCari, DBKoneksi)

            If CbNamaJurusan.SelectedIndex > 0 Then
                DA.SelectCommand.Parameters.AddWithValue("@NmProdi", CbNamaJurusan.Text.Trim())
            End If

            DA.SelectCommand.Parameters.AddWithValue("@NmMhs", "%" & TxtCariNama.Text.Trim() & "%")

            If CmbTahunAngkatan.SelectedIndex > 0 Then
                DA.SelectCommand.Parameters.AddWithValue("@Tahun", CmbTahunAngkatan.Text)
            End If

            DS = New DataSet()
            Dim rowCount As Integer = DA.Fill(DS)

            If rowCount > 0 Then
                DataGridMahasiswa.DataSource = DS.Tables(0)
                DataGridMahasiswa.Enabled = True
                Call StyleDataGrid()
                MsgBox("Ditemukan " & rowCount & " data mahasiswa.", vbInformation, "INFORMASI")
            Else
                MsgBox("Data tidak ditemukan!", vbInformation, "INFORMASI")
                TxtCariNama.SelectAll()
                TxtCariNama.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "ERROR")
        End Try
    End Sub
    Private Function ValidateTambahData() As Boolean
        If CbNamaJurusan.SelectedIndex = -1 OrElse CbNamaJurusan.SelectedIndex = 0 Then
            MsgBox("Silahkan pilih nama jurusan terlebih dahulu!" & vbCrLf & "(Tidak bisa memilih 'SEMUA PRODI')", vbExclamation, "PERINGATAN")
            CbNamaJurusan.Focus()
            Return False
        End If
        Return True
    End Function
    Private Function ValidateCariData() As Boolean
        ' Validasi cari data - tidak wajib pilih prodi
        If String.IsNullOrWhiteSpace(TxtCariNama.Text) Then
            MsgBox("Silahkan masukkan nama mahasiswa!", vbExclamation, "PERINGATAN")
            TxtCariNama.Focus()
            Return False
        End If

        If CbNamaJurusan.SelectedIndex = -1 Then
            MsgBox("Silahkan pilih jurusan atau 'SEMUA PRODI'!", vbExclamation, "PERINGATAN")
            CbNamaJurusan.Focus()
            Return False
        End If

        Return True
    End Function
    Private Function ValidateGridSelection(rowIndex As Integer) As Boolean
        If DataGridMahasiswa.Rows.Count = 0 OrElse DataGridMahasiswa.CurrentRow Is Nothing Then
            MsgBox("Tidak ada data yang dipilih!", vbExclamation, "PERINGATAN")
            Return False
        End If

        If IsDBNull(DataGridMahasiswa.Item(0, rowIndex).Value) OrElse String.IsNullOrEmpty(DataGridMahasiswa.Item(0, rowIndex).Value?.ToString()) Then
            MsgBox("Baris yang dipilih kosong!", vbExclamation, "PERINGATAN")
            Return False
        End If

        Return True
    End Function

    Private Sub ShowFormInput(isEditMode As Boolean)
        With FrmInputMahasiswa
            .MdiParent = FrmMenuUtama
            .Show()
            .CmbJurusan.Text = CbNamaJurusan.Text
            .LbKdJurusan.Text = Kode_Jurusan
            .CmbJurusan.Enabled = False

            If Not isEditMode Then
                .BtnSimpan.Text = "SIMPAN"
                .BtnKeluar.Text = "BATAL"
                .BtnHapus.Enabled = False
                .BtnHapus.BackColor = Color.Red

                .TxtNama.Clear()
                .CmbJenisKelamin.SelectedIndex = -1
                .TxtTempatLahir.Clear()
                .DateTimePickerMhs.Value = Date.Now
                .TxtAlamat.Clear()
                .CmbStatusMahasiswa.SelectedIndex = 0

                .TxtNama.Enabled = True
                .CmbJenisKelamin.Enabled = True
                .TxtTempatLahir.Enabled = True
                .DateTimePickerMhs.Enabled = True
                .TxtAlamat.Enabled = True
                .CmbStatusMahasiswa.Enabled = True
                .BtnSimpan.Enabled = True

                .TxtNama.Focus()
            Else
                .BtnSimpan.Text = "UBAH"
                .BtnKeluar.Text = "BATAL"
                .BtnHapus.Enabled = True
                .BtnHapus.BackColor = Color.Red

                .TxtNama.Enabled = True
                .CmbJenisKelamin.Enabled = True
                .TxtTempatLahir.Enabled = True
                .DateTimePickerMhs.Enabled = True
                .TxtAlamat.Enabled = True
                .CmbStatusMahasiswa.Enabled = True
                .BtnSimpan.Enabled = True
            End If
        End With
    End Sub

    Private Sub LoadDataToFormInput(rowIndex As Integer)
        Try
            isLoadingData = True

            Me.Enabled = False

            Dim namaProdi As String = DataGridMahasiswa.Item(7, rowIndex).Value?.ToString()

            Dim prodiFound As Boolean = False
            For i As Integer = 1 To CbNamaJurusan.Items.Count - 1
                If CbNamaJurusan.Items(i).ToString() = namaProdi Then
                    CbNamaJurusan.SelectedIndex = i
                    prodiFound = True
                    Exit For
                End If
            Next

            If Not prodiFound Then
                Call KoneksiDB()
                Call TampilkanFilterDataProdi()

                For i As Integer = 1 To CbNamaJurusan.Items.Count - 1
                    If CbNamaJurusan.Items(i).ToString() = namaProdi Then
                        CbNamaJurusan.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            Call ShowFormInput(isEditMode:=True)

            With DataGridMahasiswa
                FrmInputMahasiswa.LbNimVal.Text = .Item(0, rowIndex).Value?.ToString()
                FrmInputMahasiswa.TxtNama.Text = .Item(1, rowIndex).Value?.ToString()
                FrmInputMahasiswa.CmbJenisKelamin.Text = .Item(2, rowIndex).Value?.ToString()
                FrmInputMahasiswa.TxtTempatLahir.Text = .Item(3, rowIndex).Value?.ToString()

                Dim tglLahir As Object = .Item(4, rowIndex).Value
                If Not IsDBNull(tglLahir) AndAlso IsDate(tglLahir) Then
                    FrmInputMahasiswa.DateTimePickerMhs.Value = CDate(tglLahir)
                End If

                FrmInputMahasiswa.TxtAlamat.Text = .Item(5, rowIndex).Value?.ToString()
                FrmInputMahasiswa.CmbStatusMahasiswa.Text = .Item(6, rowIndex).Value?.ToString()
            End With
        Catch ex As Exception
            Me.Enabled = True
            MsgBox("Error: " & ex.Message, vbCritical, "ERROR")
        End Try
    End Sub


    Private Sub ResetFilter()
        CbNamaJurusan.SelectedIndex = 0
        CmbTahunAngkatan.SelectedIndex = 0
        LblKdProdi.Text = ""
        DataGridMahasiswa.DataSource = Nothing
    End Sub

    Sub FormNonAktif()
        CbNamaJurusan.SelectedIndex = -1
        CbNamaJurusan.Enabled = False
        CmbTahunAngkatan.SelectedIndex = -1
        CmbTahunAngkatan.Enabled = False
        TxtCariNama.Clear()
        TxtCariNama.Enabled = False
        LblKdProdi.Text = ""

        BtnCariData.Text = "AKTIFKAN FORM"
        BtnCariData.Enabled = True
        BtnTambahData.Enabled = False
        BtnKeluar.Text = "KELUAR"
        BtnKeluar.Enabled = True

        DataGridMahasiswa.DataSource = Nothing
        DataGridMahasiswa.Enabled = False
    End Sub

    Sub FormAktif()
        Call TampilkanFilterDataProdi()
        Call LoadTahunAngkatan()

        CbNamaJurusan.Enabled = True
        CmbTahunAngkatan.Enabled = True
        TxtCariNama.Enabled = True
        BtnCariData.Text = "CARI DATA"
        BtnTambahData.Enabled = True
        BtnKeluar.Text = "BATAL"
        BtnKeluar.Enabled = True
        DataGridMahasiswa.Enabled = False

        CbNamaJurusan.Focus()
    End Sub

    ' UPDATE: Refresh dengan set prodi juga
    Sub RefreshWithFilter(tahunAngkatan As String, Optional namaProdi As String = "")
        Try
            ' Reload combo
            Call TampilkanFilterDataProdi()
            Call LoadTahunAngkatanByProdi()

            ' Set prodi jika ada
            If Not String.IsNullOrEmpty(namaProdi) Then
                For i As Integer = 0 To CbNamaJurusan.Items.Count - 1
                    If CbNamaJurusan.Items(i).ToString() = namaProdi Then
                        CbNamaJurusan.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            ' Set filter tahun
            If Not String.IsNullOrEmpty(tahunAngkatan) Then
                Dim foundIndex As Integer = -1
                For i As Integer = 0 To CmbTahunAngkatan.Items.Count - 1
                    If CmbTahunAngkatan.Items(i).ToString() = tahunAngkatan Then
                        foundIndex = i
                        Exit For
                    End If
                Next

                If foundIndex > 0 Then
                    CmbTahunAngkatan.SelectedIndex = foundIndex
                Else
                    Call FilterMahasiswa()
                End If
            Else
                Call FilterMahasiswa()
            End If

        Catch ex As Exception
            MsgBox("Error refresh: " & ex.Message, vbCritical, "ERROR")
        End Try
    End Sub

    Private Sub CloseDBConnection()
        Try
            If DR IsNot Nothing AndAlso Not DR.IsClosed Then DR.Close()
            If DBKoneksi IsNot Nothing AndAlso DBKoneksi.State = ConnectionState.Open Then DBKoneksi.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridMahasiswa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMahasiswa.CellContentClick

    End Sub
End Class
