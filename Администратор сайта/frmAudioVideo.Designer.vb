<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAudioVideo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAudioVideo))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.VideoPlaySettings_Label = New System.Windows.Forms.GroupBox()
        Me.VideoNextPlay_CheckBox = New System.Windows.Forms.CheckBox()
        Me.VideoAutoPlay_CheckBox = New System.Windows.Forms.CheckBox()
        Me.VideoList_Label = New System.Windows.Forms.Label()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.VideoPlayList_ListBox = New System.Windows.Forms.ListBox()
        Me.VideoPlayListAdd_Button = New System.Windows.Forms.Button()
        Me.VideoPlayListClear_Button = New System.Windows.Forms.Button()
        Me.VideoPlayListDel_Button = New System.Windows.Forms.Button()
        Me.WindowsMediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.VideoPlaySettings_Label.SuspendLayout()
        CType(Me.WindowsMediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'VideoPlaySettings_Label
        '
        Me.VideoPlaySettings_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VideoPlaySettings_Label.Controls.Add(Me.VideoNextPlay_CheckBox)
        Me.VideoPlaySettings_Label.Controls.Add(Me.VideoAutoPlay_CheckBox)
        Me.VideoPlaySettings_Label.Location = New System.Drawing.Point(646, 213)
        Me.VideoPlaySettings_Label.Name = "VideoPlaySettings_Label"
        Me.VideoPlaySettings_Label.Size = New System.Drawing.Size(194, 85)
        Me.VideoPlaySettings_Label.TabIndex = 11
        Me.VideoPlaySettings_Label.TabStop = False
        Me.VideoPlaySettings_Label.Text = "Настройки вопроизведения:"
        '
        'VideoNextPlay_CheckBox
        '
        Me.VideoNextPlay_CheckBox.AutoSize = True
        Me.VideoNextPlay_CheckBox.Enabled = False
        Me.VideoNextPlay_CheckBox.Location = New System.Drawing.Point(5, 43)
        Me.VideoNextPlay_CheckBox.Name = "VideoNextPlay_CheckBox"
        Me.VideoNextPlay_CheckBox.Size = New System.Drawing.Size(189, 17)
        Me.VideoNextPlay_CheckBox.TabIndex = 1
        Me.VideoNextPlay_CheckBox.Text = "Непрерывное воспроизведение"
        Me.VideoNextPlay_CheckBox.UseVisualStyleBackColor = True
        '
        'VideoAutoPlay_CheckBox
        '
        Me.VideoAutoPlay_CheckBox.AutoSize = True
        Me.VideoAutoPlay_CheckBox.Location = New System.Drawing.Point(5, 20)
        Me.VideoAutoPlay_CheckBox.Name = "VideoAutoPlay_CheckBox"
        Me.VideoAutoPlay_CheckBox.Size = New System.Drawing.Size(190, 17)
        Me.VideoAutoPlay_CheckBox.TabIndex = 0
        Me.VideoAutoPlay_CheckBox.Text = "Воспроизводить автоматически"
        Me.VideoAutoPlay_CheckBox.UseVisualStyleBackColor = True
        '
        'VideoList_Label
        '
        Me.VideoList_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VideoList_Label.AutoSize = True
        Me.VideoList_Label.Location = New System.Drawing.Point(643, 5)
        Me.VideoList_Label.Name = "VideoList_Label"
        Me.VideoList_Label.Size = New System.Drawing.Size(140, 13)
        Me.VideoList_Label.TabIndex = 7
        Me.VideoList_Label.Text = "Список воспроизведения:"
        '
        'Exit_Button
        '
        Me.Exit_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Exit_Button.Image = CType(resources.GetObject("Exit_Button.Image"), System.Drawing.Image)
        Me.Exit_Button.Location = New System.Drawing.Point(926, 447)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(97, 23)
        Me.Exit_Button.TabIndex = 12
        Me.Exit_Button.Text = "Выход"
        Me.Exit_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'VideoPlayList_ListBox
        '
        Me.VideoPlayList_ListBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VideoPlayList_ListBox.FormattingEnabled = True
        Me.VideoPlayList_ListBox.Location = New System.Drawing.Point(646, 21)
        Me.VideoPlayList_ListBox.Name = "VideoPlayList_ListBox"
        Me.VideoPlayList_ListBox.Size = New System.Drawing.Size(274, 186)
        Me.VideoPlayList_ListBox.TabIndex = 13
        '
        'VideoPlayListAdd_Button
        '
        Me.VideoPlayListAdd_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VideoPlayListAdd_Button.Image = CType(resources.GetObject("VideoPlayListAdd_Button.Image"), System.Drawing.Image)
        Me.VideoPlayListAdd_Button.Location = New System.Drawing.Point(926, 21)
        Me.VideoPlayListAdd_Button.Name = "VideoPlayListAdd_Button"
        Me.VideoPlayListAdd_Button.Size = New System.Drawing.Size(97, 23)
        Me.VideoPlayListAdd_Button.TabIndex = 8
        Me.VideoPlayListAdd_Button.Text = "Добавить"
        Me.VideoPlayListAdd_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.VideoPlayListAdd_Button.UseVisualStyleBackColor = True
        '
        'VideoPlayListClear_Button
        '
        Me.VideoPlayListClear_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VideoPlayListClear_Button.Image = CType(resources.GetObject("VideoPlayListClear_Button.Image"), System.Drawing.Image)
        Me.VideoPlayListClear_Button.Location = New System.Drawing.Point(926, 79)
        Me.VideoPlayListClear_Button.Name = "VideoPlayListClear_Button"
        Me.VideoPlayListClear_Button.Size = New System.Drawing.Size(97, 23)
        Me.VideoPlayListClear_Button.TabIndex = 9
        Me.VideoPlayListClear_Button.Text = "Очистить"
        Me.VideoPlayListClear_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.VideoPlayListClear_Button.UseVisualStyleBackColor = True
        '
        'VideoPlayListDel_Button
        '
        Me.VideoPlayListDel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VideoPlayListDel_Button.Image = CType(resources.GetObject("VideoPlayListDel_Button.Image"), System.Drawing.Image)
        Me.VideoPlayListDel_Button.Location = New System.Drawing.Point(926, 50)
        Me.VideoPlayListDel_Button.Name = "VideoPlayListDel_Button"
        Me.VideoPlayListDel_Button.Size = New System.Drawing.Size(97, 23)
        Me.VideoPlayListDel_Button.TabIndex = 10
        Me.VideoPlayListDel_Button.Text = "Удалить"
        Me.VideoPlayListDel_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.VideoPlayListDel_Button.UseVisualStyleBackColor = True
        '
        'WindowsMediaPlayer
        '
        Me.WindowsMediaPlayer.Enabled = True
        Me.WindowsMediaPlayer.Location = New System.Drawing.Point(0, 0)
        Me.WindowsMediaPlayer.Name = "WindowsMediaPlayer"
        Me.WindowsMediaPlayer.OcxState = CType(resources.GetObject("WindowsMediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WindowsMediaPlayer.Size = New System.Drawing.Size(637, 482)
        Me.WindowsMediaPlayer.TabIndex = 14
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 482)
        Me.Splitter1.TabIndex = 15
        Me.Splitter1.TabStop = False
        '
        'frmAudioVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 482)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.VideoPlaySettings_Label)
        Me.Controls.Add(Me.VideoList_Label)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.VideoPlayList_ListBox)
        Me.Controls.Add(Me.VideoPlayListAdd_Button)
        Me.Controls.Add(Me.VideoPlayListClear_Button)
        Me.Controls.Add(Me.VideoPlayListDel_Button)
        Me.Controls.Add(Me.WindowsMediaPlayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAudioVideo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Аудио и видео"
        Me.VideoPlaySettings_Label.ResumeLayout(False)
        Me.VideoPlaySettings_Label.PerformLayout()
        CType(Me.WindowsMediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents VideoPlaySettings_Label As GroupBox
    Friend WithEvents VideoNextPlay_CheckBox As CheckBox
    Friend WithEvents VideoAutoPlay_CheckBox As CheckBox
    Friend WithEvents VideoList_Label As Label
    Friend WithEvents Exit_Button As Button
    Friend WithEvents VideoPlayList_ListBox As ListBox
    Friend WithEvents VideoPlayListAdd_Button As Button
    Friend WithEvents VideoPlayListClear_Button As Button
    Friend WithEvents VideoPlayListDel_Button As Button
    Friend WithEvents WindowsMediaPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Splitter1 As Splitter
End Class
