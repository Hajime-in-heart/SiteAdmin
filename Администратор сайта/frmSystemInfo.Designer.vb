<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSystemInfo))
        Me.CurrentDirectoryLabel_Label = New System.Windows.Forms.Label()
        Me.CurrentDirectory_Label = New System.Windows.Forms.Label()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.SystemDirectoryLabel_Label = New System.Windows.Forms.Label()
        Me.SystemDirectory_Label = New System.Windows.Forms.Label()
        Me.OSVerLabel_Label = New System.Windows.Forms.Label()
        Me.OSVer_Label = New System.Windows.Forms.Label()
        Me.UserNameLabel_Label = New System.Windows.Forms.Label()
        Me.UserName_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CurrentDirectoryLabel_Label
        '
        Me.CurrentDirectoryLabel_Label.AutoSize = True
        Me.CurrentDirectoryLabel_Label.Location = New System.Drawing.Point(12, 9)
        Me.CurrentDirectoryLabel_Label.Name = "CurrentDirectoryLabel_Label"
        Me.CurrentDirectoryLabel_Label.Size = New System.Drawing.Size(95, 13)
        Me.CurrentDirectoryLabel_Label.TabIndex = 0
        Me.CurrentDirectoryLabel_Label.Text = "Текущий каталог"
        '
        'CurrentDirectory_Label
        '
        Me.CurrentDirectory_Label.AutoSize = True
        Me.CurrentDirectory_Label.Location = New System.Drawing.Point(158, 9)
        Me.CurrentDirectory_Label.Name = "CurrentDirectory_Label"
        Me.CurrentDirectory_Label.Size = New System.Drawing.Size(39, 13)
        Me.CurrentDirectory_Label.TabIndex = 1
        Me.CurrentDirectory_Label.Text = "Label2"
        '
        'OK_Button
        '
        Me.OK_Button.Location = New System.Drawing.Point(394, 210)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(75, 23)
        Me.OK_Button.TabIndex = 2
        Me.OK_Button.Text = "ОК"
        Me.OK_Button.UseVisualStyleBackColor = True
        '
        'SystemDirectoryLabel_Label
        '
        Me.SystemDirectoryLabel_Label.AutoSize = True
        Me.SystemDirectoryLabel_Label.Location = New System.Drawing.Point(12, 59)
        Me.SystemDirectoryLabel_Label.Name = "SystemDirectoryLabel_Label"
        Me.SystemDirectoryLabel_Label.Size = New System.Drawing.Size(108, 13)
        Me.SystemDirectoryLabel_Label.TabIndex = 4
        Me.SystemDirectoryLabel_Label.Text = "Системный каталог"
        '
        'SystemDirectory_Label
        '
        Me.SystemDirectory_Label.AutoSize = True
        Me.SystemDirectory_Label.Location = New System.Drawing.Point(158, 59)
        Me.SystemDirectory_Label.Name = "SystemDirectory_Label"
        Me.SystemDirectory_Label.Size = New System.Drawing.Size(39, 13)
        Me.SystemDirectory_Label.TabIndex = 5
        Me.SystemDirectory_Label.Text = "Label4"
        '
        'OSVerLabel_Label
        '
        Me.OSVerLabel_Label.AutoSize = True
        Me.OSVerLabel_Label.Location = New System.Drawing.Point(12, 116)
        Me.OSVerLabel_Label.Name = "OSVerLabel_Label"
        Me.OSVerLabel_Label.Size = New System.Drawing.Size(62, 13)
        Me.OSVerLabel_Label.TabIndex = 6
        Me.OSVerLabel_Label.Text = "Версия ОС"
        '
        'OSVer_Label
        '
        Me.OSVer_Label.AutoSize = True
        Me.OSVer_Label.Location = New System.Drawing.Point(158, 116)
        Me.OSVer_Label.Name = "OSVer_Label"
        Me.OSVer_Label.Size = New System.Drawing.Size(39, 13)
        Me.OSVer_Label.TabIndex = 7
        Me.OSVer_Label.Text = "Label6"
        '
        'UserNameLabel_Label
        '
        Me.UserNameLabel_Label.AutoSize = True
        Me.UserNameLabel_Label.Location = New System.Drawing.Point(12, 174)
        Me.UserNameLabel_Label.Name = "UserNameLabel_Label"
        Me.UserNameLabel_Label.Size = New System.Drawing.Size(103, 13)
        Me.UserNameLabel_Label.TabIndex = 8
        Me.UserNameLabel_Label.Text = "Имя пользователя"
        '
        'UserName_Label
        '
        Me.UserName_Label.AutoSize = True
        Me.UserName_Label.Location = New System.Drawing.Point(158, 174)
        Me.UserName_Label.Name = "UserName_Label"
        Me.UserName_Label.Size = New System.Drawing.Size(39, 13)
        Me.UserName_Label.TabIndex = 9
        Me.UserName_Label.Text = "Label8"
        '
        'frmSystemInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 245)
        Me.Controls.Add(Me.UserName_Label)
        Me.Controls.Add(Me.UserNameLabel_Label)
        Me.Controls.Add(Me.OSVer_Label)
        Me.Controls.Add(Me.OSVerLabel_Label)
        Me.Controls.Add(Me.SystemDirectory_Label)
        Me.Controls.Add(Me.SystemDirectoryLabel_Label)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.CurrentDirectory_Label)
        Me.Controls.Add(Me.CurrentDirectoryLabel_Label)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSystemInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Информация о системе"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CurrentDirectoryLabel_Label As Label
    Friend WithEvents CurrentDirectory_Label As Label
    Friend WithEvents OK_Button As Button
    Friend WithEvents SystemDirectoryLabel_Label As Label
    Friend WithEvents SystemDirectory_Label As Label
    Friend WithEvents OSVerLabel_Label As Label
    Friend WithEvents OSVer_Label As Label
    Friend WithEvents UserNameLabel_Label As Label
    Friend WithEvents UserName_Label As Label
End Class
