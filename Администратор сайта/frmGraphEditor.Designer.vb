<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGraphEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGraphEditor))
        Me.Elements_ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ElementLine_ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ElementRoundedRectangle_ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ElementCircleFilled_ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ElementBrokenLine_ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ElementModuleFigure_ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ElementCircleWithGradient_ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ElementPen_ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Element_ToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ElementPenColorChanger_ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ImageSave_Button = New System.Windows.Forms.Button()
        Me.ImageClear_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Paint_PictureBox = New System.Windows.Forms.PictureBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FigureColorChanger_Button = New System.Windows.Forms.Button()
        Me.PenDepth_Label = New System.Windows.Forms.Label()
        Me.PenDepth_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Elements_ToolStrip.SuspendLayout()
        CType(Me.Paint_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenDepth_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Elements_ToolStrip
        '
        Me.Elements_ToolStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.Elements_ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ElementLine_ToolStripButton, Me.ElementRoundedRectangle_ToolStripButton, Me.ElementCircleFilled_ToolStripButton, Me.ElementBrokenLine_ToolStripButton, Me.ElementModuleFigure_ToolStripButton, Me.ElementCircleWithGradient_ToolStripButton, Me.ElementPen_ToolStripButton, Me.Element_ToolStripSeparator, Me.ElementPenColorChanger_ToolStripButton})
        Me.Elements_ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.Elements_ToolStrip.Name = "Elements_ToolStrip"
        Me.Elements_ToolStrip.Size = New System.Drawing.Size(24, 477)
        Me.Elements_ToolStrip.TabIndex = 0
        Me.Elements_ToolStrip.Text = "ToolStrip1"
        '
        'ElementLine_ToolStripButton
        '
        Me.ElementLine_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ElementLine_ToolStripButton.Image = CType(resources.GetObject("ElementLine_ToolStripButton.Image"), System.Drawing.Image)
        Me.ElementLine_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ElementLine_ToolStripButton.Name = "ElementLine_ToolStripButton"
        Me.ElementLine_ToolStripButton.Size = New System.Drawing.Size(21, 20)
        Me.ElementLine_ToolStripButton.Text = "Линия"
        '
        'ElementRoundedRectangle_ToolStripButton
        '
        Me.ElementRoundedRectangle_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ElementRoundedRectangle_ToolStripButton.Image = CType(resources.GetObject("ElementRoundedRectangle_ToolStripButton.Image"), System.Drawing.Image)
        Me.ElementRoundedRectangle_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ElementRoundedRectangle_ToolStripButton.Name = "ElementRoundedRectangle_ToolStripButton"
        Me.ElementRoundedRectangle_ToolStripButton.Size = New System.Drawing.Size(21, 20)
        Me.ElementRoundedRectangle_ToolStripButton.Text = "Прямоугольник"
        '
        'ElementCircleFilled_ToolStripButton
        '
        Me.ElementCircleFilled_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ElementCircleFilled_ToolStripButton.Image = CType(resources.GetObject("ElementCircleFilled_ToolStripButton.Image"), System.Drawing.Image)
        Me.ElementCircleFilled_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ElementCircleFilled_ToolStripButton.Name = "ElementCircleFilled_ToolStripButton"
        Me.ElementCircleFilled_ToolStripButton.Size = New System.Drawing.Size(21, 20)
        Me.ElementCircleFilled_ToolStripButton.Text = "Эллипс"
        '
        'ElementBrokenLine_ToolStripButton
        '
        Me.ElementBrokenLine_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ElementBrokenLine_ToolStripButton.Image = CType(resources.GetObject("ElementBrokenLine_ToolStripButton.Image"), System.Drawing.Image)
        Me.ElementBrokenLine_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ElementBrokenLine_ToolStripButton.Name = "ElementBrokenLine_ToolStripButton"
        Me.ElementBrokenLine_ToolStripButton.Size = New System.Drawing.Size(21, 20)
        Me.ElementBrokenLine_ToolStripButton.Text = "Ломанная линия"
        '
        'ElementModuleFigure_ToolStripButton
        '
        Me.ElementModuleFigure_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ElementModuleFigure_ToolStripButton.Image = CType(resources.GetObject("ElementModuleFigure_ToolStripButton.Image"), System.Drawing.Image)
        Me.ElementModuleFigure_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ElementModuleFigure_ToolStripButton.Name = "ElementModuleFigure_ToolStripButton"
        Me.ElementModuleFigure_ToolStripButton.Size = New System.Drawing.Size(21, 20)
        Me.ElementModuleFigure_ToolStripButton.Text = "Составная фигура"
        '
        'ElementCircleWithGradient_ToolStripButton
        '
        Me.ElementCircleWithGradient_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ElementCircleWithGradient_ToolStripButton.Image = CType(resources.GetObject("ElementCircleWithGradient_ToolStripButton.Image"), System.Drawing.Image)
        Me.ElementCircleWithGradient_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ElementCircleWithGradient_ToolStripButton.Name = "ElementCircleWithGradient_ToolStripButton"
        Me.ElementCircleWithGradient_ToolStripButton.Size = New System.Drawing.Size(21, 20)
        Me.ElementCircleWithGradient_ToolStripButton.Text = "Шар"
        '
        'ElementPen_ToolStripButton
        '
        Me.ElementPen_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ElementPen_ToolStripButton.Image = CType(resources.GetObject("ElementPen_ToolStripButton.Image"), System.Drawing.Image)
        Me.ElementPen_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ElementPen_ToolStripButton.Name = "ElementPen_ToolStripButton"
        Me.ElementPen_ToolStripButton.Size = New System.Drawing.Size(21, 20)
        Me.ElementPen_ToolStripButton.Text = "Кисть"
        '
        'Element_ToolStripSeparator
        '
        Me.Element_ToolStripSeparator.Name = "Element_ToolStripSeparator"
        Me.Element_ToolStripSeparator.Size = New System.Drawing.Size(21, 6)
        '
        'ElementPenColorChanger_ToolStripButton
        '
        Me.ElementPenColorChanger_ToolStripButton.AutoSize = False
        Me.ElementPenColorChanger_ToolStripButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ElementPenColorChanger_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.ElementPenColorChanger_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ElementPenColorChanger_ToolStripButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ElementPenColorChanger_ToolStripButton.Name = "ElementPenColorChanger_ToolStripButton"
        Me.ElementPenColorChanger_ToolStripButton.Size = New System.Drawing.Size(20, 20)
        Me.ElementPenColorChanger_ToolStripButton.Text = "Цвет кисти"
        '
        'ImageSave_Button
        '
        Me.ImageSave_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImageSave_Button.Image = CType(resources.GetObject("ImageSave_Button.Image"), System.Drawing.Image)
        Me.ImageSave_Button.Location = New System.Drawing.Point(422, 442)
        Me.ImageSave_Button.Name = "ImageSave_Button"
        Me.ImageSave_Button.Size = New System.Drawing.Size(90, 23)
        Me.ImageSave_Button.TabIndex = 2
        Me.ImageSave_Button.Text = "Сохранить"
        Me.ImageSave_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ImageSave_Button.UseVisualStyleBackColor = True
        '
        'ImageClear_Button
        '
        Me.ImageClear_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImageClear_Button.Image = CType(resources.GetObject("ImageClear_Button.Image"), System.Drawing.Image)
        Me.ImageClear_Button.Location = New System.Drawing.Point(518, 442)
        Me.ImageClear_Button.Name = "ImageClear_Button"
        Me.ImageClear_Button.Size = New System.Drawing.Size(78, 23)
        Me.ImageClear_Button.TabIndex = 3
        Me.ImageClear_Button.Text = "Очистить"
        Me.ImageClear_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ImageClear_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Exit_Button.Location = New System.Drawing.Point(602, 442)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(71, 23)
        Me.Exit_Button.TabIndex = 4
        Me.Exit_Button.Text = "Закрыть"
        Me.Exit_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Paint_PictureBox
        '
        Me.Paint_PictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Paint_PictureBox.Location = New System.Drawing.Point(27, 12)
        Me.Paint_PictureBox.Name = "Paint_PictureBox"
        Me.Paint_PictureBox.Size = New System.Drawing.Size(646, 424)
        Me.Paint_PictureBox.TabIndex = 1
        Me.Paint_PictureBox.TabStop = False
        '
        'FigureColorChanger_Button
        '
        Me.FigureColorChanger_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FigureColorChanger_Button.Location = New System.Drawing.Point(27, 442)
        Me.FigureColorChanger_Button.Name = "FigureColorChanger_Button"
        Me.FigureColorChanger_Button.Size = New System.Drawing.Size(126, 23)
        Me.FigureColorChanger_Button.TabIndex = 5
        Me.FigureColorChanger_Button.Text = "Выбрать цвет фигур"
        Me.FigureColorChanger_Button.UseVisualStyleBackColor = True
        '
        'PenDepth_Label
        '
        Me.PenDepth_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PenDepth_Label.AutoSize = True
        Me.PenDepth_Label.Location = New System.Drawing.Point(161, 447)
        Me.PenDepth_Label.Name = "PenDepth_Label"
        Me.PenDepth_Label.Size = New System.Drawing.Size(85, 13)
        Me.PenDepth_Label.TabIndex = 6
        Me.PenDepth_Label.Text = "Толщина кисти"
        '
        'PenDepth_NumericUpDown
        '
        Me.PenDepth_NumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PenDepth_NumericUpDown.Location = New System.Drawing.Point(252, 445)
        Me.PenDepth_NumericUpDown.Name = "PenDepth_NumericUpDown"
        Me.PenDepth_NumericUpDown.Size = New System.Drawing.Size(40, 20)
        Me.PenDepth_NumericUpDown.TabIndex = 8
        Me.PenDepth_NumericUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'frmGraphEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 477)
        Me.Controls.Add(Me.PenDepth_NumericUpDown)
        Me.Controls.Add(Me.PenDepth_Label)
        Me.Controls.Add(Me.FigureColorChanger_Button)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.ImageClear_Button)
        Me.Controls.Add(Me.ImageSave_Button)
        Me.Controls.Add(Me.Paint_PictureBox)
        Me.Controls.Add(Me.Elements_ToolStrip)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGraphEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Графический редактор"
        Me.Elements_ToolStrip.ResumeLayout(False)
        Me.Elements_ToolStrip.PerformLayout()
        CType(Me.Paint_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenDepth_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Elements_ToolStrip As ToolStrip
    Friend WithEvents ImageSave_Button As Button
    Friend WithEvents ImageClear_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ElementRoundedRectangle_ToolStripButton As ToolStripButton
    Friend WithEvents ElementCircleFilled_ToolStripButton As ToolStripButton
    Friend WithEvents ElementBrokenLine_ToolStripButton As ToolStripButton
    Friend WithEvents ElementModuleFigure_ToolStripButton As ToolStripButton
    Friend WithEvents ElementCircleWithGradient_ToolStripButton As ToolStripButton
    Friend WithEvents ElementPen_ToolStripButton As ToolStripButton
    Friend WithEvents Paint_PictureBox As PictureBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FigureColorChanger_Button As Button
    Friend WithEvents PenDepth_Label As Label
    Friend WithEvents PenDepth_NumericUpDown As NumericUpDown
    Friend WithEvents Element_ToolStripSeparator As ToolStripSeparator
    Friend WithEvents ElementPenColorChanger_ToolStripButton As ToolStripButton
    Friend WithEvents ElementLine_ToolStripButton As ToolStripButton
End Class
