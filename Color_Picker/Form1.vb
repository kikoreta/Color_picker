'Simple Color Select Tool for getting RGB Values By Kikoreta_sop

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorDialog1.ShowDialog()
        TextBox1.Text = ColorDialog1.Color.R
        TextBox2.Text = ColorDialog1.Color.G
        TextBox3.Text = ColorDialog1.Color.B
        Panel2.BackColor = ColorDialog1.Color
    End Sub
End Class
