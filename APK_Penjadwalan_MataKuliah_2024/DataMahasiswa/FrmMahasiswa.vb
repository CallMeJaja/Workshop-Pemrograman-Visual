
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
        Else
            BtnSimpan.Text = "&AKTIF FORM"
            BtnSimpan.Enabled = True
            BtnSimpan.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TxtNama.Text = "" Or CmbJenisKelamin.Text = "" Or TxtTempatLahir.Text = "" Or TxtAlamat.Text = "" Or CmbStatusMahasiswa.SelectedIndex = -1 Then
            MsgBox("Silahkan Isi Datanya", vbInformation, "Informasi")
        Else
            If BtnSimpan.Text = "SIMPAN" Then
                SQLInsert = "INSERT INTO tbl_mahasiswa VALUE ('" & LbNim.Text & "','" & TxtNama.Text & "','" & CmbJenisKelamin.Text & "','" & TxtTempatLahir.Text & "','" & DateTimePickerMhs.Value.ToString("yyyy/MM/dd") & "','" & TxtAlamat.Text & "','" & Kode_Jurusan & "','" & CmbStatusMahasiswa.Text & "')"
                CMD = New MySqlCommand(SQLInsert, DBKoneksi)
                CMD.ExecuteReader()
                MsgBox("Data berhasil di simpan.", vbInformation, "INFORMASI")
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
            SQLDelete = "DELETE FROM tbl_mahasiswa WHERE NIK_Mhs = '" & LbNim.Text & "'"
            CMD = New MySqlCommand(SQLDelete, DBKoneksi)
            CMD.ExecuteReader()
            Call FrmDataMahasiswa.TampilkanDataGridMahasiswa()

            BtnSimpan.Enabled = False
            BtnSimpan.BackColor = Color.Red
            BtnHapus.Enabled = False
            BtnHapus.BackColor = Color.Red
            MsgBox("Data berhasil dihapus", vbInformation, "INFORMASis")
        Else
            Call FrmDataMahasiswa.TampilkanDataGridMahasiswa()
            BtnHapus.Enabled = False
            BtnHapus.BackColor = Color.Red
        End If
    End Sub
End Class