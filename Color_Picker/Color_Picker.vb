'Simple Color Select Tool for getting RGB Values By Kikoreta_sop
Imports System.IO

Public Class Color_Picker

    Public ActiveTextBox As TextBox

    Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter, TextBox2.Enter, TextBox3.Enter, TextBox4.Enter
        ActiveTextBox = CType(sender, TextBox)
    End Sub

    Private Shared Sub Textbox_Input(sender As Object, e As KeyPressEventArgs) _
        Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress

        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show(text:=$"Please enter only numbers in range of ""0 - 255""")
            e.Handled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        On Error Resume Next
        If ActiveTextBox.Text > 255 Then

            ActiveTextBox.Text = 0
            MessageBox.Show(text:=$"Please enter only numbers in range of ""0 - 255""")
        ElseIf TextBox5.Text < "0" Then
            TextBox5.Text = "FF000000"
        End If
        On Error GoTo 0

        Panel2.BackColor = Color.FromArgb(TextBox4.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text)
        Panel3.BackColor = Color.FromArgb(TextBox1.Text, 0, 0)
        Panel4.BackColor = Color.FromArgb(0, TextBox2.Text, 0)
        Panel5.BackColor = Color.FromArgb(0, 0, TextBox3.Text)
        Panel6.BackColor = Color.FromArgb(TextBox4.Text, 0, 0, 0)

        If ListBox1.SelectedIndex >= 0 And ListBox1.Focused = True Then

            Dim fields As String() = ListBox1.SelectedItem.Split(",")
            Dim cr = fields(0)
            Dim cg = fields(1)
            Dim cb = fields(2)
            Dim ca = fields(3)
            Panel2.BackColor = Color.FromArgb(ca, cr, cg, cb)
            TextBox1.Text = cr
            TextBox2.Text = cg
            TextBox3.Text = cb
            TextBox4.Text = ca
            TrackBar1.Value = cr
            TrackBar2.Value = cg
            TrackBar3.Value = cb
            TrackBar4.Value = ca

        ElseIf ActiveTextBox.Focused Then

            TrackBar1.Value = TextBox1.Text
            TrackBar2.Value = TextBox2.Text
            TrackBar3.Value = TextBox3.Text
            TrackBar4.Value = TextBox4.Text
        ElseIf TextBox5.focused Then
            Dim hex As String
            Dim ha As String
            Dim hr As String
            Dim hg As String
            Dim hb As String
            hex = TextBox5.Text
            ha = Val("&H" & Mid(hex, 1, 2))
            hr = Val("&H" & Mid(hex, 3, 2))
            hg = Val("&H" & Mid(hex, 5, 2))
            hb = Val("&H" & Mid(hex, 7, 2))
            TrackBar1.Value = hr
            TrackBar2.Value = hg
            TrackBar3.Value = hb
            TrackBar4.Value = ha
            TextBox1.Text = hr
            TextBox2.Text = hg
            TextBox3.Text = hb
            TextBox4.Text = ha

        Else
            TextBox1.Text = TrackBar1.Value
            TextBox2.Text = TrackBar2.Value
            TextBox3.Text = TrackBar3.Value
            TextBox4.Text = TrackBar4.Value
            Dim c As Color = Color.FromArgb(TextBox4.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text)
            Dim value As Integer = c.ToArgb()
            Dim hex As String = value.ToString("X6")
            TextBox5.Text = hex

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Select Case Picker.Visible
            Case True
                Picker.Visible = False
            Case False
                Picker.Visible = True
        End Select

    End Sub

    Private Sub TextBox_MouseDown() Handles TextBox1.MouseDown, TextBox2.MouseDown, TextBox3.MouseDown, TextBox4.MouseDown

        ActiveTextBox.SelectAll()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ListBox1.Items.Add(TextBox1.Text + "," + TextBox2.Text + "," + TextBox3.Text + "," + TextBox4.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim saveFile = New SaveFileDialog() With {.Filter = "Text File (*.Txt)|*.txt"}
        Dim i As Integer

        If (saveFile.ShowDialog() = DialogResult.OK) Then

            Dim w = New StreamWriter(saveFile.FileName)
            For i = 0 To ListBox1.Items.Count - 1
                w.WriteLine(ListBox1.Items.Item(i))
            Next
            w.Close()

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim openFile = New OpenFileDialog() With {.Filter = "Text File (*.Txt)|*.txt"}

        If (openFile.ShowDialog() = DialogResult.OK) Then

            ListBox1.Items.Clear()
            ListBox1.Items.AddRange(File.ReadAllLines(openFile.FileName))

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case ModifierKeys
            Case Keys.Shift
                If TrackBar1.Value + 10 < 255 Then TrackBar1.Value = TrackBar1.Value + 10
            Case Keys.Control
                If TrackBar1.Value + 100 < 255 Then TrackBar1.Value = TrackBar1.Value + 100
            Case Else
                If TrackBar1.Value < 255 Then TrackBar1.Value = TrackBar1.Value + 1
        End Select
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Select Case ModifierKeys
            Case Keys.Shift
                If TrackBar1.Value - 10 > 0 Then TrackBar1.Value = TrackBar1.Value - 10
            Case Keys.Control
                If TrackBar1.Value - 100 > 0 Then TrackBar1.Value = TrackBar1.Value - 100
            Case Else
                If TrackBar1.Value > 0 Then TrackBar1.Value = TrackBar1.Value - 1
        End Select
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Select Case ModifierKeys
            Case Keys.Shift
                If TrackBar2.Value + 10 < 255 Then TrackBar2.Value = TrackBar2.Value + 10
            Case Keys.Control
                If TrackBar2.Value + 100 < 255 Then TrackBar2.Value = TrackBar2.Value + 100
            Case Else
                If TrackBar2.Value < 255 Then TrackBar2.Value = TrackBar2.Value + 1
        End Select
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Select Case ModifierKeys
            Case Keys.Shift
                If TrackBar2.Value - 10 > 0 Then TrackBar2.Value = TrackBar2.Value - 10
            Case Keys.Control
                If TrackBar2.Value - 100 > 0 Then TrackBar2.Value = TrackBar2.Value - 100
            Case Else
                If TrackBar2.Value > 0 Then TrackBar2.Value = TrackBar2.Value - 1
        End Select
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Select Case ModifierKeys
            Case Keys.Shift
                If TrackBar3.Value + 10 < 255 Then TrackBar3.Value = TrackBar3.Value + 10
            Case Keys.Control
                If TrackBar3.Value + 100 < 255 Then TrackBar3.Value = TrackBar3.Value + 100
            Case Else
                If TrackBar3.Value < 255 Then TrackBar3.Value = TrackBar3.Value + 1
        End Select
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Select Case ModifierKeys
            Case Keys.Shift
                If TrackBar3.Value - 10 > 0 Then TrackBar3.Value = TrackBar3.Value - 10
            Case Keys.Control
                If TrackBar3.Value - 100 > 0 Then TrackBar3.Value = TrackBar3.Value - 100
            Case Else
                If TrackBar3.Value > 0 Then TrackBar3.Value = TrackBar3.Value - 1
        End Select
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Select Case ModifierKeys
            Case Keys.Shift
                If TrackBar4.Value + 10 < 255 Then TrackBar4.Value = TrackBar4.Value + 10
            Case Keys.Control
                If TrackBar4.Value + 100 < 255 Then TrackBar4.Value = TrackBar4.Value + 100
            Case Else
                If TrackBar4.Value < 255 Then TrackBar4.Value = TrackBar4.Value + 1
        End Select
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Select Case ModifierKeys
            Case Keys.Shift
                If TrackBar4.Value - 10 > 0 Then TrackBar4.Value = TrackBar4.Value - 10
            Case Keys.Control
                If TrackBar4.Value - 100 > 0 Then TrackBar4.Value = TrackBar4.Value - 100
            Case Else
                If TrackBar4.Value > 0 Then TrackBar4.Value = TrackBar4.Value - 1
        End Select
    End Sub

End Class
