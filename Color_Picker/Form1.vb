'Simple Color Select Tool for getting RGB Values By Kikoreta_sop

Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If TextBox1.Text = "" Then
            TextBox1.Text = 0
            TextBox1.SelectAll()

        ElseIf TextBox2.Text = "" Then
            TextBox2.Text = 0
            TextBox2.SelectAll()

        ElseIf TextBox3.Text = "" Then
            TextBox3.Text = 0
            TextBox3.SelectAll()

        End If

        If TextBox1.Text > 255 Then
            TextBox1.Text = 0
            TextBox1.SelectAll()

        ElseIf TextBox2.Text > 255 Then
            TextBox2.Text = 0
            TextBox2.SelectAll()

        ElseIf TextBox3.Text > 255 Then
            TextBox3.Text = 0
            TextBox3.SelectAll()

        End If

        Panel2.BackColor = Color.FromArgb(TextBox1.Text, TextBox2.Text, TextBox3.Text)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ColorDialog1.ShowDialog()

        TextBox1.Text = ColorDialog1.Color.R
        TextBox2.Text = ColorDialog1.Color.G
        TextBox3.Text = ColorDialog1.Color.B

    End Sub

    Private Sub TextBox1_MouseDown() Handles TextBox1.MouseDown
        TextBox1.SelectAll()
    End Sub
    Private Sub TextBox2_MouseDown() Handles TextBox2.MouseDown
        TextBox2.SelectAll()
    End Sub
    Private Sub TextBox3_MouseDown() Handles TextBox3.MouseDown
        TextBox3.SelectAll()
    End Sub
End Class
