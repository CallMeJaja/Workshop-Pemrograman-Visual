Public Class FrmKalkulator
    Public Shared Angka1, Angka2, hasil As Double
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Angka1 = Val(Txtangka1.Text)
        Angka2 = Val(Txtangka2.Text)
        hasil = Angka1 + Angka2
        Txthasil.Text = hasil
    End Sub
    Private Sub BtnKurang_Click(sender As Object, e As EventArgs) Handles BtnKurang.Click
        Angka1 = Val(Txtangka1.Text)
        Angka2 = Val(Txtangka2.Text)
        hasil = Angka1 - Angka2
        Txthasil.Text = hasil
    End Sub
    Private Sub BtnBagi_Click(sender As Object, e As EventArgs) Handles BtnBagi.Click
        Angka1 = Val(Txtangka1.Text)
        Angka2 = Val(Txtangka2.Text)
        If Angka2 = 0 Then
            Txthasil.Text = "Pembagi tidak bisa 0"
        Else
            hasil = Angka1 / Angka2
            Txthasil.Text = hasil
        End If
    End Sub
    Private Sub BtnKali_Click(sender As Object, e As EventArgs) Handles BtnKali.Click
        Angka1 = Val(Txtangka1.Text)
        Angka2 = Val(Txtangka2.Text)
        hasil = Angka1 * Angka2
        Txthasil.Text = hasil
    End Sub
    Private Sub FrmKalkulator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txthasil.Enabled = False
    End Sub
End Class
