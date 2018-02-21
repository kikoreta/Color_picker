'Simple Color Select Tool for getting RGB Values By Kikoreta_sop
Imports System.IO

Public Class Color_Picker

    Public ActiveTextBox As TextBox

    Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter, TextBox2.Enter, TextBox3.Enter
        ActiveTextBox = CType(sender, TextBox)
    End Sub

    Private Shared Sub Textbox_Input(sender As Object, e As KeyPressEventArgs) _
        Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress

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

        End If
        On Error GoTo 0

        Panel2.BackColor = Color.FromArgb(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        Panel3.BackColor = Color.FromArgb(TextBox1.Text, 0, 0)
        Panel4.BackColor = Color.FromArgb(0, TextBox2.Text, 0)
        Panel5.BackColor = Color.FromArgb(0, 0, TextBox3.Text)

        If ListBox1.SelectedIndex >= 0 And ListBox1.Focused = True Then

            Dim fields As String() = ListBox1.SelectedItem.Split(",")
            Dim cr = fields(0)
            Dim cg = fields(1)
            Dim cb = fields(2)
            Panel2.BackColor = Color.FromArgb(cr, cg, cb)
            TextBox1.Text = cr
            TextBox2.Text = cg
            TextBox3.Text = cb
            TrackBar1.Value = cr
            TrackBar2.Value = cg
            TrackBar3.Value = cb

        Else

            TextBox1.Text = TrackBar1.Value
            TextBox2.Text = TrackBar2.Value
            TextBox3.Text = TrackBar3.Value

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

    Private Sub TextBox_MouseDown() Handles TextBox1.MouseDown, TextBox2.MouseDown, TextBox3.MouseDown

        ActiveTextBox.SelectAll()
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
End Class
