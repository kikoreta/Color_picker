Friend NotInheritable Class Picker

    Dim ReadOnly _imagef As String = AppDomain.CurrentDomain.BaseDirectory & "Imagenes\"

    Private Sub Picker_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        On Error Resume Next
        Dim img As New Bitmap(PictureBox1.Width, PictureBox1.Height)
        img = PictureBox1.Image
        Dim px, py
        px = (MousePosition.X - Left - PictureBox1.Left - 9)
        py = (MousePosition.Y - Top - PictureBox1.Top - 25)
        PictureBox2.BackColor = img.GetPixel(px, py)
    End Sub

    Private Sub Picker_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Color_Picker.TextBox1.Text = PictureBox2.BackColor.R
        Color_Picker.TextBox2.Text = PictureBox2.BackColor.G
        Color_Picker.TextBox3.Text = PictureBox2.BackColor.B
        Color_Picker.TrackBar1.Value = PictureBox2.BackColor.R
        Color_Picker.TrackBar2.Value = PictureBox2.BackColor.G
        Color_Picker.TrackBar3.Value = PictureBox2.BackColor.B
        Color_Picker.TrackBar4.Value = PictureBox2.BackColor.A
    End Sub

    Private Sub Picker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each image As String In Computer.FileSystem.GetFiles(_imagef, FileIO.SearchOption.SearchTopLevelOnly, "*.png")
            Dim imagen = image.Remove(0, _imagef.Length)
            imagen = imagen.Remove(2, 4)
            ListBox1.Items.Add(imagen)
        Next
        ListBox1.SelectedIndex = 0
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim corrname = ListBox1.SelectedIndex + 1
        Dim imagename As String = "0" + corrname.ToString + ".png"
        Dim src As String = _imagef & imagename
        PictureBox1.ImageLocation = src
    End Sub

End Class