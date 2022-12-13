<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContentEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContentEditor))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ContentWatchChanger_TabControl = New System.Windows.Forms.TabControl()
        Me.Editor_TabPage = New System.Windows.Forms.TabPage()
        Me.EditorElement_RadioButton = New System.Windows.Forms.RadioButton()
        Me.EditorBlock_RadioButton = New System.Windows.Forms.RadioButton()
        Me.EditorClear_Button = New System.Windows.Forms.Button()
        Me.EditorSave_Button = New System.Windows.Forms.Button()
        Me.EditorPaste_Button = New System.Windows.Forms.Button()
        Me.EditorCut_Button = New System.Windows.Forms.Button()
        Me.EditorCopy_Button = New System.Windows.Forms.Button()
        Me.EditorLoad_Button = New System.Windows.Forms.Button()
        Me.EditorSiteContent_Label = New System.Windows.Forms.Label()
        Me.Editor_RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.EditorImageManager_Button = New System.Windows.Forms.Button()
        Me.EditorNumbering_Button = New System.Windows.Forms.Button()
        Me.EditorMarker_Button = New System.Windows.Forms.Button()
        Me.EditorFragment_Button = New System.Windows.Forms.Button()
        Me.EditorElement_Button = New System.Windows.Forms.Button()
        Me.EditorParagraph_Button = New System.Windows.Forms.Button()
        Me.EditorLinkEditor_Button = New System.Windows.Forms.Button()
        Me.EditorSubScript_Button = New System.Windows.Forms.Button()
        Me.EditorSuperScript_Button = New System.Windows.Forms.Button()
        Me.EditorUnderLine_Button = New System.Windows.Forms.Button()
        Me.EditorItalics_Button = New System.Windows.Forms.Button()
        Me.EditorBold_Button = New System.Windows.Forms.Button()
        Me.Browser_TabPage = New System.Windows.Forms.TabPage()
        Me.Browser_ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.OpenFile_Button = New System.Windows.Forms.ToolStripButton()
        Me.BrowserHomePage_Button = New System.Windows.Forms.ToolStripButton()
        Me.Browser_ToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BrowserLink_Label = New System.Windows.Forms.ToolStripLabel()
        Me.BrowserLink_TextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.BrowserGo_Button = New System.Windows.Forms.ToolStripButton()
        Me.Browser_WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContentWatchChanger_TabControl.SuspendLayout()
        Me.Editor_TabPage.SuspendLayout()
        Me.Browser_TabPage.SuspendLayout()
        Me.Browser_ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ContentWatchChanger_TabControl
        '
        Me.ContentWatchChanger_TabControl.Controls.Add(Me.Editor_TabPage)
        Me.ContentWatchChanger_TabControl.Controls.Add(Me.Browser_TabPage)
        Me.ContentWatchChanger_TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentWatchChanger_TabControl.Location = New System.Drawing.Point(0, 0)
        Me.ContentWatchChanger_TabControl.Name = "ContentWatchChanger_TabControl"
        Me.ContentWatchChanger_TabControl.SelectedIndex = 0
        Me.ContentWatchChanger_TabControl.Size = New System.Drawing.Size(784, 361)
        Me.ContentWatchChanger_TabControl.TabIndex = 0
        '
        'Editor_TabPage
        '
        Me.Editor_TabPage.Controls.Add(Me.EditorElement_RadioButton)
        Me.Editor_TabPage.Controls.Add(Me.EditorBlock_RadioButton)
        Me.Editor_TabPage.Controls.Add(Me.EditorClear_Button)
        Me.Editor_TabPage.Controls.Add(Me.EditorSave_Button)
        Me.Editor_TabPage.Controls.Add(Me.EditorPaste_Button)
        Me.Editor_TabPage.Controls.Add(Me.EditorCut_Button)
        Me.Editor_TabPage.Controls.Add(Me.EditorCopy_Button)
        Me.Editor_TabPage.Controls.Add(Me.EditorLoad_Button)
        Me.Editor_TabPage.Controls.Add(Me.EditorSiteContent_Label)
        Me.Editor_TabPage.Controls.Add(Me.Editor_RichTextBox)
        Me.Editor_TabPage.Controls.Add(Me.EditorImageManager_Button)
        Me.Editor_TabPage.Controls.Add(Me.EditorNumbering_Button)
        Me.Editor_TabPage.Controls.Add(Me.EditorMarker_Button)
        Me.Editor_TabPage.Controls.Add(Me.EditorFragment_Button)
        Me.Editor_TabPage.Controls.Add(Me.EditorElement_Button)
        Me.Editor_TabPage.Controls.Add(Me.EditorParagraph_Button)
        Me.Editor_TabPage.Controls.Add(Me.EditorLinkEditor_Button)
        Me.Editor_TabPage.Controls.Add(Me.EditorSubScript_Button)
        Me.Editor_TabPage.Controls.Add(Me.EditorSuperScript_Button)
        Me.Editor_TabPage.Controls.Add(Me.EditorUnderLine_Button)
        Me.Editor_TabPage.Controls.Add(Me.EditorItalics_Button)
        Me.Editor_TabPage.Controls.Add(Me.EditorBold_Button)
        Me.Editor_TabPage.Location = New System.Drawing.Point(4, 22)
        Me.Editor_TabPage.Name = "Editor_TabPage"
        Me.Editor_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.Editor_TabPage.Size = New System.Drawing.Size(776, 335)
        Me.Editor_TabPage.TabIndex = 0
        Me.Editor_TabPage.Text = "Редактор"
        Me.Editor_TabPage.UseVisualStyleBackColor = True
        '
        'EditorElement_RadioButton
        '
        Me.EditorElement_RadioButton.AutoSize = True
        Me.EditorElement_RadioButton.Location = New System.Drawing.Point(529, 14)
        Me.EditorElement_RadioButton.Name = "EditorElement_RadioButton"
        Me.EditorElement_RadioButton.Size = New System.Drawing.Size(69, 17)
        Me.EditorElement_RadioButton.TabIndex = 5
        Me.EditorElement_RadioButton.Text = "Элемент"
        Me.EditorElement_RadioButton.UseVisualStyleBackColor = True
        '
        'EditorBlock_RadioButton
        '
        Me.EditorBlock_RadioButton.AutoSize = True
        Me.EditorBlock_RadioButton.Checked = True
        Me.EditorBlock_RadioButton.Location = New System.Drawing.Point(473, 14)
        Me.EditorBlock_RadioButton.Name = "EditorBlock_RadioButton"
        Me.EditorBlock_RadioButton.Size = New System.Drawing.Size(50, 17)
        Me.EditorBlock_RadioButton.TabIndex = 5
        Me.EditorBlock_RadioButton.TabStop = True
        Me.EditorBlock_RadioButton.Text = "Блок"
        Me.EditorBlock_RadioButton.UseVisualStyleBackColor = True
        '
        'EditorClear_Button
        '
        Me.EditorClear_Button.Location = New System.Drawing.Point(599, 301)
        Me.EditorClear_Button.Name = "EditorClear_Button"
        Me.EditorClear_Button.Size = New System.Drawing.Size(95, 23)
        Me.EditorClear_Button.TabIndex = 4
        Me.EditorClear_Button.Text = "Очистить"
        Me.ToolTip1.SetToolTip(Me.EditorClear_Button, "Очистить содержимое")
        Me.EditorClear_Button.UseVisualStyleBackColor = True
        '
        'EditorSave_Button
        '
        Me.EditorSave_Button.Image = CType(resources.GetObject("EditorSave_Button.Image"), System.Drawing.Image)
        Me.EditorSave_Button.Location = New System.Drawing.Point(498, 301)
        Me.EditorSave_Button.Name = "EditorSave_Button"
        Me.EditorSave_Button.Size = New System.Drawing.Size(95, 23)
        Me.EditorSave_Button.TabIndex = 4
        Me.EditorSave_Button.Text = "Сохранить"
        Me.EditorSave_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.EditorSave_Button, "Сохранить")
        Me.EditorSave_Button.UseVisualStyleBackColor = True
        '
        'EditorPaste_Button
        '
        Me.EditorPaste_Button.Image = CType(resources.GetObject("EditorPaste_Button.Image"), System.Drawing.Image)
        Me.EditorPaste_Button.Location = New System.Drawing.Point(313, 301)
        Me.EditorPaste_Button.Name = "EditorPaste_Button"
        Me.EditorPaste_Button.Size = New System.Drawing.Size(95, 23)
        Me.EditorPaste_Button.TabIndex = 4
        Me.EditorPaste_Button.Text = "Вставить"
        Me.EditorPaste_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.EditorPaste_Button, "Вставить")
        Me.EditorPaste_Button.UseVisualStyleBackColor = True
        '
        'EditorCut_Button
        '
        Me.EditorCut_Button.Image = CType(resources.GetObject("EditorCut_Button.Image"), System.Drawing.Image)
        Me.EditorCut_Button.Location = New System.Drawing.Point(212, 301)
        Me.EditorCut_Button.Name = "EditorCut_Button"
        Me.EditorCut_Button.Size = New System.Drawing.Size(95, 23)
        Me.EditorCut_Button.TabIndex = 4
        Me.EditorCut_Button.Text = "Вырезать"
        Me.EditorCut_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.EditorCut_Button, "Вырезать выделенное")
        Me.EditorCut_Button.UseVisualStyleBackColor = True
        '
        'EditorCopy_Button
        '
        Me.EditorCopy_Button.Image = CType(resources.GetObject("EditorCopy_Button.Image"), System.Drawing.Image)
        Me.EditorCopy_Button.Location = New System.Drawing.Point(111, 301)
        Me.EditorCopy_Button.Name = "EditorCopy_Button"
        Me.EditorCopy_Button.Size = New System.Drawing.Size(95, 23)
        Me.EditorCopy_Button.TabIndex = 4
        Me.EditorCopy_Button.Text = "Копировать"
        Me.EditorCopy_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.EditorCopy_Button, "Копировать выделенное")
        Me.EditorCopy_Button.UseVisualStyleBackColor = True
        '
        'EditorLoad_Button
        '
        Me.EditorLoad_Button.Location = New System.Drawing.Point(10, 301)
        Me.EditorLoad_Button.Name = "EditorLoad_Button"
        Me.EditorLoad_Button.Size = New System.Drawing.Size(95, 23)
        Me.EditorLoad_Button.TabIndex = 4
        Me.EditorLoad_Button.Text = "Загрузить"
        Me.ToolTip1.SetToolTip(Me.EditorLoad_Button, "Загрузить файл")
        Me.EditorLoad_Button.UseVisualStyleBackColor = True
        '
        'EditorSiteContent_Label
        '
        Me.EditorSiteContent_Label.AutoSize = True
        Me.EditorSiteContent_Label.Location = New System.Drawing.Point(5, 49)
        Me.EditorSiteContent_Label.Name = "EditorSiteContent_Label"
        Me.EditorSiteContent_Label.Size = New System.Drawing.Size(80, 13)
        Me.EditorSiteContent_Label.TabIndex = 3
        Me.EditorSiteContent_Label.Text = "Контент сайта"
        '
        'Editor_RichTextBox
        '
        Me.Editor_RichTextBox.Location = New System.Drawing.Point(8, 65)
        Me.Editor_RichTextBox.Name = "Editor_RichTextBox"
        Me.Editor_RichTextBox.Size = New System.Drawing.Size(760, 230)
        Me.Editor_RichTextBox.TabIndex = 2
        Me.Editor_RichTextBox.Text = ""
        '
        'EditorImageManager_Button
        '
        Me.EditorImageManager_Button.BackColor = System.Drawing.Color.White
        Me.EditorImageManager_Button.Image = CType(resources.GetObject("EditorImageManager_Button.Image"), System.Drawing.Image)
        Me.EditorImageManager_Button.Location = New System.Drawing.Point(604, 6)
        Me.EditorImageManager_Button.Name = "EditorImageManager_Button"
        Me.EditorImageManager_Button.Size = New System.Drawing.Size(32, 32)
        Me.EditorImageManager_Button.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.EditorImageManager_Button, "Изображение")
        Me.EditorImageManager_Button.UseVisualStyleBackColor = False
        '
        'EditorNumbering_Button
        '
        Me.EditorNumbering_Button.BackColor = System.Drawing.Color.White
        Me.EditorNumbering_Button.Image = CType(resources.GetObject("EditorNumbering_Button.Image"), System.Drawing.Image)
        Me.EditorNumbering_Button.Location = New System.Drawing.Point(435, 6)
        Me.EditorNumbering_Button.Name = "EditorNumbering_Button"
        Me.EditorNumbering_Button.Size = New System.Drawing.Size(32, 32)
        Me.EditorNumbering_Button.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.EditorNumbering_Button, "Нумерация")
        Me.EditorNumbering_Button.UseVisualStyleBackColor = False
        '
        'EditorMarker_Button
        '
        Me.EditorMarker_Button.BackColor = System.Drawing.Color.White
        Me.EditorMarker_Button.Image = CType(resources.GetObject("EditorMarker_Button.Image"), System.Drawing.Image)
        Me.EditorMarker_Button.Location = New System.Drawing.Point(397, 6)
        Me.EditorMarker_Button.Name = "EditorMarker_Button"
        Me.EditorMarker_Button.Size = New System.Drawing.Size(32, 32)
        Me.EditorMarker_Button.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.EditorMarker_Button, "Маркеры")
        Me.EditorMarker_Button.UseVisualStyleBackColor = False
        '
        'EditorFragment_Button
        '
        Me.EditorFragment_Button.BackColor = System.Drawing.Color.White
        Me.EditorFragment_Button.Image = CType(resources.GetObject("EditorFragment_Button.Image"), System.Drawing.Image)
        Me.EditorFragment_Button.Location = New System.Drawing.Point(359, 6)
        Me.EditorFragment_Button.Name = "EditorFragment_Button"
        Me.EditorFragment_Button.Size = New System.Drawing.Size(32, 32)
        Me.EditorFragment_Button.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.EditorFragment_Button, "Фрагмент")
        Me.EditorFragment_Button.UseVisualStyleBackColor = False
        '
        'EditorElement_Button
        '
        Me.EditorElement_Button.BackColor = System.Drawing.Color.White
        Me.EditorElement_Button.Image = CType(resources.GetObject("EditorElement_Button.Image"), System.Drawing.Image)
        Me.EditorElement_Button.Location = New System.Drawing.Point(321, 6)
        Me.EditorElement_Button.Name = "EditorElement_Button"
        Me.EditorElement_Button.Size = New System.Drawing.Size(32, 32)
        Me.EditorElement_Button.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.EditorElement_Button, "Элемент")
        Me.EditorElement_Button.UseVisualStyleBackColor = False
        '
        'EditorParagraph_Button
        '
        Me.EditorParagraph_Button.BackColor = System.Drawing.Color.White
        Me.EditorParagraph_Button.Image = CType(resources.GetObject("EditorParagraph_Button.Image"), System.Drawing.Image)
        Me.EditorParagraph_Button.Location = New System.Drawing.Point(283, 6)
        Me.EditorParagraph_Button.Name = "EditorParagraph_Button"
        Me.EditorParagraph_Button.Size = New System.Drawing.Size(32, 32)
        Me.EditorParagraph_Button.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.EditorParagraph_Button, "Параграф")
        Me.EditorParagraph_Button.UseVisualStyleBackColor = False
        '
        'EditorLinkEditor_Button
        '
        Me.EditorLinkEditor_Button.BackColor = System.Drawing.Color.White
        Me.EditorLinkEditor_Button.Image = CType(resources.GetObject("EditorLinkEditor_Button.Image"), System.Drawing.Image)
        Me.EditorLinkEditor_Button.Location = New System.Drawing.Point(233, 6)
        Me.EditorLinkEditor_Button.Name = "EditorLinkEditor_Button"
        Me.EditorLinkEditor_Button.Size = New System.Drawing.Size(32, 32)
        Me.EditorLinkEditor_Button.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.EditorLinkEditor_Button, "Редактор ссылок")
        Me.EditorLinkEditor_Button.UseVisualStyleBackColor = False
        '
        'EditorSubScript_Button
        '
        Me.EditorSubScript_Button.BackColor = System.Drawing.Color.White
        Me.EditorSubScript_Button.Image = CType(resources.GetObject("EditorSubScript_Button.Image"), System.Drawing.Image)
        Me.EditorSubScript_Button.Location = New System.Drawing.Point(179, 6)
        Me.EditorSubScript_Button.Name = "EditorSubScript_Button"
        Me.EditorSubScript_Button.Size = New System.Drawing.Size(32, 32)
        Me.EditorSubScript_Button.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.EditorSubScript_Button, "Нижний индекс")
        Me.EditorSubScript_Button.UseVisualStyleBackColor = False
        '
        'EditorSuperScript_Button
        '
        Me.EditorSuperScript_Button.BackColor = System.Drawing.Color.White
        Me.EditorSuperScript_Button.Image = CType(resources.GetObject("EditorSuperScript_Button.Image"), System.Drawing.Image)
        Me.EditorSuperScript_Button.Location = New System.Drawing.Point(141, 6)
        Me.EditorSuperScript_Button.Name = "EditorSuperScript_Button"
        Me.EditorSuperScript_Button.Size = New System.Drawing.Size(32, 32)
        Me.EditorSuperScript_Button.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.EditorSuperScript_Button, "Верхний индекс")
        Me.EditorSuperScript_Button.UseVisualStyleBackColor = False
        '
        'EditorUnderLine_Button
        '
        Me.EditorUnderLine_Button.BackColor = System.Drawing.Color.White
        Me.EditorUnderLine_Button.Image = CType(resources.GetObject("EditorUnderLine_Button.Image"), System.Drawing.Image)
        Me.EditorUnderLine_Button.Location = New System.Drawing.Point(84, 6)
        Me.EditorUnderLine_Button.Name = "EditorUnderLine_Button"
        Me.EditorUnderLine_Button.Size = New System.Drawing.Size(32, 32)
        Me.EditorUnderLine_Button.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.EditorUnderLine_Button, "Подчеркнутый")
        Me.EditorUnderLine_Button.UseVisualStyleBackColor = False
        '
        'EditorItalics_Button
        '
        Me.EditorItalics_Button.BackColor = System.Drawing.Color.White
        Me.EditorItalics_Button.Image = CType(resources.GetObject("EditorItalics_Button.Image"), System.Drawing.Image)
        Me.EditorItalics_Button.Location = New System.Drawing.Point(46, 6)
        Me.EditorItalics_Button.Name = "EditorItalics_Button"
        Me.EditorItalics_Button.Size = New System.Drawing.Size(32, 32)
        Me.EditorItalics_Button.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.EditorItalics_Button, "Курсив")
        Me.EditorItalics_Button.UseVisualStyleBackColor = False
        '
        'EditorBold_Button
        '
        Me.EditorBold_Button.BackColor = System.Drawing.Color.White
        Me.EditorBold_Button.Image = CType(resources.GetObject("EditorBold_Button.Image"), System.Drawing.Image)
        Me.EditorBold_Button.Location = New System.Drawing.Point(8, 6)
        Me.EditorBold_Button.Name = "EditorBold_Button"
        Me.EditorBold_Button.Size = New System.Drawing.Size(32, 32)
        Me.EditorBold_Button.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.EditorBold_Button, "Полужирный")
        Me.EditorBold_Button.UseVisualStyleBackColor = False
        '
        'Browser_TabPage
        '
        Me.Browser_TabPage.Controls.Add(Me.Browser_ToolStrip)
        Me.Browser_TabPage.Controls.Add(Me.Browser_WebBrowser)
        Me.Browser_TabPage.Location = New System.Drawing.Point(4, 22)
        Me.Browser_TabPage.Name = "Browser_TabPage"
        Me.Browser_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.Browser_TabPage.Size = New System.Drawing.Size(776, 335)
        Me.Browser_TabPage.TabIndex = 1
        Me.Browser_TabPage.Text = "Браузер"
        Me.Browser_TabPage.UseVisualStyleBackColor = True
        '
        'Browser_ToolStrip
        '
        Me.Browser_ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFile_Button, Me.BrowserHomePage_Button, Me.Browser_ToolStripSeparator, Me.BrowserLink_Label, Me.BrowserLink_TextBox, Me.BrowserGo_Button})
        Me.Browser_ToolStrip.Location = New System.Drawing.Point(3, 3)
        Me.Browser_ToolStrip.Name = "Browser_ToolStrip"
        Me.Browser_ToolStrip.Size = New System.Drawing.Size(770, 25)
        Me.Browser_ToolStrip.TabIndex = 1
        Me.Browser_ToolStrip.Text = "ToolStrip1"
        '
        'OpenFile_Button
        '
        Me.OpenFile_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenFile_Button.Image = CType(resources.GetObject("OpenFile_Button.Image"), System.Drawing.Image)
        Me.OpenFile_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenFile_Button.Name = "OpenFile_Button"
        Me.OpenFile_Button.Size = New System.Drawing.Size(23, 22)
        Me.OpenFile_Button.Text = "Загрузить файл для предпросмотра"
        '
        'BrowserHomePage_Button
        '
        Me.BrowserHomePage_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserHomePage_Button.Image = CType(resources.GetObject("BrowserHomePage_Button.Image"), System.Drawing.Image)
        Me.BrowserHomePage_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserHomePage_Button.Name = "BrowserHomePage_Button"
        Me.BrowserHomePage_Button.Size = New System.Drawing.Size(23, 22)
        Me.BrowserHomePage_Button.Text = "Домашняя страница"
        '
        'Browser_ToolStripSeparator
        '
        Me.Browser_ToolStripSeparator.Name = "Browser_ToolStripSeparator"
        Me.Browser_ToolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BrowserLink_Label
        '
        Me.BrowserLink_Label.Name = "BrowserLink_Label"
        Me.BrowserLink_Label.Size = New System.Drawing.Size(52, 22)
        Me.BrowserLink_Label.Text = "Ссылка:"
        '
        'BrowserLink_TextBox
        '
        Me.BrowserLink_TextBox.Name = "BrowserLink_TextBox"
        Me.BrowserLink_TextBox.Size = New System.Drawing.Size(100, 25)
        '
        'BrowserGo_Button
        '
        Me.BrowserGo_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserGo_Button.Image = CType(resources.GetObject("BrowserGo_Button.Image"), System.Drawing.Image)
        Me.BrowserGo_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserGo_Button.Name = "BrowserGo_Button"
        Me.BrowserGo_Button.Size = New System.Drawing.Size(23, 22)
        Me.BrowserGo_Button.Text = "Поиск..."
        '
        'Browser_WebBrowser
        '
        Me.Browser_WebBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Browser_WebBrowser.Location = New System.Drawing.Point(3, 31)
        Me.Browser_WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Browser_WebBrowser.Name = "Browser_WebBrowser"
        Me.Browser_WebBrowser.Size = New System.Drawing.Size(770, 301)
        Me.Browser_WebBrowser.TabIndex = 0
        '
        'frmContentEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.Controls.Add(Me.ContentWatchChanger_TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContentEditor"
        Me.Text = "Редактор контента сайта"
        Me.ContentWatchChanger_TabControl.ResumeLayout(False)
        Me.Editor_TabPage.ResumeLayout(False)
        Me.Editor_TabPage.PerformLayout()
        Me.Browser_TabPage.ResumeLayout(False)
        Me.Browser_TabPage.PerformLayout()
        Me.Browser_ToolStrip.ResumeLayout(False)
        Me.Browser_ToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ContentWatchChanger_TabControl As System.Windows.Forms.TabControl
    Friend WithEvents Editor_TabPage As System.Windows.Forms.TabPage
    Friend WithEvents Browser_TabPage As System.Windows.Forms.TabPage
    Friend WithEvents EditorImageManager_Button As System.Windows.Forms.Button
    Friend WithEvents EditorNumbering_Button As System.Windows.Forms.Button
    Friend WithEvents EditorMarker_Button As System.Windows.Forms.Button
    Friend WithEvents EditorFragment_Button As System.Windows.Forms.Button
    Friend WithEvents EditorElement_Button As System.Windows.Forms.Button
    Friend WithEvents EditorParagraph_Button As System.Windows.Forms.Button
    Friend WithEvents EditorLinkEditor_Button As System.Windows.Forms.Button
    Friend WithEvents EditorSubScript_Button As System.Windows.Forms.Button
    Friend WithEvents EditorSuperScript_Button As System.Windows.Forms.Button
    Friend WithEvents EditorUnderLine_Button As System.Windows.Forms.Button
    Friend WithEvents EditorItalics_Button As System.Windows.Forms.Button
    Friend WithEvents EditorBold_Button As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents EditorSiteContent_Label As System.Windows.Forms.Label
    Friend WithEvents Editor_RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents EditorLoad_Button As System.Windows.Forms.Button
    Friend WithEvents EditorCopy_Button As System.Windows.Forms.Button
    Friend WithEvents EditorCut_Button As System.Windows.Forms.Button
    Friend WithEvents EditorPaste_Button As System.Windows.Forms.Button
    Friend WithEvents EditorSave_Button As System.Windows.Forms.Button
    Friend WithEvents EditorClear_Button As System.Windows.Forms.Button
    Friend WithEvents EditorBlock_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents EditorElement_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Browser_WebBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents Browser_ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents OpenFile_Button As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserHomePage_Button As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserGo_Button As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserLink_Label As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BrowserLink_TextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Browser_ToolStripSeparator As System.Windows.Forms.ToolStripSeparator
End Class
