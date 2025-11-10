<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuUtama))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.LoginSistemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutSistemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DATAMASTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ABOUTBOXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripDropDownButton2, Me.ToolStripDropDownButton3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1046, 26)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginSistemToolStripMenuItem, Me.LogOutSistemToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem1})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(72, 24)
        Me.ToolStripDropDownButton1.Text = "ADMIN"
        '
        'LoginSistemToolStripMenuItem
        '
        Me.LoginSistemToolStripMenuItem.Name = "LoginSistemToolStripMenuItem"
        Me.LoginSistemToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.LoginSistemToolStripMenuItem.Text = "Login Sistem"
        '
        'LogOutSistemToolStripMenuItem
        '
        Me.LogOutSistemToolStripMenuItem.Name = "LogOutSistemToolStripMenuItem"
        Me.LogOutSistemToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.LogOutSistemToolStripMenuItem.Text = "LogOut Sistem"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(221, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATAMASTERToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(120, 24)
        Me.ToolStripDropDownButton2.Text = "DATA MASTER"
        '
        'DATAMASTERToolStripMenuItem
        '
        Me.DATAMASTERToolStripMenuItem.Name = "DATAMASTERToolStripMenuItem"
        Me.DATAMASTERToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DATAMASTERToolStripMenuItem.Text = "Data Mahasiswa"
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABOUTBOXToolStripMenuItem})
        Me.ToolStripDropDownButton3.Image = CType(resources.GetObject("ToolStripDropDownButton3.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(104, 24)
        Me.ToolStripDropDownButton3.Text = "ABOUT BOX"
        '
        'ABOUTBOXToolStripMenuItem
        '
        Me.ABOUTBOXToolStripMenuItem.Name = "ABOUTBOXToolStripMenuItem"
        Me.ABOUTBOXToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.ABOUTBOXToolStripMenuItem.Text = "Tentang Aplikasi"
        '
        'FrmMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.IsMdiContainer = True
        Me.Name = "FrmMenuUtama"
        Me.Text = "FrmMenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents DATAMASTERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton3 As ToolStripDropDownButton
    Friend WithEvents ABOUTBOXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutSistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginSistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
End Class
