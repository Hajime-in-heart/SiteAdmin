Imports System.Data.OleDb
Imports System.Diagnostics.Debug
Public Class Partitions
    Dim intId As Integer
    Dim strTitle As String
    Dim intIdSite As Integer
    Dim strLink As String

    Public Property id As Integer
        Get
            Return intId
        End Get
        Set(value As Integer)
            intId = value
        End Set
    End Property
    Public Property Title As String
        Get
            Return strTitle
        End Get
        Set(value As String)
            strTitle = value
        End Set
    End Property
    Public Property IdSite As Integer
        Get
            Return intIdSite
        End Get
        Set(value As Integer)
            intIdSite = value
        End Set
    End Property
    Public Property Link As String
        Get
            Return strLink
        End Get
        Set(value As String)
            strLink = value
        End Set
    End Property

    Public Function NewPartitions(ByVal objPartitions As Partitions)
        frmMain.РазделыСайтаToolStripMenuItem1.DropDownItems.Clear()
        frmMain.ToolStripComboBox2.Items.Clear()
        Try
            Dim DataReader As OleDbDataReader
            Dim Command As New OleDbCommand("SELECT * FROM Partitions", ConnectToDataBase)
            ConnectToDataBase.Open()
            DataReader = Command.ExecuteReader
            While DataReader.Read() = True
                With objPartitions
                    .id = DataReader.GetValue(0)
                    .Title = DataReader.GetValue(1)
                    .IdSite = DataReader.GetValue(2)
                    If frmMain.ToolStripComboBox1.SelectedIndex + 1 = .IdSite Then
                        frmMain.ToolStripComboBox2.Items.Add(.Title)
                    End If
                    If .IdSite = 1 Then
                        frmMain.РазделыСайтаToolStripMenuItem1.DropDownItems.Add(.Title)
                    End If
                End With
            End While
            DataReader.Close()
            ConnectToDataBase.Close()
            Console.WriteLine("Load Partitions from database" & vbCrLf)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function WriteFile(ByVal objPartitions As Partitions)
        Try
            Dim Command As New OleDbCommand("Insert Into [Partitions] ([ID_Partitions], [Partition], [ID_Sites]) values ('" & objPartitions.id & "', '" & objPartitions.Title & "', '" & objPartitions.IdSite & "')", ConnectToDataBase)
            ConnectToDataBase.Open()
            Command.ExecuteNonQuery()
            ConnectToDataBase.Close()
            frmNew.Close()
        Catch ex As Exception
            ConnectToDataBase.Close()
            Console.WriteLine(ex.Message & " " & Now.ToLongTimeString)
        End Try
        objPartitions.NewPartitions(objPartitions)
        frmPartitions.Reboot()
    End Function

    Public Function DeleteNote(ByVal objPartitions As Partitions)
        Try
            Dim Command As New OleDbCommand("DELETE Partitions.[ID_Partitions], Partitions.[Partition], Partitions.[ID_Sites] FROM Partitions WHERE (((Partitions.[Partition])='" & objPartitions.Title & "') AND ((Partitions.[ID_Sites])='" & objPartitions.IdSite & "'));", ConnectToDataBase)
            ConnectToDataBase.Open()
            Command.ExecuteNonQuery()
            ConnectToDataBase.Close()
        Catch ex As Exception
            ConnectToDataBase.Close()
            Console.WriteLine(ex.Message & " " & Now.ToLongTimeString)
        End Try
        objPartitions.NewPartitions(objPartitions)
        frmPartitions.Reboot()
    End Function

    Public Function EditNote(ByVal objPartitions As Partitions)
        Try
            Dim Command As New OleDbCommand("UPDATE [Partitions] SET [Partition]='" & objPartitions.Title & "', [ID_Sites]='" & objPartitions.IdSite & "' WHERE ([Partition] Like '" & oldTitlePartitions & "' AND [ID_Sites] Like '" & oldSiteIDPartitions & "')", ConnectToDataBase)
            ConnectToDataBase.Open()
            Command.ExecuteNonQuery()
            ConnectToDataBase.Close()
            objSite.NewSite(objSite)
        Catch ex As Exception
            ConnectToDataBase.Close()
            Console.WriteLine(ex.Message & " " & Now.ToLongTimeString)
        End Try
    End Function
End Class
