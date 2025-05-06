Public Class frmUtama
    Private namafile As String

    Private Sub BukaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BukaToolStripMenuItem.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog1.FileName)
            namafile = openFileDialog1.FileName
        End If
    End Sub

    Private Sub SimpanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanToolStripMenuItem.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        Dim MyPicture As Image
        MyPicture = PictureBox1.Image
        saveFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If saveFileDialog1.FilterIndex = 1 Then
                MyPicture.Save(saveFileDialog1.FileName,
               System.Drawing.Imaging.ImageFormat.Bmp)
            End If
            If saveFileDialog1.FilterIndex = 2 Then
                MyPicture.Save(saveFileDialog1.FileName,
               System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
        End If
    End Sub

    Private Sub InformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformationToolStripMenuItem.Click
        MessageBox.Show("Nama File: " + namafile + vbCr + "Lebar: " +
       PictureBox1.Image.Width.ToString + vbCr + "Tinggi: " +
       PictureBox1.Image.Height.ToString)
    End Sub

    Private Sub GrayscaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrayscaleToolStripMenuItem.Click
        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Citra yang belum dibuka! Silakan buka citra terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim r, g, b, gray As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)

        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                gray = Math.Round(0.2126 * r + 0.7152 * g + 0.0722 * b)
                bmp.SetPixel(kol, bar, Color.FromArgb(gray, gray, gray))
            Next
        Next

        PictureBox1.Image = bmp
    End Sub


    Private Sub CerahkanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerahkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R + 10
                g = bmp.GetPixel(kol, bar).G + 10
                b = bmp.GetPixel(kol, bar).B + 10
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub GelapkanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GelapkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R - 10
                g = bmp.GetPixel(kol, bar).G - 10
                b = bmp.GetPixel(kol, bar).B - 10
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub
    Private Sub TambahKontrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahKontrasToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                r = Math.Round(128 + (1.1 * (r - 128)))
                g = Math.Round(128 + (1.1 * (g - 128)))
                b = Math.Round(128 + (1.1 * (b - 128)))
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub
    Private Sub KurangiKontrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KurangiKontrasToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                r = Math.Round(128 + (0.90909 * (r - 128)))
                g = Math.Round(128 + (0.90909 * (g - 128)))
                b = Math.Round(128 + (0.90909 * (b - 128)))
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(namafile)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub TampilkanHistogramToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TampilkanHistogramToolStripMenuItem.Click
        frmHistogram.ShowDialog()
    End Sub

    Private Sub TajamkanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TajamkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        Dim kernel As Integer() = {-1, -1, -1, -1, 8, -1, -1, -1, -1}
        For bar As Integer = 1 To PictureBox1.Image.Height - 2
            For kol As Integer = 1 To PictureBox1.Image.Width - 2
                r = 0
                g = 0
                b = 0
                For i As Integer = 0 To 8
                    r = r + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).R)
                    g = g + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).G)
                    b = b + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).B)
                Next
                r = Math.Floor(r / 3)
                g = Math.Floor(g / 3)
                b = Math.Floor(b / 3)
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub KaburkanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KaburkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        Dim kernel As Integer() = {1, 1, 1, 1, 1, 1, 1, 1, 1}
        For bar As Integer = 1 To PictureBox1.Image.Height - 2
            For kol As Integer = 1 To PictureBox1.Image.Width - 2
                r = 0
                g = 0
                b = 0
                For i As Integer = 0 To 8
                    r = r + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).R)
                    g = g + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).G)
                    b = b + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).B)
                Next
                r = Math.Floor(r / 9)
                g = Math.Floor(g / 9)
                b = Math.Floor(b / 9)
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub RotateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RotateToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox1.Image = bmp
    End Sub

    Private Sub FlipHorizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlipHorizontalToolStripMenuItem.Click
        Dim gambar As Bitmap = New Bitmap(PictureBox1.Image)

        Dim hasil As New Bitmap(gambar.Width, gambar.Height)

        For y = 0 To gambar.Height - 1
            For x = 0 To gambar.Width - 1
                Dim warnaPixel As Color = gambar.GetPixel(x, y)
                hasil.SetPixel(gambar.Width - 1 - x, y, warnaPixel)
            Next
        Next

        PictureBox1.Image = hasil
    End Sub



    Private Sub FlipVerticallyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlipVerticallyToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        bmp.RotateFlip(RotateFlipType.RotateNoneFlipY)
        PictureBox1.Image = bmp
    End Sub

    Private Sub BoxBlurToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxBlurToolStripMenuItem.Click
        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Silakan buka gambar terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim bmpOriginal As New Bitmap(PictureBox1.Image)
        Dim bmpBlur As New Bitmap(bmpOriginal.Width, bmpOriginal.Height)

        Dim r, g, b As Integer

        For y As Integer = 1 To bmpOriginal.Height - 2
            For x As Integer = 1 To bmpOriginal.Width - 2
                r = 0 : g = 0 : b = 0

                For j As Integer = -1 To 1
                    For i As Integer = -1 To 1
                        Dim warna As Color = bmpOriginal.GetPixel(x + i, y + j)
                        r += warna.R
                        g += warna.G
                        b += warna.B
                    Next
                Next

                r = r \ 9
                g = g \ 9
                b = b \ 9

                bmpBlur.SetPixel(x, y, Color.FromArgb(r, g, b))
            Next
        Next

        PictureBox1.Image = bmpBlur
    End Sub
End Class
