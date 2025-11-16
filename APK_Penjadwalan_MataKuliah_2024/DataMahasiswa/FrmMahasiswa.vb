
Imports MySql.Data.MySqlClient

Public Class FrmMahasiswa
    Sub StatusMahasiswa()
        CmbStatusMahasiswa.Items.Add("AKTIF")
        CmbStatusMahasiswa.Items.Add("NON AKTIF")
        CmbStatusMahasiswa.Items.Add("CUTI AKADEMIK")
        CmbStatusMahasiswa.Items.Add("DROP OUt")
    End Sub
    Sub JenisKelamin()
        CmbJenisKelamin.Items.Add("LAKI-LAKI")
        CmbJenisKelamin.Items.Add("PEREMPUAN")
    End Sub
    Private Sub CmbStatusMahasiswa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbStatusMahasiswa.SelectedIndexChanged

    End Sub
    Private Sub CmbJurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbJurusan.SelectedIndexChanged

    End Sub
    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        If BtnKeluar.Text = "KELUAR" Then
            Pesan = MsgBox("Anda yakin ingin keluar dari data mahasiswa?", vbQuestion + vbYesNo, "Informasi")
            If Pesan = vbYes Then
                Me.Close()
                FrmDataMahasiswa.Show()
                FrmDataMahasiswa.Enabled = True
            End If
        ElseIf BtnKeluar.Text = "BATAL" Then
            Me.Close()
            FrmDataMahasiswa.Show()
            FrmDataMahasiswa.Enabled = True
        Else
            BtnSimpan.Text = "&AKTIF FORM"
            BtnSimpan.Enabled = True
            BtnSimpan.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Call KoneksiDB()

        If TxtNama.Text = "" Or CmbJenisKelamin.Text = "" Or TxtTempatLahir.Text = "" Or TxtAlamat.Text = "" Or CmbStatusMahasiswa.SelectedIndex = -1 Then
            MsgBox("Silahkan Isi Datanya", vbInformation, "Informasi")
        Else
            If BtnSimpan.Text = "SIMPAN" Then
                SQLInsert = "INSERT INTO tbl_mahasiswa VALUE ('" & LbNimVal.Text & "','" & TxtNama.Text & "','" & CmbJenisKelamin.Text & "','" & TxtTempatLahir.Text & "','" & DateTimePickerMhs.Value.ToString("yyyy/MM/dd") & "','" & TxtAlamat.Text & "','" & Kode_Jurusan & "','" & CmbStatusMahasiswa.Text & "')"
                CMD = New MySqlCommand(SQLInsert, DBKoneksi)
                CMD.ExecuteReader()
                MsgBox("Data berhasil di simpan.", vbInformation, "INFORMASI")
                Me.Close()
                FrmDataMahasiswa.Enabled = True
                FrmDataMahasiswa.FilterByNamaProdiMahasiswa()


            ElseIf BtnSimpan.Text = "UBAH" Then
                Nama = TxtNama.Text
                Nama_Jurusan = CmbJurusan.Text

                SQLUpdate = "UPDATE tbl_mahasiswa SET Nm_Mhs='" & TxtNama.Text & "', JK_Mhs='" & CmbJenisKelamin.Text & "', tmptlahir_Mhs='" & TxtTempatLahir.Text & "', TglLahir_Mhs='" & DateTimePickerMhs.Value.ToString("yyyy/MM/dd") & "', Alamat_Mhs='" & TxtAlamat.Text & "', Status_Mhs='" & CmbStatusMahasiswa.Text & "', Kd_Prodi='" & Kode_Jurusan & "' WHERE NIK_Mhs='" & LbNimVal.Text & "'"
                CMD = New MySqlCommand(SQLUpdate, DBKoneksi)
                CMD.ExecuteReader()
                MsgBox("Data berhasil di perbarui", vbInformation, "INFORMASI")
                Me.Close()
                FrmDataMahasiswa.Enabled = True
                Call KoneksiDB()
                Query = "SELECT tbl_mahasiswa.*, tbl_prodi.Nm_Prodi FROM tbl_mahasiswa INNER JOIN tbl_prodi ON tbl_prodi.Kd_Prodi = tbl_mahasiswa.Kd_Prodi WHERE tbl_prodi.Nm_Prodi ='" & Nama_Jurusan & "' AND tbl_mahasiswa.Nm_Mhs LIKE '%" & Nama & "%'"
                DA = New MySqlDataAdapter(Query, DBKoneksi)
                DS = New DataSet()
                DA.Fill(DS)
                FrmDataMahasiswa.DataGridMahasiswa.DataSource = DS.Tables(0)

            End If
        End If
    End Sub

    Private Sub FrmMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call JenisKelamin()
        Call StatusMahasiswa()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Call KoneksiDB()
        Dim Konfirmasi As String
        Konfirmasi = MsgBox("Anda yakin ingin menghapus data ini?", vbYesNo + vbQuestion, "INFORMASI")
        If Konfirmasi = vbYes Then
            SQLDelete = "DELETE FROM tbl_mahasiswa WHERE NIK_Mhs = '" & LbNimVal.Text & "'"
            CMD = New MySqlCommand(SQLDelete, DBKoneksi)
            CMD.ExecuteReader()
            Call FrmDataMahasiswa.TampilkanDataGridMahasiswa()
            MsgBox("Data berhasil dihapus", vbInformation, "INFORMASi")
            Me.Close()
            FrmDataMahasiswa.FilterByNamaProdiMahasiswa()
        Else
            Call FrmDataMahasiswa.TampilkanDataGridMahasiswa()
            Me.Close()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class