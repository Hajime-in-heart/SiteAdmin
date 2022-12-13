Imports System.Drawing.Printing
Imports System.IO
Public Class frmPrint
    Private filetoprint As StreamReader
    Private printfont As New Font("Courier New", 10)
    Dim pathtofile As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles FileOpen_Button.Click
        With OpenFileDialog1
            .Title = "Выберите документ"
            .Filter = "Документы| *.txt;*.rtf;*.log;*.csv |Все файлы| *.*"
            .FileName = ""
            .InitialDirectory = "C:\"
            .Multiselect = False
            If .ShowDialog() = DialogResult.OK Then
                If .FileName <> Nothing Then
                    pathtofile = .FileName
                    FileName_TextBox.Text = pathtofile
                    PrintDocument1.DocumentName = FileName_TextBox.Text
                    Console.WriteLine("Open file: " & .FileName & vbCrLf)
                End If
            End If
        End With
    End Sub

    Private Sub frmPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("frmPrint open" & vbCrLf)
        MdiParent = frmMain
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Preview_Button.Click
        If Not (FileName_TextBox.Text Is Nothing) Then
            filetoprint = New StreamReader(FileName_TextBox.Text)
            PrintPreviewDialog1.MdiParent = frmMain
            PrintPreviewDialog1.ShowDialog()
            filetoprint.Close()
        Else
            MessageBox.Show("Не указано имя файла")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Print_Button.Click
        If Not (FileName_TextBox.Text Is Nothing) Then
            If (PrintDialog1.ShowDialog() = DialogResult.OK) Then

                Printing()
            End If
        Else
            MessageBox.Show("Не указано имя файла")
        End If
    End Sub
    Private Sub Printing()
        filetoprint = New StreamReader(FileName_TextBox.Text)
        Try
            PrintDocument1.DefaultPageSettings.Margins = New Margins(150, 150, 150, 150)
            PrintDocument1.DefaultPageSettings.Landscape = False
            PrintDocument1.PrinterSettings.Copies = 2
            If (PrintDocument1.PrinterSettings.CanDuplex) Then
                PrintDocument1.PrinterSettings.Duplex() = Duplex.Horizontal
            End If
            PrintDocument1.Print()
        Catch ex As Exception
            Console.WriteLine(vbCrLf & ex.Message & vbCrLf)
        End Try
        filetoprint.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim y As Single = e.MarginBounds.Top
        Dim line As String = Nothing
        While y < e.MarginBounds.Bottom
            line = filetoprint.ReadLine()
            If line Is Nothing Then
                Exit While
            End If
            y += printfont.Height
            e.Graphics.DrawString(line, printfont, Brushes.Black, e.MarginBounds.Left, y)
        End While
        If Not (line Is Nothing) Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Console.WriteLine("frmPrint close" & vbCrLf)
        Me.Close()
    End Sub
End Class