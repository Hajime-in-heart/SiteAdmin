<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEdit))
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Edit_Button = New System.Windows.Forms.Button()
        Me.Index_TextBox = New System.Windows.Forms.TextBox()
        Me.Index_Label = New System.Windows.Forms.Label()
        Me.Name_TextBox = New System.Windows.Forms.TextBox()
        Me.Name_Label = New System.Windows.Forms.Label()
        Me.LInk_Label = New System.Windows.Forms.Label()
        Me.Link_TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(12, 90)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_Button.TabIndex = 11
        Me.Cancel_Button.Text = "Отмена"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'Edit_Button
        '
        Me.Edit_Button.Location = New System.Drawing.Point(297, 90)
        Me.Edit_Button.Name = "Edit_Button"
        Me.Edit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Edit_Button.TabIndex = 10
        Me.Edit_Button.Text = "Сохранить"
        Me.Edit_Button.UseVisualStyleBackColor = True
        '
        'Index_TextBox
        '
        Me.Index_TextBox.Enabled = False
        Me.Index_TextBox.Location = New System.Drawing.Point(101, 38)
        Me.Index_TextBox.Name = "Index_TextBox"
        Me.Index_TextBox.Size = New System.Drawing.Size(271, 20)
        Me.Index_TextBox.TabIndex = 7
        '
        'Index_Label
        '
        Me.Index_Label.AutoSize = True
        Me.Index_Label.Location = New System.Drawing.Point(12, 41)
        Me.Index_Label.Name = "Index_Label"
        Me.Index_Label.Size = New System.Drawing.Size(77, 13)
        Me.Index_Label.TabIndex = 4
        Me.Index_Label.Text = "Индекс сайта"
        '
        'Name_TextBox
        '
        Me.Name_TextBox.Location = New System.Drawing.Point(101, 12)
        Me.Name_TextBox.Name = "Name_TextBox"
        Me.Name_TextBox.Size = New System.Drawing.Size(271, 20)
        Me.Name_TextBox.TabIndex = 9
        '
        'Name_Label
        '
        Me.Name_Label.AutoSize = True
        Me.Name_Label.Location = New System.Drawing.Point(12, 15)
        Me.Name_Label.Name = "Name_Label"
        Me.Name_Label.Size = New System.Drawing.Size(83, 13)
        Me.Name_Label.TabIndex = 6
        Me.Name_Label.Text = "Наименование"
        '
        'LInk_Label
        '
        Me.LInk_Label.AutoSize = True
        Me.LInk_Label.Location = New System.Drawing.Point(12, 67)
        Me.LInk_Label.Name = "LInk_Label"
        Me.LInk_Label.Size = New System.Drawing.Size(46, 13)
        Me.LInk_Label.TabIndex = 5
        Me.LInk_Label.Text = "Ссылка"
        '
        'Link_TextBox
        '
        Me.Link_TextBox.Location = New System.Drawing.Point(101, 64)
        Me.Link_TextBox.Name = "Link_TextBox"
        Me.Link_TextBox.Size = New System.Drawing.Size(271, 20)
        Me.Link_TextBox.TabIndex = 8
        '
        'frmEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 120)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Edit_Button)
        Me.Controls.Add(Me.Index_TextBox)
        Me.Controls.Add(Me.Index_Label)
        Me.Controls.Add(Me.Link_TextBox)
        Me.Controls.Add(Me.LInk_Label)
        Me.Controls.Add(Me.Name_TextBox)
        Me.Controls.Add(Me.Name_Label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Редактирование элемента справочника"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cancel_Button As Button
    Friend WithEvents Edit_Button As Button
    Friend WithEvents Index_TextBox As TextBox
    Friend WithEvents Index_Label As Label
    Friend WithEvents Name_TextBox As TextBox
    Friend WithEvents Name_Label As Label
    Friend WithEvents LInk_Label As Label
    Friend WithEvents Link_TextBox As TextBox
End Class
