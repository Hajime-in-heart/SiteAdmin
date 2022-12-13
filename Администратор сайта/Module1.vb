Imports System.Data.OleDb

Module Module1
    Public PathToDataBase As String = Application.StartupPath & "\Сайты (ссылки)\db.mdb"
    Public ConnectToDataBase As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & PathToDataBase & ";Persist Security Info=True;Jet OLEDB:Database Password=Password")
    Public PartitionsCount As Integer = 0
    Public objPartitions As New Partitions()
    Public objSite As New Site()
    Public oldTitlePartitions As String
    Public oldSiteIDPartitions As Integer
    Public mode As String
End Module
