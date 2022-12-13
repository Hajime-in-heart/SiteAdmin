<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrint))
        Me.FileName_Label = New System.Windows.Forms.Label()
        Me.FileName_TextBox = New System.Windows.Forms.TextBox()
        Me.FileOpen_Button = New System.Windows.Forms.Button()
        Me.Preview_Button = New System.Windows.Forms.Button()
        Me.Print_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'FileName_Label
        '
        Me.FileName_Label.AutoSize = True
        Me.FileName_Label.Location = New System.Drawing.Point(12, 9)
        Me.FileName_Label.Name = "FileName_Label"
        Me.FileName_Label.Size = New System.Drawing.Size(64, 13)
        Me.FileName_Label.TabIndex = 0
        Me.FileName_Label.Text = "Имя файла"
        '
        'FileName_TextBox
        '
        Me.FileName_TextBox.Location = New System.Drawing.Point(12, 34)
        Me.FileName_TextBox.Name = "FileName_TextBox"
        Me.FileName_TextBox.Size = New System.Drawing.Size(235, 20)
        Me.FileName_TextBox.TabIndex = 1
        '
        'FileOpen_Button
        '
        Me.FileOpen_Button.Location = New System.Drawing.Point(253, 32)
        Me.FileOpen_Button.Name = "FileOpen_Button"
        Me.FileOpen_Button.Size = New System.Drawing.Size(50, 23)
        Me.FileOpen_Button.TabIndex = 2
        Me.FileOpen_Button.Text = "..."
        Me.FileOpen_Button.UseVisualStyleBackColor = True
        '
        'Preview_Button
        '
        Me.Preview_Button.Image = CType(resources.GetObject("Preview_Button.Image"), System.Drawing.Image)
        Me.Preview_Button.Location = New System.Drawing.Point(12, 68)
        Me.Preview_Button.Name = "Preview_Button"
        Me.Preview_Button.Size = New System.Drawing.Size(93, 23)
        Me.Preview_Button.TabIndex = 3
        Me.Preview_Button.Text = "Просмотр"
        Me.Preview_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Preview_Button.UseVisualStyleBackColor = True
        '
        'Print_Button
        '
        Me.Print_Button.Image = CType(resources.GetObject("Print_Button.Image"), System.Drawing.Image)
        Me.Print_Button.Location = New System.Drawing.Point(111, 68)
        Me.Print_Button.Name = "Print_Button"
        Me.Print_Button.Size = New System.Drawing.Size(93, 23)
        Me.Print_Button.TabIndex = 4
        Me.Print_Button.Text = "Печать"
        Me.Print_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Print_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Image = CType(resources.GetObject("Exit_Button.Image"), System.Drawing.Image)
        Me.Exit_Button.Location = New System.Drawing.Point(210, 68)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(93, 23)
        Me.Exit_Button.TabIndex = 5
        Me.Exit_Button.Text = "Выход"
        Me.Exit_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 103)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Print_Button)
        Me.Controls.Add(Me.Preview_Button)
        Me.Controls.Add(Me.FileOpen_Button)
        Me.Controls.Add(Me.FileName_TextBox)
        Me.Controls.Add(Me.FileName_Label)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Печать файла"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileName_Label As Label
    Friend WithEvents FileName_TextBox As TextBox
    Friend WithEvents FileOpen_Button As Button
    Friend WithEvents Preview_Button As Button
    Friend WithEvents Print_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
