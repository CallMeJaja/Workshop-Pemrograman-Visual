Public Class FrmMahasiswa
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
End Class