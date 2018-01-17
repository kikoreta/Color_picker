'Simple Color Select Tool for getting RGB Values By Kikoreta_sop

Public Class Color_Picker

    Public activeTextBox As TextBox

    Private Sub TextBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Enter, TextBox2.Enter, TextBox3.Enter
        activeTextBox = CType(sender, TextBox)
    End Sub

    Private Sub Textbox_Input(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress

        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter only numbers in range of ""0 - 255""")
            e.Handled = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        On Error Resume Next
        If activeTextBox.Text > 255 Then

            activeTextBox.Text = 0
            MessageBox.Show("Please enter only numbers in range of ""0 - 255""")

        End If
        On Error GoTo 0

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

    Private Sub TextBox_MouseDown() Handles TextBox1.MouseDown, TextBox2.MouseDown, TextBox3.MouseDown

        activeTextBox.SelectAll()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ListBox1.Items.Add(TextBox1.Text + "," + TextBox2.Text + "," + TextBox3.Text)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ListBox1.Items.Remove(ListBox1.SelectedItem)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim saveFile = New SaveFileDialog() With {.Filter = "Text File (*.Txt)|*.txt"}
        Dim i As Integer

        If (saveFile.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then

            Dim w = New IO.StreamWriter(saveFile.FileName)
            For i = 0 To ListBox1.Items.Count - 1
                w.WriteLine(ListBox1.Items.Item(i))
            Next
            w.Close()

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim openFile = New OpenFileDialog() With {.Filter = "Text File (*.Txt)|*.txt"}

        If (openFile.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then

            ListBox1.Items.Clear()
            ListBox1.Items.AddRange(IO.File.ReadAllLines(openFile.FileName))

        End If

    End Sub

End Class
