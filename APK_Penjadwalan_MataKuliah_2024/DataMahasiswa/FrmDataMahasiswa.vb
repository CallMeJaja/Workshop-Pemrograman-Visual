Imports MySql.Data.MySqlClient

Public Class FrmDataMahasiswa
    Function GetKodeProdi(ByVal namaProdi As String) As String
        Dim kode As String

        Select Case namaProdi
            Case "TEKNOLOGI LISTRIK (D3)"
                kode = "01"
            Case "TEKNOLOGI REKAYASA MEKATRONIKA (D4)"
                kode = "02"
            Case "TEKNOLOGI REKAYASA MANUFACTUR (D4)"
                kode = "03"
            Case "TEKNOLOGI REKAYASA PERANGKAT LUNAK (D4)"
                kode = "04"
            Case Else
                kode = "UNK" ' Unknown
        End Select

        Return kode
    End Function
    ' Create DataGridView
    Sub EnableDataGridMahasiswa()
        With DataGridMahasiswa()
            .EnableHeadersVisualStyles = False
            Try
                .Font = New Font(.Font, FontStyle.Bold)
                .DefaultCellStyle.Font = New Font("Arial", 10)
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                .ColumnHeadersHeight = 35

                ' Style NIM
                .Columns(0).Width = 100
                .Columns(0).HeaderText = "NIM"
                .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                ' Style NAMA
                .Columns(1).Width = 250
                .Columns(1).HeaderText = "NAMA"
                .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                ' Style JENIS KELAMIN
                .Columns(2).Width = 150
                .Columns(2).HeaderText = "JENIS KELAMIN"
                .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                ' Style TEMPAT LAHIR
                .Columns(3).Width = 200
                .Columns(3).HeaderText = "TEMPAT LAHIR"
                .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                ' Style TANGGAL LAHIR
                .Columns(4).Width = 80
                .Columns(4).HeaderText = "TANGGAL LAHIR"
                .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                ' Style ALAMAT
                .Columns(5).Width = 300
                .Columns(5).HeaderText = "ALAMAT"
                .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                ' Style STATUS MAHASISWA
                .Columns(6).Width = 200
                .Columns(6).HeaderText = "STATUS MAHASISWA"
                .Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                ' Style STATUS MAHASISWA
                .Columns(7).Width = 350
                .Columns(7).HeaderText = "NAMA PRODI"
                .Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Catch ex As Exception

            End Try
        End With
    End Sub
    Sub TampilkanDataGridMahasiswa()
        Call KoneksiDB()
        DA = New MySqlDataAdapter("SELECT DISTINCT
	                            tbl_mahasiswa.NIK_Mhs, 
	                            tbl_mahasiswa.Nm_Mhs, 
	                            tbl_mahasiswa.JK_Mhs, 
	                            tbl_mahasiswa.tmptlahir_Mhs, 
	                            tbl_mahasiswa.TglLahir_Mhs, 
	                            tbl_mahasiswa.Alamat_Mhs, 
	                            tbl_mahasiswa.Status_Mhs, 
	                            tbl_prodi.Nm_Prodi
                                FROM
	                             tbl_prodi
	                            INNER JOIN
	                            tbl_mahasiswa
	                            ON 
                                tbl_mahasiswa.Kd_Prodi = tbl_prodi.Kd_Prodi", DBKoneksi)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)
        DataGridMahasiswa.DataSource = DS.Tables(0)
        DataGridMahasiswa.ReadOnly = True

        Call EnableDataGridMahasiswa()
    End Sub
    Sub TampilkanFilterDataProdi()
        'Call KoneksiDB()
        Kode_Jurusan = ""
        CMD = New MySqlCommand("SELECT * from tbl_prodi", DBKoneksi)
        DR = CMD.ExecuteReader
        CbNamaJurusan.Items.Clear()
        Do While DR.Read
            CbNamaJurusan.Items.Add(DR.Item("Nm_Prodi"))
        Loop
    End Sub
    Sub FilterByNamaProdiMahasiswa()
        Call KoneksiDB()
        ' menampilkan filter data berdasarkan nama prodi
        DA = New MySqlDataAdapter("SELECT DISTINCT
	                                    tbl_mahasiswa.NIK_Mhs, 
	                                    tbl_mahasiswa.Nm_Mhs, 
	                                    tbl_mahasiswa.JK_Mhs, 
	                                    tbl_mahasiswa.tmptlahir_Mhs, 
	                                    tbl_mahasiswa.TglLahir_Mhs, 
	                                    tbl_mahasiswa.Alamat_Mhs, 
	                                    tbl_prodi.Nm_Prodi, 
	                                    tbl_mahasiswa.Status_Mhs
                                    FROM
	                                    tbl_mahasiswa
	                                    INNER JOIN
	                                    tbl_prodi
	                                    ON 
		                                    tbl_prodi.Kd_Prodi = tbl_mahasiswa.Kd_Prodi
                                    WHERE
	                                    tbl_prodi.Nm_Prodi LIKE '" + CbNamaJurusan.Text + "'", DBKoneksi)

        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)
        'MsgBox("DEBUG : " & DS.Tables(0).ToString & " ", vbInformation, "INFORMASI")
        DataGridMahasiswa.DataSource = DS.Tables(0)
        DataGridMahasiswa.ReadOnly = True

        CMD = New MySqlCommand("SELECT DISTINCT
	                                tbl_mahasiswa.NIK_Mhs, 
	                                tbl_mahasiswa.Nm_Mhs, 
	                                tbl_mahasiswa.JK_Mhs, 
	                                tbl_mahasiswa.tmptlahir_Mhs, 
	                                tbl_mahasiswa.TglLahir_Mhs, 
	                                tbl_mahasiswa.Alamat_Mhs, 
	                                tbl_prodi.Nm_Prodi, 
	                                tbl_mahasiswa.Status_Mhs
                                FROM
	                                tbl_mahasiswa
	                                INNER JOIN
	                                tbl_prodi
	                                ON 
		                                tbl_prodi.Kd_Prodi = tbl_mahasiswa.Kd_Prodi
                                WHERE
	                                tbl_prodi.Nm_Prodi LIKE '" + CbNamaJurusan.Text + "'", DBKoneksi)


        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            CbNamaJurusan.Text = DR.Item("Nm_Prodi")
        Else
            MsgBox("Data Mahasiswa Jurusan " & CbNamaJurusan.Text & " belum ada", vbCritical + vbOKOnly, "Peringatan")
            Call TampilkanDataGridMahasiswa()
            CbNamaJurusan.Select()
            Exit Sub
        End If
    End Sub
    Private Sub FrmDataMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call KoneksiDB()
            'Call TampilkanDataGridMahasiswa()
            Call TampilkanFilterDataProdi()
            DataGridMahasiswa.Enabled = False
        Catch ex As Exception
            MsgBox("Upss : " & ex.Message & " ", vbInformation, ex.Message)
        End Try
    End Sub
    Private Sub CbNamaJurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNamaJurusan.SelectedIndexChanged
        Call KoneksiDB()
        Call TampilkanDataGridMahasiswa()
        CMD = New MySqlCommand("SELECT * FROM tbl_prodi WHERE Nm_Prodi = '" & CbNamaJurusan.Text & "'", DBKoneksi)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Kode_Jurusan = DR.Item("Kd_Prodi")
            LblKdProdi.Text = Microsoft.VisualBasic.Right(Kode_Jurusan, 2)
        End If
        Call FilterByNamaProdiMahasiswa()
    End Sub
    Private Sub BtnTambahData_Click(sender As Object, e As EventArgs) Handles BtnTambahData.Click
        If CbNamaJurusan.SelectedIndex = -1 Then
            MsgBox("Silahkan Pilih Nama Jurusan Terlebih Dahulu!", vbCritical + vbYes, "Peringatan")
            CbNamaJurusan.Focus()
        Else
            FrmMahasiswa.Show()
            FrmMahasiswa.MdiParent = FrmMenuUtama
            Me.Enabled = False
            FrmMahasiswa.CmbJurusan.Text = CbNamaJurusan.Text
            FrmMahasiswa.LbKdJurusan.Text = LblKdProdi.Text
            Call BuatNIMMahasiswa(LblKdProdi.Text)
        End If
    End Sub
    Private Sub BtnCariData_Click(sender As Object, e As EventArgs) Handles BtnCariData.Click
        Call KoneksiDB()
        If TxtCariNama.Text = "" Then
            MsgBox("Silahkan masukkan nama mahasiswa!", vbCritical + vbYes, "Peringatan")
        ElseIf CbNamaJurusan.SelectedIndex = -1 Then
            MsgBox("Silahkan pilih nama jurusan!", vbCritical + vbYes, "Peringatan")
        Else
            DA = New MySqlDataAdapter("SELECT DISTINCT
	                                    tbl_mahasiswa.NIK_Mhs, 
	                                    tbl_mahasiswa.Nm_Mhs, 
	                                    tbl_mahasiswa.JK_Mhs, 
	                                    tbl_mahasiswa.tmptlahir_Mhs, 
	                                    tbl_mahasiswa.TglLahir_Mhs, 
	                                    tbl_mahasiswa.Alamat_Mhs, 
	                                    tbl_prodi.Nm_Prodi, 
	                                    tbl_mahasiswa.Status_Mhs
                                    FROM
	                                    tbl_mahasiswa
	                                    INNER JOIN
	                                    tbl_prodi
	                                    ON 
		                                    tbl_prodi.Kd_Prodi = tbl_mahasiswa.Kd_Prodi
                                    WHERE
	                                    tbl_prodi.Nm_Prodi LIKE '" + CbNamaJurusan.Text + "' AND tbl_mahasiswa.Nm_Mhs LIKE '%" & TxtCariNama.Text & "%'", DBKoneksi)
            DS = New DataSet()
            Dim rowCount As Integer = DA.Fill(DS)

            If rowCount > 0 Then
                DataGridMahasiswa.DataSource = DS.Tables(0)
                DataGridMahasiswa.Enabled = True
            Else
                MsgBox("Data tidak ditemukan!", vbInformation + vbOKOnly, "INFORMASI")
                TampilkanDataGridMahasiswa()
            End If
        End If
    End Sub
    Sub BuatNIMMahasiswa(KodeProdi As String)
        Try
            Call KoneksiDB()
            ' Ambil Tahun Sekarang
            Dim TahunSekarang As String = Format(Date.Now, "yyyy")

            ' Ambil NIM terakhir berdasarkan tahun dan kode prodi
            CMD = New MySqlCommand("SELECT
  NIK_Mhs
FROM
  tbl_mahasiswa
WHERE
  LEFT(NIK_Mhs, 6) = '" & TahunSekarang & KodeProdi & "'
ORDER BY
  NIK_Mhs DESC
  LIMIT 1;", DBKoneksi)

            DR = CMD.ExecuteReader
            'MsgBox("AFTER")
            If DR.Read() Then
                ' Ambil 3 Digit terakhir dari NIM terakhir lalu tambahkan
                Hitung = CLng(Microsoft.VisualBasic.Right(DR.GetString(0), 3)) + 1
            Else
                ' Jika belum ada data di tahun ini
                Hitung = 1
            End If
            DR.Close()

            Hasil = TahunSekarang & KodeProdi & Microsoft.VisualBasic.Right("000" & Hitung, 3)

            FrmMahasiswa.LbNimVal.Text = Hasil
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat membuat NIM : " & ex.Message, ex.Message)
        End Try
    End Sub
    Private Sub TxtCariNama_TextChanged(sender As Object, e As EventArgs) Handles TxtCariNama.TextChanged
        Call KoneksiDB()
        If TxtCariNama.Text = "" Then
            DA = New MySqlDataAdapter("SELECT * FROM tbl_mahasiswa", DBKoneksi)
            DS = New DataSet()
            DA.Fill(DS)
            DataGridMahasiswa.DataSource = DS.Tables(0)
            CbNamaJurusan.SelectedIndex = -1
            LblKdProdi.Text = ""
        End If
    End Sub

    Private Sub DataGridMahasiswa_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridMahasiswa.CellMouseDoubleClick
        On Error Resume Next
        Dim Baris As Integer
        FrmMahasiswa.Show()
        FrmMahasiswa.MdiParent = FrmMenuUtama

        FrmMahasiswa.BtnSimpan.Text = "UBAH"
        FrmMahasiswa.BtnKeluar.Text = "BATAL"

        CMD = New MySqlCommand("SELECT         
                                tbl_mahasiswa.NIK_Mhs, 
	                            tbl_mahasiswa.Nm_Mhs, 
	                            tbl_mahasiswa.JK_Mhs, 
	                            tbl_mahasiswa.tmptlahir_Mhs, 
	                            tbl_mahasiswa.TglLahir_Mhs, 
	                            tbl_mahasiswa.Alamat_Mhs, 
	                            tbl_mahasiswa.Status_Mhs, 
                                FROM tbl_mahasiswa WHERE NIK_Mhs = '" & DataGridMahasiswa.Item(0, Baris).Value & "'", DBKoneksi)
        DR = CMD.ExecuteReader
        DR.Read()

        With DataGridMahasiswa()
            Baris = .CurrentRow.Index
            FrmMahasiswa.LbNimVal.Text = .Item(0, Baris).Value
            FrmMahasiswa.TxtNama.Text = .Item(1, Baris).Value
            FrmMahasiswa.CmbJenisKelamin.Text = .Item(2, Baris).Value
            FrmMahasiswa.TxtTempatLahir.Text = .Item(3, Baris).Value
            FrmMahasiswa.DateTimePickerMhs.Value = .Item(4, Baris).Value
            FrmMahasiswa.TxtAlamat.Text = .Item(4, Baris).Value
            FrmMahasiswa.LbKdJurusan.Text = Kode_Jurusan
            FrmMahasiswa.CmbJurusan.Text = CbNamaJurusan.Text
            FrmMahasiswa.CmbStatusMahasiswa.SelectedItem = .Item(7, Baris).Value
        End With
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        If BtnKeluar.Text = "KELUAR" Then
            Pesan = MsgBox("Anda yakin ingin keluar dari data mahasiswa?", vbQuestion + vbYesNo, "Informasi")
            If Pesan = vbYes Then
                Me.Close()
            End If
        Else
            BtnTambahData.Text = "&AKTIF FORM"
            BtnTambahData.Enabled = True
            BtnTambahData.BackColor = Color.LightGray
        End If
    End Sub
End Class
