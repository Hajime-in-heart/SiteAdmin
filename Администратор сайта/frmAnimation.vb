Public Class frmAnimation
    Public filename As String
    Public anime As Animation
    Private Sub frmAnimation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("Open frmAnimation: " & sender.ToString() & vbCrLf)
        MdiParent = frmMain
    End Sub

    Private Sub OnFrameChanged(ByVal o As Object, ByVal e As EventArgs)
        GIF_PictureBox.Invalidate()
    End Sub

    Private Sub OpenFile_Button_Click(sender As Object, e As EventArgs) Handles OpenFile_Button.Click
        With OpenFileDialog1
            .Title = "Выберите документ"
            .Filter = "Анимации| *.gif; *.flc; *.swf |Все файлы| *.*"
            .FileName = ""
            .InitialDirectory = "C:\"
            .Multiselect = False
        End With
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            If OpenFileDialog1.FileName <> Nothing Then
                filename = OpenFileDialog1.FileName
                FileName_Textbox.Text = filename
                anime = New Animation(filename)
            End If
        End If
        Console.WriteLine("Open File: " & sender.ToString() & vbCrLf)
    End Sub

    Private Sub Play_Button_Click(sender As Object, e As EventArgs) Handles Play_Button.Click
        Try
            If Not anime.isanimating Then
                anime.AnimateImage(New EventHandler(AddressOf Me.OnFrameChanged))
                Play_Button.Text = "Стоп"
                Play_Button.Image = ImageList1.Images(1)
                GIF_PictureBox.Invalidate()
                Console.WriteLine("Play Animation: " & sender.ToString() & vbCrLf)
            Else
                anime.StopAnimation(New EventHandler(AddressOf Me.OnFrameChanged))
                Play_Button.Text = "Старт"
                Play_Button.Image = ImageList1.Images(0)
                Console.WriteLine("Stop Animation: " & sender.ToString() & vbCrLf)
            End If
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message & " " & sender.ToString() & vbCrLf)
        End Try
    End Sub

    Private Sub GIF_PictureBox_Paint(sender As Object, e As PaintEventArgs) Handles GIF_PictureBox.Paint
        Try
            ImageAnimator.UpdateFrames()
            anime.Draw(e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Exit_Buttom_Click(sender As System.Object, e As System.EventArgs) Handles Exit_Buttom.Click
        Console.WriteLine("frmAnimation close: " & sender.ToString() & vbCrLf)
        Me.Close()
    End Sub
End Class


