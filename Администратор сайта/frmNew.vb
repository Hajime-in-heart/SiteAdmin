Imports System.Diagnostics.Debug
Imports System.Data.OleDb
Public Class frmNew
    Dim i As Integer = 0
    Dim index As Integer

    Private Sub frmNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("FrmNew open" & vbCrLf)
        MdiParent = frmMain
        meLoad()
    End Sub
    Sub meLoad()
        If mode = "Site" Then
            Index_TextBox.Enabled = False
            Index_Label.Enabled = False
        Else
            Index_TextBox.Enabled = True
            Index_Label.Enabled = True
            Index_TextBox.Text = frmPartitions.TreeView1.SelectedNode.Tag
        End If
    End Sub

    Private Sub Create_Button_Click(sender As Object, e As System.EventArgs) Handles Create_Button.Click
        If mode = "Site" Then
            CreateNewSite()
        Else
            CreateNewPartitions()
        End If
    End Sub
    Sub CreateNewSite()
        Dim k As Integer = frmSite.DataGridView1.Rows.Count - 2
        Dim arr(k) As Integer

        For i = 0 To k
            arr(i) = frmSite.DataGridView1.Rows(i).Cells(0).Value
        Next

        Dim except = Enumerable.Range(0, k).Except(arr)

        For Each i In except
            If i <> Nothing Then
                index = i
            Else
                index = frmSite.DataGridView1.Rows.Count + 1
            End If
            Console.WriteLine("Checked missing index for additional item: " & index)
        Next

        index = i

        With objSite
            .id = index
            .Title = Name_TextBox.Text
            .Link = Link_TextBox.Text
        End With

        Console.WriteLine(vbCrLf & "Create field values (site editing) | ID: " & objSite.id & " | Title: " & objSite.Title & " | Link: " & objSite.Link & vbCrLf)
        objSite.WriteFile(objSite)
        frmSite.Reboot()

    End Sub
    Sub CreateNewPartitions()
        Dim ArrayLength As Integer = PartitionsCount + 1
        Dim ArrayPartitions(ArrayLength) As Integer

        Try
            Dim DataReader As OleDbDataReader
            Dim Command As New OleDbCommand("SELECT * FROM Partitions", ConnectToDataBase)
            ConnectToDataBase.Open()
            DataReader = Command.ExecuteReader
            While DataReader.Read() = True
                Try
                    ArrayPartitions(i) = DataReader.GetValue(0)
                    Console.WriteLine(ArrayPartitions(i))
                    i = i + 1
                Catch ex As Exception

                End Try
            End While
            DataReader.Close()
            ConnectToDataBase.Close()
        Catch ex As Exception
            ConnectToDataBase.Close()
            Console.WriteLine(vbCrLf & ex.Message & " " & Now.ToLongTimeString & vbCrLf)
        End Try

        Dim except = Enumerable.Range(0, ArrayLength).Except(ArrayPartitions)

        For Each i In except
            If i <> Nothing Then
                index = i
                Exit For
            Else
                index = PartitionsCount
            End If
        Next

        index = i
        Console.WriteLine("Checked missing index for additional item: " & index)

        With objPartitions
            .id = index
            .Title = Name_TextBox.Text
            .Link = Link_TextBox.Text
            .IdSite = Index_TextBox.Text
        End With

        frmPartitions.TreeView1.SelectedNode.Nodes.Add(Name_TextBox.Text)
        Console.WriteLine(vbCrLf & "Updated field values (partitions editing) | ID: " & objPartitions.id & " | Title: " & objPartitions.Title & " | Link: " & objPartitions.Link & " | ID_Site: " & objPartitions.IdSite & vbCrLf)
        frmPartitions.Reboot()
        objPartitions.WriteFile(objPartitions)
    End Sub
    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
        Console.WriteLine("Close frmNew" & vbCrLf)
    End Sub
End Class