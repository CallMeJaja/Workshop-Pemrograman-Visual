<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInputMahasiswa
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.LbHasil = New System.Windows.Forms.Label()
        Me.CmbStatusMahasiswa = New System.Windows.Forms.ComboBox()
        Me.LbAlamatMhs = New System.Windows.Forms.Label()
        Me.LbNamaMhs = New System.Windows.Forms.Label()
        Me.LbJurusanMhs = New System.Windows.Forms.Label()
        Me.CmbJurusan = New System.Windows.Forms.ComboBox()
        Me.LbStatusMhs = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.CmbJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.LbJkMhs = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.LbNimMhs = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbKdJurusan = New System.Windows.Forms.Label()
        Me.LbNimVal = New System.Windows.Forms.Label()
        Me.DateTimePickerMhs = New System.Windows.Forms.DateTimePicker()
        Me.LbTTLMhs = New System.Windows.Forms.Label()
        Me.TxtTempatLahir = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.BtnSimpan)
        Me.GroupBox2.Controls.Add(Me.BtnKeluar)
        Me.GroupBox2.Controls.Add(Me.BtnHapus)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 492)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(424, 58)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.AutoSize = True
        Me.BtnSimpan.Location = New System.Drawing.Point(57, 16)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(108, 26)
        Me.BtnSimpan.TabIndex = 15
        Me.BtnSimpan.Text = "SIMPAN"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.AutoSize = True
        Me.BtnKeluar.Location = New System.Drawing.Point(293, 16)
        Me.BtnKeluar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(74, 26)
        Me.BtnKeluar.TabIndex = 16
        Me.BtnKeluar.Text = "KELUAR"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.AutoSize = True
        Me.BtnHapus.Location = New System.Drawing.Point(196, 15)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(65, 26)
        Me.BtnHapus.TabIndex = 18
        Me.BtnHapus.Text = "HAPUS"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'LbHasil
        '
        Me.LbHasil.BackColor = System.Drawing.Color.Silver
        Me.LbHasil.Location = New System.Drawing.Point(15, 301)
        Me.LbHasil.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbHasil.Name = "LbHasil"
        Me.LbHasil.Size = New System.Drawing.Size(410, 114)
        Me.LbHasil.TabIndex = 16
        '
        'CmbStatusMahasiswa
        '
        Me.CmbStatusMahasiswa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStatusMahasiswa.FormattingEnabled = True
        Me.CmbStatusMahasiswa.Location = New System.Drawing.Point(128, 270)
        Me.CmbStatusMahasiswa.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbStatusMahasiswa.Name = "CmbStatusMahasiswa"
        Me.CmbStatusMahasiswa.Size = New System.Drawing.Size(297, 20)
        Me.CmbStatusMahasiswa.TabIndex = 14
        '
        'LbAlamatMhs
        '
        Me.LbAlamatMhs.AutoSize = True
        Me.LbAlamatMhs.Location = New System.Drawing.Point(13, 150)
        Me.LbAlamatMhs.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbAlamatMhs.Name = "LbAlamatMhs"
        Me.LbAlamatMhs.Size = New System.Drawing.Size(45, 14)
        Me.LbAlamatMhs.TabIndex = 5
        Me.LbAlamatMhs.Text = "Alamat"
        '
        'LbNamaMhs
        '
        Me.LbNamaMhs.AutoSize = True
        Me.LbNamaMhs.Location = New System.Drawing.Point(13, 58)
        Me.LbNamaMhs.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbNamaMhs.Name = "LbNamaMhs"
        Me.LbNamaMhs.Size = New System.Drawing.Size(37, 14)
        Me.LbNamaMhs.TabIndex = 2
        Me.LbNamaMhs.Text = "Nama"
        '
        'LbJurusanMhs
        '
        Me.LbJurusanMhs.AutoSize = True
        Me.LbJurusanMhs.Location = New System.Drawing.Point(13, 236)
        Me.LbJurusanMhs.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbJurusanMhs.Name = "LbJurusanMhs"
        Me.LbJurusanMhs.Size = New System.Drawing.Size(52, 14)
        Me.LbJurusanMhs.TabIndex = 6
        Me.LbJurusanMhs.Text = "Jurusan"
        '
        'CmbJurusan
        '
        Me.CmbJurusan.FormattingEnabled = True
        Me.CmbJurusan.Location = New System.Drawing.Point(184, 236)
        Me.CmbJurusan.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbJurusan.Name = "CmbJurusan"
        Me.CmbJurusan.Size = New System.Drawing.Size(241, 20)
        Me.CmbJurusan.TabIndex = 13
        '
        'LbStatusMhs
        '
        Me.LbStatusMhs.AutoSize = True
        Me.LbStatusMhs.Location = New System.Drawing.Point(13, 270)
        Me.LbStatusMhs.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbStatusMhs.Name = "LbStatusMhs"
        Me.LbStatusMhs.Size = New System.Drawing.Size(107, 14)
        Me.LbStatusMhs.TabIndex = 7
        Me.LbStatusMhs.Text = "Status Mahasiswa"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 41)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = ":: BIODATA MAHASISWA ::"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Location = New System.Drawing.Point(128, 150)
        Me.TxtAlamat.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAlamat.Multiline = True
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtAlamat.Size = New System.Drawing.Size(297, 75)
        Me.TxtAlamat.TabIndex = 12
        '
        'CmbJenisKelamin
        '
        Me.CmbJenisKelamin.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbJenisKelamin.FormattingEnabled = True
        Me.CmbJenisKelamin.Location = New System.Drawing.Point(128, 89)
        Me.CmbJenisKelamin.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbJenisKelamin.Name = "CmbJenisKelamin"
        Me.CmbJenisKelamin.Size = New System.Drawing.Size(297, 20)
        Me.CmbJenisKelamin.TabIndex = 10
        '
        'LbJkMhs
        '
        Me.LbJkMhs.AutoSize = True
        Me.LbJkMhs.Location = New System.Drawing.Point(13, 89)
        Me.LbJkMhs.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbJkMhs.Name = "LbJkMhs"
        Me.LbJkMhs.Size = New System.Drawing.Size(84, 14)
        Me.LbJkMhs.TabIndex = 3
        Me.LbJkMhs.Text = "Jenis Kelamin"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(128, 58)
        Me.TxtNama.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(297, 19)
        Me.TxtNama.TabIndex = 9
        '
        'LbNimMhs
        '
        Me.LbNimMhs.AutoSize = True
        Me.LbNimMhs.Location = New System.Drawing.Point(13, 30)
        Me.LbNimMhs.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbNimMhs.Name = "LbNimMhs"
        Me.LbNimMhs.Size = New System.Drawing.Size(27, 14)
        Me.LbNimMhs.TabIndex = 1
        Me.LbNimMhs.Text = "NIM"
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.LbKdJurusan)
        Me.GroupBox1.Controls.Add(Me.LbNimVal)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerMhs)
        Me.GroupBox1.Controls.Add(Me.LbTTLMhs)
        Me.GroupBox1.Controls.Add(Me.TxtTempatLahir)
        Me.GroupBox1.Controls.Add(Me.LbHasil)
        Me.GroupBox1.Controls.Add(Me.CmbStatusMahasiswa)
        Me.GroupBox1.Controls.Add(Me.LbAlamatMhs)
        Me.GroupBox1.Controls.Add(Me.LbNamaMhs)
        Me.GroupBox1.Controls.Add(Me.LbJurusanMhs)
        Me.GroupBox1.Controls.Add(Me.CmbJurusan)
        Me.GroupBox1.Controls.Add(Me.LbStatusMhs)
        Me.GroupBox1.Controls.Add(Me.TxtAlamat)
        Me.GroupBox1.Controls.Add(Me.CmbJenisKelamin)
        Me.GroupBox1.Controls.Add(Me.LbJkMhs)
        Me.GroupBox1.Controls.Add(Me.LbNimMhs)
        Me.GroupBox1.Controls.Add(Me.TxtNama)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 45)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(437, 429)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = ":: Input Data ::"
        '
        'LbKdJurusan
        '
        Me.LbKdJurusan.BackColor = System.Drawing.Color.Khaki
        Me.LbKdJurusan.Location = New System.Drawing.Point(126, 236)
        Me.LbKdJurusan.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbKdJurusan.Name = "LbKdJurusan"
        Me.LbKdJurusan.Size = New System.Drawing.Size(54, 20)
        Me.LbKdJurusan.TabIndex = 22
        Me.LbKdJurusan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbNimVal
        '
        Me.LbNimVal.BackColor = System.Drawing.Color.Khaki
        Me.LbNimVal.Location = New System.Drawing.Point(128, 25)
        Me.LbNimVal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbNimVal.Name = "LbNimVal"
        Me.LbNimVal.Size = New System.Drawing.Size(82, 20)
        Me.LbNimVal.TabIndex = 21
        Me.LbNimVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePickerMhs
        '
        Me.DateTimePickerMhs.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerMhs.Location = New System.Drawing.Point(265, 120)
        Me.DateTimePickerMhs.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePickerMhs.Name = "DateTimePickerMhs"
        Me.DateTimePickerMhs.Size = New System.Drawing.Size(161, 19)
        Me.DateTimePickerMhs.TabIndex = 20
        '
        'LbTTLMhs
        '
        Me.LbTTLMhs.AutoSize = True
        Me.LbTTLMhs.Location = New System.Drawing.Point(13, 122)
        Me.LbTTLMhs.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbTTLMhs.Name = "LbTTLMhs"
        Me.LbTTLMhs.Size = New System.Drawing.Size(28, 14)
        Me.LbTTLMhs.TabIndex = 17
        Me.LbTTLMhs.Text = "TTL"
        '
        'TxtTempatLahir
        '
        Me.TxtTempatLahir.Location = New System.Drawing.Point(128, 120)
        Me.TxtTempatLahir.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTempatLahir.Name = "TxtTempatLahir"
        Me.TxtTempatLahir.Size = New System.Drawing.Size(133, 19)
        Me.TxtTempatLahir.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 41)
        Me.Panel1.TabIndex = 23
        '
        'FrmInputMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmInputMahasiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmInputMahasiswa"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents LbHasil As Label
    Friend WithEvents CmbStatusMahasiswa As ComboBox
    Friend WithEvents LbAlamatMhs As Label
    Friend WithEvents LbNamaMhs As Label
    Friend WithEvents LbJurusanMhs As Label
    Friend WithEvents CmbJurusan As ComboBox
    Friend WithEvents LbStatusMhs As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents CmbJenisKelamin As ComboBox
    Friend WithEvents LbJkMhs As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents LbNimMhs As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePickerMhs As DateTimePicker
    Friend WithEvents LbTTLMhs As Label
    Friend WithEvents TxtTempatLahir As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LbKdJurusan As Label
    Friend WithEvents LbNimVal As Label
End Class
