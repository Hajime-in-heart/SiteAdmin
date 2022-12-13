<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFileInfo))
        Me.FileNameLabel_Label = New System.Windows.Forms.Label()
        Me.FIleName_Label = New System.Windows.Forms.Label()
        Me.FileSizeLabel_Label = New System.Windows.Forms.Label()
        Me.FileSize_Label = New System.Windows.Forms.Label()
        Me.FileDateLabel_Label = New System.Windows.Forms.Label()
        Me.FileDate_Label = New System.Windows.Forms.Label()
        Me.Attributes_GroupBox = New System.Windows.Forms.GroupBox()
        Me.AttributesReadOnly_CheckBox = New System.Windows.Forms.CheckBox()
        Me.AttributesNotContentIndexed_CheckBox = New System.Windows.Forms.CheckBox()
        Me.AttributesEncrypted_CheckBox = New System.Windows.Forms.CheckBox()
        Me.AttributesCompressed_CheckBox = New System.Windows.Forms.CheckBox()
        Me.AttributesTemporary_CheckBox = New System.Windows.Forms.CheckBox()
        Me.AttributesHidden_CheckBox = New System.Windows.Forms.CheckBox()
        Me.AttributesSystem_CheckBox = New System.Windows.Forms.CheckBox()
        Me.AttributesArchive_CheckBox = New System.Windows.Forms.CheckBox()
        Me.AttributesNormal_CheckBox = New System.Windows.Forms.CheckBox()
        Me.SaveAttributes_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Attributes_GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileNameLabel_Label
        '
        Me.FileNameLabel_Label.AutoSize = True
        Me.FileNameLabel_Label.Location = New System.Drawing.Point(10, 9)
        Me.FileNameLabel_Label.Name = "FileNameLabel_Label"
        Me.FileNameLabel_Label.Size = New System.Drawing.Size(29, 13)
        Me.FileNameLabel_Label.TabIndex = 0
        Me.FileNameLabel_Label.Text = "Имя"
        '
        'FIleName_Label
        '
        Me.FIleName_Label.AutoSize = True
        Me.FIleName_Label.Location = New System.Drawing.Point(158, 9)
        Me.FIleName_Label.Name = "FIleName_Label"
        Me.FIleName_Label.Size = New System.Drawing.Size(39, 13)
        Me.FIleName_Label.TabIndex = 1
        Me.FIleName_Label.Text = "Label2"
        '
        'FileSizeLabel_Label
        '
        Me.FileSizeLabel_Label.AutoSize = True
        Me.FileSizeLabel_Label.Location = New System.Drawing.Point(10, 37)
        Me.FileSizeLabel_Label.Name = "FileSizeLabel_Label"
        Me.FileSizeLabel_Label.Size = New System.Drawing.Size(46, 13)
        Me.FileSizeLabel_Label.TabIndex = 2
        Me.FileSizeLabel_Label.Text = "Размер"
        '
        'FileSize_Label
        '
        Me.FileSize_Label.AutoSize = True
        Me.FileSize_Label.Location = New System.Drawing.Point(158, 37)
        Me.FileSize_Label.Name = "FileSize_Label"
        Me.FileSize_Label.Size = New System.Drawing.Size(39, 13)
        Me.FileSize_Label.TabIndex = 3
        Me.FileSize_Label.Text = "Label4"
        '
        'FileDateLabel_Label
        '
        Me.FileDateLabel_Label.AutoSize = True
        Me.FileDateLabel_Label.Location = New System.Drawing.Point(10, 64)
        Me.FileDateLabel_Label.Name = "FileDateLabel_Label"
        Me.FileDateLabel_Label.Size = New System.Drawing.Size(84, 13)
        Me.FileDateLabel_Label.TabIndex = 4
        Me.FileDateLabel_Label.Text = "Дата создания"
        '
        'FileDate_Label
        '
        Me.FileDate_Label.AutoSize = True
        Me.FileDate_Label.Location = New System.Drawing.Point(158, 64)
        Me.FileDate_Label.Name = "FileDate_Label"
        Me.FileDate_Label.Size = New System.Drawing.Size(39, 13)
        Me.FileDate_Label.TabIndex = 5
        Me.FileDate_Label.Text = "Label6"
        '
        'Attributes_GroupBox
        '
        Me.Attributes_GroupBox.Controls.Add(Me.AttributesReadOnly_CheckBox)
        Me.Attributes_GroupBox.Controls.Add(Me.AttributesNotContentIndexed_CheckBox)
        Me.Attributes_GroupBox.Controls.Add(Me.AttributesEncrypted_CheckBox)
        Me.Attributes_GroupBox.Controls.Add(Me.AttributesCompressed_CheckBox)
        Me.Attributes_GroupBox.Controls.Add(Me.AttributesTemporary_CheckBox)
        Me.Attributes_GroupBox.Controls.Add(Me.AttributesHidden_CheckBox)
        Me.Attributes_GroupBox.Controls.Add(Me.AttributesSystem_CheckBox)
        Me.Attributes_GroupBox.Controls.Add(Me.AttributesArchive_CheckBox)
        Me.Attributes_GroupBox.Controls.Add(Me.AttributesNormal_CheckBox)
        Me.Attributes_GroupBox.Location = New System.Drawing.Point(12, 98)
        Me.Attributes_GroupBox.Name = "Attributes_GroupBox"
        Me.Attributes_GroupBox.Size = New System.Drawing.Size(394, 89)
        Me.Attributes_GroupBox.TabIndex = 6
        Me.Attributes_GroupBox.TabStop = False
        Me.Attributes_GroupBox.Text = "Атрибуты"
        '
        'AttributesReadOnly_CheckBox
        '
        Me.AttributesReadOnly_CheckBox.AutoSize = True
        Me.AttributesReadOnly_CheckBox.Location = New System.Drawing.Point(238, 65)
        Me.AttributesReadOnly_CheckBox.Name = "AttributesReadOnly_CheckBox"
        Me.AttributesReadOnly_CheckBox.Size = New System.Drawing.Size(121, 17)
        Me.AttributesReadOnly_CheckBox.TabIndex = 18
        Me.AttributesReadOnly_CheckBox.Text = "Только для чтения"
        Me.AttributesReadOnly_CheckBox.UseVisualStyleBackColor = True
        '
        'AttributesNotContentIndexed_CheckBox
        '
        Me.AttributesNotContentIndexed_CheckBox.AutoSize = True
        Me.AttributesNotContentIndexed_CheckBox.Location = New System.Drawing.Point(238, 42)
        Me.AttributesNotContentIndexed_CheckBox.Name = "AttributesNotContentIndexed_CheckBox"
        Me.AttributesNotContentIndexed_CheckBox.Size = New System.Drawing.Size(150, 17)
        Me.AttributesNotContentIndexed_CheckBox.TabIndex = 17
        Me.AttributesNotContentIndexed_CheckBox.Text = "Непроиндексированный"
        Me.AttributesNotContentIndexed_CheckBox.UseVisualStyleBackColor = True
        '
        'AttributesEncrypted_CheckBox
        '
        Me.AttributesEncrypted_CheckBox.AutoSize = True
        Me.AttributesEncrypted_CheckBox.Location = New System.Drawing.Point(238, 19)
        Me.AttributesEncrypted_CheckBox.Name = "AttributesEncrypted_CheckBox"
        Me.AttributesEncrypted_CheckBox.Size = New System.Drawing.Size(111, 17)
        Me.AttributesEncrypted_CheckBox.TabIndex = 16
        Me.AttributesEncrypted_CheckBox.Text = "Зашифрованный"
        Me.AttributesEncrypted_CheckBox.UseVisualStyleBackColor = True
        '
        'AttributesCompressed_CheckBox
        '
        Me.AttributesCompressed_CheckBox.AutoSize = True
        Me.AttributesCompressed_CheckBox.Location = New System.Drawing.Point(127, 65)
        Me.AttributesCompressed_CheckBox.Name = "AttributesCompressed_CheckBox"
        Me.AttributesCompressed_CheckBox.Size = New System.Drawing.Size(66, 17)
        Me.AttributesCompressed_CheckBox.TabIndex = 15
        Me.AttributesCompressed_CheckBox.Text = "Сжатый"
        Me.AttributesCompressed_CheckBox.UseVisualStyleBackColor = True
        '
        'AttributesTemporary_CheckBox
        '
        Me.AttributesTemporary_CheckBox.AutoSize = True
        Me.AttributesTemporary_CheckBox.Location = New System.Drawing.Point(127, 42)
        Me.AttributesTemporary_CheckBox.Name = "AttributesTemporary_CheckBox"
        Me.AttributesTemporary_CheckBox.Size = New System.Drawing.Size(85, 17)
        Me.AttributesTemporary_CheckBox.TabIndex = 14
        Me.AttributesTemporary_CheckBox.Text = "Временный"
        Me.AttributesTemporary_CheckBox.UseVisualStyleBackColor = True
        '
        'AttributesHidden_CheckBox
        '
        Me.AttributesHidden_CheckBox.AutoSize = True
        Me.AttributesHidden_CheckBox.Location = New System.Drawing.Point(127, 19)
        Me.AttributesHidden_CheckBox.Name = "AttributesHidden_CheckBox"
        Me.AttributesHidden_CheckBox.Size = New System.Drawing.Size(72, 17)
        Me.AttributesHidden_CheckBox.TabIndex = 13
        Me.AttributesHidden_CheckBox.Text = "Скрытый"
        Me.AttributesHidden_CheckBox.UseVisualStyleBackColor = True
        '
        'AttributesSystem_CheckBox
        '
        Me.AttributesSystem_CheckBox.AutoSize = True
        Me.AttributesSystem_CheckBox.Location = New System.Drawing.Point(6, 65)
        Me.AttributesSystem_CheckBox.Name = "AttributesSystem_CheckBox"
        Me.AttributesSystem_CheckBox.Size = New System.Drawing.Size(84, 17)
        Me.AttributesSystem_CheckBox.TabIndex = 12
        Me.AttributesSystem_CheckBox.Text = "Системный"
        Me.AttributesSystem_CheckBox.UseVisualStyleBackColor = True
        '
        'AttributesArchive_CheckBox
        '
        Me.AttributesArchive_CheckBox.AutoSize = True
        Me.AttributesArchive_CheckBox.Location = New System.Drawing.Point(6, 42)
        Me.AttributesArchive_CheckBox.Name = "AttributesArchive_CheckBox"
        Me.AttributesArchive_CheckBox.Size = New System.Drawing.Size(76, 17)
        Me.AttributesArchive_CheckBox.TabIndex = 11
        Me.AttributesArchive_CheckBox.Text = "Архивный"
        Me.AttributesArchive_CheckBox.UseVisualStyleBackColor = True
        '
        'AttributesNormal_CheckBox
        '
        Me.AttributesNormal_CheckBox.AutoSize = True
        Me.AttributesNormal_CheckBox.Location = New System.Drawing.Point(6, 19)
        Me.AttributesNormal_CheckBox.Name = "AttributesNormal_CheckBox"
        Me.AttributesNormal_CheckBox.Size = New System.Drawing.Size(73, 17)
        Me.AttributesNormal_CheckBox.TabIndex = 10
        Me.AttributesNormal_CheckBox.Text = "Обычный"
        Me.AttributesNormal_CheckBox.UseVisualStyleBackColor = True
        '
        'SaveAttributes_Button
        '
        Me.SaveAttributes_Button.Location = New System.Drawing.Point(12, 204)
        Me.SaveAttributes_Button.Name = "SaveAttributes_Button"
        Me.SaveAttributes_Button.Size = New System.Drawing.Size(132, 23)
        Me.SaveAttributes_Button.TabIndex = 7
        Me.SaveAttributes_Button.Text = "Сохранить атрибуты"
        Me.SaveAttributes_Button.UseVisualStyleBackColor = True
        '
        'OK_Button
        '
        Me.OK_Button.Location = New System.Drawing.Point(250, 204)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(75, 23)
        Me.OK_Button.TabIndex = 8
        Me.OK_Button.Text = "ОК"
        Me.OK_Button.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(331, 204)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_Button.TabIndex = 9
        Me.Cancel_Button.Text = "Отмена"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'frmFileInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 237)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.SaveAttributes_Button)
        Me.Controls.Add(Me.Attributes_GroupBox)
        Me.Controls.Add(Me.FileDate_Label)
        Me.Controls.Add(Me.FileDateLabel_Label)
        Me.Controls.Add(Me.FileSize_Label)
        Me.Controls.Add(Me.FileSizeLabel_Label)
        Me.Controls.Add(Me.FIleName_Label)
        Me.Controls.Add(Me.FileNameLabel_Label)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFileInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Сведения о файле"
        Me.Attributes_GroupBox.ResumeLayout(False)
        Me.Attributes_GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileNameLabel_Label As Label
    Friend WithEvents FIleName_Label As Label
    Friend WithEvents FileSizeLabel_Label As Label
    Friend WithEvents FileSize_Label As Label
    Friend WithEvents FileDateLabel_Label As Label
    Friend WithEvents FileDate_Label As Label
    Friend WithEvents Attributes_GroupBox As GroupBox
    Friend WithEvents AttributesReadOnly_CheckBox As CheckBox
    Friend WithEvents AttributesNotContentIndexed_CheckBox As CheckBox
    Friend WithEvents AttributesEncrypted_CheckBox As CheckBox
    Friend WithEvents AttributesCompressed_CheckBox As CheckBox
    Friend WithEvents AttributesTemporary_CheckBox As CheckBox
    Friend WithEvents AttributesHidden_CheckBox As CheckBox
    Friend WithEvents AttributesSystem_CheckBox As CheckBox
    Friend WithEvents AttributesArchive_CheckBox As CheckBox
    Friend WithEvents AttributesNormal_CheckBox As CheckBox
    Friend WithEvents SaveAttributes_Button As Button
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
End Class
