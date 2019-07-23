Friend NotInheritable Class Picker

    Dim ReadOnly _imagef As String = AppDomain.CurrentDomain.BaseDirectory & "Imagenes\"

    Private Sub Picker_MouseMove(sender As Object, e As MouseEventArgs) Handles PBImagen.MouseMove
        On Error Resume Next
        Dim img As New Bitmap(PBImagen.Width, PBImagen.Height)
        img = PBImagen.Image
        Dim px, py
        px = (MousePosition.X - Left - PBImagen.Left - 9)
        py = (MousePosition.Y - Top - PBImagen.Top - 25)
        PBColor.BackColor = img.GetPixel(px, py)
    End Sub

    Private Sub Picker_Click(sender As Object, e As EventArgs) Handles PBImagen.Click
        Color_Picker.TbR.Text = PBColor.BackColor.R
        Color_Picker.TbG.Text = PBColor.BackColor.G
        Color_Picker.TbB.Text = PBColor.BackColor.B
        Color_Picker.TBarR.Value = PBColor.BackColor.R
        Color_Picker.TBarG.Value = PBColor.BackColor.G
        Color_Picker.TBarB.Value = PBColor.BackColor.B
        Color_Picker.TBarA.Value = PBColor.BackColor.A
    End Sub

    Private Sub Picker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each image As String In Computer.FileSystem.GetFiles(_imagef, FileIO.SearchOption.SearchTopLevelOnly, "*.png")
            Dim imagen = image.Remove(0, _imagef.Length)
            imagen = imagen.Remove(2, 4)
            LbImagenes.Items.Add(imagen)
        Next
        LbImagenes.SelectedIndex = 0
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbImagenes.SelectedIndexChanged
        Dim corrname = LbImagenes.SelectedIndex + 1
        Dim imagename As String = "0" + corrname.ToString + ".png"
        Dim src As String = _imagef & imagename
        PBImagen.ImageLocation = src
    End Sub

End Class