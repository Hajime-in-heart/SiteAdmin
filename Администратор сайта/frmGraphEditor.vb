Imports System.Drawing.Drawing2D
Public Class frmGraphEditor
    Dim pencolor As Color = Color.Red
    Dim brushcolor As Color = Color.Red
    Dim freedom As Boolean = False
    Dim ris As Boolean = False
    Dim index As Integer
    Dim graph As Graphics
    Dim flag As Bitmap
    Private Sub frmGraphEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain
        Me.DoubleBuffered = True
        ElementPenColorChanger_ToolStripButton.BackColor = pencolor
        ElementPenColorChanger_ToolStripButton.Visible = False
        flag = New Bitmap(Paint_PictureBox.Width, Paint_PictureBox.Height)

        With SaveFileDialog1
            .Title = "Сохранить картинку как..."
            .OverwritePrompt = True
            .CheckPathExists = True
            .Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*"
            .ShowHelp = True
        End With
        Console.WriteLine("frmGraphEditor load: " & sender.ToString() & vbCrLf)
    End Sub


    Sub DrawLineExample(ByVal index As Integer)
        graph = Graphics.FromImage(flag)
        Dim penl As New Pen(brushcolor, 5)
        Dim brushl As New SolidBrush(brushcolor)
        graph.Clear(Color.FromArgb(255, 255, 255))

        Select Case index
            Case 0
                DrawLine(penl)
            Case 1
                DrawSquare(penl)
            Case 2
                DrawFillCircle(brushl)
            Case 3
                DrawBrokenLine(penl)
            Case 4
                DrawModuleFigure(penl, brushl)
            Case 5
                DrawGradientCircle()
        End Select
        ElementPenColorChanger_ToolStripButton.Visible = False
        Paint_PictureBox.Image = flag
        freedom = False
    End Sub

    Sub DrawLine(ByVal penl As Pen)
        graph.DrawLine(penl, 50, 50, 500, 500)
    End Sub

    Sub DrawSquare(ByVal penl As Pen)
        graph.PageUnit = GraphicsUnit.Millimeter
        graph.SmoothingMode = SmoothingMode.AntiAlias
        graph.DrawLine(penl, 20, 20, 90, 20)
        graph.DrawArc(penl, 80, 20, 20, 20, 270, 90)
        graph.DrawLine(penl, 100, 30, 100, 40)
        graph.DrawArc(penl, 80, 30, 20, 20, 0, 90)
        graph.DrawLine(penl, 20, 50, 90, 50)
        graph.DrawArc(penl, 10, 30, 20, 20, 90, 90)
        graph.DrawLine(penl, 10, 30, 10, 40)
        graph.DrawArc(penl, 10, 20, 20, 20, 180, 90)
    End Sub
    Sub DrawFillCircle(ByVal brushl As SolidBrush)
        graph.FillEllipse(brushl, 50, 50, 150, 150)
    End Sub

    Sub DrawBrokenLine(ByVal penl As Pen)
        Dim points(21) As Point
        For i As Integer = 0 To 20 Step 2
            points(i) = New Point(20 + 10 * i, 25 + 5 * i)
            points(i + 1) = New Point(40 + 10 * i, 20 - 5 * i)
        Next
        graph.DrawLines(penl, points)
    End Sub

    Sub DrawModuleFigure(ByVal penl As Pen, ByVal brushl As SolidBrush)
        penl.EndCap() = LineCap.RoundAnchor
        penl.StartCap() = LineCap.RoundAnchor
        graph.DrawLine(penl, 50, 50, 200, 50)
        graph.FillEllipse(brushl, 50, 50, 150, 150)
    End Sub

    Sub DrawGradientCircle()
        Dim linGrBrush As LinearGradientBrush = New LinearGradientBrush(
                New Point(30, 150),
                New Point(150, 30),
                brushcolor,
                Color.FromArgb(0, 0, 0, 0))
        linGrBrush.WrapMode = WrapMode.TileFlipX
        graph.FillEllipse(linGrBrush, 50, 50, 150, 150)
    End Sub
    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ElementLine_ToolStripButton.Click
        DrawLineExample(0)
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ElementRoundedRectangle_ToolStripButton.Click
        DrawLineExample(1)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ElementCircleFilled_ToolStripButton.Click
        DrawLineExample(2)
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ElementBrokenLine_ToolStripButton.Click
        DrawLineExample(3)
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ElementModuleFigure_ToolStripButton.Click
        DrawLineExample(4)
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ElementCircleWithGradient_ToolStripButton.Click
        DrawLineExample(5)
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ElementPen_ToolStripButton.Click
        EnablePen()
    End Sub
    Sub EnablePen()
        freedom = True
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            If ColorDialog1.Color <> Nothing Then
                pencolor = ColorDialog1.Color
                ElementPenColorChanger_ToolStripButton.Visible = True
                ElementPenColorChanger_ToolStripButton.BackColor = pencolor
            End If
        Else
            pencolor = Color.Red
        End If

    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles Paint_PictureBox.MouseDown
        ris = True
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles Paint_PictureBox.MouseMove
        If ris = True And freedom = True Then
            graph = Graphics.FromImage(flag)
            graph.FillRectangle(New SolidBrush(pencolor), e.X, e.Y, PenDepth_NumericUpDown.Value, PenDepth_NumericUpDown.Value)
            Paint_PictureBox.Image = flag
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles Paint_PictureBox.MouseUp
        ris = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ImageClear_Button.Click
        flag = New Bitmap(Paint_PictureBox.Width, Paint_PictureBox.Height)
        Paint_PictureBox.Image = flag
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles FigureColorChanger_Button.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            If ColorDialog1.Color <> Nothing Then
                brushcolor = ColorDialog1.Color
                DrawLineExample(index)
            End If
        Else
            brushcolor = Color.Red
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles PenDepth_NumericUpDown.ValueChanged
        If PenDepth_NumericUpDown.Value > 1 Then
            Exit Sub
        Else
            PenDepth_NumericUpDown.Value = 1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
        Console.WriteLine("frmGraphEditorClose close: " & sender.ToString() & vbCrLf)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ImageSave_Button.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Paint_PictureBox.Image.Save(SaveFileDialog1.FileName)
            Catch ex As Exception
                MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ElementPenColorChanger_ToolStripButton.Click
        EnablePen()
    End Sub
End Class