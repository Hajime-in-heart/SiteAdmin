Imports Microsoft.Office.Interop

Public Class frmMain
    Dim intTimer As Integer = 0
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("Open programm" & vbCrLf)
        StatusStripWidth()
        Timer2.Interval = 500
        Timer2.Enabled = True
        ToolStripProgressBar1.Value = 0
        ToolStripStatusLabel1.Text = "Загрузка..."
        loadsites()
        ToolStripComboBox1.SelectedIndex = 0
        Console.WriteLine("Laoding the programm is done" & vbCrLf)
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Try
            intTimer += 1
            If intTimer > 5 Then
                Timer2.Enabled = False
                ToolStripStatusLabel1.Text = "Готово"
                ToolStripProgressBar1.Value = 0
            Else
                ToolStripStatusLabel1.Text = "Загрузка (" & ToolStripProgressBar1.Value & "%)..."
                ToolStripProgressBar1.Value = ToolStripProgressBar1.Value + 20
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub StatusStripWidth()
        ToolStripStatusLabel1.Width = Me.Width / 3
        ToolStripStatusLabel2.Width = Me.Width / 0.5
        ToolStripStatusLabel3.Width = Me.Width / 0.5
        ToolStripStatusLabel4.Width = Me.Width / 0.5
        ToolStripStatusLabel5.Width = Me.Width / 0.5
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = "Дата: "
        ToolStripStatusLabel4.Text = "Время: "
        ToolStripStatusLabel3.Text = Now.ToLongDateString
        ToolStripStatusLabel5.Text = Now.ToLongTimeString
    End Sub

    Private Sub ОткрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub СохранитьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СохранитьToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub ШрифтToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ШрифтToolStripMenuItem.Click
        FontDialog1.ShowDialog()
    End Sub

    Private Sub ЦветоваяПалитраToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЦветоваяПалитраToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub РедакторHTMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles РедакторHTMLToolStripMenuItem.Click
        AnimationProgressBar()
        frmContentEditor.Show()
    End Sub

    Private Sub МенеджерИзображенийToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles МенеджерИзображенийToolStripMenuItem.Click
        AnimationProgressBar()
        frmImageManager.Show()
    End Sub

    Private Sub ПараметрыToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ПараметрыToolStripMenuItem.Click
        AnimationProgressBar()
        frmOptions.Show()
    End Sub

    Private Sub ОбАвторахToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ОбАвторахToolStripMenuItem.Click
        AnimationProgressBar()
        frmAbout.Show()
    End Sub

    Sub AnimationProgressBar()
        intTimer = 0
        Timer2.Enabled = True
        ToolStripStatusLabel1.Text = "Загрузка..."
    End Sub
    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        With frmContentEditor
            If .Editor_RichTextBox.SelectionLength > 0 Then
                .Editor_RichTextBox.Copy()
            End If
        End With
    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        With frmContentEditor
            Try
                .Editor_RichTextBox.Paste()
            Catch ex As Exception

            End Try
        End With
    End Sub

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        With frmContentEditor
            If .Editor_RichTextBox.SelectionLength > 0 Then
                .Editor_RichTextBox.Cut()
            End If
        End With
    End Sub

    Private Sub КопироватьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles КопироватьToolStripMenuItem.Click
        With frmContentEditor
            If .Editor_RichTextBox.SelectionLength > 0 Then
                .Editor_RichTextBox.Copy()
            End If
        End With
    End Sub

    Private Sub ВырезатьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ВырезатьToolStripMenuItem.Click
        With frmContentEditor
            If .Editor_RichTextBox.SelectionLength > 0 Then
                .Editor_RichTextBox.Cut()
            End If
        End With
    End Sub

    Private Sub ВставитьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ВставитьToolStripMenuItem.Click
        With frmContentEditor
            Try
                .Editor_RichTextBox.Paste()
            Catch ex As Exception

            End Try
        End With
    End Sub

    Private Sub ДобавитьСайтToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmNew.Show()
    End Sub

    Private Sub ДобавитьРазделToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьРазделToolStripMenuItem.Click
        frmPartitions.Show()
    End Sub

    Private Sub ДобавитьСайтToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ДобавитьСайтToolStripMenuItem1.Click
        frmSite.Show()
    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        loadsections()
    End Sub

    Sub loadsites()
        Try
            objSite.NewSite(objSite)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub loadsections()
        Try
            objPartitions.NewPartitions(objPartitions)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ИнформацияОСистемеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ИнформацияОСистемеToolStripMenuItem.Click
        frmSystemInfo.Show()
    End Sub

    Private Sub ПечатьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПечатьToolStripMenuItem.Click
        frmPrint.Show()
    End Sub

    Private Sub ГрафическийРедакторToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ГрафическийРедакторToolStripMenuItem.Click
        frmGraphEditor.Show()
    End Sub

    Private Sub АнимацияToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles АнимацияToolStripMenuItem.Click
        frmAnimation.Show()
    End Sub

    Private Sub VideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VideoToolStripMenuItem.Click
        frmAudioVideo.Show()
    End Sub

    'Sub ShowHelp(ByVal parent As Control, ByVal url As String, ByVal command As HelpNavigator)

    'End Sub
    Public Sub СправкаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СправкаToolStripMenuItem.Click
        Dim helpFilename As String = Application.StartupPath & "\Справка\пр10.chm"
        Help.ShowHelp(Me, helpFilename)
    End Sub

    Private Sub ВсеСайтыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВсеСайтыToolStripMenuItem.Click
        frmSite.Show()
    End Sub

    Private Sub ВсеРазделыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВсеРазделыToolStripMenuItem.Click
        frmPartitions.Show()
    End Sub

    Private Sub ПримерОтчетаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПримерОтчетаToolStripMenuItem.Click
        frmReportViewer.Show()
    End Sub

    Private Sub ИнтернетобозревательToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ИнтернетобозревательToolStripMenuItem.Click
        frmBrowser.Show()
    End Sub

    Private Sub ПерваяHTMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПерваяHTMLToolStripMenuItem.Click
        frmBrowser.Show()
        frmBrowser.Navigate(Application.StartupPath & "\Примеры сайтов\1\index.html")
    End Sub

    Private Sub ВтораяHTMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВтораяHTMLToolStripMenuItem.Click
        frmBrowser.Show()
        frmBrowser.Navigate(Application.StartupPath & "\Примеры сайтов\2\index.html")
    End Sub

    Private Sub ТретьяHTMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ТретьяHTMLToolStripMenuItem.Click
        frmBrowser.Show()
        frmBrowser.Navigate(Application.StartupPath & "\Примеры сайтов\3\index.html")
    End Sub

    Private Sub XMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XMLToolStripMenuItem.Click
        frmBrowser.Show()
        frmBrowser.Navigate(Application.StartupPath & "\XMLFile1.xml")
    End Sub

    Private Sub СписокПроцессовToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СписокПроцессовToolStripMenuItem.Click

        Dim app As New Excel.Application
            Dim wb = app.Workbooks.Open(Application.StartupPath & "\Отчеты\Report.xlsx")
        Dim ws As Excel.Worksheet = wb.Worksheets(1)
        Try
            Dim nameCell = wb.Names.Item(Nothing, "NAME", Nothing).RefersToRange
            Dim baseRowNum = nameCell.Row
            Dim rowNum = 1
            For Each p As Process In Process.GetProcesses()
                Try
                    Dim fname = p.MainModule.FileName, id = p.Id,
                    st = p.StartTime
                    Dim rs = nameCell.EntireRow
                    Dim newRowNum = baseRowNum + rowNum
                    rs.Copy(ws.Range("A" & newRowNum).EntireRow)
                    rowNum = rowNum + 1
                    ws.Range("A" & newRowNum).Value = fname
                    ws.Range("B" & newRowNum).Value = id
                    ws.Range("C" & newRowNum).Value = st
                Catch ex As Exception
                End Try
            Next
            nameCell.EntireRow.Delete()
            app.Visible = True
        Catch ex As Exception
            app.Workbooks.Close()
            Console.WriteLine(ex.Message & " " & Now.ToLongTimeString)
        End Try
    End Sub

    Private Sub СистемнаяИнформацияToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СистемнаяИнформацияToolStripMenuItem.Click
        Try
            Dim app As New Word.Application
            Dim doc = app.Documents.Open(Application.StartupPath & "\Отчеты\Report.docx")
            doc.Bookmarks("COMPUTER").Range.Text = Environment.MachineName
            doc.Bookmarks("OS").Range.Text = Environment.OSVersion.ToString()
            doc.Bookmarks("USER").Range.Text = Environment.UserName
            app.Visible = True
        Catch ex As Exception
            Console.WriteLine(ex.Message & " " & Now.ToLongTimeString)

        End Try
    End Sub
End Class