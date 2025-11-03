<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDataMhs
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbStatusMahasiswa = New System.Windows.Forms.ComboBox()
        Me.CbJurusan = New System.Windows.Forms.ComboBox()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.CbAgama = New System.Windows.Forms.ComboBox()
        Me.CBJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtNik = New System.Windows.Forms.TextBox()
        Me.LbHasil = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridMahasiswa = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbStatusMahasiswa)
        Me.GroupBox1.Controls.Add(Me.CbJurusan)
        Me.GroupBox1.Controls.Add(Me.TxtAlamat)
        Me.GroupBox1.Controls.Add(Me.CbAgama)
        Me.GroupBox1.Controls.Add(Me.CBJenisKelamin)
        Me.GroupBox1.Controls.Add(Me.TxtNama)
        Me.GroupBox1.Controls.Add(Me.TxtNik)
        Me.GroupBox1.Controls.Add(Me.LbHasil)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 446)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = ":: INPUT DATA ::"
        '
        'CbStatusMahasiswa
        '
        Me.CbStatusMahasiswa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbStatusMahasiswa.FormattingEnabled = True
        Me.CbStatusMahasiswa.Location = New System.Drawing.Point(112, 235)
        Me.CbStatusMahasiswa.Name = "CbStatusMahasiswa"
        Me.CbStatusMahasiswa.Size = New System.Drawing.Size(220, 22)
        Me.CbStatusMahasiswa.TabIndex = 14
        '
        'CbJurusan
        '
        Me.CbJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbJurusan.FormattingEnabled = True
        Me.CbJurusan.Location = New System.Drawing.Point(112, 207)
        Me.CbJurusan.Name = "CbJurusan"
        Me.CbJurusan.Size = New System.Drawing.Size(266, 22)
        Me.CbJurusan.TabIndex = 13
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Location = New System.Drawing.Point(112, 127)
        Me.TxtAlamat.Multiline = True
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(266, 74)
        Me.TxtAlamat.TabIndex = 12
        '
        'CbAgama
        '
        Me.CbAgama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbAgama.FormattingEnabled = True
        Me.CbAgama.Location = New System.Drawing.Point(112, 99)
        Me.CbAgama.Name = "CbAgama"
        Me.CbAgama.Size = New System.Drawing.Size(220, 22)
        Me.CbAgama.TabIndex = 11
        '
        'CBJenisKelamin
        '
        Me.CBJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBJenisKelamin.FormattingEnabled = True
        Me.CBJenisKelamin.Location = New System.Drawing.Point(112, 71)
        Me.CBJenisKelamin.Name = "CBJenisKelamin"
        Me.CBJenisKelamin.Size = New System.Drawing.Size(178, 22)
        Me.CBJenisKelamin.TabIndex = 10
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(112, 45)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(220, 20)
        Me.TxtNama.TabIndex = 9
        '
        'TxtNik
        '
        Me.TxtNik.Location = New System.Drawing.Point(112, 19)
        Me.TxtNik.Name = "TxtNik"
        Me.TxtNik.Size = New System.Drawing.Size(220, 20)
        Me.TxtNik.TabIndex = 8
        '
        'LbHasil
        '
        Me.LbHasil.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LbHasil.Location = New System.Drawing.Point(6, 275)
        Me.LbHasil.Name = "LbHasil"
        Me.LbHasil.Size = New System.Drawing.Size(407, 158)
        Me.LbHasil.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 28)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Status " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mahasiswa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 14)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Jurusan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 14)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 14)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Agama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 14)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 14)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NIK"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnTambah)
        Me.GroupBox2.Controls.Add(Me.BtnKeluar)
        Me.GroupBox2.Controls.Add(Me.BtnSimpan)
        Me.GroupBox2.Controls.Add(Me.BtnHapus)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 518)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(419, 64)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(343, 18)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(70, 40)
        Me.BtnTambah.TabIndex = 2
        Me.BtnTambah.Text = "TAMBAH"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(229, 18)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(70, 40)
        Me.BtnKeluar.TabIndex = 1
        Me.BtnKeluar.Text = "KELUAR"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(7, 18)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(70, 40)
        Me.BtnSimpan.TabIndex = 0
        Me.BtnSimpan.Text = "SIMPAN"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(118, 18)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(70, 40)
        Me.BtnHapus.TabIndex = 3
        Me.BtnHapus.Text = "HAPUS"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Georgia", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(89, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = ":: BIODATA MAHASISWA ::"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridMahasiswa
        '
        Me.DataGridMahasiswa.AllowUserToDeleteRows = False
        Me.DataGridMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMahasiswa.Location = New System.Drawing.Point(437, 66)
        Me.DataGridMahasiswa.Name = "DataGridMahasiswa"
        Me.DataGridMahasiswa.ReadOnly = True
        Me.DataGridMahasiswa.Size = New System.Drawing.Size(627, 516)
        Me.DataGridMahasiswa.TabIndex = 2
        '
        'FrmDataMhs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 594)
        Me.Controls.Add(Me.DataGridMahasiswa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmDataMhs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":: DATA INPUT MAHASISWA ::"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBJenisKelamin As ComboBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtNik As TextBox
    Friend WithEvents LbHasil As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CbStatusMahasiswa As ComboBox
    Friend WithEvents CbJurusan As ComboBox
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents CbAgama As ComboBox
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents DataGridMahasiswa As DataGridView
End Class
