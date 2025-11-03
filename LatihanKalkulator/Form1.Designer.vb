<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKalkulator
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtAngka1 = New System.Windows.Forms.TextBox()
        Me.TxtAngka2 = New System.Windows.Forms.TextBox()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.BtnJumlah = New System.Windows.Forms.Button()
        Me.BtnKurang = New System.Windows.Forms.Button()
        Me.BtnBagi = New System.Windows.Forms.Button()
        Me.BtnKali = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Angka Pertama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Angka Kedua"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasil"
        '
        'TxtAngka1
        '
        Me.TxtAngka1.Location = New System.Drawing.Point(109, 38)
        Me.TxtAngka1.Name = "TxtAngka1"
        Me.TxtAngka1.Size = New System.Drawing.Size(197, 20)
        Me.TxtAngka1.TabIndex = 3
        '
        'TxtAngka2
        '
        Me.TxtAngka2.Location = New System.Drawing.Point(109, 64)
        Me.TxtAngka2.Name = "TxtAngka2"
        Me.TxtAngka2.Size = New System.Drawing.Size(197, 20)
        Me.TxtAngka2.TabIndex = 4
        '
        'TxtHasil
        '
        Me.TxtHasil.Location = New System.Drawing.Point(109, 198)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(197, 20)
        Me.TxtHasil.TabIndex = 5
        '
        'BtnJumlah
        '
        Me.BtnJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJumlah.Location = New System.Drawing.Point(30, 122)
        Me.BtnJumlah.Name = "BtnJumlah"
        Me.BtnJumlah.Size = New System.Drawing.Size(67, 33)
        Me.BtnJumlah.TabIndex = 6
        Me.BtnJumlah.Text = "+"
        Me.BtnJumlah.UseVisualStyleBackColor = True
        '
        'BtnKurang
        '
        Me.BtnKurang.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKurang.Location = New System.Drawing.Point(97, 122)
        Me.BtnKurang.Name = "BtnKurang"
        Me.BtnKurang.Size = New System.Drawing.Size(67, 33)
        Me.BtnKurang.TabIndex = 7
        Me.BtnKurang.Text = "-"
        Me.BtnKurang.UseVisualStyleBackColor = True
        '
        'BtnBagi
        '
        Me.BtnBagi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBagi.Location = New System.Drawing.Point(164, 122)
        Me.BtnBagi.Name = "BtnBagi"
        Me.BtnBagi.Size = New System.Drawing.Size(67, 33)
        Me.BtnBagi.TabIndex = 8
        Me.BtnBagi.Text = "/"
        Me.BtnBagi.UseVisualStyleBackColor = True
        '
        'BtnKali
        '
        Me.BtnKali.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKali.Location = New System.Drawing.Point(231, 122)
        Me.BtnKali.Name = "BtnKali"
        Me.BtnKali.Size = New System.Drawing.Size(67, 33)
        Me.BtnKali.TabIndex = 9
        Me.BtnKali.Text = "*"
        Me.BtnKali.UseVisualStyleBackColor = True
        '
        'FrmKalkulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 256)
        Me.Controls.Add(Me.BtnKali)
        Me.Controls.Add(Me.BtnBagi)
        Me.Controls.Add(Me.BtnKurang)
        Me.Controls.Add(Me.BtnJumlah)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.TxtAngka2)
        Me.Controls.Add(Me.TxtAngka1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmKalkulator"
        Me.Text = "Kalkulator Sederhana"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtAngka1 As TextBox
    Friend WithEvents TxtAngka2 As TextBox
    Friend WithEvents TxtHasil As TextBox
    Friend WithEvents BtnJumlah As Button
    Friend WithEvents BtnKurang As Button
    Friend WithEvents BtnBagi As Button
    Friend WithEvents BtnKali As Button
End Class
