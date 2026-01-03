<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLapDataMahasiswa
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CmbTahunAngkatan = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCetakLaporan = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CbNamaJurusan = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CrLapJurusan = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(776, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LAPORAN " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DATA MAHASISWA PER PRODI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CmbTahunAngkatan)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.BtnCetakLaporan)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.CbNamaJurusan)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 51)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 58)
        Me.Panel1.TabIndex = 1
        '
        'CmbTahunAngkatan
        '
        Me.CmbTahunAngkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTahunAngkatan.FormattingEnabled = True
        Me.CmbTahunAngkatan.Location = New System.Drawing.Point(440, 20)
        Me.CmbTahunAngkatan.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbTahunAngkatan.Name = "CmbTahunAngkatan"
        Me.CmbTahunAngkatan.Size = New System.Drawing.Size(92, 21)
        Me.CmbTahunAngkatan.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(350, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tahun Angkatan"
        '
        'BtnCetakLaporan
        '
        Me.BtnCetakLaporan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCetakLaporan.AutoSize = True
        Me.BtnCetakLaporan.Location = New System.Drawing.Point(612, 6)
        Me.BtnCetakLaporan.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCetakLaporan.Name = "BtnCetakLaporan"
        Me.BtnCetakLaporan.Size = New System.Drawing.Size(84, 44)
        Me.BtnCetakLaporan.TabIndex = 4
        Me.BtnCetakLaporan.Text = "CETAK" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LAPORAN"
        Me.BtnCetakLaporan.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.AutoSize = True
        Me.Button1.Location = New System.Drawing.Point(700, 6)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 44)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "KELUAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CbNamaJurusan
        '
        Me.CbNamaJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbNamaJurusan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CbNamaJurusan.FormattingEnabled = True
        Me.CbNamaJurusan.Location = New System.Drawing.Point(83, 20)
        Me.CbNamaJurusan.Margin = New System.Windows.Forms.Padding(2)
        Me.CbNamaJurusan.Name = "CbNamaJurusan"
        Me.CbNamaJurusan.Size = New System.Drawing.Size(264, 21)
        Me.CbNamaJurusan.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Prodi"
        '
        'CrLapJurusan
        '
        Me.CrLapJurusan.ActiveViewIndex = -1
        Me.CrLapJurusan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrLapJurusan.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrLapJurusan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrLapJurusan.Location = New System.Drawing.Point(0, 109)
        Me.CrLapJurusan.Margin = New System.Windows.Forms.Padding(2)
        Me.CrLapJurusan.Name = "CrLapJurusan"
        Me.CrLapJurusan.Size = New System.Drawing.Size(776, 400)
        Me.CrLapJurusan.TabIndex = 2
        Me.CrLapJurusan.ToolPanelWidth = 150
        '
        'FrmLapDataMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 509)
        Me.Controls.Add(Me.CrLapJurusan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmLapDataMahasiswa"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CbNamaJurusan As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCetakLaporan As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CrLapJurusan As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CmbTahunAngkatan As ComboBox
    Friend WithEvents Label3 As Label
End Class
