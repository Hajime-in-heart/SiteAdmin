Public Class frmReportViewer
    Private Sub frmReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain
        'TODO: This line of code loads data into the 'DbDataSet.Sites' table. You can move, or remove it, as needed.
        Me.SitesTableAdapter.Fill(Me.DbDataSet.Sites)

        'TODO: This line of code loads data into the 'DbDataSet.Partitions' table. You can move, or remove it, as needed.
        Me.ReportViewer1.RefreshReport()
        MdiParent = frmMain
    End Sub
End Class