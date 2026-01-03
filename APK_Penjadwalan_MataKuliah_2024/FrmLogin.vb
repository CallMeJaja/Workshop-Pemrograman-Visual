Imports MySql.Data.MySqlClient

Public Class FrmLogin

    Private Const MAX_LOGIN_ATTEMPTS As Integer = 3
    Private loginAttempts As Integer = 0

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ResetForm()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If Not ValidateInput() Then Exit Sub
        Try
            Call KoneksiDB()
            Call ProcessLogin()
        Catch ex As MySqlException
            MsgBox("Error Database: " & ex.Message, vbCritical, "ERROR")
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, vbCritical, "ERROR")
        Finally
            Call CloseConnection()
        End Try
    End Sub
    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        If MsgBox("Anda yakin ingin keluar?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
            Me.Close()
        End If
    End Sub

    Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(TxtUser.Text) Then
            MsgBox("Nama User tidak boleh kosong!", vbExclamation, "PERINGATAN")
            TxtUser.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(TxtPwd.Text) Then
            MsgBox("Password tidak boleh kosong!", vbExclamation, "PERINGATAN")
            TxtPwd.Focus()
            Return False
        End If

        Return True
    End Function

    Sub ProcessLogin()
        Dim SQLLogin As String = "SELECT Nm_User, Pass_User, Level_User FROM tbl_user WHERE Nm_User = @user"
        CMD = New MySqlCommand(SQLLogin, DBKoneksi)
        CMD.Parameters.AddWithValue("@user", TxtUser.Text.Trim())

        DR = CMD.ExecuteReader()

        If DR.Read() Then
            Dim storedPassword As String = DR("Pass_User").ToString()
            Nama_User = DR("Nm_User").ToString()
            Role = DR("Level_User").ToString()
            DR.Close()

            If TxtPwd.Text = storedPassword Then
                Call HandleSuccessfulLogin()
            Else
                Call HandleFailedLogin()
            End If
        Else
            DR.Close()
            MsgBox("Username tidak ditemukan!", vbCritical, "PERINGATAN")
            Call ResetForm()
            TxtUser.Focus()
        End If
    End Sub

    Sub HandleSuccessfulLogin()
        loginAttempts = 0
        isLogin = True

        MsgBox("Selamat datang, " & Nama_User & "!", vbInformation, "Login Berhasil")

        Select Case Role.ToUpper()
            Case "ADMINISTRATOR"
                Call SetAdministratorMenu()
            Case "MAHASISWA"
                Call SetMahasiswaMenu()
            Case Else
                MsgBox("Role tidak dikenali! Hubungi administrator.", vbCritical, "ERROR")
                Call ResetForm()
                Exit Sub
        End Select

        Me.Close()
    End Sub

    Sub HandleFailedLogin()
        loginAttempts += 1

        If loginAttempts < MAX_LOGIN_ATTEMPTS Then
            MsgBox("Password salah! Percobaan ke-" & loginAttempts & " dari " & MAX_LOGIN_ATTEMPTS & ".", vbExclamation, "PERINGATAN")
            TxtPwd.Clear()
            TxtPwd.Focus()
        Else
            MsgBox("Anda telah gagal login " & MAX_LOGIN_ATTEMPTS & " kali! Silahkan coba lagi.", vbCritical, "Akses Ditolak")
            Me.Close()
        End If
    End Sub

    Sub SetAdministratorMenu()
        With FrmMenuUtama
            .ToolStripDropDownDataMasterButton2.Enabled = True
            .ToolStripDropDownAboutButton3.Enabled = True
            .LoginSistemToolStripMenuItem.Enabled = False
            .LogOutSistemToolStripMenuItem.Enabled = True
        End With
    End Sub

    Sub SetMahasiswaMenu()
        With FrmMenuUtama
            .ToolStripDropDownDataMasterButton2.Enabled = True
            .ToolStripDropDownAboutButton3.Enabled = True
            .DataMahasiswaToolStripMenuItem.Enabled = False
            .LoginSistemToolStripMenuItem.Enabled = False
            .LogOutSistemToolStripMenuItem.Enabled = True
        End With
    End Sub

    Sub ResetForm()
        TxtUser.Clear()
        TxtPwd.Clear()
        TxtUser.Focus()
    End Sub

    Sub CloseConnection()
        If DR IsNot Nothing AndAlso Not DR.IsClosed Then DR.Close()
        If DBKoneksi IsNot Nothing AndAlso DBKoneksi.State = ConnectionState.Open Then DBKoneksi.Close()
    End Sub

End Class
