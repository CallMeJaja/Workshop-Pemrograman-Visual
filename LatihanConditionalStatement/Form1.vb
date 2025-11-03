Public Class FrmConditionalStatement
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nilai, Bobot As Double
        Dim Grade, Predikat As String

        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("NILAI KOSONG ATAU TIDAK VALID." & vbCrLf & "SILAHKAN INPUT ULANG.")
            TextBox1.Clear()
            TextBox1.Focus()
            Return
        End If

        Nilai = Val(TextBox1.Text)

        If Nilai = 0 Then
            Grade = "E"
            Bobot = 4
            Predikat = "Gagal"
        ElseIf Nilai < 0 Or Nilai > 100 Then
            MsgBox("NILAI TIDAK VALID. HARUS ANTARA 0 - 100." & vbCrLf & "SILAHKAN INPUT ULANG.")
            TextBox1.Clear()
            TextBox1.Focus()
            Return
        Else
            Select Case Nilai
                Case 90 To 100
                    Grade = "A"
                    Bobot = 4
                    Predikat = "Sangat Memuaskan"
                Case 80 To 89
                    Grade = "AB"
                    Bobot = 3.5
                    Predikat = "Memuaskan"
                Case 70 To 79
                    Grade = "B"
                    Bobot = 3
                    Predikat = "Baik"
                Case 60 To 69
                    Grade = "BC"
                    Bobot = 2.5
                    Predikat = "Cukup Baik"
                Case 50 To 59
                    Grade = "C"
                    Bobot = 2
                    Predikat = "Cukup"
                Case 40 To 49
                    Grade = "D"
                    Bobot = 1
                    Predikat = "Kurang"
                Case Else
                    Grade = "E"
                    Bobot = 0
                    Predikat = "Gagal"
            End Select
        End If

        TextBox2.Text = Grade
        TextBox3.Text = Bobot
        TextBox4.Text = Predikat
    End Sub
End Class
