<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Friend NotInheritable Class Picker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Picker))
        Me.LbImagenes = New System.Windows.Forms.ListBox()
        Me.PBColor = New System.Windows.Forms.PictureBox()
        Me.PBImagen = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PBColor,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PBImagen,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'LbImagenes
        '
        Me.LbImagenes.FormattingEnabled = true
        Me.LbImagenes.Location = New System.Drawing.Point(272, 7)
        Me.LbImagenes.Name = "LbImagenes"
        Me.LbImagenes.Size = New System.Drawing.Size(47, 290)
        Me.LbImagenes.TabIndex = 2
        '
        'PBColor
        '
        Me.PBColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBColor.Location = New System.Drawing.Point(10, 274)
        Me.PBColor.Name = "PBColor"
        Me.PBColor.Size = New System.Drawing.Size(256, 26)
        Me.PBColor.TabIndex = 1
        Me.PBColor.TabStop = false
        '
        'PBImagen
        '
        Me.PBImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBImagen.InitialImage = Nothing
        Me.PBImagen.Location = New System.Drawing.Point(12, 12)
        Me.PBImagen.MaximumSize = New System.Drawing.Size(512, 512)
        Me.PBImagen.Name = "PBImagen"
        Me.PBImagen.Size = New System.Drawing.Size(254, 256)
        Me.PBImagen.TabIndex = 0
        Me.PBImagen.TabStop = false
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = true
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 0)
        Me.Panel1.TabIndex = 3
        '
        'Picker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(329, 309)
        Me.Controls.Add(Me.PBImagen)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LbImagenes)
        Me.Controls.Add(Me.PBColor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Picker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Picker"
        CType(Me.PBColor,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PBImagen,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PBImagen As PictureBox
    Friend WithEvents PBColor As PictureBox
    Friend WithEvents LbImagenes As ListBox
    Friend WithEvents Panel1 As Panel
End Class
