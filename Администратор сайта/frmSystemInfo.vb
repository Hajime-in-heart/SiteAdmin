Imports System.IO
Public Class frmSystemInfo
    Private Sub frmSystemInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("frmSystemInfo open" & vbCrLf)
        MdiParent = frmMain
        CheckSystemInfo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Me.Close()
        Console.WriteLine("frmSystemInfo close" & vbCrLf)
    End Sub

    Sub CheckSystemInfo()
        Dim dirname As String = Application.StartupPath
        Dim dirinfo As New DirectoryInfo(dirname)
        CurrentDirectory_Label.Text = (dirinfo.FullName)
        SystemDirectory_Label.Text = Environment.SystemDirectory
        With My.Computer.Info
            OSVer_Label.Text = .OSFullName & " " & .OSVersion
            UserName_Label.Text = My.User.Name
        End With
        Console.WriteLine("frmSystemInfo load data" & vbCrLf)
    End Sub
End Class