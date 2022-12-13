Imports System.ComponentModel

Public Class frmAbout
    Private Sub frmAbout_HelpButtonClicked(sender As Object, e As CancelEventArgs) Handles Me.HelpButtonClicked
        Dim helpFilename As String = Application.StartupPath & "\Справка\пр10.chm"
        Help.ShowHelp(Me, helpFilename, HelpNavigator.KeywordIndex, "Authors")
        Console.WriteLine(vbCrLf & "Open HTML Helper: " & sender.ToString() & vbCrLf)
    End Sub

    Private Sub frmAbout_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MdiParent = frmMain
        Console.WriteLine("Open FrmAbout: " & sender.ToString() & vbCrLf)
    End Sub
End Class