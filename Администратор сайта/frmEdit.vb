Imports System.Data.OleDb
Public Class frmEdit

    Private Sub frmNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("frmEdit open with settings: " & sender.ToString() & vbCrLf)
        MdiParent = frmMain
        meLoad()
    End Sub
    Sub meLoad()
        If mode = "Site" Then
            LoadFromWithSiteMode()
        Else
            LoadFromWithPartitionsMode()
        End If
    End Sub

    Sub LoadFromWithSiteMode()
        Index_TextBox.Enabled = False
        Link_TextBox.Enabled = True
        Name_TextBox.Text = frmSite.DataGridView1.SelectedCells(1).Value
        Link_TextBox.Text = frmSite.DataGridView1.SelectedCells(2).Value
    End Sub

    Sub LoadFromWithPartitionsMode()
        oldSiteIDPartitions = frmPartitions.TreeView1.SelectedNode.Parent.Tag
        oldTitlePartitions = frmPartitions.TreeView1.SelectedNode.Text
        Index_TextBox.Text = oldSiteIDPartitions
        Name_TextBox.Text = oldTitlePartitions
        Index_TextBox.Enabled = True
        Link_TextBox.Enabled = False
    End Sub


    Private Sub Edit_Button_Click(sender As Object, e As System.EventArgs) Handles Edit_Button.Click
        If mode = "Site" Then
            EditSite()
        Else
            EditPartitions()
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
        Console.WriteLine("frmEdit close: " & sender.ToString() & vbCrLf)
    End Sub

    Sub EditSite()
        With objSite
            .id = Convert.ToInt32(frmSite.DataGridView1.SelectedCells(0).Value)
            .Title = Name_TextBox.Text
            .Link = Link_TextBox.Text
        End With
        Console.WriteLine(vbCrLf & "Updated field values (site editing) | ID: " & objSite.id & " | Title: " & objSite.Title & " | Link: " & objSite.Link & vbCrLf)
        objSite.EditNote(objSite)
        frmSite.Reboot()
    End Sub
    Sub EditPartitions()
        With objPartitions
            .Title = Name_TextBox.Text
            .IdSite = Index_TextBox.Text
        End With
        Console.WriteLine(vbCrLf & "Updated field values (partitions editing) | Title: " & objPartitions.Title & " | ID_Site: " & objPartitions.IdSite & vbCrLf)
        objPartitions.EditNote(objPartitions)
        frmPartitions.Reboot()
    End Sub
End Class