<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnimation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnimation))
        Me.Play_Button = New System.Windows.Forms.Button()
        Me.Exit_Buttom = New System.Windows.Forms.Button()
        Me.OpenFile_Button = New System.Windows.Forms.Button()
        Me.FileName_Textbox = New System.Windows.Forms.TextBox()
        Me.FileName_Label = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GIF_PictureBox = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.GIF_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Play_Button
        '
        Me.Play_Button.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Play_Button.Image = CType(resources.GetObject("Play_Button.Image"), System.Drawing.Image)
        Me.Play_Button.Location = New System.Drawing.Point(370, 159)
        Me.Play_Button.Name = "Play_Button"
        Me.Play_Button.Size = New System.Drawing.Size(93, 23)
        Me.Play_Button.TabIndex = 11
        Me.Play_Button.Text = "Старт"
        Me.Play_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Play_Button.UseVisualStyleBackColor = True
        '
        'Exit_Buttom
        '
        Me.Exit_Buttom.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Exit_Buttom.Image = CType(resources.GetObject("Exit_Buttom.Image"), System.Drawing.Image)
        Me.Exit_Buttom.Location = New System.Drawing.Point(370, 188)
        Me.Exit_Buttom.Name = "Exit_Buttom"
        Me.Exit_Buttom.Size = New System.Drawing.Size(93, 23)
        Me.Exit_Buttom.TabIndex = 12
        Me.Exit_Buttom.Text = "Выход"
        Me.Exit_Buttom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Exit_Buttom.UseVisualStyleBackColor = True
        '
        'OpenFile_Button
        '
        Me.OpenFile_Button.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.OpenFile_Button.Location = New System.Drawing.Point(413, 4)
        Me.OpenFile_Button.Name = "OpenFile_Button"
        Me.OpenFile_Button.Size = New System.Drawing.Size(50, 23)
        Me.OpenFile_Button.TabIndex = 10
        Me.OpenFile_Button.Text = "..."
        Me.OpenFile_Button.UseVisualStyleBackColor = True
        '
        'FileName_Textbox
        '
        Me.FileName_Textbox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FileName_Textbox.Location = New System.Drawing.Point(79, 6)
        Me.FileName_Textbox.Name = "FileName_Textbox"
        Me.FileName_Textbox.Size = New System.Drawing.Size(328, 20)
        Me.FileName_Textbox.TabIndex = 9
        '
        'FileName_Label
        '
        Me.FileName_Label.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FileName_Label.AutoSize = True
        Me.FileName_Label.Location = New System.Drawing.Point(9, 9)
        Me.FileName_Label.Name = "FileName_Label"
        Me.FileName_Label.Size = New System.Drawing.Size(64, 13)
        Me.FileName_Label.TabIndex = 8
        Me.FileName_Label.Text = "Имя файла"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'GIF_PictureBox
        '
        Me.GIF_PictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GIF_PictureBox.Location = New System.Drawing.Point(12, 32)
        Me.GIF_PictureBox.Name = "GIF_PictureBox"
        Me.GIF_PictureBox.Size = New System.Drawing.Size(352, 309)
        Me.GIF_PictureBox.TabIndex = 13
        Me.GIF_PictureBox.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-¦-¦-TБ¦¬TА¦-¦¬¦¬¦-¦¦¦+¦¦¦-¦¬¦¦-16.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8-¦¬¦-TГ¦¬¦--16.png")
        '
        'frmAnimation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 381)
        Me.Controls.Add(Me.GIF_PictureBox)
        Me.Controls.Add(Me.Play_Button)
        Me.Controls.Add(Me.Exit_Buttom)
        Me.Controls.Add(Me.OpenFile_Button)
        Me.Controls.Add(Me.FileName_Textbox)
        Me.Controls.Add(Me.FileName_Label)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAnimation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Анимация"
        CType(Me.GIF_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Play_Button As Button
    Friend WithEvents Exit_Buttom As Button
    Friend WithEvents OpenFile_Button As Button
    Friend WithEvents FileName_Textbox As TextBox
    Friend WithEvents FileName_Label As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GIF_PictureBox As PictureBox
    Friend WithEvents ImageList1 As ImageList
End Class
