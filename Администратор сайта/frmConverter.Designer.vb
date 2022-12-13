<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConverter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConverter))
        Me.EnterDigit_Label = New System.Windows.Forms.Label()
        Me.EnterDigit_TextBox = New System.Windows.Forms.TextBox()
        Me.ChangeCurrNotation_ComboBox = New System.Windows.Forms.ComboBox()
        Me.TargetNotation_GroupBox = New System.Windows.Forms.GroupBox()
        Me.HeximalSystem_RadioButton = New System.Windows.Forms.RadioButton()
        Me.DecimalSystem_RadioButton = New System.Windows.Forms.RadioButton()
        Me.OctalNotation_RadioButton = New System.Windows.Forms.RadioButton()
        Me.BinarySystem_RadioButton = New System.Windows.Forms.RadioButton()
        Me.CalculateResult_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.TargetNotation_GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'EnterDigit_Label
        '
        Me.EnterDigit_Label.AutoSize = True
        Me.EnterDigit_Label.Location = New System.Drawing.Point(12, 9)
        Me.EnterDigit_Label.Name = "EnterDigit_Label"
        Me.EnterDigit_Label.Size = New System.Drawing.Size(45, 13)
        Me.EnterDigit_Label.TabIndex = 0
        Me.EnterDigit_Label.Text = "Число: "
        '
        'EnterDigit_TextBox
        '
        Me.EnterDigit_TextBox.Location = New System.Drawing.Point(57, 6)
        Me.EnterDigit_TextBox.Name = "EnterDigit_TextBox"
        Me.EnterDigit_TextBox.Size = New System.Drawing.Size(203, 20)
        Me.EnterDigit_TextBox.TabIndex = 1
        '
        'ChangeCurrNotation_ComboBox
        '
        Me.ChangeCurrNotation_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ChangeCurrNotation_ComboBox.FormattingEnabled = True
        Me.ChangeCurrNotation_ComboBox.Items.AddRange(New Object() {"Bin", "Oct", "Dec", "Hex"})
        Me.ChangeCurrNotation_ComboBox.Location = New System.Drawing.Point(266, 6)
        Me.ChangeCurrNotation_ComboBox.Name = "ChangeCurrNotation_ComboBox"
        Me.ChangeCurrNotation_ComboBox.Size = New System.Drawing.Size(76, 21)
        Me.ChangeCurrNotation_ComboBox.TabIndex = 2
        '
        'TargetNotation_GroupBox
        '
        Me.TargetNotation_GroupBox.Controls.Add(Me.HeximalSystem_RadioButton)
        Me.TargetNotation_GroupBox.Controls.Add(Me.DecimalSystem_RadioButton)
        Me.TargetNotation_GroupBox.Controls.Add(Me.OctalNotation_RadioButton)
        Me.TargetNotation_GroupBox.Controls.Add(Me.BinarySystem_RadioButton)
        Me.TargetNotation_GroupBox.Location = New System.Drawing.Point(12, 43)
        Me.TargetNotation_GroupBox.Name = "TargetNotation_GroupBox"
        Me.TargetNotation_GroupBox.Size = New System.Drawing.Size(330, 118)
        Me.TargetNotation_GroupBox.TabIndex = 3
        Me.TargetNotation_GroupBox.TabStop = False
        Me.TargetNotation_GroupBox.Text = "Система счисления"
        '
        'HeximalSystem_RadioButton
        '
        Me.HeximalSystem_RadioButton.AutoSize = True
        Me.HeximalSystem_RadioButton.Location = New System.Drawing.Point(6, 88)
        Me.HeximalSystem_RadioButton.Name = "HeximalSystem_RadioButton"
        Me.HeximalSystem_RadioButton.Size = New System.Drawing.Size(127, 17)
        Me.HeximalSystem_RadioButton.TabIndex = 0
        Me.HeximalSystem_RadioButton.TabStop = True
        Me.HeximalSystem_RadioButton.Text = "Шестнадцатеричная"
        Me.HeximalSystem_RadioButton.UseVisualStyleBackColor = True
        '
        'DecimalSystem_RadioButton
        '
        Me.DecimalSystem_RadioButton.AutoSize = True
        Me.DecimalSystem_RadioButton.Location = New System.Drawing.Point(6, 65)
        Me.DecimalSystem_RadioButton.Name = "DecimalSystem_RadioButton"
        Me.DecimalSystem_RadioButton.Size = New System.Drawing.Size(86, 17)
        Me.DecimalSystem_RadioButton.TabIndex = 0
        Me.DecimalSystem_RadioButton.TabStop = True
        Me.DecimalSystem_RadioButton.Text = "Десятичная"
        Me.DecimalSystem_RadioButton.UseVisualStyleBackColor = True
        '
        'OctalNotation_RadioButton
        '
        Me.OctalNotation_RadioButton.AutoSize = True
        Me.OctalNotation_RadioButton.Location = New System.Drawing.Point(6, 42)
        Me.OctalNotation_RadioButton.Name = "OctalNotation_RadioButton"
        Me.OctalNotation_RadioButton.Size = New System.Drawing.Size(99, 17)
        Me.OctalNotation_RadioButton.TabIndex = 0
        Me.OctalNotation_RadioButton.TabStop = True
        Me.OctalNotation_RadioButton.Text = "Восьмеричная"
        Me.OctalNotation_RadioButton.UseVisualStyleBackColor = True
        '
        'BinarySystem_RadioButton
        '
        Me.BinarySystem_RadioButton.AutoSize = True
        Me.BinarySystem_RadioButton.Location = New System.Drawing.Point(6, 19)
        Me.BinarySystem_RadioButton.Name = "BinarySystem_RadioButton"
        Me.BinarySystem_RadioButton.Size = New System.Drawing.Size(75, 17)
        Me.BinarySystem_RadioButton.TabIndex = 0
        Me.BinarySystem_RadioButton.TabStop = True
        Me.BinarySystem_RadioButton.Text = "Двоичная"
        Me.BinarySystem_RadioButton.UseVisualStyleBackColor = True
        '
        'CalculateResult_Button
        '
        Me.CalculateResult_Button.Location = New System.Drawing.Point(185, 167)
        Me.CalculateResult_Button.Name = "CalculateResult_Button"
        Me.CalculateResult_Button.Size = New System.Drawing.Size(75, 23)
        Me.CalculateResult_Button.TabIndex = 1
        Me.CalculateResult_Button.Text = "Расчёт"
        Me.CalculateResult_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(266, 167)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Exit_Button.TabIndex = 2
        Me.Exit_Button.Text = "Выход"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'frmConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 197)
        Me.Controls.Add(Me.CalculateResult_Button)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.TargetNotation_GroupBox)
        Me.Controls.Add(Me.ChangeCurrNotation_ComboBox)
        Me.Controls.Add(Me.EnterDigit_TextBox)
        Me.Controls.Add(Me.EnterDigit_Label)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConverter"
        Me.Text = "Преобразователь"
        Me.TargetNotation_GroupBox.ResumeLayout(False)
        Me.TargetNotation_GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EnterDigit_Label As System.Windows.Forms.Label
    Friend WithEvents EnterDigit_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChangeCurrNotation_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TargetNotation_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents HeximalSystem_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DecimalSystem_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents OctalNotation_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents BinarySystem_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CalculateResult_Button As System.Windows.Forms.Button
    Friend WithEvents Exit_Button As System.Windows.Forms.Button
End Class
