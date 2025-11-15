Imports MySql.Data.MySqlClient
Public Class FrmLogin

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Call KoneksiDB()

        If TxtUser.Text = "" Then
            MsgBox("Nama User Tidak Boleh Kosong", vbExclamation, "KOSONG!")
            TxtUser.Focus()
            Exit Sub
        End If

        If TxtPwd.Text = "" Then
            MsgBox("Password Tidak Boleh Kosong", vbExclamation, "KOSONG!")
            TxtPwd.Focus()
            Exit Sub
        End If

        Try
            Dim checkUserQuery As String = "SELECT * FROM tbl_user WHERE Nm_User = @user"
            CMD = New MySqlCommand(checkUserQuery, DBKoneksi)
            CMD.Parameters.AddWithValue("@user", TxtUser.Text)

            DR = CMD.ExecuteReader()

            If DR.Read() Then
                Dim storedPassword As String = DR("Pass_User").ToString()
                Dim level As String = DR("Level_User").ToString()
                Dim namaUser As String = DR("Nm_User").ToString()

                DR.Close()

                If TxtPwd.Text = storedPassword Then
                    Hitung = 0

                    MsgBox("Selamat datang, " & namaUser, vbInformation, "Login Berhasil")

                    If level = "Administrator" AndAlso namaUser = "Reza" Then
                        With FrmMenuUtama
                            Me.Close()
                            .ToolStripDropDownButton2.Enabled = True
                            .ToolStripDropDownButton3.Enabled = True
                            .LoginSistemToolStripMenuItem.Enabled = False
                            .LogOutSistemToolStripMenuItem.Enabled = True
                        End With

                    ElseIf level = "Mahasiswa" Then
                        Me.Close()
                        FrmMenuUtama.Show()
                        With FrmMenuUtama
                            .ToolStripDropDownButton3.Enabled = True
                            .LoginSistemToolStripMenuItem.Enabled = False
                            .LogOutSistemToolStripMenuItem.Enabled = True
                        End With
                    Else
                        MsgBox("Anda tidak berhak menggunakan program ini!", vbCritical + vbOKOnly, "INFORMASI")
                        TxtUser.Text = ""
                        TxtPwd.Text = ""
                    End If

                    isLogin = True

                Else
                    Hitung += 1

                    If Hitung < 3 Then
                        MsgBox("Password salah! Percobaan ke-" & Hitung & " dari 3.", vbExclamation, "Warning")
                        TxtPwd.Text = ""
                        TxtPwd.Focus()
                    Else
                        MsgBox("Anda telah gagal login 3 kali! Aplikasi akan ditutup.", vbCritical, "Akses Ditolak")
                        Me.Close()
                    End If
                End If

            Else
                MsgBox("Username tidak ditemukan!", vbCritical, "Peringatan")
                TxtUser.Text = ""
                TxtPwd.Text = ""
                TxtUser.Focus()
            End If

        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, vbCritical, "Error")

        Finally
            If DR IsNot Nothing AndAlso Not DR.IsClosed Then DR.Close()
            DBKoneksi.Close()
        End Try
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        If MsgBox("Anda yakin ingin keluar?", vbQuestion + vbYesNo, "Warning") = vbYes Then
            Me.Close()
        End If

    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class