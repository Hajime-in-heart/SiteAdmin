﻿Public Class frmBrowser
    Private Sub frmBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("Open frmBrowser: " & sender.ToString() & vbCrLf)
        MdiParent = frmMain
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Navigate("")
    End Sub

    Sub Navigate(ByVal URL As String)
        If TextBox1.Text <> Nothing Then
            WebBrowser1.Navigate(TextBox1.Text)
            Console.WriteLine("Navigate frmBrowser: " & TextBox1.Text & vbCrLf)
        End If

        If URL <> Nothing Then
            WebBrowser1.Navigate(URL)
            Console.WriteLine("Navigate frmBrowser: " & URL & vbCrLf)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ChoiseFile()
    End Sub
    Sub ChoiseFile()
        With OpenFileDialog1
            .Filter = "Текстовые файлы (*.html, *.htm) |*.html; *.htm| All files (*.*)|*.*"
            .Title = "Выберите документ"
            .FileName = ""
            .InitialDirectory = "C:\"
            .Multiselect = False
            If .ShowDialog = DialogResult.OK And .FileName <> Nothing Then
                TextBox1.Text = .FileName
                Console.WriteLine("Open File: " & .FileName & vbCrLf)
            End If
        End With
    End Sub
End Class