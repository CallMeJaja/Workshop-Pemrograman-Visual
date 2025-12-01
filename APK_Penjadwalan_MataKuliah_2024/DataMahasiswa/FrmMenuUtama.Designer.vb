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
        Me.ToolStripDropDownAdminButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.LoginSistemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutSistemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownDataMasterButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DataMahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataProdiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownAboutButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TentangAplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripDropDownAdminButton1
        '
        Me.ToolStripDropDownAdminButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownAdminButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginSistemToolStripMenuItem, Me.LogOutSistemToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem1})
        Me.ToolStripDropDownAdminButton1.Image = CType(resources.GetObject("ToolStripDropDownAdminButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownAdminButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownAdminButton1.Name = "ToolStripDropDownAdminButton1"
        Me.ToolStripDropDownAdminButton1.Size = New System.Drawing.Size(60, 20)
        Me.ToolStripDropDownAdminButton1.Text = "ADMIN"
        '
        'LoginSistemToolStripMenuItem
        '
        Me.LoginSistemToolStripMenuItem.Name = "LoginSistemToolStripMenuItem"
        Me.LoginSistemToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LoginSistemToolStripMenuItem.Text = "Login Sistem"
        '
        'LogOutSistemToolStripMenuItem
        '
        Me.LogOutSistemToolStripMenuItem.Name = "LogOutSistemToolStripMenuItem"
        Me.LogOutSistemToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogOutSistemToolStripMenuItem.Text = "LogOut Sistem"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'ToolStripDropDownDataMasterButton2
        '
        Me.ToolStripDropDownDataMasterButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownDataMasterButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMahasiswaToolStripMenuItem, Me.DataProdiToolStripMenuItem})
        Me.ToolStripDropDownDataMasterButton2.Image = CType(resources.GetObject("ToolStripDropDownDataMasterButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownDataMasterButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownDataMasterButton2.Name = "ToolStripDropDownDataMasterButton2"
        Me.ToolStripDropDownDataMasterButton2.Size = New System.Drawing.Size(98, 20)
        Me.ToolStripDropDownDataMasterButton2.Text = "DATA MASTER"
        '
        'DataMahasiswaToolStripMenuItem
        '
        Me.DataMahasiswaToolStripMenuItem.Name = "DataMahasiswaToolStripMenuItem"
        Me.DataMahasiswaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataMahasiswaToolStripMenuItem.Text = "Data Mahasiswa"
        '
        'DataProdiToolStripMenuItem
        '
        Me.DataProdiToolStripMenuItem.Name = "DataProdiToolStripMenuItem"
        Me.DataProdiToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataProdiToolStripMenuItem.Text = "Data Jurusan"
        '
        'ToolStripDropDownAboutButton3
        '
        Me.ToolStripDropDownAboutButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownAboutButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TentangAplikasiToolStripMenuItem})
        Me.ToolStripDropDownAboutButton3.Image = CType(resources.GetObject("ToolStripDropDownAboutButton3.Image"), System.Drawing.Image)
        Me.ToolStripDropDownAboutButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownAboutButton3.Name = "ToolStripDropDownAboutButton3"
        Me.ToolStripDropDownAboutButton3.Size = New System.Drawing.Size(86, 20)
        Me.ToolStripDropDownAboutButton3.Text = "ABOUT BOX"
        '
        'TentangAplikasiToolStripMenuItem
        '
        Me.TentangAplikasiToolStripMenuItem.Name = "TentangAplikasiToolStripMenuItem"
        Me.TentangAplikasiToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TentangAplikasiToolStripMenuItem.Text = "Tentang Aplikasi"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownAdminButton1, Me.ToolStripDropDownDataMasterButton2, Me.ToolStripDropDownAboutButton3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(884, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusStrip2
        '
        Me.StatusStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 395)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(884, 22)
        Me.StatusStrip2.TabIndex = 2
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(186, 17)
        Me.ToolStripStatusLabel1.Text = "Reza Asriano Maulana : 202404021"
        '
        'FrmMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 417)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmMenuUtama"
        Me.Text = "FrmMenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStripDropDownAdminButton1 As ToolStripDropDownButton
    Friend WithEvents LoginSistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutSistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownDataMasterButton2 As ToolStripDropDownButton
    Friend WithEvents DataMahasiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownAboutButton3 As ToolStripDropDownButton
    Friend WithEvents TentangAplikasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents DataProdiToolStripMenuItem As ToolStripMenuItem
End Class
