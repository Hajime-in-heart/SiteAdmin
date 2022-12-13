Public Class frmOptions

    Private Sub frmOptions_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Console.WriteLine("frmOptions open" & vbCrLf)
        MdiParent = frmMain
    End Sub
End Class