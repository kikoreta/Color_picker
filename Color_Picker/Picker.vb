Public Class Picker


    Private Sub Picker_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        On Error Resume Next
        Dim img As New Bitmap(1, 1)
        img = PictureBox1.Image
        Dim Px, Py
        Px = (MousePosition.X - Left - PictureBox1.Left - 9)
        Py = (MousePosition.Y - Top - PictureBox1.Top - 25)
        PictureBox2.BackColor = img.GetPixel(Px, Py)
    End Sub

    Private Sub Picker_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Color_Picker.TextBox1.Text = PictureBox2.BackColor.R
        Color_Picker.TextBox2.Text = PictureBox2.BackColor.G
        Color_Picker.TextBox3.Text = PictureBox2.BackColor.B
        Color_Picker.TrackBar1.Value = PictureBox2.BackColor.R
        Color_Picker.TrackBar2.Value = PictureBox2.BackColor.G
        Color_Picker.TrackBar3.Value = PictureBox2.BackColor.B
    End Sub

    Private Sub Picker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each imagesNames As String In ImageList1.Images.Keys
            ListBox1.Items.Add(imagesNames)
        Next
        ListBox1.SelectedIndex = 0
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        PictureBox1.Image = ImageList1.Images.Item(ListBox1.SelectedIndex)
    End Sub
End Class