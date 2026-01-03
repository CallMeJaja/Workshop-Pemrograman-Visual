Imports MySql.Data.MySqlClient

Public Class FrmDataMhsPagination
    Private isDev As Boolean = False
    ' Variable Paging
    Dim CurrentPage As Integer = 1
    Dim PageSize As Integer = 10
    Dim TotalData As Integer = 0
    Dim TotalPage As Integer = 0

    ' Flag untuk mencegah event jalan saat form loading
    Private isLoading As Boolean = True

    Sub LogDebug(message As String)
        If isDev Then
            MsgBox("DEBUG: " & message)
        End If
    End Sub

    Sub GenerateNIM(kodeAngkaProdi As String)
        Try
            Call KoneksiDB()
            Dim TahunSekarang As String = Date.Now.Year.ToString()
            Dim prefix As String = TahunSekarang & kodeAngkaProdi

            ' Cari NIM Tertinggi
            Dim sql As String = "SELECT MAX(NIK_Mhs) from tbl_mahasiswa WHERE LEFT(NIK_Mhs, 6) = @prefix"
            Using cmd As New MySqlCommand(sql, DBKoneksi)
                cmd.Parameters.AddWithValue("@prefix", prefix)
                Dim hasil As Object = cmd.ExecuteScalar()
                Dim noUrut As Integer = 1

                If hasil IsNot Nothing AndAlso Not IsDBNull(hasil) Then
                    ' Ambil 3 Digit Terakhir & Tambah 1
                    noUrut = CInt(Microsoft.VisualBasic.Right(hasil.ToString(), 3)) + 1
                End If

                ' Format NIM : 2026 + 04 + 001
                Dim nimBaru As String = prefix & noUrut.ToString("000")

                FrmInputMahasiswa.LbNimVal.Text = nimBaru
            End Using
        Catch ex As Exception
            MsgBox("Gagal Generate NIM: " & ex.Message)
        End Try
    End Sub

    Private Sub FrmDataMhsPagination_Load(sender As Object, e As EventArgs) Handles Me.Load
        isLoading = True
        Call KoneksiDB()

        ' Inisiasi ComboBox Entires
        ComboBoxEntries.Items.Clear()
        ComboBoxEntries.Items.AddRange({"10", "20", "50", "100"})
        ComboBoxEntries.SelectedIndex = 0
        PageSize = 10

        ' Menghilangkan kolom/barois kosogn di ujung kanan & bawah
        DataGridMahasiswa.AllowUserToAddRows = False
        DataGridMahasiswa.RowHeadersWidth = 50
        DataGridMahasiswa.RowHeadersVisible = True

        ' Terapkan Styling Grid
        Call AktifkanDataGridMahasiswa()

        ' Isi ComboBox Prodi
        Call LoadProdi()


        ' Set tampilan awal
        CmbTahunAngkatan.DataSource = Nothing
        DataGridMahasiswa.DataSource = Nothing

        isLoading = False
    End Sub

    Sub AktifkanDataGridMahasiswa()
        With DataGridMahasiswa
            .EnableHeadersVisualStyles = False
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 35
            .DefaultCellStyle.Font = New Font("Arial", 9)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 9, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .TopLeftHeaderCell.Value = "No"
            .TopLeftHeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        End With
    End Sub

    ' Mengatur lebar kolom secara dinamis
    Sub FormatKolomGrid()
        If DataGridMahasiswa.ColumnCount > 0 Then
            With DataGridMahasiswa
                .Columns(0).HeaderText = "NIM"
                .Columns(0).Width = 80
                .Columns(1).HeaderText = "NAMA MAHASISWA"
                .Columns(1).Width = 250
                .Columns(2).HeaderText = "JENIS KELAMIN"
                .Columns(2).Width = 90
                .Columns(3).HeaderText = "TEMPAT LAHIR"
                .Columns(3).Width = 120
                .Columns(4).HeaderText = "TANGGAL LAHIR"
                .Columns(4).Width = 100
                .Columns(5).HeaderText = "ALAMAT"
                .Columns(6).HeaderText = "STATUS"
                .Columns(6).Width = 90
            End With
        End If
    End Sub

    Private Sub LoadProdi()
        Try
            Call KoneksiDB()

            ' Query ambil data kode dan nama prodi
            Dim sql As String = "SELECT Kd_Prodi, Nm_Prodi FROM tbl_prodi ORDER BY Nm_Prodi"

            ' Gunakan DataAdapter untu kmengisi DataTable
            DA = New MySqlDataAdapter(sql, DBKoneksi)
            Dim DT As New DataTable
            DA.Fill(DT)

            ' Tambahkan placeholder di baris pertama 
            Dim dr As DataRow = DT.NewRow
            dr("Kd_Prodi") = ""
            dr("Nm_Prodi") = "--- PILIH PRODI ---"
            DT.Rows.InsertAt(dr, 0)

            ' Bind data ke ComboBox
            isLoading = True
            CbNamaJurusan.DataSource = DT
            CbNamaJurusan.DisplayMember = "Nm_Prodi"
            CbNamaJurusan.ValueMember = "Kd_Prodi"
            CbNamaJurusan.SelectedIndex = 0
            isLoading = False
        Catch ex As Exception
            MsgBox("Gagal memuat data prodi: " & ex.Message, vbCritical)
        End Try
    End Sub

    Sub FetchData()
        If isLoading OrElse CbNamaJurusan.SelectedValue Is Nothing Then Exit Sub

        Try
            Call KoneksiDB()
            PageSize = Val(ComboBoxEntries.Text)
            Dim offset As Integer = (CurrentPage - 1) * PageSize

            LogDebug($"PageSize: {PageSize}, Offset: {offset}")

            ' --- 1. HITUNG TOTAL DATA UNTUK PAGINASI ----
            Dim countSql As String = "SELECT COUNT(*) FROM tbl_mahasiswa WHERE Kd_Prodi = @kd"
            If CmbTahunAngkatan.Text <> "ALL" AndAlso CmbTahunAngkatan.Text <> "" Then
                countSql &= " AND LEFT(NIK_Mhs, 4) = @tahun"
            End If

            If TxtCariNama.Text.Trim <> "" Then
                countSql &= " AND Nm_Mhs LIKE @nama"
            End If

            Dim cmdCount As New MySqlCommand(countSql, DBKoneksi)
            cmdCount.Parameters.AddWithValue("@kd", CbNamaJurusan.SelectedValue)
            If countSql.Contains("@tahun") Then cmdCount.Parameters.AddWithValue("@tahun", CmbTahunAngkatan.Text)
            If countSql.Contains("@nama") Then cmdCount.Parameters.AddWithValue("@nama", "%" & TxtCariNama.Text & "%")

            TotalData = CInt(cmdCount.ExecuteScalar())

            If TotalData = 0 Then
                If CbNamaJurusan.SelectedIndex > 0 AndAlso CmbTahunAngkatan.SelectedIndex > 0 Then
                    MsgBox("Data tidak ditemukan untuk kriteria ini.", vbExclamation)
                End If
                Call ClearHasil()
                Exit Sub
            End If

            TotalPage = If(TotalData > 0, Math.Ceiling(CDbl(TotalData) / PageSize), 1)

            If TotalPage < 1 Then TotalPage = 1

            LogDebug($"TotalData: {TotalData}, TotalPage: {TotalPage}")

            ' --- 2. AMBIL DATA DENGAN LIMIT & OFFSET ---
            Dim dataSql As String = "SELECT NIK_Mhs, Nm_Mhs, JK_Mhs, tmptlahir_Mhs, TglLahir_Mhs, Alamat_Mhs, Status_Mhs FROM tbl_mahasiswa WHERE Kd_Prodi = @kd"
            If countSql.Contains("@tahun") Then dataSql &= " AND LEFT(NIK_Mhs, 4) = @tahun"
            If countSql.Contains("@nama") Then dataSql &= " AND Nm_Mhs LIKE @nama"

            dataSql &= " ORDER BY NIK_Mhs ASC LIMIT @limit OFFSET @offset"

            DA = New MySqlDataAdapter(dataSql, DBKoneksi)
            DA.SelectCommand.Parameters.AddWithValue("@kd", CbNamaJurusan.SelectedValue)
            DA.SelectCommand.Parameters.AddWithValue("@limit", PageSize)
            DA.SelectCommand.Parameters.AddWithValue("@offset", offset)
            If countSql.Contains("@tahun") Then DA.SelectCommand.Parameters.AddWithValue("@tahun", CmbTahunAngkatan.Text)
            If countSql.Contains("@nama") Then DA.SelectCommand.Parameters.AddWithValue("@nama", "%" & TxtCariNama.Text & "%")

            Dim DT As New DataTable
            DA.Fill(DT)
            DataGridMahasiswa.DataSource = DT

            Call FormatKolomGrid()
            Call UpdateUI()
        Catch ex As Exception
            MsgBox("Error FetchData: " & ex.Message)
        End Try
    End Sub

    Private Sub CbNamaJurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNamaJurusan.SelectedIndexChanged
        If isLoading OrElse CbNamaJurusan.SelectedIndex <= 0 Then
            Call ResetTampilan()
            LblKdProdi.Text = ""
            Exit Sub
        End If
        Try
            CmbTahunAngkatan.DataSource = Nothing
            CmbTahunAngkatan.Items.Clear()
            DataGridMahasiswa.DataSource = Nothing

            Dim kdProdi As String = CbNamaJurusan.SelectedValue.ToString()
            LblKdProdi.Text = Microsoft.VisualBasic.Right(kdProdi, 2)

            ' Cek ada datanya gk
            Call KoneksiDB()
            Dim sqlCek As String = "SELECT COUNT(*) FROM tbl_mahasiswa WHERE Kd_Prodi = @kd"
            CMD = New MySqlCommand(sqlCek, DBKoneksi)
            CMD.Parameters.AddWithValue("@kd", kdProdi)

            Dim jumlahMhs As Integer = CInt(CMD.ExecuteScalar())

            If jumlahMhs = 0 Then
                MsgBox("Maaf, data mahasiswa untuk prodi " & CbNamaJurusan.Text & " belum tersedia/masih kosong", vbExclamation, "Data Kosong")
                Call ResetTampilan()
                Exit Sub
            End If

            Call LoadTahunAngkatan(kdProdi)
        Catch ex As Exception
            MsgBox("Error saat cek data prodi: " & ex.Message)
        End Try

    End Sub

    Public Sub LoadTahunAngkatan(kdProdi As String)
        Try
            Call KoneksiDB()

            ' Query untuk mendapatkan tahun unik dari 4 digit NIM
            ' Menggunakan DISTINCT agar tahun tidak duplikat
            Dim sql As String = "SELECT DISTINCT LEFT(NIK_Mhs, 4) AS Tahun FROM tbl_mahasiswa WHERE Kd_Prodi = @kd ORDER BY Tahun ASC"

            CMD = New MySqlCommand(sql, DBKoneksi)
            CMD.Parameters.AddWithValue("@kd", kdProdi)

            DA = New MySqlDataAdapter(CMD)
            Dim DT As New DataTable
            DA.Fill(DT)

            ' Tambahkan placeholder di index 0 dan "ALL" di Index 1
            Dim drPlaceholder As DataRow = DT.NewRow
            drPlaceholder("Tahun") = "--- PIILIH TAHUN ANGKATAN ---"
            DT.Rows.InsertAt(drPlaceholder, 0)

            Dim drAll As DataRow = DT.NewRow
            drAll("Tahun") = "ALL"
            DT.Rows.InsertAt(drAll, 1)

            ' Bind data ke ComboBox Tahun Angkatan
            CmbTahunAngkatan.DataSource = DT
            CmbTahunAngkatan.DisplayMember = "Tahun"
            CmbTahunAngkatan.ValueMember = "Tahun"
            CmbTahunAngkatan.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Error LoadTahunAngkatan: " & ex.Message, vbCritical)
        End Try
    End Sub

    ' Saat Tahun dipilih
    Private Sub CmbTahunAngkatan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTahunAngkatan.SelectedIndexChanged
        ' DataGrid hanya bereaksi jika yang dipilih bukan placeholder (index > 0)
        If isLoading OrElse CmbTahunAngkatan.SelectedIndex <= 0 Then Exit Sub
        Call RefreshPaging()
    End Sub

    ' Saat tombol Cari diklik
    Private Sub BtnCariData_Click(sender As Object, e As EventArgs) Handles BtnCariData.Click
        Call RefreshPaging()
    End Sub

    Sub UpdateUI()
        LbTotalBaris.Text = "Total Data : " & TotalData
        LbHasilBagiHalaman.Text = "Jumlah Hal: " & TotalPage
        LbJumlahBaris.Text = "Jumlah Baris Entri : " & DataGridMahasiswa.RowCount

        BindingNavigatorPositionItem.Text = CurrentPage.ToString
        BindingNavigatorCountItem.Text = "of " & TotalPage

        ' Navigasi Button State
        BindingNavigatorMoveFirstItem.Enabled = (CurrentPage > 1)
        BindingNavigatorMovePreviousItem.Enabled = (CurrentPage > 1)
        BindingNavigatorMoveNextItem.Enabled = (CurrentPage < TotalPage)
        BindingNavigatorMoveLastItem.Enabled = (CurrentPage < TotalPage)
    End Sub

    ' Contoh event tombol Next
    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        If CurrentPage < TotalPage Then
            CurrentPage += 1
            FetchData()
        End If
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        If CurrentPage > 1 Then
            CurrentPage -= 1
            FetchData()
        End If
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click
        CurrentPage = TotalPage
        FetchData()
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click
        CurrentPage = 1
        FetchData()
    End Sub

    Private Sub DataGridMahasiswa_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridMahasiswa.DataBindingComplete
        ' Hitung titik awal nomor berdasarkan halaman aktif
        ' Rumus: (Halaman Sekarang - 1) * Jumlah Data per Halaman
        Dim offset As Integer = (CurrentPage - 1) * PageSize

        ' Lakukan perulangan untuk setipa baris yang tampil di grid
        For i As Integer = 0 To DataGridMahasiswa.Rows.Count - 1
            ' Isi HeaderCell dengan angka (index baris + offset + 1)
            DataGridMahasiswa.Rows(i).HeaderCell.Value = (offset + i + 1).ToString()
        Next
    End Sub

    Private Sub TxtCariNama_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCariNama.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            BtnCariData.PerformClick()
        End If
    End Sub

    Sub ResetTampilan()
        isLoading = True
        TotalData = 0 : TotalPage = 0 : CurrentPage = 1
        DataGridMahasiswa.DataSource = Nothing
        CmbTahunAngkatan.DataSource = Nothing
        CmbTahunAngkatan.Items.Clear()
        CmbTahunAngkatan.Text = ""
        CmbTahunAngkatan.SelectedIndex = -1
        Call ResetNavigatorLabels()
        isLoading = False
    End Sub

    Sub ClearHasil()
        TotalData = 0 : TotalPage = 0 : CurrentPage = 1
        DataGridMahasiswa.DataSource = Nothing
        CmbTahunAngkatan.DataSource = Nothing
        Call ResetNavigatorLabels()
    End Sub

    Sub ResetNavigatorLabels()
        LbTotalBaris.Text = "Total data : 0"
        LbHasilBagiHalaman.Text = "Jumlah Hal : 0"
        LbJumlahBaris.Text = "Jumlah Baris Entri : 0"
        BindingNavigatorPositionItem.Text = "0"
        BindingNavigatorCountItem.Text = "of 0"
        BindingNavigatorMoveFirstItem.Enabled = False
        BindingNavigatorMovePreviousItem.Enabled = False
        BindingNavigatorMoveNextItem.Enabled = False
        BindingNavigatorMoveLastItem.Enabled = False
    End Sub

    Private Sub ComboBoxEntries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEntries.SelectedIndexChanged
        If isLoading OrElse ComboBoxEntries.SelectedIndex = -1 Then Exit Sub

        Call RefreshPaging()

        LogDebug("Jumlah entri di ubah ke: " & ComboBoxEntries.Text)
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dim pesan As DialogResult = MessageBox.Show("Anda yakin mau exit dari Form Data Mahasiswa?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If pesan = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnTambahData_Click(sender As Object, e As EventArgs) Handles BtnTambahData.Click
        ' Wajib Piih Prodi
        If CbNamaJurusan.SelectedIndex <= 0 Then
            MsgBox("Silahkan pilih Nama Prodi terlebih dahulu sebelum menambah data!", vbExclamation, "Peringatan")
            CbNamaJurusan.Focus()
            Exit Sub
        End If

        ' Generate NIM berdasarkan Label Kode Prodi
        Call GenerateNIM(LblKdProdi.Text)

        ' Nonaktifkna Form Data
        Me.Enabled = False

        With FrmInputMahasiswa
            .ResetForm()
            .LbKdJurusan.Text = CbNamaJurusan.SelectedValue.ToString()
            .CmbJurusan.Text = CbNamaJurusan.Text
            .CmbJurusan.Enabled = False
            .ShowDialog()
        End With

        Me.Enabled = True
        Call RefreshPaging()
    End Sub

    Public Sub RefreshPaging()
        CurrentPage = 1
        Call FetchData()
        LogDebug("Pagging Refreshed.")
    End Sub

    Private Sub DataGridMahasiswa_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridMahasiswa.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridMahasiswa.Rows(e.RowIndex)
            LogDebug(row.Cells(1).Value.ToString())
            ' Nonaktifkan Form utama sementara
            Me.Enabled = False

            With FrmInputMahasiswa
                ' Passing Data Ke Form Input
                .LbNimVal.Text = row.Cells(0).Value.ToString()
                .TxtNama.Text = row.Cells(1).Value.ToString()
                .CmbJenisKelamin.Text = row.Cells(2).Value.ToString()
                .TxtTempatLahir.Text = row.Cells(3).Value.ToString()
                .DateTimePickerMhs.Value = row.Cells(4).Value.ToString()
                .TxtAlamat.Text = row.Cells(5).Value.ToString()
                .CmbStatusMahasiswa.Text = row.Cells(6).Value.ToString()

                ' Passing Kode & Nama Jurusan
                .LbKdJurusan.Text = CbNamaJurusan.SelectedValue.ToString()
                .CmbJurusan.Text = CbNamaJurusan.Text

                ' Atur State Form Input Mode Edit
                .CmbJurusan.Enabled = False
                .BtnSimpan.Text = "UBAH"
                .BtnSimpan.BackColor = Color.Orange

                ' Tampilkan Form
                .ShowDialog()
            End With

            ' Aktifkan Form dan Refresh
            Me.Enabled = True
            Call RefreshPaging()
        End If
    End Sub
End Class