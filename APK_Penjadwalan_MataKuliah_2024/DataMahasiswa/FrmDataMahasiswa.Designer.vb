<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDataMahasiswa
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbTahunAngkatan = New System.Windows.Forms.ComboBox()
        Me.LblKdProdi = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCariData = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnTambahData = New System.Windows.Forms.Button()
        Me.TxtCariNama = New System.Windows.Forms.TextBox()
        Me.CbNamaJurusan = New System.Windows.Forms.ComboBox()
        Me.CariNama = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridMahasiswa = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1159, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA MAHASISWA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CmbTahunAngkatan)
        Me.Panel1.Controls.Add(Me.LblKdProdi)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.TxtCariNama)
        Me.Panel1.Controls.Add(Me.CbNamaJurusan)
        Me.Panel1.Controls.Add(Me.CariNama)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1159, 119)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(421, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "TAHUN ANGKATAN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbTahunAngkatan
        '
        Me.CmbTahunAngkatan.FormattingEnabled = True
        Me.CmbTahunAngkatan.Location = New System.Drawing.Point(421, 28)
        Me.CmbTahunAngkatan.Name = "CmbTahunAngkatan"
        Me.CmbTahunAngkatan.Size = New System.Drawing.Size(161, 24)
        Me.CmbTahunAngkatan.TabIndex = 11
        '
        'LblKdProdi
        '
        Me.LblKdProdi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblKdProdi.Location = New System.Drawing.Point(374, 27)
        Me.LblKdProdi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblKdProdi.Name = "LblKdProdi"
        Me.LblKdProdi.Size = New System.Drawing.Size(42, 24)
        Me.LblKdProdi.TabIndex = 10
        Me.LblKdProdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnCariData)
        Me.GroupBox1.Controls.Add(Me.BtnKeluar)
        Me.GroupBox1.Controls.Add(Me.BtnTambahData)
        Me.GroupBox1.Location = New System.Drawing.Point(758, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(376, 112)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'BtnCariData
        '
        Me.BtnCariData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.BtnCariData.AutoSize = True
        Me.BtnCariData.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCariData.Location = New System.Drawing.Point(19, 36)
        Me.BtnCariData.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCariData.Name = "BtnCariData"
        Me.BtnCariData.Size = New System.Drawing.Size(98, 49)
        Me.BtnCariData.TabIndex = 8
        Me.BtnCariData.Text = "CARI DATA"
        Me.BtnCariData.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnKeluar.AutoSize = True
        Me.BtnKeluar.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.BtnKeluar.Location = New System.Drawing.Point(287, 36)
        Me.BtnKeluar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(73, 49)
        Me.BtnKeluar.TabIndex = 7
        Me.BtnKeluar.Text = "KELUAR"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnTambahData
        '
        Me.BtnTambahData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTambahData.AutoSize = True
        Me.BtnTambahData.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambahData.Location = New System.Drawing.Point(152, 36)
        Me.BtnTambahData.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTambahData.Name = "BtnTambahData"
        Me.BtnTambahData.Size = New System.Drawing.Size(112, 49)
        Me.BtnTambahData.TabIndex = 6
        Me.BtnTambahData.Text = "TAMBAH DATA"
        Me.BtnTambahData.UseVisualStyleBackColor = True
        '
        'TxtCariNama
        '
        Me.TxtCariNama.Location = New System.Drawing.Point(12, 75)
        Me.TxtCariNama.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCariNama.Name = "TxtCariNama"
        Me.TxtCariNama.Size = New System.Drawing.Size(359, 23)
        Me.TxtCariNama.TabIndex = 5
        '
        'CbNamaJurusan
        '
        Me.CbNamaJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbNamaJurusan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbNamaJurusan.FormattingEnabled = True
        Me.CbNamaJurusan.Location = New System.Drawing.Point(11, 27)
        Me.CbNamaJurusan.Margin = New System.Windows.Forms.Padding(2)
        Me.CbNamaJurusan.Name = "CbNamaJurusan"
        Me.CbNamaJurusan.Size = New System.Drawing.Size(360, 24)
        Me.CbNamaJurusan.TabIndex = 4
        '
        'CariNama
        '
        Me.CariNama.AutoSize = True
        Me.CariNama.Location = New System.Drawing.Point(10, 58)
        Me.CariNama.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CariNama.Name = "CariNama"
        Me.CariNama.Size = New System.Drawing.Size(82, 16)
        Me.CariNama.TabIndex = 3
        Me.CariNama.Text = "CARI NAMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NAMA PRODI"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 507)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1159, 20)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridMahasiswa)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 160)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1159, 347)
        Me.Panel3.TabIndex = 9
        '
        'DataGridMahasiswa
        '
        Me.DataGridMahasiswa.AllowUserToDeleteRows = False
        Me.DataGridMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMahasiswa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridMahasiswa.Location = New System.Drawing.Point(0, 0)
        Me.DataGridMahasiswa.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridMahasiswa.Name = "DataGridMahasiswa"
        Me.DataGridMahasiswa.ReadOnly = True
        Me.DataGridMahasiswa.RowHeadersWidth = 51
        Me.DataGridMahasiswa.RowTemplate.Height = 24
        Me.DataGridMahasiswa.Size = New System.Drawing.Size(1159, 347)
        Me.DataGridMahasiswa.TabIndex = 10
        '
        'FrmDataMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 527)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmDataMahasiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDataMahasiswa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BtnTambahData As Button
    Friend WithEvents TxtCariNama As TextBox
    Friend WithEvents CbNamaJurusan As ComboBox
    Friend WithEvents CariNama As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridMahasiswa As DataGridView
    Friend WithEvents BtnCariData As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblKdProdi As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbTahunAngkatan As ComboBox
End Class
