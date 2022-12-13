Imports System.IO
Public Class frmContentEditor
    Dim pathtodocument As String
    Dim typefile As String
    Dim block As Boolean = True
    Dim element As Boolean = False
    Dim oDocument As Object

    Private Sub frmContentEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("Open frmContentEditor: " & sender.ToString() & vbCrLf)
        MdiParent = frmMain

        With OpenFileDialog1
            .Filter = "Текстовые файлы (*.txt; *.rtf; *.html) |*.txt; *.rtf; *.html| All files (*.*)|*.*"
            .Title = "Выберите документ"
            .FileName = ""
            .InitialDirectory = "C:\"
            .Multiselect = False
        End With

        With SaveFileDialog1
            .Filter = "Текстовые файлы (*.txt; *.rtf; *.html) |*.txt; *.rtf; *.html| All files (*.*)|*.*"
            .Title = "Выберите документ"
            .FileName = ""
            .InitialDirectory = "C:\"
        End With

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles EditorBold_Button.Click
        If Editor_RichTextBox.SelectedText.Contains("<b>") = True Or Editor_RichTextBox.SelectedText.Contains("</b>") = True Then
            Exit Sub
        Else
            Editor_RichTextBox.SelectedText = "<b>" & Editor_RichTextBox.SelectedText & "</b>"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles EditorItalics_Button.Click
        If Editor_RichTextBox.SelectedText.Contains("<i>") = True Or Editor_RichTextBox.SelectedText.Contains("</i>") = True Then
            Exit Sub
        Else
            Editor_RichTextBox.SelectedText = "<i>" & Editor_RichTextBox.SelectedText & "</i>"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles EditorUnderLine_Button.Click
        If Editor_RichTextBox.SelectedText.Contains("<u>") = True Or Editor_RichTextBox.SelectedText.Contains("</u>") = True Then
            Exit Sub
        Else
            Editor_RichTextBox.SelectedText = "<u>" & Editor_RichTextBox.SelectedText & "</u>"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles EditorSuperScript_Button.Click
        If Editor_RichTextBox.SelectedText.Contains("<sup>") = True Or Editor_RichTextBox.SelectedText.Contains("</sup>") = True Then
            Exit Sub
        Else
            Editor_RichTextBox.SelectedText = "<sup>" & Editor_RichTextBox.SelectedText & "</sup>"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles EditorSubScript_Button.Click
        If Editor_RichTextBox.SelectedText.Contains("<sub>") = True Or Editor_RichTextBox.SelectedText.Contains("</sub>") = True Then
            Exit Sub
        Else
            Editor_RichTextBox.SelectedText = "<sub>" & Editor_RichTextBox.SelectedText & "</sub>"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles EditorLinkEditor_Button.Click
        MessageBox.Show("Данный функционал находится в разработке!", "Печалька ^_^", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles EditorParagraph_Button.Click
        If Editor_RichTextBox.SelectedText.Contains("<p>") = True Or Editor_RichTextBox.SelectedText.Contains("</p>") = True Then
            Exit Sub
        Else
            Editor_RichTextBox.SelectedText = "<p>" & Editor_RichTextBox.SelectedText & "</p>"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles EditorElement_Button.Click

        If Editor_RichTextBox.SelectedText.Contains("<span>") = True Or Editor_RichTextBox.SelectedText.Contains("</span>") = True Then
            Exit Sub
        Else
            Editor_RichTextBox.SelectedText = "<span>" & Editor_RichTextBox.SelectedText & "</span>"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles EditorFragment_Button.Click
        If Editor_RichTextBox.SelectedText.Contains("<div>") = True Or Editor_RichTextBox.SelectedText.Contains("</div>") = True Then
            Exit Sub
        Else
            Editor_RichTextBox.SelectedText = "<div>" & Editor_RichTextBox.SelectedText & "</div>"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles EditorMarker_Button.Click
        If element = True Then
            Editor_RichTextBox.SelectedText = "<li>" & Editor_RichTextBox.SelectedText & "</li>"
        Else
            Editor_RichTextBox.SelectedText = "<ul>" & Editor_RichTextBox.SelectedText & "</ul>"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles EditorNumbering_Button.Click
        If element = True Then
            Editor_RichTextBox.SelectedText = "<li>" & Editor_RichTextBox.SelectedText & "</li>"
        Else
            Editor_RichTextBox.SelectedText = "<ol>" & Editor_RichTextBox.SelectedText & "</ol>"
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles EditorBlock_RadioButton.CheckedChanged
        If EditorBlock_RadioButton.Checked Then
            block = True
            element = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles EditorElement_RadioButton.CheckedChanged
        If EditorElement_RadioButton.Checked Then
            block = False
            element = True
        End If
    End Sub

    Private Sub Button_picture_Click(sender As Object, e As EventArgs) Handles EditorImageManager_Button.Click
        frmImageManager.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles EditorLoad_Button.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK And OpenFileDialog1.FileName <> Nothing Then
            pathtodocument = OpenFileDialog1.FileName
            typefile = Path.GetExtension(pathtodocument)
        End If

        Select Case typefile
            Case ".txt"
                LoadDataFromTXT()
            Case ".rtf"
                LoadDataFromRTF()
            Case ".html"
                LoadDataFromHTML()
        End Select
        Console.WriteLine("Open file: " & OpenFileDialog1.FileName & vbCrLf)
    End Sub

    Sub LoadDataFromTXT()
        Dim Reader As StreamReader
        Try
            Reader = New StreamReader(pathtodocument)
            Editor_RichTextBox.Text = Reader.ReadToEnd()
            Reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Sub LoadDataFromRTF()
        Try
            Editor_RichTextBox.LoadFile(pathtodocument)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub
    Sub LoadDataFromHTML()
        Dim Reader As StreamReader
        Try
            Reader = New StreamReader(pathtodocument)
            Editor_RichTextBox.Text = Reader.ReadToEnd()
            Reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles EditorCopy_Button.Click
        If Editor_RichTextBox.SelectionLength > 0 Then
            Editor_RichTextBox.Copy()
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles EditorCut_Button.Click
        If Editor_RichTextBox.SelectionLength > 0 Then
            Editor_RichTextBox.Cut()
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles EditorPaste_Button.Click
        Try
            Editor_RichTextBox.Paste()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles EditorSave_Button.Click
        If pathtodocument = "" Then
            If (SaveFileDialog1.ShowDialog() = DialogResult.OK) Then
                pathtodocument = SaveFileDialog1.FileName
                typefile = Path.GetExtension(pathtodocument)
                File.WriteAllText(pathtodocument, Editor_RichTextBox.Text)
                MessageBox.Show("Файл сохранен")
                Exit Sub
            End If
        End If

        Select Case typefile
            Case ".txt"
                SaveDataInTXT()
            Case ".rtf"
                SaveDataInRTF()
            Case ".html"
                SaveDataInHTML()
        End Select
        Console.WriteLine("Save file: " & pathtodocument & vbCrLf)
    End Sub

    Sub SaveDataInTXT()
        Dim Writer As StreamWriter
        Try
            Writer = New StreamWriter(pathtodocument)
            Writer.Write(Editor_RichTextBox.Text)
            Writer.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub
    Sub SaveDataInRTF()
        Try
            Editor_RichTextBox.SaveFile(pathtodocument)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Sub SaveDataInHTML()
        Dim Writer As StreamWriter
        Try
            Writer = New StreamWriter(pathtodocument)
            Writer.Write(Editor_RichTextBox.Text)
            Writer.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles EditorClear_Button.Click
        Editor_RichTextBox.Clear()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles OpenFile_Button.Click
        Dim strFileName As String
        With OpenFileDialog1
            If .ShowDialog() = DialogResult.OK And .FileName <> Nothing Then
                strFileName = .FileName
            End If
        End With

        If strFileName.Length Then
            oDocument = Nothing
            Browser_WebBrowser.Navigate(strFileName)
        End If
    End Sub
    Private Sub WebBrowser1_NavigateComplete2(ByVal pDisp As Object, URL As Object)
        On Error Resume Next
        oDocument = pDisp.Document
        MsgBox("File opened by: " & oDocument.Application.Name)
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles BrowserHomePage_Button.Click
        Browser_WebBrowser.GoHome()
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles BrowserGo_Button.Click
        Browser_WebBrowser.Navigate(BrowserLink_TextBox.Text)
    End Sub
End Class