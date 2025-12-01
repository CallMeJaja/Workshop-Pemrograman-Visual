Public Class FrmMenuUtama

    Private Sub FrmMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call UpdateMenuState()
    End Sub

    Sub UpdateMenuState()
        Dim isUserLoggedIn As Boolean = isLogin

        ToolStripDropDownDataMasterButton2.Enabled = isUserLoggedIn
        ToolStripDropDownAboutButton3.Enabled = isUserLoggedIn
        LoginSistemToolStripMenuItem.Enabled = Not isUserLoggedIn
        LogOutSistemToolStripMenuItem.Enabled = isUserLoggedIn
    End Sub

    Private Sub ShowMdiChild(childForm As Form)
        If childForm.Visible Then
            childForm.Activate()
            Return
        End If

        childForm.MdiParent = Me
        childForm.Show()
    End Sub

    Private Sub DataMahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMahasiswaToolStripMenuItem.Click
        Call ShowMdiChild(FrmDataMahasiswa)
    End Sub

    Private Sub DataProdiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataProdiToolStripMenuItem.Click
        Call ShowMdiChild(FrmDataJurusan)
    End Sub

    Private Sub ABOUTBOXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TentangAplikasiToolStripMenuItem.Click
        Call ShowMdiChild(TentangAplikasi)
    End Sub

    Private Sub LoginSistemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginSistemToolStripMenuItem.Click
        Call ShowMdiChild(FrmLogin)
    End Sub

    Private Sub LogOutSistemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutSistemToolStripMenuItem.Click
        Dim confirm As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            Call CloseAllChildForms()
            Call ClearUserSession()
            Call UpdateMenuState()

            MsgBox("Logout berhasil!", vbInformation + vbOKOnly, "INFORMASI")
        End If
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Dim confirm As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Sub CloseAllChildForms()
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
    End Sub

    Sub ClearUserSession()
        isLogin = False
        Nama_User = ""
        Role = ""
    End Sub

End Class
