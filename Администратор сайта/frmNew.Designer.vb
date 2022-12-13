<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNew
    Inherits frmNewItem.frmNewItem

    'Форма переопределяет dispose для очистки списка компонент.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form. 
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Name_Label = New System.Windows.Forms.Label()
        Me.Name_TextBox = New System.Windows.Forms.TextBox()
        Me.LInk_Label = New System.Windows.Forms.Label()
        Me.Link_TextBox = New System.Windows.Forms.TextBox()
        Me.Index_Label = New System.Windows.Forms.Label()
        Me.Index_TextBox = New System.Windows.Forms.TextBox()
        Me.Create_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Name_Label
        '
        Me.Name_Label.AutoSize = True
        Me.Name_Label.Location = New System.Drawing.Point(12, 15)
        Me.Name_Label.Name = "Name_Label"
        Me.Name_Label.Size = New System.Drawing.Size(83, 13)
        Me.Name_Label.TabIndex = 0
        Me.Name_Label.Text = "Наименование"
        '
        'Name_TextBox
        '
        Me.Name_TextBox.Location = New System.Drawing.Point(101, 12)
        Me.Name_TextBox.Name = "Name_TextBox"
        Me.Name_TextBox.Size = New System.Drawing.Size(271, 20)
        Me.Name_TextBox.TabIndex = 1
        '
        'LInk_Label
        '
        Me.LInk_Label.AutoSize = True
        Me.LInk_Label.Location = New System.Drawing.Point(12, 41)
        Me.LInk_Label.Name = "LInk_Label"
        Me.LInk_Label.Size = New System.Drawing.Size(46, 13)
        Me.LInk_Label.TabIndex = 0
        Me.LInk_Label.Text = "Ссылка"
        '
        'Link_TextBox
        '
        Me.Link_TextBox.Location = New System.Drawing.Point(101, 38)
        Me.Link_TextBox.Name = "Link_TextBox"
        Me.Link_TextBox.Size = New System.Drawing.Size(271, 20)
        Me.Link_TextBox.TabIndex = 1
        '
        'Index_Label
        '
        Me.Index_Label.AutoSize = True
        Me.Index_Label.Location = New System.Drawing.Point(12, 67)
        Me.Index_Label.Name = "Index_Label"
        Me.Index_Label.Size = New System.Drawing.Size(77, 13)
        Me.Index_Label.TabIndex = 0
        Me.Index_Label.Text = "Индекс сайта"
        '
        'Index_TextBox
        '
        Me.Index_TextBox.Location = New System.Drawing.Point(101, 64)
        Me.Index_TextBox.Name = "Index_TextBox"
        Me.Index_TextBox.Size = New System.Drawing.Size(271, 20)
        Me.Index_TextBox.TabIndex = 1
        '
        'Create_Button
        '
        Me.Create_Button.Location = New System.Drawing.Point(297, 100)
        Me.Create_Button.Name = "Create_Button"
        Me.Create_Button.Size = New System.Drawing.Size(75, 23)
        Me.Create_Button.TabIndex = 2
        Me.Create_Button.Text = "Создать"
        Me.Create_Button.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(12, 100)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_Button.TabIndex = 3
        Me.Cancel_Button.Text = "Отмена"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'frmNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(380, 127)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Create_Button)
        Me.Controls.Add(Me.Index_TextBox)
        Me.Controls.Add(Me.Index_Label)
        Me.Controls.Add(Me.Link_TextBox)
        Me.Controls.Add(Me.LInk_Label)
        Me.Controls.Add(Me.Name_TextBox)
        Me.Controls.Add(Me.Name_Label)
        Me.Name = "frmNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Name_Label As System.Windows.Forms.Label
    Friend WithEvents Name_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents LInk_Label As System.Windows.Forms.Label
    Friend WithEvents Link_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Index_Label As System.Windows.Forms.Label
    Friend WithEvents Index_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Create_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button

End Class
