Public Class FrmMenuUtama
    Private Sub DATAMASTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATAMASTERToolStripMenuItem.Click
        FrmDataMahasiswa.Show()
        FrmDataMahasiswa.MdiParent = Me
    End Sub

    Private Sub ABOUTBOXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTBOXToolStripMenuItem.Click
        TentangAplikasi.Show()
    End Sub

    Private Sub LoginSistemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginSistemToolStripMenuItem.Click
        FrmLogin.Show()
        FrmLogin.MdiParent = Me
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub FrmMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (isLogin <> True) Then
            ToolStripDropDownButton2.Enabled = False
            ToolStripDropDownButton3.Enabled = False
            LogOutSistemToolStripMenuItem.Enabled = False
        End If
    End Sub
    Private Sub LogOutSistemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutSistemToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class