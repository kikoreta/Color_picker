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

        ElseIf TextBox2.Text > 255 Or TextBox2.Text = "" Then

            TextBox2.Text = 0
            TextBox2.SelectAll()

        ElseIf TextBox3.Text > 255 Or TextBox3.Text = "" Then

            TextBox3.Text = 0
            TextBox3.SelectAll()

        End If

        Panel2.BackColor = Color.FromArgb(TextBox1.Text, TextBox2.Text, TextBox3.Text)


        If ListBox1.SelectedIndex >= 0 And ListBox1.Focused = True Then

            Dim fields As String() = ListBox1.SelectedItem.Split(",")
            Dim Cr = fields(0)
            Dim Cg = fields(1)
            Dim Cb = fields(2)
            Panel2.BackColor = Color.FromArgb(Cr, Cg, Cb)
            TextBox1.Text = Cr
            TextBox2.Text = Cg
            TextBox3.Text = Cb

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Picker.Visible = True Then
            Picker.Visible = False

        Else

            Picker.Visible = True

        End If


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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ListBox1.Items.Add(TextBox1.Text + "," + TextBox2.Text + "," + TextBox3.Text)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ListBox1.Items.Remove(ListBox1.SelectedItem)

    End Sub

End Class
