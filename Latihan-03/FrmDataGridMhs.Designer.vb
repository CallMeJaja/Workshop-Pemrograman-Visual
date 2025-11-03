<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDataGridMhs
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
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.CmbStatusMahasiswa = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmbJurusan = New System.Windows.Forms.ComboBox()
        Me.TxtNik = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.CmbJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbAgama = New System.Windows.Forms.ComboBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridMahasiswa = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.BtnSimpan)
        Me.GroupBox2.Controls.Add(Me.BtnKeluar)
        Me.GroupBox2.Controls.Add(Me.BtnHapus)
        Me.GroupBox2.Controls.Add(Me.BtnTambah)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(20, 390)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(342, 59)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.AutoSize = True
        Me.BtnSimpan.Location = New System.Drawing.Point(16, 17)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(108, 26)
        Me.BtnSimpan.TabIndex = 15
        Me.BtnSimpan.Text = "SIMPAN"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.AutoSize = True
        Me.BtnKeluar.Location = New System.Drawing.Point(188, 16)
        Me.BtnKeluar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(74, 26)
        Me.BtnKeluar.TabIndex = 16
        Me.BtnKeluar.Text = "KELUAR"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.AutoSize = True
        Me.BtnHapus.Location = New System.Drawing.Point(128, 16)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(65, 26)
        Me.BtnHapus.TabIndex = 18
        Me.BtnHapus.Text = "HAPUS"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.AutoSize = True
        Me.BtnTambah.Location = New System.Drawing.Point(261, 16)
        Me.BtnTambah.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(76, 26)
        Me.BtnTambah.TabIndex = 17
        Me.BtnTambah.Text = "TAMBAH"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'CmbStatusMahasiswa
        '
        Me.CmbStatusMahasiswa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStatusMahasiswa.FormattingEnabled = True
        Me.CmbStatusMahasiswa.Location = New System.Drawing.Point(128, 297)
        Me.CmbStatusMahasiswa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CmbStatusMahasiswa.Name = "CmbStatusMahasiswa"
        Me.CmbStatusMahasiswa.Size = New System.Drawing.Size(198, 20)
        Me.CmbStatusMahasiswa.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 166)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 14)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 125)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Agama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 263)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 14)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Jurusan"
        '
        'CmbJurusan
        '
        Me.CmbJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbJurusan.FormattingEnabled = True
        Me.CmbJurusan.Location = New System.Drawing.Point(128, 263)
        Me.CmbJurusan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CmbJurusan.Name = "CmbJurusan"
        Me.CmbJurusan.Size = New System.Drawing.Size(198, 20)
        Me.CmbJurusan.TabIndex = 13
        '
        'TxtNik
        '
        Me.TxtNik.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNik.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNik.Location = New System.Drawing.Point(128, 30)
        Me.TxtNik.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtNik.Multiline = True
        Me.TxtNik.Name = "TxtNik"
        Me.TxtNik.Size = New System.Drawing.Size(198, 15)
        Me.TxtNik.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 297)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 14)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Status Mahasiswa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 22)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = ":: BIODATA MAHASISWA ::"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Location = New System.Drawing.Point(128, 166)
        Me.TxtAlamat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtAlamat.Multiline = True
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtAlamat.Size = New System.Drawing.Size(200, 75)
        Me.TxtAlamat.TabIndex = 12
        '
        'CmbJenisKelamin
        '
        Me.CmbJenisKelamin.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbJenisKelamin.FormattingEnabled = True
        Me.CmbJenisKelamin.Location = New System.Drawing.Point(128, 89)
        Me.CmbJenisKelamin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CmbJenisKelamin.Name = "CmbJenisKelamin"
        Me.CmbJenisKelamin.Size = New System.Drawing.Size(200, 20)
        Me.CmbJenisKelamin.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 89)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'CmbAgama
        '
        Me.CmbAgama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAgama.FormattingEnabled = True
        Me.CmbAgama.Location = New System.Drawing.Point(128, 125)
        Me.CmbAgama.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CmbAgama.Name = "CmbAgama"
        Me.CmbAgama.Size = New System.Drawing.Size(198, 20)
        Me.CmbAgama.TabIndex = 11
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(128, 58)
        Me.TxtNama.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(200, 19)
        Me.TxtNama.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIK"
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
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
        Me.GroupBox1.Location = New System.Drawing.Point(20, 54)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(342, 333)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = ":: Input Data ::"
        '
        'DataGridMahasiswa
        '
        Me.DataGridMahasiswa.AllowUserToDeleteRows = False
        Me.DataGridMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridMahasiswa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMahasiswa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridMahasiswa.Location = New System.Drawing.Point(7, 0)
        Me.DataGridMahasiswa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridMahasiswa.Name = "DataGridMahasiswa"
        Me.DataGridMahasiswa.ReadOnly = True
        Me.DataGridMahasiswa.RowHeadersWidth = 51
        Me.DataGridMahasiswa.RowTemplate.Height = 24
        Me.DataGridMahasiswa.Size = New System.Drawing.Size(562, 379)
        Me.DataGridMahasiswa.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 73
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 73
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 73
        '
        'Column4
        '
        Me.Column4.HeaderText = "Column4"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 73
        '
        'Column5
        '
        Me.Column5.HeaderText = "Column5"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 73
        '
        'Column6
        '
        Me.Column6.HeaderText = "Column6"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 73
        '
        'Column7
        '
        Me.Column7.HeaderText = "Column7"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 73
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.Controls.Add(Me.DataGridMahasiswa)
        Me.GroupBox3.Location = New System.Drawing.Point(377, 54)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(574, 396)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        '
        'FrmDataGridMhs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(958, 478)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmDataGridMhs"
        Me.Text = "FrmDataGridMhs"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents CmbStatusMahasiswa As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CmbJurusan As ComboBox
    Friend WithEvents TxtNik As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents CmbJenisKelamin As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbAgama As ComboBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridMahasiswa As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
