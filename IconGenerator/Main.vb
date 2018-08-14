Imports System.Drawing.Imaging

''' <summary>
''' Author: Kuroki Almajiro
''' Created On: 2018/8/13 23:40
''' Description: IconGenerator Main Source File
''' References:
'''     https://msdn.microsoft.com/ja-jp/library/system.drawing.bitmap_methods(v=vs.110).aspx
'''     http://www.vbforums.com/showthread.php?396650-Create-Valid-Icon-Files!-In-24-bit-true-color
'''     https://msdn.microsoft.com/ja-jp/library/system.drawing.imaging.colormatrix.matrix33(v=vs.110).aspx
'''     https://msdn.microsoft.com/ja-jp/library/system.drawing.imaging.imageattributes(v=vs.110).aspx
''' </summary>

Public Class Main
    <System.Runtime.InteropServices.DllImport(
        "user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto)>
    Private Shared Function DestroyIcon(ByVal handle As IntPtr) As Boolean
    End Function

    ' Current Image
    Private currentImage As Bitmap

    ' Image Zoom Ratio
    Private zoomRatio As Double = 1.0

    ' Target Rectangle
    Private drawRectangle As Rectangle

    ' Current Image Path
    Private imagePath As String

    ' Color Flags
    Private grayScale As Boolean = False
    Private sepia As Boolean = False

    ' Transparency
    Dim transparency As New System.Drawing.Imaging.ColorMatrix()

    ' ImageAttributes
    Dim imgattr As New Imaging.ImageAttributes()

    ' IconDepth
    Dim iconDepthName() As String = {
            "4ビット",
            "8ビット",
            "16ビット",
            "24ビット",
            "32ビット ( 8-bit Alpha )"
    }

    '-------------------------------
    ' Color Preset (Grayscale)
    '-------------------------------
    Dim grayScalePreset As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

    '-------------------------------
    ' Color Preset (Sepia)
    '-------------------------------
    Dim sepiaPreset As New System.Drawing.Imaging.ColorMatrix(
        New Single()() {
            New Single() {0.393F, 0.349F, 0.272F, 0, 0},
            New Single() {0.769F, 0.686F, 0.534F, 0, 0},
            New Single() {0.189F, 0.168F, 0.131F, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}})

    '---------------------------
    ' Core Functions Start
    '---------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SizeSelect.SelectedIndex = 6
        IconDepth.SelectedIndex = 4
        PictureBox1.Height = 320
        PictureBox1.Width = 320
    End Sub

    Private Sub Reset()
        drawRectangle = New Rectangle(0, 0, currentImage.Width, currentImage.Height)

        zoomRatio = 1.0
        zoomRatioLabel.Text = zoomRatio

        sepia = False
        grayScale = False
        SepiaToolStripMenuItem.Checked = False
        GrayScaleToolStripMenuItem.Checked = False

        TransparencyBar.Value = 0
        Percentage.Text = "0%"

        transparency.Matrix00 = 1
        transparency.Matrix11 = 1
        transparency.Matrix22 = 1
        transparency.Matrix33 = 1
        transparency.Matrix44 = 1

        IconDepth.Items.Clear()
        For i = 0 To 4
            IconDepth.Items.Add(iconDepthName(i))
        Next

        IconDepth.SelectedIndex = 4

        PictureBox1.Invalidate()
    End Sub

    Private Sub DoOpenImage()
        If Not (currentImage Is Nothing) Then
            currentImage.Dispose()
        End If

        Dim ofd As New OpenFileDialog()

        ofd.InitialDirectory = "~\"
        ofd.Filter = "画像ファイル(*.jpg;*.png)|*.jpg;*.png|すべてのファイル(*.*)|*.*"
        ofd.FilterIndex = 2
        ofd.Title = "開く画像ファイルを選択してください"
        ofd.RestoreDirectory = True
        ofd.CheckFileExists = True
        ofd.CheckPathExists = True

        If ofd.ShowDialog() = DialogResult.OK Then
            imagePath = ofd.FileName

            currentImage = New Bitmap(imagePath)
            ImageFilePathLabel.Text = "パス: " + imagePath

            Me.Text = System.IO.Path.GetFileName(imagePath) + " (" + currentImage.Width.ToString + "," + currentImage.Height.ToString + ")" + " - Image Resize & .ico Coverter"
            ImageSizeLabel.Text = "サイズ: " + currentImage.Width.ToString + "px," + currentImage.Height.ToString + "px"

            Reset()

            SaveIconToolStripMenuItem.Enabled = True
            GrayScaleToolStripMenuItem.Enabled = True
            SepiaToolStripMenuItem.Enabled = True
            zoomRatioLabel.Enabled = True
            UpButton.Enabled = True
            DownButton.Enabled = True
            LeftButton.Enabled = True
            RightButton.Enabled = True
            IconDepth.Enabled = True
            SizeSelect.Enabled = True
            ChangeRatioButton.Enabled = True
            SaveIconButton.Enabled = True
            ResetToolStripMenuItem.Enabled = True
            TransparencyBar.Enabled = True
        End If
    End Sub

    Private Sub DoSaveIcon(ByVal pixel As Integer, ByVal filePath As String)
        Dim corpBmp As New Bitmap(320, 320)
        Dim thisRectangle As Rectangle = drawRectangle

        Dim graphic As Graphics = Graphics.FromImage(corpBmp)

        If grayScale Then
            grayScalePreset.Matrix33 = transparency.Matrix33
            imgattr.SetColorMatrix(grayScalePreset)
            graphic.DrawImage(currentImage, drawRectangle, 0, 0, currentImage.Width, currentImage.Height, System.Drawing.GraphicsUnit.Pixel, imgattr)
        ElseIf sepia Then
            sepiaPreset.Matrix33 = transparency.Matrix33
            imgattr.SetColorMatrix(sepiaPreset)
            graphic.DrawImage(currentImage, drawRectangle, 0, 0, currentImage.Width, currentImage.Height, System.Drawing.GraphicsUnit.Pixel, imgattr)
        Else
            imgattr.SetColorMatrix(transparency)
            graphic.DrawImage(currentImage, drawRectangle, 0, 0, currentImage.Width, currentImage.Height, System.Drawing.GraphicsUnit.Pixel, imgattr)
        End If

        graphic.Dispose()

        Dim resizedBmp As New Bitmap(pixel, pixel)
        graphic = Graphics.FromImage(resizedBmp)
        graphic.DrawImage(corpBmp, 0, 0, pixel, pixel)
        graphic.Dispose()

        ' Create icon from Bitmap
        ' but GDI+ converter is not suppport convert to ico file
        Dim ico As Icon = System.Drawing.Icon.FromHandle(resizedBmp.GetHicon())

        ' Save icon File
        Dim fs As New System.IO.FileStream(filePath, System.IO.FileMode.Create, System.IO.FileAccess.Write)
        ico.Save(fs)
        fs.Close()

        ' so, we use external dll by Steve McMahon
        ' thanks to http://www.vbforums.com/showthread.php?396650-Create-Valid-Icon-Files!-In-24-bit-true-color
        ' Opens icon file we just created for editing with IconEX
        Dim Iconex As New vbAccelerator.Components.Win32.IconEx(filePath)
        ' Removes original icon image that we created above
        Iconex.Items.RemoveAt(0)

        Dim colorDepth As ColorDepth

        Select Case IconDepth.Text
            Case "4ビット"
                colorDepth = ColorDepth.Depth4Bit
            Case "8ビット"
                colorDepth = ColorDepth.Depth8Bit
            Case "16ビット"
                colorDepth = ColorDepth.Depth16Bit
            Case "24ビット"
                colorDepth = ColorDepth.Depth24Bit
            Case "32ビット ( 8-bit Alpha )"
                colorDepth = ColorDepth.Depth32Bit
        End Select

        ' Creates a new pixel x pixel IconDeviceImage, to store the new icon image
        Dim IconDeviceImage As New vbAccelerator.Components.Win32.IconDeviceImage(New Size(pixel, pixel), colorDepth)
        ' Gets bitmap of (assumed) 32 x 32 image in picturebox, sets it to IconImage
        IconDeviceImage.IconImage = resizedBmp
        ' Add icondevicimage to the icon file
        Iconex.Items.Add(IconDeviceImage)
        ' Save icon 
        Iconex.Save(filePath)

        ' Clean up
        resizedBmp.Dispose()
        corpBmp.Dispose()
        ico.Dispose()
        DestroyIcon(ico.Handle)

        ImageSizeLabel.Text = "ファイルは、" + filePath + "へ保存されました。"
    End Sub

    Private Sub SaveFileAs(ByVal pixel As Integer)
        Dim sfd As New SaveFileDialog()

        sfd.FileName = System.IO.Path.GetFileNameWithoutExtension(imagePath) + "(" + pixel.ToString + "x" + pixel.ToString + ")" + ".ico"
        sfd.InitialDirectory = "~\"
        sfd.Filter = "アイコンファイル(*.ico)|*.ico"
        sfd.FilterIndex = 2
        sfd.Title = "保存先の画像ファイルを選択してください (" + pixel.ToString + "x" + pixel.ToString + ")"
        sfd.RestoreDirectory = True
        sfd.OverwritePrompt = True
        sfd.CheckPathExists = True

        If sfd.ShowDialog() = DialogResult.OK Then
            DoSaveIcon(pixel, sfd.FileName)
        End If
    End Sub

    Private Function DoSaveAsFromFormInputs() As Integer
        Select Case SizeSelect.Text
            Case "16x16"
                SaveFileAs(16)
            Case "20x20"
                SaveFileAs(20)
            Case "24x24"
                SaveFileAs(24)
            Case "32x32"
                SaveFileAs(32)
            Case "40x40"
                SaveFileAs(40)
            Case "48x48"
                SaveFileAs(48)
            Case "64x64"
                SaveFileAs(64)
            Case "96x96"
                SaveFileAs(96)
            Case "128x128"
                SaveFileAs(128)
            Case "256x256"
                SaveFileAs(256)
        End Select
    End Function

    '---------------------------
    ' Core Functions End
    '---------------------------

    '---------------------------
    ' PictureBox Start
    '---------------------------
    Private Sub PictureBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseWheel
        If Not (currentImage Is Nothing) Then
            Dim pictureBox As PictureBox = DirectCast(sender, PictureBox)
            Dim imagePoint As New Point(
                CInt(Math.Round((e.X - drawRectangle.X) / zoomRatio)),
                CInt(Math.Round((e.Y - drawRectangle.Y) / zoomRatio))
            )

            If e.Delta > 0 Then
                zoomRatio *= 1.05
            ElseIf e.Delta < 0 Then
                zoomRatio *= 0.9
            End If

            drawRectangle.Width = CInt(Math.Round(currentImage.Width * zoomRatio))
            drawRectangle.Height = CInt(Math.Round(currentImage.Height * zoomRatio))
            drawRectangle.X = CInt(Math.Round(pictureBox.Width / 2.0 - imagePoint.X * zoomRatio))
            drawRectangle.Y = CInt(Math.Round(pictureBox.Height / 2.0 - imagePoint.Y * zoomRatio))

            zoomRatioLabel.Text = zoomRatio.ToString("0.000")

            PictureBox1.Invalidate()
        End If
    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        If Not (currentImage Is Nothing) Then
            If grayScale Then
                grayScalePreset.Matrix33 = transparency.Matrix33

                imgattr.SetColorMatrix(grayScalePreset)
                e.Graphics.DrawImage(currentImage, drawRectangle, 0, 0, currentImage.Width, currentImage.Height, System.Drawing.GraphicsUnit.Pixel, imgattr)
            ElseIf sepia Then
                sepiaPreset.Matrix33 = transparency.Matrix33

                imgattr.SetColorMatrix(sepiaPreset)
                e.Graphics.DrawImage(currentImage, drawRectangle, 0, 0, currentImage.Width, currentImage.Height, System.Drawing.GraphicsUnit.Pixel, imgattr)
            Else
                imgattr.SetColorMatrix(transparency)
                e.Graphics.DrawImage(currentImage, drawRectangle, 0, 0, currentImage.Width, currentImage.Height, System.Drawing.GraphicsUnit.Pixel, imgattr)
            End If
        End If
    End Sub
    '---------------------------
    ' PictureBox End
    '---------------------------

    '---------------------------
    ' Buttons Start
    '---------------------------
    Private Sub UpButton_Click(sender As Object, e As EventArgs) Handles UpButton.Click
        drawRectangle.Y -= 10
        PictureBox1.Invalidate()
    End Sub

    Private Sub LeftButton_Click(sender As Object, e As EventArgs) Handles LeftButton.Click
        drawRectangle.X -= 10
        PictureBox1.Invalidate()
    End Sub

    Private Sub DownButton_Click(sender As Object, e As EventArgs) Handles DownButton.Click
        drawRectangle.Y += 10
        PictureBox1.Invalidate()
    End Sub

    Private Sub RightButton_Click(sender As Object, e As EventArgs) Handles RightButton.Click
        drawRectangle.X += 10
        PictureBox1.Invalidate()
    End Sub

    Private Sub ChangeRatioButton_Click(sender As Object, e As EventArgs) Handles ChangeRatioButton.Click
        If IsNumeric(zoomRatioLabel.Text) Then
            zoomRatio = Val(zoomRatioLabel.Text)

            drawRectangle.Width = CInt(Math.Round(currentImage.Width * zoomRatio))
            drawRectangle.Height = CInt(Math.Round(currentImage.Height * zoomRatio))

            PictureBox1.Invalidate()
        Else
            MessageBox.Show("倍率は、数字を入力してください。")
        End If
    End Sub

    Private Sub SaveIconButton_Click(sender As Object, e As EventArgs) Handles SaveIconButton.Click
        DoSaveAsFromFormInputs()
    End Sub
    '---------------------------
    ' Buttons End
    '---------------------------

    '---------------------------
    ' ToolStripMenuItem Start
    '---------------------------
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        DoOpenImage()
    End Sub

    Private Sub SaveIconToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveIconToolStripMenuItem.Click
        DoSaveAsFromFormInputs()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        Reset()
    End Sub

    Private Sub GrayScaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrayScaleToolStripMenuItem.Click
        Dim item As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)
        grayScale = Not grayScale

        If sepia Then
            sepia = Not sepia
            SepiaToolStripMenuItem.Checked = sepia
        End If

        item.Checked = grayScale
        PictureBox1.Invalidate()
    End Sub

    Private Sub SepiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SepiaToolStripMenuItem.Click
        Dim item As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)
        sepia = Not sepia

        If grayScale Then
            grayScale = Not grayScale
            GrayScaleToolStripMenuItem.Checked = grayScale
        End If

        item.Checked = sepia
        PictureBox1.Invalidate()
    End Sub
    '---------------------------
    ' ToolStripMenuItem End
    '---------------------------

    '---------------------------
    ' TrackBar Start
    '---------------------------
    Private Sub TransparencyBar_Scroll(sender As Object, e As EventArgs) Handles TransparencyBar.Scroll
        Percentage.Text = TransparencyBar.Value.ToString + "%"
        transparency.Matrix33 = (100 - TransparencyBar.Value) / 100.0

        If TransparencyBar.Value = 0 Then
            IconDepth.Items.Clear()

            For i = 0 To 4
                IconDepth.Items.Add(iconDepthName(i))
            Next

            IconDepth.SelectedIndex = 4
        Else
            IconDepth.Items.Clear()
            IconDepth.Items.Add(iconDepthName(4))
            IconDepth.SelectedIndex = 0
        End If

        PictureBox1.Invalidate()
    End Sub
    '---------------------------
    ' TrackBar End
    '---------------------------
End Class
