Public Class FrmKalkulator
    Private Sub BtnJumlah_Click(sender As Object, e As EventArgs) Handles BtnJumlah.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(TxtAngka1.Text)
        angka2 = Val(TxtAngka2.Text)
        hasil = angka1 + angka2
        TxtHasil.Text = hasil
    End Sub

    Private Sub BtnKurang_Click(sender As Object, e As EventArgs) Handles BtnKurang.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(TxtAngka1.Text)
        angka2 = Val(TxtAngka2.Text)
        hasil = angka1 - angka2
        TxtHasil.Text = hasil
    End Sub

    Private Sub BtnBagi_Click(sender As Object, e As EventArgs) Handles BtnBagi.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(TxtAngka1.Text)
        angka2 = Val(TxtAngka2.Text)
        If angka2 = 0 Then
            TxtHasil.Text = "Tidak bisa dibagi dengan 0"
        Else
            hasil = angka1 / angka2
            TxtHasil.Text = hasil
        End If
    End Sub

    Private Sub BtnKali_Click(sender As Object, e As EventArgs) Handles BtnKali.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(TxtAngka1.Text)
        angka2 = Val(TxtAngka2.Text)
        hasil = angka1 * angka2
        TxtHasil.Text = hasil
    End Sub

    Private Sub FrmKalkulator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtHasil.Enabled = False
    End Sub
End Class
