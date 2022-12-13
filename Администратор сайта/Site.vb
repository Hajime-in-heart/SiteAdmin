Imports System.Data.OleDb
Imports System.Diagnostics.Debug
Public Class Site
    Public intId As Integer
    Public strTitle As String
    Public strLink As String
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
    Public Property Link As String
        Get
            Return strLink
        End Get
        Set(value As String)
            strLink = value
        End Set
    End Property

    Public Function NewSite(ByVal objSite As Site)
        Try
            frmSite.DataGridView1.Rows.Clear()
            frmMain.ToolStripComboBox1.Items.Clear()
            Dim DataReader As OleDbDataReader
            Dim Command As New OleDbCommand("SELECT * FROM Sites", ConnectToDataBase)
            ConnectToDataBase.Open()
            DataReader = Command.ExecuteReader
            While DataReader.Read() = True
                With objSite
                    .id = DataReader.GetValue(0)
                    .Title = DataReader.GetValue(1)
                    .Link = DataReader.GetValue(2)
                    frmMain.ToolStripComboBox1.Items.Add(.Title)
                    Try
                        frmSite.DataGridView1.Rows.Add(.id, .Title, .Link)
                    Catch ex As Exception

                    End Try
                End With
            End While
            DataReader.Close()
            ConnectToDataBase.Close()
            Console.WriteLine("Load Sites from database" & vbCrLf)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function WriteFile(ByVal objSite As Site)
        Try
            Dim Command As New OleDbCommand("Insert Into [Sites] ([ID_Site], [Site], [URL]) values ('" & objSite.id & "', '" & objSite.Title & "', '" & objSite.Link & "')", ConnectToDataBase)
            ConnectToDataBase.Open()
            Command.ExecuteNonQuery()
            ConnectToDataBase.Close()
            frmNew.Close()
        Catch ex As Exception
            ConnectToDataBase.Close()
            Console.WriteLine(ex.Message & " " & Now.ToLongTimeString)
        End Try
        objSite.NewSite(objSite)
    End Function

    Public Function DeleteNote(ByVal objSite As Site)
        Try
            Dim Command As New OleDbCommand("DELETE Sites.[ID_Site], Sites.[Site], Sites.[URL] From Sites Where (((Sites.[ID_Site]) = " & objSite.id & "))", ConnectToDataBase)
            ConnectToDataBase.Open()
            Command.ExecuteNonQuery()
            ConnectToDataBase.Close()
            objSite.NewSite(objSite)
        Catch ex As Exception
            ConnectToDataBase.Close()
            Console.WriteLine(ex.Message & " " & Now.ToLongTimeString)
        End Try
    End Function


    Public Function EditNote(ByVal objSite As Site)
        Try
            Dim Command As New OleDbCommand("UPDATE [Sites] Set Sites.[ID_Site] = '" & objSite.id & "', Sites.[Site] = '" & objSite.Title & "', Sites.[URL] = '" & objSite.Link & "' WHERE(((Sites.[ID_Site]) = " & objSite.id & "));", ConnectToDataBase)
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
