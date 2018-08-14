<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ImageSizeLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ImageFilePathLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveIconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.イメージToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.プリセットToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrayScaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SepiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpButton = New System.Windows.Forms.Button()
        Me.DownButton = New System.Windows.Forms.Button()
        Me.LeftButton = New System.Windows.Forms.Button()
        Me.RightButton = New System.Windows.Forms.Button()
        Me.zoomRatioLabel = New System.Windows.Forms.TextBox()
        Me.ChangeRatioButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SaveIconButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SizeSelect = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.IconDepth = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Percentage = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TransparencyBar = New System.Windows.Forms.TrackBar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.TransparencyBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.IconGenerator.My.Resources.Resources.transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(12, 49)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(482, 497)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImageSizeLabel, Me.ImageFilePathLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 553)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(748, 30)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ImageSizeLabel
        '
        Me.ImageSizeLabel.Name = "ImageSizeLabel"
        Me.ImageSizeLabel.Size = New System.Drawing.Size(0, 25)
        '
        'ImageFilePathLabel
        '
        Me.ImageFilePathLabel.Name = "ImageFilePathLabel"
        Me.ImageFilePathLabel.Size = New System.Drawing.Size(240, 25)
        Me.ImageFilePathLabel.Text = "ファイルが選択されていません。"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.イメージToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(748, 33)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveIconToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(78, 29)
        Me.FileToolStripMenuItem.Text = "ファイル"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(284, 30)
        Me.OpenToolStripMenuItem.Text = "ファイルを開く(&O)"
        '
        'SaveIconToolStripMenuItem
        '
        Me.SaveIconToolStripMenuItem.Enabled = False
        Me.SaveIconToolStripMenuItem.Name = "SaveIconToolStripMenuItem"
        Me.SaveIconToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveIconToolStripMenuItem.Size = New System.Drawing.Size(284, 30)
        Me.SaveIconToolStripMenuItem.Text = "アイコンを保存(&S)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(281, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(284, 30)
        Me.ExitToolStripMenuItem.Text = "終了(&X)"
        '
        'イメージToolStripMenuItem
        '
        Me.イメージToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.プリセットToolStripMenuItem, Me.ToolStripSeparator2, Me.ResetToolStripMenuItem})
        Me.イメージToolStripMenuItem.Name = "イメージToolStripMenuItem"
        Me.イメージToolStripMenuItem.Size = New System.Drawing.Size(83, 29)
        Me.イメージToolStripMenuItem.Text = "イメージ"
        '
        'プリセットToolStripMenuItem
        '
        Me.プリセットToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GrayScaleToolStripMenuItem, Me.SepiaToolStripMenuItem})
        Me.プリセットToolStripMenuItem.Name = "プリセットToolStripMenuItem"
        Me.プリセットToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.プリセットToolStripMenuItem.Text = "プリセット"
        '
        'GrayScaleToolStripMenuItem
        '
        Me.GrayScaleToolStripMenuItem.Enabled = False
        Me.GrayScaleToolStripMenuItem.Name = "GrayScaleToolStripMenuItem"
        Me.GrayScaleToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GrayScaleToolStripMenuItem.Size = New System.Drawing.Size(322, 30)
        Me.GrayScaleToolStripMenuItem.Text = "グレースケール(&G)"
        '
        'SepiaToolStripMenuItem
        '
        Me.SepiaToolStripMenuItem.Enabled = False
        Me.SepiaToolStripMenuItem.Name = "SepiaToolStripMenuItem"
        Me.SepiaToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SepiaToolStripMenuItem.Size = New System.Drawing.Size(322, 30)
        Me.SepiaToolStripMenuItem.Text = "セピア色(&S)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(249, 6)
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Enabled = False
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ResetToolStripMenuItem.Text = "リセット(&R)"
        '
        'UpButton
        '
        Me.UpButton.Enabled = False
        Me.UpButton.Location = New System.Drawing.Point(85, 25)
        Me.UpButton.Name = "UpButton"
        Me.UpButton.Size = New System.Drawing.Size(58, 32)
        Me.UpButton.TabIndex = 6
        Me.UpButton.Text = "↑"
        Me.UpButton.UseVisualStyleBackColor = True
        '
        'DownButton
        '
        Me.DownButton.Enabled = False
        Me.DownButton.Location = New System.Drawing.Point(85, 63)
        Me.DownButton.Name = "DownButton"
        Me.DownButton.Size = New System.Drawing.Size(58, 32)
        Me.DownButton.TabIndex = 7
        Me.DownButton.Text = "↓"
        Me.DownButton.UseVisualStyleBackColor = True
        '
        'LeftButton
        '
        Me.LeftButton.Enabled = False
        Me.LeftButton.Location = New System.Drawing.Point(21, 44)
        Me.LeftButton.Name = "LeftButton"
        Me.LeftButton.Size = New System.Drawing.Size(58, 32)
        Me.LeftButton.TabIndex = 8
        Me.LeftButton.Text = "←"
        Me.LeftButton.UseVisualStyleBackColor = True
        '
        'RightButton
        '
        Me.RightButton.Enabled = False
        Me.RightButton.Location = New System.Drawing.Point(149, 44)
        Me.RightButton.Name = "RightButton"
        Me.RightButton.Size = New System.Drawing.Size(58, 32)
        Me.RightButton.TabIndex = 9
        Me.RightButton.Text = "→"
        Me.RightButton.UseVisualStyleBackColor = True
        '
        'zoomRatioLabel
        '
        Me.zoomRatioLabel.Enabled = False
        Me.zoomRatioLabel.Location = New System.Drawing.Point(23, 29)
        Me.zoomRatioLabel.Name = "zoomRatioLabel"
        Me.zoomRatioLabel.Size = New System.Drawing.Size(116, 26)
        Me.zoomRatioLabel.TabIndex = 10
        '
        'ChangeRatioButton
        '
        Me.ChangeRatioButton.Enabled = False
        Me.ChangeRatioButton.Location = New System.Drawing.Point(143, 27)
        Me.ChangeRatioButton.Name = "ChangeRatioButton"
        Me.ChangeRatioButton.Size = New System.Drawing.Size(63, 31)
        Me.ChangeRatioButton.TabIndex = 11
        Me.ChangeRatioButton.Text = "変更"
        Me.ChangeRatioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RightButton)
        Me.GroupBox1.Controls.Add(Me.UpButton)
        Me.GroupBox1.Controls.Add(Me.DownButton)
        Me.GroupBox1.Controls.Add(Me.LeftButton)
        Me.GroupBox1.Location = New System.Drawing.Point(512, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 118)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "移動"
        '
        'SaveIconButton
        '
        Me.SaveIconButton.Enabled = False
        Me.SaveIconButton.Location = New System.Drawing.Point(512, 505)
        Me.SaveIconButton.Name = "SaveIconButton"
        Me.SaveIconButton.Size = New System.Drawing.Size(224, 41)
        Me.SaveIconButton.TabIndex = 14
        Me.SaveIconButton.Text = "アイコンを保存"
        Me.SaveIconButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SizeSelect)
        Me.GroupBox2.Location = New System.Drawing.Point(512, 357)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 68)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "出力サイズ ( px )"
        '
        'SizeSelect
        '
        Me.SizeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SizeSelect.Enabled = False
        Me.SizeSelect.FormattingEnabled = True
        Me.SizeSelect.Items.AddRange(New Object() {"16x16", "20x20", "24x24", "32x32", "40x40", "48x48", "64x64", "96x96", "128x128", "256x256"})
        Me.SizeSelect.Location = New System.Drawing.Point(23, 25)
        Me.SizeSelect.Name = "SizeSelect"
        Me.SizeSelect.Size = New System.Drawing.Size(183, 28)
        Me.SizeSelect.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.zoomRatioLabel)
        Me.GroupBox3.Controls.Add(Me.ChangeRatioButton)
        Me.GroupBox3.Location = New System.Drawing.Point(512, 49)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(223, 69)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "倍率"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.IconDepth)
        Me.GroupBox4.Location = New System.Drawing.Point(512, 431)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(223, 68)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ビット深度 ( 色深度 )"
        '
        'IconDepth
        '
        Me.IconDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IconDepth.Enabled = False
        Me.IconDepth.FormattingEnabled = True
        Me.IconDepth.Items.AddRange(New Object() {"4ビット", "8ビット", "16ビット", "24ビット", "32ビット ( 8-bit Alpha )"})
        Me.IconDepth.Location = New System.Drawing.Point(21, 25)
        Me.IconDepth.Name = "IconDepth"
        Me.IconDepth.Size = New System.Drawing.Size(183, 28)
        Me.IconDepth.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Percentage)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.TransparencyBar)
        Me.GroupBox5.Location = New System.Drawing.Point(512, 248)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(225, 103)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "透明度"
        '
        'Percentage
        '
        Me.Percentage.AutoSize = True
        Me.Percentage.Location = New System.Drawing.Point(91, 63)
        Me.Percentage.Name = "Percentage"
        Me.Percentage.Size = New System.Drawing.Size(32, 20)
        Me.Percentage.TabIndex = 3
        Me.Percentage.Text = "0%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "100%"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "0%"
        '
        'TransparencyBar
        '
        Me.TransparencyBar.AutoSize = False
        Me.TransparencyBar.Enabled = False
        Me.TransparencyBar.Location = New System.Drawing.Point(6, 25)
        Me.TransparencyBar.Maximum = 100
        Me.TransparencyBar.Name = "TransparencyBar"
        Me.TransparencyBar.Size = New System.Drawing.Size(213, 69)
        Me.TransparencyBar.TabIndex = 0
        Me.TransparencyBar.TickFrequency = 5
        Me.TransparencyBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(748, 583)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.SaveIconButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(770, 639)
        Me.MinimumSize = New System.Drawing.Size(770, 639)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Image Resize & .ico Coverter"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.TransparencyBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ImageFilePathLabel As ToolStripStatusLabel
    Friend WithEvents ImageSizeLabel As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpButton As Button
    Friend WithEvents DownButton As Button
    Friend WithEvents LeftButton As Button
    Friend WithEvents RightButton As Button
    Friend WithEvents zoomRatioLabel As TextBox
    Friend WithEvents ChangeRatioButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SaveIconButton As Button
    Friend WithEvents SaveIconToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SizeSelect As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents イメージToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents IconDepth As ComboBox
    Friend WithEvents プリセットToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrayScaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SepiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TransparencyBar As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Percentage As Label
End Class
