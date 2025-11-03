<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmKalkulator
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtangka1 = New System.Windows.Forms.TextBox()
        Me.Txtangka2 = New System.Windows.Forms.TextBox()
        Me.Txthasil = New System.Windows.Forms.TextBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnKurang = New System.Windows.Forms.Button()
        Me.BtnBagi = New System.Windows.Forms.Button()
        Me.BtnKali = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Angka Pertama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Angka Kedua"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasil"
        '
        'Txtangka1
        '
        Me.Txtangka1.Location = New System.Drawing.Point(117, 36)
        Me.Txtangka1.Name = "Txtangka1"
        Me.Txtangka1.Size = New System.Drawing.Size(210, 22)
        Me.Txtangka1.TabIndex = 3
        '
        'Txtangka2
        '
        Me.Txtangka2.Location = New System.Drawing.Point(117, 92)
        Me.Txtangka2.Name = "Txtangka2"
        Me.Txtangka2.Size = New System.Drawing.Size(210, 22)
        Me.Txtangka2.TabIndex = 4
        '
        'Txthasil
        '
        Me.Txthasil.Location = New System.Drawing.Point(98, 267)
        Me.Txthasil.Name = "Txthasil"
        Me.Txthasil.Size = New System.Drawing.Size(282, 22)
        Me.Txthasil.TabIndex = 5
        '
        'BtnTambah
        '
        Me.BtnTambah.AllowDrop = True
        Me.BtnTambah.Location = New System.Drawing.Point(9, 147)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambah.TabIndex = 6
        Me.BtnTambah.Text = "+"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnKurang
        '
        Me.BtnKurang.Location = New System.Drawing.Point(90, 147)
        Me.BtnKurang.Name = "BtnKurang"
        Me.BtnKurang.Size = New System.Drawing.Size(75, 23)
        Me.BtnKurang.TabIndex = 7
        Me.BtnKurang.Text = "-"
        Me.BtnKurang.UseVisualStyleBackColor = True
        '
        'BtnBagi
        '
        Me.BtnBagi.Location = New System.Drawing.Point(171, 147)
        Me.BtnBagi.Name = "BtnBagi"
        Me.BtnBagi.Size = New System.Drawing.Size(75, 23)
        Me.BtnBagi.TabIndex = 8
        Me.BtnBagi.Text = "/"
        Me.BtnBagi.UseVisualStyleBackColor = True
        '
        'BtnKali
        '
        Me.BtnKali.Location = New System.Drawing.Point(252, 147)
        Me.BtnKali.Name = "BtnKali"
        Me.BtnKali.Size = New System.Drawing.Size(75, 23)
        Me.BtnKali.TabIndex = 9
        Me.BtnKali.Text = "*"
        Me.BtnKali.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.BtnKurang)
        Me.GroupBox1.Controls.Add(Me.BtnKali)
        Me.GroupBox1.Controls.Add(Me.BtnTambah)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnBagi)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txtangka1)
        Me.GroupBox1.Controls.Add(Me.Txtangka2)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 191)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Angka"
        '
        'FrmKalkulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 347)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Txthasil)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmKalkulator"
        Me.Text = "Kalkulator Sederhana"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtangka1 As TextBox
    Friend WithEvents Txtangka2 As TextBox
    Friend WithEvents Txthasil As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnKurang As Button
    Friend WithEvents BtnBagi As Button
    Friend WithEvents BtnKali As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
