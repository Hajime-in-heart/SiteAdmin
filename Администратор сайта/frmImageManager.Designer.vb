<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImageManager
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImageManager))
        Me.ImageList_Label = New System.Windows.Forms.Label()
        Me.Block_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ImageList_ListBox = New System.Windows.Forms.ListBox()
        Me.AddImageToListBox_Button = New System.Windows.Forms.Button()
        Me.DelImageFromListBox_Button = New System.Windows.Forms.Button()
        Me.EditImageInListBox_Button = New System.Windows.Forms.Button()
        Me.ImageProperties_GroupBox = New System.Windows.Forms.GroupBox()
        Me.ImageAbout_Button = New System.Windows.Forms.Button()
        Me.ImageScale_TrackBar = New System.Windows.Forms.TrackBar()
        Me.ImageScale_Label = New System.Windows.Forms.Label()
        Me.ImageClear_Button = New System.Windows.Forms.Button()
        Me.SaveToListBox_Button = New System.Windows.Forms.Button()
        Me.ImageResolution_Label = New System.Windows.Forms.Label()
        Me.ImageWatch_CheckBox = New System.Windows.Forms.CheckBox()
        Me.ImageWatch_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Comment_TextBox = New System.Windows.Forms.TextBox()
        Me.Comment_Label = New System.Windows.Forms.Label()
        Me.ImageOrientation_GroupBox = New System.Windows.Forms.GroupBox()
        Me.ImageOrientationAlbum_RadioButton = New System.Windows.Forms.RadioButton()
        Me.ImageOrientationBook_RadioButton = New System.Windows.Forms.RadioButton()
        Me.ImageWidth_TextBox = New System.Windows.Forms.TextBox()
        Me.ImageHeight_TextBox = New System.Windows.Forms.TextBox()
        Me.Block_Label = New System.Windows.Forms.Label()
        Me.ImageWidth_Label = New System.Windows.Forms.Label()
        Me.ImageHeight_Label = New System.Windows.Forms.Label()
        Me.ImageOpen_Button = New System.Windows.Forms.Button()
        Me.ImagePathToFile_TextBox = New System.Windows.Forms.TextBox()
        Me.ImagePathToFile_Label = New System.Windows.Forms.Label()
        Me.Alignment_Label = New System.Windows.Forms.Label()
        Me.Alignment_ComboBox = New System.Windows.Forms.ComboBox()
        Me.ImageFIleName_TextBox = New System.Windows.Forms.TextBox()
        Me.ImageName_TextBox = New System.Windows.Forms.TextBox()
        Me.ImageFileName_Label = New System.Windows.Forms.Label()
        Me.ImageName_Label = New System.Windows.Forms.Label()
        Me.Buffer_ListView = New System.Windows.Forms.ListView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.Block_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ImageProperties_GroupBox.SuspendLayout()
        CType(Me.ImageScale_TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageWatch_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ImageOrientation_GroupBox.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList_Label
        '
        Me.ImageList_Label.AutoSize = True
        Me.ImageList_Label.Location = New System.Drawing.Point(5, 8)
        Me.ImageList_Label.Name = "ImageList_Label"
        Me.ImageList_Label.Size = New System.Drawing.Size(115, 13)
        Me.ImageList_Label.TabIndex = 0
        Me.ImageList_Label.Text = "Список изображений"
        '
        'Block_NumericUpDown
        '
        Me.Block_NumericUpDown.Location = New System.Drawing.Point(339, 132)
        Me.Block_NumericUpDown.Name = "Block_NumericUpDown"
        Me.Block_NumericUpDown.Size = New System.Drawing.Size(52, 20)
        Me.Block_NumericUpDown.TabIndex = 1
        '
        'ImageList_ListBox
        '
        Me.ImageList_ListBox.FormattingEnabled = True
        Me.ImageList_ListBox.Location = New System.Drawing.Point(5, 32)
        Me.ImageList_ListBox.Name = "ImageList_ListBox"
        Me.ImageList_ListBox.Size = New System.Drawing.Size(393, 82)
        Me.ImageList_ListBox.TabIndex = 2
        '
        'AddImageToListBox_Button
        '
        Me.AddImageToListBox_Button.Location = New System.Drawing.Point(403, 32)
        Me.AddImageToListBox_Button.Name = "AddImageToListBox_Button"
        Me.AddImageToListBox_Button.Size = New System.Drawing.Size(127, 22)
        Me.AddImageToListBox_Button.TabIndex = 3
        Me.AddImageToListBox_Button.Text = "Добавить"
        Me.AddImageToListBox_Button.UseVisualStyleBackColor = True
        '
        'DelImageFromListBox_Button
        '
        Me.DelImageFromListBox_Button.Location = New System.Drawing.Point(403, 62)
        Me.DelImageFromListBox_Button.Name = "DelImageFromListBox_Button"
        Me.DelImageFromListBox_Button.Size = New System.Drawing.Size(127, 23)
        Me.DelImageFromListBox_Button.TabIndex = 4
        Me.DelImageFromListBox_Button.Text = "Удалить"
        Me.DelImageFromListBox_Button.UseVisualStyleBackColor = True
        '
        'EditImageInListBox_Button
        '
        Me.EditImageInListBox_Button.Location = New System.Drawing.Point(403, 92)
        Me.EditImageInListBox_Button.Name = "EditImageInListBox_Button"
        Me.EditImageInListBox_Button.Size = New System.Drawing.Size(127, 22)
        Me.EditImageInListBox_Button.TabIndex = 5
        Me.EditImageInListBox_Button.Text = "Редактировать"
        Me.EditImageInListBox_Button.UseVisualStyleBackColor = True
        '
        'ImageProperties_GroupBox
        '
        Me.ImageProperties_GroupBox.Controls.Add(Me.ImageAbout_Button)
        Me.ImageProperties_GroupBox.Controls.Add(Me.ImageScale_TrackBar)
        Me.ImageProperties_GroupBox.Controls.Add(Me.ImageScale_Label)
        Me.ImageProperties_GroupBox.Controls.Add(Me.ImageClear_Button)
        Me.ImageProperties_GroupBox.Controls.Add(Me.SaveToListBox_Button)
        Me.ImageProperties_GroupBox.Controls.Add(Me.ImageResolution_Label)
        Me.ImageProperties_GroupBox.Controls.Add(Me.ImageWatch_CheckBox)
        Me.ImageProperties_GroupBox.Controls.Add(Me.ImageWatch_PictureBox)
        Me.ImageProperties_GroupBox.Controls.Add(Me.Comment_TextBox)
        Me.ImageProperties_GroupBox.Controls.Add(Me.Comment_Label)
        Me.ImageProperties_GroupBox.Controls.Add(Me.ImageOrientation_GroupBox)
        Me.ImageProperties_GroupBox.Controls.Add(Me.ImageWidth_TextBox)
        Me.ImageProperties_GroupBox.Controls.Add(Me.ImageHeight_TextBox)
        Me.ImageProperties_GroupBox.Controls.Add(Me.Block_Label)
        Me.ImageProperties_GroupBox.Controls.Add(Me.ImageWidth_Label)
        Me.ImageProperties_GroupBox.Controls.Add(Me.ImageHeight_Label)
        Me.ImageProperties_GroupBox.Controls.Add(Me.ImageOpen_Button)
        Me.ImageProperties_GroupBox.Controls.Add(Me.ImagePathToFile_TextBox)
        Me.ImageProperties_GroupBox.Controls.Add(Me.ImagePathToFile_Label)
        Me.ImageProperties_GroupBox.Controls.Add(Me.Alignment_Label)
        Me.ImageProperties_GroupBox.Controls.Add(Me.Alignment_ComboBox)
        Me.ImageProperties_GroupBox.Controls.Add(Me.ImageFIleName_TextBox)
        Me.ImageProperties_GroupBox.Controls.Add(Me.ImageName_TextBox)
        Me.ImageProperties_GroupBox.Controls.Add(Me.ImageFileName_Label)
        Me.ImageProperties_GroupBox.Controls.Add(Me.ImageName_Label)
        Me.ImageProperties_GroupBox.Controls.Add(Me.Block_NumericUpDown)
        Me.ImageProperties_GroupBox.Controls.Add(Me.Buffer_ListView)
        Me.ImageProperties_GroupBox.Enabled = False
        Me.ImageProperties_GroupBox.Location = New System.Drawing.Point(5, 127)
        Me.ImageProperties_GroupBox.Name = "ImageProperties_GroupBox"
        Me.ImageProperties_GroupBox.Size = New System.Drawing.Size(542, 388)
        Me.ImageProperties_GroupBox.TabIndex = 6
        Me.ImageProperties_GroupBox.TabStop = False
        Me.ImageProperties_GroupBox.Text = "Свойства изображения"
        '
        'ImageAbout_Button
        '
        Me.ImageAbout_Button.Location = New System.Drawing.Point(422, 338)
        Me.ImageAbout_Button.Name = "ImageAbout_Button"
        Me.ImageAbout_Button.Size = New System.Drawing.Size(101, 23)
        Me.ImageAbout_Button.TabIndex = 28
        Me.ImageAbout_Button.Text = "О файле"
        Me.ImageAbout_Button.UseVisualStyleBackColor = True
        Me.ImageAbout_Button.Visible = False
        '
        'ImageScale_TrackBar
        '
        Me.ImageScale_TrackBar.AutoSize = False
        Me.ImageScale_TrackBar.Location = New System.Drawing.Point(412, 138)
        Me.ImageScale_TrackBar.Maximum = 100
        Me.ImageScale_TrackBar.Minimum = 1
        Me.ImageScale_TrackBar.Name = "ImageScale_TrackBar"
        Me.ImageScale_TrackBar.Size = New System.Drawing.Size(121, 29)
        Me.ImageScale_TrackBar.TabIndex = 27
        Me.ImageScale_TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.ImageScale_TrackBar.Value = 10
        Me.ImageScale_TrackBar.Visible = False
        '
        'ImageScale_Label
        '
        Me.ImageScale_Label.AutoSize = True
        Me.ImageScale_Label.Location = New System.Drawing.Point(446, 122)
        Me.ImageScale_Label.Name = "ImageScale_Label"
        Me.ImageScale_Label.Size = New System.Drawing.Size(53, 13)
        Me.ImageScale_Label.TabIndex = 26
        Me.ImageScale_Label.Text = "Масштаб"
        Me.ImageScale_Label.Visible = False
        '
        'ImageClear_Button
        '
        Me.ImageClear_Button.Location = New System.Drawing.Point(424, 50)
        Me.ImageClear_Button.Name = "ImageClear_Button"
        Me.ImageClear_Button.Size = New System.Drawing.Size(101, 22)
        Me.ImageClear_Button.TabIndex = 25
        Me.ImageClear_Button.Text = "Очистить"
        Me.ImageClear_Button.UseVisualStyleBackColor = True
        '
        'SaveToListBox_Button
        '
        Me.SaveToListBox_Button.Location = New System.Drawing.Point(424, 21)
        Me.SaveToListBox_Button.Name = "SaveToListBox_Button"
        Me.SaveToListBox_Button.Size = New System.Drawing.Size(101, 22)
        Me.SaveToListBox_Button.TabIndex = 25
        Me.SaveToListBox_Button.Text = "Сохранить"
        Me.SaveToListBox_Button.UseVisualStyleBackColor = True
        '
        'ImageResolution_Label
        '
        Me.ImageResolution_Label.Location = New System.Drawing.Point(412, 299)
        Me.ImageResolution_Label.Name = "ImageResolution_Label"
        Me.ImageResolution_Label.Size = New System.Drawing.Size(122, 20)
        Me.ImageResolution_Label.TabIndex = 24
        Me.ImageResolution_Label.Text = "Разрешение"
        Me.ImageResolution_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ImageResolution_Label.Visible = False
        '
        'ImageWatch_CheckBox
        '
        Me.ImageWatch_CheckBox.Location = New System.Drawing.Point(415, 90)
        Me.ImageWatch_CheckBox.Name = "ImageWatch_CheckBox"
        Me.ImageWatch_CheckBox.Size = New System.Drawing.Size(119, 28)
        Me.ImageWatch_CheckBox.TabIndex = 7
        Me.ImageWatch_CheckBox.Text = "Просмотр"
        Me.ImageWatch_CheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ImageWatch_CheckBox.UseVisualStyleBackColor = True
        Me.ImageWatch_CheckBox.Visible = False
        '
        'ImageWatch_PictureBox
        '
        Me.ImageWatch_PictureBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ImageWatch_PictureBox.InitialImage = Nothing
        Me.ImageWatch_PictureBox.Location = New System.Drawing.Point(412, 173)
        Me.ImageWatch_PictureBox.Name = "ImageWatch_PictureBox"
        Me.ImageWatch_PictureBox.Size = New System.Drawing.Size(122, 123)
        Me.ImageWatch_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageWatch_PictureBox.TabIndex = 23
        Me.ImageWatch_PictureBox.TabStop = False
        Me.ImageWatch_PictureBox.Visible = False
        '
        'Comment_TextBox
        '
        Me.Comment_TextBox.Location = New System.Drawing.Point(15, 228)
        Me.Comment_TextBox.Multiline = True
        Me.Comment_TextBox.Name = "Comment_TextBox"
        Me.Comment_TextBox.Size = New System.Drawing.Size(379, 52)
        Me.Comment_TextBox.TabIndex = 22
        '
        'Comment_Label
        '
        Me.Comment_Label.AutoSize = True
        Me.Comment_Label.Location = New System.Drawing.Point(15, 212)
        Me.Comment_Label.Name = "Comment_Label"
        Me.Comment_Label.Size = New System.Drawing.Size(77, 13)
        Me.Comment_Label.TabIndex = 7
        Me.Comment_Label.Text = "Комментарий"
        '
        'ImageOrientation_GroupBox
        '
        Me.ImageOrientation_GroupBox.Controls.Add(Me.ImageOrientationAlbum_RadioButton)
        Me.ImageOrientation_GroupBox.Controls.Add(Me.ImageOrientationBook_RadioButton)
        Me.ImageOrientation_GroupBox.Location = New System.Drawing.Point(15, 166)
        Me.ImageOrientation_GroupBox.Name = "ImageOrientation_GroupBox"
        Me.ImageOrientation_GroupBox.Size = New System.Drawing.Size(377, 43)
        Me.ImageOrientation_GroupBox.TabIndex = 21
        Me.ImageOrientation_GroupBox.TabStop = False
        Me.ImageOrientation_GroupBox.Text = "Ориентация"
        '
        'ImageOrientationAlbum_RadioButton
        '
        Me.ImageOrientationAlbum_RadioButton.AutoSize = True
        Me.ImageOrientationAlbum_RadioButton.Location = New System.Drawing.Point(279, 19)
        Me.ImageOrientationAlbum_RadioButton.Name = "ImageOrientationAlbum_RadioButton"
        Me.ImageOrientationAlbum_RadioButton.Size = New System.Drawing.Size(82, 17)
        Me.ImageOrientationAlbum_RadioButton.TabIndex = 1
        Me.ImageOrientationAlbum_RadioButton.TabStop = True
        Me.ImageOrientationAlbum_RadioButton.Text = "Альбомная"
        Me.ImageOrientationAlbum_RadioButton.UseVisualStyleBackColor = True
        '
        'ImageOrientationBook_RadioButton
        '
        Me.ImageOrientationBook_RadioButton.AutoSize = True
        Me.ImageOrientationBook_RadioButton.Location = New System.Drawing.Point(22, 19)
        Me.ImageOrientationBook_RadioButton.Name = "ImageOrientationBook_RadioButton"
        Me.ImageOrientationBook_RadioButton.Size = New System.Drawing.Size(70, 17)
        Me.ImageOrientationBook_RadioButton.TabIndex = 0
        Me.ImageOrientationBook_RadioButton.TabStop = True
        Me.ImageOrientationBook_RadioButton.Text = "Книжная"
        Me.ImageOrientationBook_RadioButton.UseVisualStyleBackColor = True
        '
        'ImageWidth_TextBox
        '
        Me.ImageWidth_TextBox.Location = New System.Drawing.Point(212, 131)
        Me.ImageWidth_TextBox.Name = "ImageWidth_TextBox"
        Me.ImageWidth_TextBox.Size = New System.Drawing.Size(55, 20)
        Me.ImageWidth_TextBox.TabIndex = 20
        '
        'ImageHeight_TextBox
        '
        Me.ImageHeight_TextBox.Location = New System.Drawing.Point(63, 131)
        Me.ImageHeight_TextBox.Name = "ImageHeight_TextBox"
        Me.ImageHeight_TextBox.Size = New System.Drawing.Size(55, 20)
        Me.ImageHeight_TextBox.TabIndex = 19
        '
        'Block_Label
        '
        Me.Block_Label.Location = New System.Drawing.Point(299, 129)
        Me.Block_Label.Name = "Block_Label"
        Me.Block_Label.Size = New System.Drawing.Size(35, 22)
        Me.Block_Label.TabIndex = 18
        Me.Block_Label.Text = "Блок"
        Me.Block_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageWidth_Label
        '
        Me.ImageWidth_Label.Location = New System.Drawing.Point(159, 131)
        Me.ImageWidth_Label.Name = "ImageWidth_Label"
        Me.ImageWidth_Label.Size = New System.Drawing.Size(47, 20)
        Me.ImageWidth_Label.TabIndex = 17
        Me.ImageWidth_Label.Text = "Ширина"
        Me.ImageWidth_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageHeight_Label
        '
        Me.ImageHeight_Label.Location = New System.Drawing.Point(6, 131)
        Me.ImageHeight_Label.Name = "ImageHeight_Label"
        Me.ImageHeight_Label.Size = New System.Drawing.Size(50, 18)
        Me.ImageHeight_Label.TabIndex = 16
        Me.ImageHeight_Label.Text = "Высота"
        Me.ImageHeight_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageOpen_Button
        '
        Me.ImageOpen_Button.Location = New System.Drawing.Point(339, 50)
        Me.ImageOpen_Button.Name = "ImageOpen_Button"
        Me.ImageOpen_Button.Size = New System.Drawing.Size(54, 20)
        Me.ImageOpen_Button.TabIndex = 15
        Me.ImageOpen_Button.Text = "Обзор..."
        Me.ImageOpen_Button.UseVisualStyleBackColor = True
        '
        'ImagePathToFile_TextBox
        '
        Me.ImagePathToFile_TextBox.Location = New System.Drawing.Point(63, 102)
        Me.ImagePathToFile_TextBox.Name = "ImagePathToFile_TextBox"
        Me.ImagePathToFile_TextBox.Size = New System.Drawing.Size(330, 20)
        Me.ImagePathToFile_TextBox.TabIndex = 14
        '
        'ImagePathToFile_Label
        '
        Me.ImagePathToFile_Label.Location = New System.Drawing.Point(6, 101)
        Me.ImagePathToFile_Label.Name = "ImagePathToFile_Label"
        Me.ImagePathToFile_Label.Size = New System.Drawing.Size(47, 20)
        Me.ImagePathToFile_Label.TabIndex = 13
        Me.ImagePathToFile_Label.Text = "Ссылка"
        Me.ImagePathToFile_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Alignment_Label
        '
        Me.Alignment_Label.Location = New System.Drawing.Point(6, 74)
        Me.Alignment_Label.Name = "Alignment_Label"
        Me.Alignment_Label.Size = New System.Drawing.Size(82, 20)
        Me.Alignment_Label.TabIndex = 12
        Me.Alignment_Label.Text = "Выравнивание"
        Me.Alignment_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Alignment_ComboBox
        '
        Me.Alignment_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Alignment_ComboBox.FormattingEnabled = True
        Me.Alignment_ComboBox.Items.AddRange(New Object() {"По левому краю", "По центру", "По правому краю"})
        Me.Alignment_ComboBox.Location = New System.Drawing.Point(95, 75)
        Me.Alignment_ComboBox.Name = "Alignment_ComboBox"
        Me.Alignment_ComboBox.Size = New System.Drawing.Size(298, 21)
        Me.Alignment_ComboBox.TabIndex = 11
        '
        'ImageFIleName_TextBox
        '
        Me.ImageFIleName_TextBox.Location = New System.Drawing.Point(63, 50)
        Me.ImageFIleName_TextBox.Name = "ImageFIleName_TextBox"
        Me.ImageFIleName_TextBox.Size = New System.Drawing.Size(271, 20)
        Me.ImageFIleName_TextBox.TabIndex = 10
        '
        'ImageName_TextBox
        '
        Me.ImageName_TextBox.Location = New System.Drawing.Point(63, 23)
        Me.ImageName_TextBox.Name = "ImageName_TextBox"
        Me.ImageName_TextBox.Size = New System.Drawing.Size(331, 20)
        Me.ImageName_TextBox.TabIndex = 9
        '
        'ImageFileName_Label
        '
        Me.ImageFileName_Label.Location = New System.Drawing.Point(6, 49)
        Me.ImageFileName_Label.Name = "ImageFileName_Label"
        Me.ImageFileName_Label.Size = New System.Drawing.Size(43, 20)
        Me.ImageFileName_Label.TabIndex = 8
        Me.ImageFileName_Label.Text = "Файл"
        Me.ImageFileName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageName_Label
        '
        Me.ImageName_Label.Location = New System.Drawing.Point(7, 23)
        Me.ImageName_Label.Name = "ImageName_Label"
        Me.ImageName_Label.Size = New System.Drawing.Size(43, 19)
        Me.ImageName_Label.TabIndex = 7
        Me.ImageName_Label.Text = "Имя"
        Me.ImageName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Buffer_ListView
        '
        Me.Buffer_ListView.GridLines = True
        Me.Buffer_ListView.HideSelection = False
        Me.Buffer_ListView.Location = New System.Drawing.Point(75, 29)
        Me.Buffer_ListView.MultiSelect = False
        Me.Buffer_ListView.Name = "Buffer_ListView"
        Me.Buffer_ListView.Size = New System.Drawing.Size(303, 14)
        Me.Buffer_ListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.Buffer_ListView.TabIndex = 7
        Me.Buffer_ListView.UseCompatibleStateImageBehavior = False
        Me.Buffer_ListView.View = System.Windows.Forms.View.Details
        Me.Buffer_ListView.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmImageManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 513)
        Me.Controls.Add(Me.ImageProperties_GroupBox)
        Me.Controls.Add(Me.EditImageInListBox_Button)
        Me.Controls.Add(Me.DelImageFromListBox_Button)
        Me.Controls.Add(Me.AddImageToListBox_Button)
        Me.Controls.Add(Me.ImageList_ListBox)
        Me.Controls.Add(Me.ImageList_Label)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImageManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Редактор изображений"
        CType(Me.Block_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ImageProperties_GroupBox.ResumeLayout(False)
        Me.ImageProperties_GroupBox.PerformLayout()
        CType(Me.ImageScale_TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageWatch_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ImageOrientation_GroupBox.ResumeLayout(False)
        Me.ImageOrientation_GroupBox.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImageList_Label As Label
    Friend WithEvents Block_NumericUpDown As NumericUpDown
    Friend WithEvents ImageList_ListBox As ListBox
    Friend WithEvents AddImageToListBox_Button As Button
    Friend WithEvents DelImageFromListBox_Button As Button
    Friend WithEvents EditImageInListBox_Button As Button
    Friend WithEvents ImageProperties_GroupBox As GroupBox
    Friend WithEvents ImageOpen_Button As Button
    Friend WithEvents ImagePathToFile_TextBox As TextBox
    Friend WithEvents ImagePathToFile_Label As Label
    Friend WithEvents Alignment_Label As Label
    Friend WithEvents Alignment_ComboBox As ComboBox
    Friend WithEvents ImageFIleName_TextBox As TextBox
    Friend WithEvents ImageName_TextBox As TextBox
    Friend WithEvents ImageFileName_Label As Label
    Friend WithEvents ImageName_Label As Label
    Friend WithEvents ImageWidth_TextBox As TextBox
    Friend WithEvents ImageHeight_TextBox As TextBox
    Friend WithEvents Block_Label As Label
    Friend WithEvents ImageWidth_Label As Label
    Friend WithEvents ImageHeight_Label As Label
    Friend WithEvents ImageOrientation_GroupBox As GroupBox
    Friend WithEvents ImageOrientationAlbum_RadioButton As RadioButton
    Friend WithEvents ImageOrientationBook_RadioButton As RadioButton
    Friend WithEvents ImageResolution_Label As Label
    Friend WithEvents ImageWatch_CheckBox As CheckBox
    Friend WithEvents ImageWatch_PictureBox As PictureBox
    Friend WithEvents Comment_TextBox As TextBox
    Friend WithEvents Comment_Label As Label
    Friend WithEvents ImageClear_Button As Button
    Friend WithEvents SaveToListBox_Button As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Buffer_ListView As ListView
    Friend WithEvents ImageScale_TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents ImageScale_Label As Label
    Friend WithEvents ImageAbout_Button As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
