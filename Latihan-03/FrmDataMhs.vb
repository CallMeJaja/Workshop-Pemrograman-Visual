Public Class FrmDataMahasiswa
    ' Membuat prosedur untuk menonaktifkan objek
    Sub FormMati()
        TxtNik.Enabled = False
        TxtNama.Enabled = False
        CmbJenisKelamin.Enabled = False
        CmbAgama.Enabled = False
        TxtAlamat.Enabled = False
        CmbJurusan.Enabled = False
        CmbStatusMahasiswa.Enabled = False
    End Sub

    Private Sub FrmDataMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormMati()
    End Sub
End Class
