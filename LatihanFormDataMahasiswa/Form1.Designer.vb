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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbProdi = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridMahasiswa = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnKeluar)
        Me.Panel1.Controls.Add(Me.BtnTambah)
        Me.Panel1.Controls.Add(Me.TxtCari)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CmbProdi)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 45)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(920, 57)
        Me.Panel1.TabIndex = 4
        '
        'BtnKeluar
        '
        Me.BtnKeluar.AutoSize = True
        Me.BtnKeluar.Location = New System.Drawing.Point(805, 18)
        Me.BtnKeluar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(59, 24)
        Me.BtnKeluar.TabIndex = 5
        Me.BtnKeluar.Text = "KELUAR"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.AutoSize = True
        Me.BtnTambah.Location = New System.Drawing.Point(695, 18)
        Me.BtnTambah.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(94, 24)
        Me.BtnTambah.TabIndex = 4
        Me.BtnTambah.Text = "TAMBAH DATA"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TxtCari
        '
        Me.TxtCari.Location = New System.Drawing.Point(398, 18)
        Me.TxtCari.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(233, 19)
        Me.TxtCari.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(329, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CARI NAMA"
        '
        'CmbProdi
        '
        Me.CmbProdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProdi.FormattingEnabled = True
        Me.CmbProdi.Location = New System.Drawing.Point(90, 17)
        Me.CmbProdi.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbProdi.Name = "CmbProdi"
        Me.CmbProdi.Size = New System.Drawing.Size(181, 20)
        Me.CmbProdi.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 14)
        Me.Label2.TabIndex = 0
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
        Me.Label1.Size = New System.Drawing.Size(920, 45)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = ":: DATA MAHASISWA ::"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 457)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(920, 14)
        Me.Panel2.TabIndex = 5
        '
        'DataGridMahasiswa
        '
        Me.DataGridMahasiswa.AllowUserToAddRows = False
        Me.DataGridMahasiswa.AllowUserToDeleteRows = False
        Me.DataGridMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMahasiswa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridMahasiswa.Location = New System.Drawing.Point(0, 102)
        Me.DataGridMahasiswa.Name = "DataGridMahasiswa"
        Me.DataGridMahasiswa.ReadOnly = True
        Me.DataGridMahasiswa.Size = New System.Drawing.Size(920, 355)
        Me.DataGridMahasiswa.TabIndex = 6
        '
        'FrmDataMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 471)
        Me.Controls.Add(Me.DataGridMahasiswa)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmDataMahasiswa"
        Me.Text = "DATA MAHASISWA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbProdi As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridMahasiswa As DataGridView
End Class
