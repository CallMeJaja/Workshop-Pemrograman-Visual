<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataMahasiswa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbHasil = New System.Windows.Forms.Label()
        Me.CmbStatusMahasiswa = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmbJurusan = New System.Windows.Forms.ComboBox()
        Me.TxtNik = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.CmbJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbAgama = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbHasil)
        Me.GroupBox1.Controls.Add(Me.CmbStatusMahasiswa)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CmbJurusan)
        Me.GroupBox1.Controls.Add(Me.TxtNik)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtAlamat)
        Me.GroupBox1.Controls.Add(Me.CmbJenisKelamin)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CmbAgama)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtNama)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 543)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = ":: Input Data ::"
        '
        'LbHasil
        '
        Me.LbHasil.BackColor = System.Drawing.Color.Silver
        Me.LbHasil.Location = New System.Drawing.Point(30, 413)
        Me.LbHasil.Name = "LbHasil"
        Me.LbHasil.Size = New System.Drawing.Size(406, 114)
        Me.LbHasil.TabIndex = 16
        '
        'CmbStatusMahasiswa
        '
        Me.CmbStatusMahasiswa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStatusMahasiswa.FormattingEnabled = True
        Me.CmbStatusMahasiswa.Location = New System.Drawing.Point(170, 366)
        Me.CmbStatusMahasiswa.Name = "CmbStatusMahasiswa"
        Me.CmbStatusMahasiswa.Size = New System.Drawing.Size(173, 24)
        Me.CmbStatusMahasiswa.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Agama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 313)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Jurusan"
        '
        'CmbJurusan
        '
        Me.CmbJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbJurusan.FormattingEnabled = True
        Me.CmbJurusan.Location = New System.Drawing.Point(170, 324)
        Me.CmbJurusan.Name = "CmbJurusan"
        Me.CmbJurusan.Size = New System.Drawing.Size(173, 24)
        Me.CmbJurusan.TabIndex = 13
        '
        'TxtNik
        '
        Me.TxtNik.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNik.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNik.Location = New System.Drawing.Point(170, 37)
        Me.TxtNik.Name = "TxtNik"
        Me.TxtNik.Size = New System.Drawing.Size(146, 15)
        Me.TxtNik.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 366)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Status Mahasiswa"
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Location = New System.Drawing.Point(170, 204)
        Me.TxtAlamat.Multiline = True
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtAlamat.Size = New System.Drawing.Size(266, 91)
        Me.TxtAlamat.TabIndex = 12
        '
        'CmbJenisKelamin
        '
        Me.CmbJenisKelamin.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbJenisKelamin.FormattingEnabled = True
        Me.CmbJenisKelamin.Location = New System.Drawing.Point(170, 109)
        Me.CmbJenisKelamin.Name = "CmbJenisKelamin"
        Me.CmbJenisKelamin.Size = New System.Drawing.Size(173, 24)
        Me.CmbJenisKelamin.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'CmbAgama
        '
        Me.CmbAgama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAgama.FormattingEnabled = True
        Me.CmbAgama.Location = New System.Drawing.Point(170, 154)
        Me.CmbAgama.Name = "CmbAgama"
        Me.CmbAgama.Size = New System.Drawing.Size(173, 24)
        Me.CmbAgama.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIK"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(170, 72)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(266, 22)
        Me.TxtNama.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = ":: BIODATA MAHASISWA ::"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnSimpan
        '
        Me.BtnSimpan.AutoSize = True
        Me.BtnSimpan.Location = New System.Drawing.Point(30, 21)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(144, 27)
        Me.BtnSimpan.TabIndex = 15
        Me.BtnSimpan.Text = "SIMPAN"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.AutoSize = True
        Me.BtnKeluar.Location = New System.Drawing.Point(261, 21)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(82, 27)
        Me.BtnKeluar.TabIndex = 16
        Me.BtnKeluar.Text = "KELUAR"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.AutoSize = True
        Me.BtnTambah.Location = New System.Drawing.Point(349, 21)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(87, 27)
        Me.BtnTambah.TabIndex = 17
        Me.BtnTambah.Text = "TAMBAH"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.AutoSize = True
        Me.BtnHapus.Location = New System.Drawing.Point(180, 21)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 27)
        Me.BtnHapus.TabIndex = 18
        Me.BtnHapus.Text = "HAPUS"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnSimpan)
        Me.GroupBox2.Controls.Add(Me.BtnKeluar)
        Me.GroupBox2.Controls.Add(Me.BtnHapus)
        Me.GroupBox2.Controls.Add(Me.BtnTambah)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(28, 656)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 67)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'FrmDataMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(510, 740)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmDataMahasiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":: DATA INPUT MAHASISWA ::"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents CmbJurusan As ComboBox
    Friend WithEvents CmbAgama As ComboBox
    Friend WithEvents CmbJenisKelamin As ComboBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtNik As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbStatusMahasiswa As ComboBox
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LbHasil As Label
End Class
