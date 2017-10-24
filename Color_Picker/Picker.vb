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
        Form1.TextBox1.Text = PictureBox2.BackColor.R
        Form1.TextBox2.Text = PictureBox2.BackColor.G
        Form1.TextBox3.Text = PictureBox2.BackColor.B
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