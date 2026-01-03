<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataMhsPagination
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDataMhsPagination))
        Me.DataGridMahasiswa = New System.Windows.Forms.DataGridView()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LbJumlahBaris = New System.Windows.Forms.Label()
        Me.LbHasilBagiHalaman = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LbTotalBaris = New System.Windows.Forms.Label()
        Me.BindingNapPaging = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ComboBoxEntries = New System.Windows.Forms.ToolStripComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.DataGridMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNapPaging, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNapPaging.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridMahasiswa
        '
        Me.DataGridMahasiswa.AllowUserToDeleteRows = False
        Me.DataGridMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMahasiswa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridMahasiswa.Location = New System.Drawing.Point(0, 44)
        Me.DataGridMahasiswa.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridMahasiswa.Name = "DataGridMahasiswa"
        Me.DataGridMahasiswa.ReadOnly = True
        Me.DataGridMahasiswa.RowHeadersWidth = 51
        Me.DataGridMahasiswa.RowTemplate.Height = 24
        Me.DataGridMahasiswa.Size = New System.Drawing.Size(1354, 390)
        Me.DataGridMahasiswa.TabIndex = 10
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
        Me.Panel1.Size = New System.Drawing.Size(1354, 117)
        Me.Panel1.TabIndex = 11
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
        Me.CmbTahunAngkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTahunAngkatan.FormattingEnabled = True
        Me.CmbTahunAngkatan.Location = New System.Drawing.Point(421, 28)
        Me.CmbTahunAngkatan.Name = "CmbTahunAngkatan"
        Me.CmbTahunAngkatan.Size = New System.Drawing.Size(216, 24)
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
        Me.GroupBox1.Location = New System.Drawing.Point(967, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(376, 110)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'BtnCariData
        '
        Me.BtnCariData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCariData.AutoSize = True
        Me.BtnCariData.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCariData.Location = New System.Drawing.Point(18, 25)
        Me.BtnCariData.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCariData.Name = "BtnCariData"
        Me.BtnCariData.Size = New System.Drawing.Size(104, 65)
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
        Me.BtnKeluar.Location = New System.Drawing.Point(289, 25)
        Me.BtnKeluar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(83, 65)
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
        Me.BtnTambahData.Location = New System.Drawing.Point(145, 25)
        Me.BtnTambahData.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTambahData.Name = "BtnTambahData"
        Me.BtnTambahData.Size = New System.Drawing.Size(130, 65)
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1354, 41)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "DATA MAHASISWA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LbJumlahBaris)
        Me.Panel2.Controls.Add(Me.LbHasilBagiHalaman)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.LbTotalBaris)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 592)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1354, 73)
        Me.Panel2.TabIndex = 12
        '
        'LbJumlahBaris
        '
        Me.LbJumlahBaris.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbJumlahBaris.AutoSize = True
        Me.LbJumlahBaris.BackColor = System.Drawing.Color.White
        Me.LbJumlahBaris.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LbJumlahBaris.Location = New System.Drawing.Point(1199, 37)
        Me.LbJumlahBaris.Name = "LbJumlahBaris"
        Me.LbJumlahBaris.Size = New System.Drawing.Size(96, 16)
        Me.LbJumlahBaris.TabIndex = 3
        Me.LbJumlahBaris.Text = "Jumlah Baris :"
        '
        'LbHasilBagiHalaman
        '
        Me.LbHasilBagiHalaman.BackColor = System.Drawing.Color.White
        Me.LbHasilBagiHalaman.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LbHasilBagiHalaman.Location = New System.Drawing.Point(107, 49)
        Me.LbHasilBagiHalaman.Name = "LbHasilBagiHalaman"
        Me.LbHasilBagiHalaman.Size = New System.Drawing.Size(114, 16)
        Me.LbHasilBagiHalaman.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(17, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Jumlah Hal :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbTotalBaris
        '
        Me.LbTotalBaris.AutoSize = True
        Me.LbTotalBaris.BackColor = System.Drawing.Color.White
        Me.LbTotalBaris.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LbTotalBaris.Location = New System.Drawing.Point(17, 22)
        Me.LbTotalBaris.Name = "LbTotalBaris"
        Me.LbTotalBaris.Size = New System.Drawing.Size(82, 16)
        Me.LbTotalBaris.TabIndex = 0
        Me.LbTotalBaris.Text = "Total Baris :"
        Me.LbTotalBaris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BindingNapPaging
        '
        Me.BindingNapPaging.AddNewItem = Nothing
        Me.BindingNapPaging.AutoSize = False
        Me.BindingNapPaging.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNapPaging.DeleteItem = Nothing
        Me.BindingNapPaging.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNapPaging.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripLabel1, Me.ComboBoxEntries})
        Me.BindingNapPaging.Location = New System.Drawing.Point(0, 0)
        Me.BindingNapPaging.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNapPaging.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNapPaging.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNapPaging.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNapPaging.Name = "BindingNapPaging"
        Me.BindingNapPaging.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNapPaging.Size = New System.Drawing.Size(1354, 44)
        Me.BindingNapPaging.TabIndex = 13
        Me.BindingNapPaging.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 41)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 41)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 41)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 44)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 44)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 41)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 41)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 44)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(76, 41)
        Me.ToolStripLabel1.Text = "Tampil Data :"
        '
        'ComboBoxEntries
        '
        Me.ComboBoxEntries.AutoSize = False
        Me.ComboBoxEntries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEntries.Items.AddRange(New Object() {""})
        Me.ComboBoxEntries.Name = "ComboBoxEntries"
        Me.ComboBoxEntries.Size = New System.Drawing.Size(50, 23)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridMahasiswa)
        Me.Panel3.Controls.Add(Me.BindingNapPaging)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 158)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1354, 434)
        Me.Panel3.TabIndex = 14
        '
        'FrmDataMhsPagination
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 665)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmDataMhsPagination"
        Me.Text = "FrmDataMhsPagination"
        CType(Me.DataGridMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNapPaging, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNapPaging.ResumeLayout(False)
        Me.BindingNapPaging.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridMahasiswa As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbTahunAngkatan As ComboBox
    Friend WithEvents LblKdProdi As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnCariData As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BtnTambahData As Button
    Friend WithEvents TxtCariNama As TextBox
    Friend WithEvents CbNamaJurusan As ComboBox
    Friend WithEvents CariNama As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BindingNapPaging As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LbJumlahBaris As Label
    Friend WithEvents LbHasilBagiHalaman As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LbTotalBaris As Label
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ComboBoxEntries As ToolStripComboBox
    Friend WithEvents Panel3 As Panel
End Class
