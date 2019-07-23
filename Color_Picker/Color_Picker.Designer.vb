<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Friend NotInheritable Class Color_Picker
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Color_Picker))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbHex = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbG = New System.Windows.Forms.TextBox()
        Me.TbB = New System.Windows.Forms.TextBox()
        Me.PnlColor = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LbColores = New System.Windows.Forms.ListBox()
        Me.TbR = New System.Windows.Forms.TextBox()
        Me.TBarR = New System.Windows.Forms.TrackBar()
        Me.BtnRMas = New System.Windows.Forms.Button()
        Me.BtnRMen = New System.Windows.Forms.Button()
        Me.TBarG = New System.Windows.Forms.TrackBar()
        Me.TBarB = New System.Windows.Forms.TrackBar()
        Me.BtnGMas = New System.Windows.Forms.Button()
        Me.BtnBMas = New System.Windows.Forms.Button()
        Me.BtnGMen = New System.Windows.Forms.Button()
        Me.BtnBMen = New System.Windows.Forms.Button()
        Me.PnlR = New System.Windows.Forms.Panel()
        Me.PnlG = New System.Windows.Forms.Panel()
        Me.PnlB = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBarA = New System.Windows.Forms.TrackBar()
        Me.TbA = New System.Windows.Forms.TextBox()
        Me.BtnAMas = New System.Windows.Forms.Button()
        Me.BtnAMen = New System.Windows.Forms.Button()
        Me.PnlA = New System.Windows.Forms.Panel()
        Me.PnlGridFondo = New System.Windows.Forms.Panel()
        Me.TbHexNoTrans = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout
        CType(Me.TBarR,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TBarG,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TBarB,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TBarA,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PnlGridFondo.SuspendLayout
        Me.SuspendLayout
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(382, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.TabStop = false
        Me.Button1.Text = "Picker"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TbHex)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 328)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 42)
        Me.Panel1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(3, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "#"
        '
        'TbHex
        '
        Me.TbHex.Location = New System.Drawing.Point(23, 10)
        Me.TbHex.MaxLength = 8
        Me.TbHex.Name = "TbHex"
        Me.TbHex.Size = New System.Drawing.Size(100, 20)
        Me.TbHex.TabIndex = 9
        Me.TbHex.TabStop = false
        Me.TbHex.Text = "FF000000"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(319, 7)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(57, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.TabStop = false
        Me.Button5.Text = "Load"
        Me.Button5.UseVisualStyleBackColor = true
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(255, 7)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(57, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.TabStop = false
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = true
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(192, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(57, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.TabStop = false
        Me.Button3.Text = "Remove"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(129, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.TabStop = false
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(14, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "R"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(14, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "G"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(15, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "B"
        '
        'TbG
        '
        Me.TbG.Location = New System.Drawing.Point(150, 91)
        Me.TbG.MaxLength = 3
        Me.TbG.Name = "TbG"
        Me.TbG.Size = New System.Drawing.Size(27, 20)
        Me.TbG.TabIndex = 2
        Me.TbG.Text = "0"
        '
        'TbB
        '
        Me.TbB.Location = New System.Drawing.Point(150, 161)
        Me.TbB.MaxLength = 3
        Me.TbB.Name = "TbB"
        Me.TbB.Size = New System.Drawing.Size(27, 20)
        Me.TbB.TabIndex = 3
        Me.TbB.Text = "0"
        '
        'PnlColor
        '
        Me.PnlColor.BackColor = System.Drawing.SystemColors.Control
        Me.PnlColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PnlColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PnlColor.Location = New System.Drawing.Point(0, -2)
        Me.PnlColor.Name = "PnlColor"
        Me.PnlColor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PnlColor.Size = New System.Drawing.Size(120, 280)
        Me.PnlColor.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Enabled = true
        '
        'LbColores
        '
        Me.LbColores.FormattingEnabled = true
        Me.LbColores.Location = New System.Drawing.Point(325, 12)
        Me.LbColores.Name = "LbColores"
        Me.LbColores.Size = New System.Drawing.Size(114, 277)
        Me.LbColores.TabIndex = 7
        Me.LbColores.TabStop = false
        '
        'TbR
        '
        Me.TbR.Location = New System.Drawing.Point(150, 20)
        Me.TbR.MaxLength = 3
        Me.TbR.Name = "TbR"
        Me.TbR.Size = New System.Drawing.Size(27, 20)
        Me.TbR.TabIndex = 1
        Me.TbR.Text = "0"
        '
        'TBarR
        '
        Me.TBarR.LargeChange = 10
        Me.TBarR.Location = New System.Drawing.Point(33, 20)
        Me.TBarR.Maximum = 255
        Me.TBarR.Name = "TBarR"
        Me.TBarR.Size = New System.Drawing.Size(111, 45)
        Me.TBarR.TabIndex = 5
        '
        'BtnRMas
        '
        Me.BtnRMas.AutoSize = true
        Me.BtnRMas.Location = New System.Drawing.Point(150, 43)
        Me.BtnRMas.Name = "BtnRMas"
        Me.BtnRMas.Size = New System.Drawing.Size(23, 26)
        Me.BtnRMas.TabIndex = 10
        Me.BtnRMas.TabStop = false
        Me.BtnRMas.Text = "+"
        Me.BtnRMas.UseVisualStyleBackColor = true
        '
        'BtnRMen
        '
        Me.BtnRMen.AutoSize = true
        Me.BtnRMen.Location = New System.Drawing.Point(15, 43)
        Me.BtnRMen.Name = "BtnRMen"
        Me.BtnRMen.Size = New System.Drawing.Size(23, 26)
        Me.BtnRMen.TabIndex = 11
        Me.BtnRMen.TabStop = false
        Me.BtnRMen.Text = "-"
        Me.BtnRMen.UseVisualStyleBackColor = true
        '
        'TBarG
        '
        Me.TBarG.LargeChange = 10
        Me.TBarG.Location = New System.Drawing.Point(35, 91)
        Me.TBarG.Maximum = 255
        Me.TBarG.Name = "TBarG"
        Me.TBarG.Size = New System.Drawing.Size(111, 45)
        Me.TBarG.TabIndex = 6
        '
        'TBarB
        '
        Me.TBarB.LargeChange = 10
        Me.TBarB.Location = New System.Drawing.Point(33, 161)
        Me.TBarB.Maximum = 255
        Me.TBarB.Name = "TBarB"
        Me.TBarB.Size = New System.Drawing.Size(111, 45)
        Me.TBarB.TabIndex = 7
        '
        'BtnGMas
        '
        Me.BtnGMas.AutoSize = true
        Me.BtnGMas.Location = New System.Drawing.Point(150, 119)
        Me.BtnGMas.Name = "BtnGMas"
        Me.BtnGMas.Size = New System.Drawing.Size(23, 26)
        Me.BtnGMas.TabIndex = 14
        Me.BtnGMas.TabStop = false
        Me.BtnGMas.Text = "+"
        Me.BtnGMas.UseVisualStyleBackColor = true
        '
        'BtnBMas
        '
        Me.BtnBMas.AutoSize = true
        Me.BtnBMas.Location = New System.Drawing.Point(150, 187)
        Me.BtnBMas.Name = "BtnBMas"
        Me.BtnBMas.Size = New System.Drawing.Size(23, 26)
        Me.BtnBMas.TabIndex = 15
        Me.BtnBMas.TabStop = false
        Me.BtnBMas.Text = "+"
        Me.BtnBMas.UseVisualStyleBackColor = true
        '
        'BtnGMen
        '
        Me.BtnGMen.AutoSize = true
        Me.BtnGMen.Location = New System.Drawing.Point(15, 119)
        Me.BtnGMen.Name = "BtnGMen"
        Me.BtnGMen.Size = New System.Drawing.Size(23, 26)
        Me.BtnGMen.TabIndex = 16
        Me.BtnGMen.TabStop = false
        Me.BtnGMen.Text = "-"
        Me.BtnGMen.UseVisualStyleBackColor = true
        '
        'BtnBMen
        '
        Me.BtnBMen.AutoSize = true
        Me.BtnBMen.Location = New System.Drawing.Point(15, 187)
        Me.BtnBMen.Name = "BtnBMen"
        Me.BtnBMen.Size = New System.Drawing.Size(23, 26)
        Me.BtnBMen.TabIndex = 17
        Me.BtnBMen.TabStop = false
        Me.BtnBMen.Text = "-"
        Me.BtnBMen.UseVisualStyleBackColor = true
        '
        'PnlR
        '
        Me.PnlR.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PnlR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlR.Location = New System.Drawing.Point(44, 55)
        Me.PnlR.Name = "PnlR"
        Me.PnlR.Size = New System.Drawing.Size(100, 14)
        Me.PnlR.TabIndex = 18
        '
        'PnlG
        '
        Me.PnlG.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PnlG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlG.Location = New System.Drawing.Point(44, 131)
        Me.PnlG.Name = "PnlG"
        Me.PnlG.Size = New System.Drawing.Size(100, 14)
        Me.PnlG.TabIndex = 19
        '
        'PnlB
        '
        Me.PnlB.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PnlB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlB.Location = New System.Drawing.Point(44, 199)
        Me.PnlB.Name = "PnlB"
        Me.PnlB.Size = New System.Drawing.Size(100, 14)
        Me.PnlB.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(15, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "A"
        '
        'TBarA
        '
        Me.TBarA.LargeChange = 10
        Me.TBarA.Location = New System.Drawing.Point(35, 228)
        Me.TBarA.Maximum = 255
        Me.TBarA.Name = "TBarA"
        Me.TBarA.Size = New System.Drawing.Size(111, 45)
        Me.TBarA.TabIndex = 8
        '
        'TbA
        '
        Me.TbA.Location = New System.Drawing.Point(150, 228)
        Me.TbA.MaxLength = 3
        Me.TbA.Name = "TbA"
        Me.TbA.Size = New System.Drawing.Size(27, 20)
        Me.TbA.TabIndex = 4
        Me.TbA.Text = "255"
        '
        'BtnAMas
        '
        Me.BtnAMas.AutoSize = true
        Me.BtnAMas.Location = New System.Drawing.Point(150, 257)
        Me.BtnAMas.Name = "BtnAMas"
        Me.BtnAMas.Size = New System.Drawing.Size(23, 26)
        Me.BtnAMas.TabIndex = 23
        Me.BtnAMas.TabStop = false
        Me.BtnAMas.Text = "+"
        Me.BtnAMas.UseVisualStyleBackColor = true
        '
        'BtnAMen
        '
        Me.BtnAMen.AutoSize = true
        Me.BtnAMen.Location = New System.Drawing.Point(15, 257)
        Me.BtnAMen.Name = "BtnAMen"
        Me.BtnAMen.Size = New System.Drawing.Size(23, 26)
        Me.BtnAMen.TabIndex = 24
        Me.BtnAMen.TabStop = false
        Me.BtnAMen.Text = "-"
        Me.BtnAMen.UseVisualStyleBackColor = true
        '
        'PnlA
        '
        Me.PnlA.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PnlA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlA.Location = New System.Drawing.Point(44, 269)
        Me.PnlA.Name = "PnlA"
        Me.PnlA.Size = New System.Drawing.Size(100, 14)
        Me.PnlA.TabIndex = 20
        '
        'PnlGridFondo
        '
        Me.PnlGridFondo.BackColor = System.Drawing.SystemColors.Control
        Me.PnlGridFondo.BackgroundImage = Global.Color_Picker.My.Resources.Resources.checkerboard_pattern_0
        Me.PnlGridFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlGridFondo.Controls.Add(Me.PnlColor)
        Me.PnlGridFondo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PnlGridFondo.Location = New System.Drawing.Point(183, 12)
        Me.PnlGridFondo.Name = "PnlGridFondo"
        Me.PnlGridFondo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PnlGridFondo.Size = New System.Drawing.Size(120, 280)
        Me.PnlGridFondo.TabIndex = 25
        '
        'TbHexNoTrans
        '
        Me.TbHexNoTrans.Location = New System.Drawing.Point(23, 302)
        Me.TbHexNoTrans.Name = "TbHexNoTrans"
        Me.TbHexNoTrans.ReadOnly = true
        Me.TbHexNoTrans.Size = New System.Drawing.Size(100, 20)
        Me.TbHexNoTrans.TabIndex = 26
        '
        'Color_Picker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(456, 370)
        Me.Controls.Add(Me.TbHexNoTrans)
        Me.Controls.Add(Me.PnlGridFondo)
        Me.Controls.Add(Me.PnlA)
        Me.Controls.Add(Me.BtnAMen)
        Me.Controls.Add(Me.BtnAMas)
        Me.Controls.Add(Me.TbA)
        Me.Controls.Add(Me.TBarA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PnlB)
        Me.Controls.Add(Me.PnlG)
        Me.Controls.Add(Me.PnlR)
        Me.Controls.Add(Me.BtnBMen)
        Me.Controls.Add(Me.BtnGMen)
        Me.Controls.Add(Me.BtnBMas)
        Me.Controls.Add(Me.BtnGMas)
        Me.Controls.Add(Me.TBarB)
        Me.Controls.Add(Me.TBarG)
        Me.Controls.Add(Me.BtnRMen)
        Me.Controls.Add(Me.BtnRMas)
        Me.Controls.Add(Me.TBarR)
        Me.Controls.Add(Me.TbR)
        Me.Controls.Add(Me.LbColores)
        Me.Controls.Add(Me.TbB)
        Me.Controls.Add(Me.TbG)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Color_Picker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Picker"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.TBarR,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TBarG,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TBarB,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TBarA,System.ComponentModel.ISupportInitialize).EndInit
        Me.PnlGridFondo.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TbG As TextBox
    Friend WithEvents TbB As TextBox
    Friend WithEvents PnlColor As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents LbColores As ListBox
    Friend WithEvents TbR As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TBarR As TrackBar
    Friend WithEvents BtnRMas As Button
    Friend WithEvents BtnBMas As Button
    Friend WithEvents BtnGMas As Button
    Friend WithEvents TBarB As TrackBar
    Friend WithEvents TBarG As TrackBar
    Friend WithEvents BtnRMen As Button
    Friend WithEvents BtnBMen As Button
    Friend WithEvents BtnGMen As Button
    Friend WithEvents PnlB As Panel
    Friend WithEvents PnlG As Panel
    Friend WithEvents PnlR As Panel
    Friend WithEvents TbHex As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PnlA As Panel
    Friend WithEvents BtnAMen As Button
    Friend WithEvents BtnAMas As Button
    Friend WithEvents TbA As TextBox
    Friend WithEvents TBarA As TrackBar
    Friend WithEvents Label4 As Label
    Friend WithEvents PnlGridFondo As Panel
    Friend WithEvents TbHexNoTrans As TextBox
End Class
