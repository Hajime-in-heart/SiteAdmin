Imports System.IO
Public Class frmFileInfo
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Console.WriteLine("frmFileInfo close: " & sender.ToString() & vbCrLf)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        SetAttributes(frmImageManager.ImagePathToFile_TextBox.Text)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SaveAttributes_Button.Click
        SetAttributes(frmImageManager.ImagePathToFile_TextBox.Text)
    End Sub

    Private Sub frmFileInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain
        Console.WriteLine("frmFileInfo open: " & sender.ToString() & vbCrLf)
        CheckFileInfo(frmImageManager.ImagePathToFile_TextBox.Text)
    End Sub

    Sub SetAttributes(ByVal filename As String)
        Dim flags As Integer = 0

        If AttributesNormal_CheckBox.Checked = True Then
            flags = flags Or FileAttributes.Normal
        End If

        If AttributesArchive_CheckBox.Checked = True Then
            flags = flags Or FileAttributes.Archive
        End If

        If AttributesSystem_CheckBox.Checked = True Then
            flags = flags Or FileAttributes.System
        End If

        If AttributesHidden_CheckBox.Checked = True Then
            flags = flags Or FileAttributes.Hidden
        End If

        If AttributesTemporary_CheckBox.Checked = True Then
            flags = flags Or FileAttributes.Temporary
        End If

        If AttributesCompressed_CheckBox.Checked = True Then
            flags = flags Or FileAttributes.Compressed
        End If

        If AttributesEncrypted_CheckBox.Checked = True Then
            flags = flags Or FileAttributes.Encrypted
        End If

        If AttributesNotContentIndexed_CheckBox.Checked = True Then
            flags = flags Or FileAttributes.NotContentIndexed
        End If

        If AttributesReadOnly_CheckBox.Checked = True Then
            flags = flags Or FileAttributes.ReadOnly
        End If

        File.SetAttributes(filename, flags)
        Console.WriteLine("Set attributes: " & flags & vbCrLf)
    End Sub
    Sub CheckFileInfo(ByVal filename As String)
        Dim MyFile As New FileInfo(filename)
        FIleName_Label.Text = frmImageManager.ImageFIleName_TextBox.Text
        FileSize_Label.Text = (MyFile.Length / 1024) & " " & "Kb"
        FileDate_Label.Text = MyFile.CreationTime
        CheckAttributes(MyFile, filename)
        Console.WriteLine("Check FIleInfo: " & filename & vbCrLf)
    End Sub

    Sub CheckAttributes(ByVal MyFile As FileInfo, ByVal filename As String)
        AttributesNormal_CheckBox.Checked = (File.GetAttributes(filename) And FileAttributes.Normal) = FileAttributes.Normal
        AttributesArchive_CheckBox.Checked = (File.GetAttributes(filename) And FileAttributes.Archive) = FileAttributes.Archive
        AttributesSystem_CheckBox.Checked = (File.GetAttributes(filename) And FileAttributes.System) = FileAttributes.System
        AttributesHidden_CheckBox.Checked = (File.GetAttributes(filename) And FileAttributes.Hidden) = FileAttributes.Hidden
        AttributesTemporary_CheckBox.Checked = (File.GetAttributes(filename) And FileAttributes.Temporary) = FileAttributes.Temporary
        AttributesCompressed_CheckBox.Checked = (File.GetAttributes(filename) And FileAttributes.Compressed) = FileAttributes.Compressed
        AttributesEncrypted_CheckBox.Checked = (File.GetAttributes(filename) And FileAttributes.Encrypted) = FileAttributes.Encrypted
        AttributesNotContentIndexed_CheckBox.Checked = (File.GetAttributes(filename) And FileAttributes.NotContentIndexed) = FileAttributes.NotContentIndexed
        AttributesReadOnly_CheckBox.Checked = (File.GetAttributes(filename) And FileAttributes.ReadOnly) = FileAttributes.ReadOnly
        Console.WriteLine("Check attributes: " & filename & vbCrLf)
    End Sub
End Class