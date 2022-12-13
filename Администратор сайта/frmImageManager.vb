Imports System.ComponentModel
Imports System.IO
Public Class frmImageManager
    Dim fromnametoid As Integer
    Dim mode As String
    Dim firstsizewidth, firstsizeheight As String
    Dim firstsize As Boolean = True
    Private Sub frmImageManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain
        With Buffer_ListView
            .Columns.Clear()
            .Items.Clear()
            .Columns.Add("ID")
            .Columns.Add("Name")
            .Columns.Add("Filename")
            .Columns.Add("Position")
            .Columns.Add("Pathtofile")
            .Columns.Add("Height")
            .Columns.Add("Width")
            .Columns.Add("Block")
            .Columns.Add("Orientation")
            .Columns.Add("Comment")
        End With
        Console.WriteLine("Set attributes: " & sender.ToString() & vbCrLf)
        loadentities()
        ErrorProvider1.BlinkRate = 0
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ImageOpen_Button.Click
        OpenImageFile(0, 0)
    End Sub
    Sub OpenImageFile(ByVal pathofpicture As String, ByVal filename As String)
        With OpenFileDialog1
            .Title = "Выберите изображение"
            .Filter = "Только изображения| *.png;*.jpg |Все файлы| *.*"
            .FileName = ""
            .InitialDirectory = "C:\"
            .Multiselect = False
            If .ShowDialog() = DialogResult.OK And .FileName <> Nothing Then
                filename = Path.GetFileName(.FileName)
                pathofpicture = .FileName
                ImagePathToFile_TextBox.Text = pathofpicture
                ImageFIleName_TextBox.Text = filename
                ImageResolution_Label.Visible = True
                ImageWatch_CheckBox.Visible = True
                ImageAbout_Button.Visible = True
                ImageWatch_PictureBox.ImageLocation = pathofpicture
                Console.WriteLine("Open File: " & pathofpicture & vbCrLf)
            End If
        End With
    End Sub

    Sub CheckfirstSizePict()
        Try
            If firstsize = True Then
                firstsizewidth = ImageWatch_PictureBox.Image.Width
                firstsizeheight = ImageWatch_PictureBox.Image.Height
                firstsize = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ImageWatch_CheckBox.CheckedChanged
        If ImageWatch_CheckBox.Checked Then
            ImageWatch_PictureBox.Visible = True
            ImageResolution_Label.Visible = True
            ImageScale_TrackBar.Visible = True
            ImageScale_Label.Visible = True
            ImageAbout_Button.Visible = True
        Else
            ImageWatch_PictureBox.Visible = False
            ImageScale_TrackBar.Visible = False
            ImageResolution_Label.Visible = False
            ImageScale_Label.Visible = False
            ImageAbout_Button.Visible = False
        End If

    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles ImageWatch_PictureBox.Paint
        CheckfirstSizePict()
        Try
            ImageResolution_Label.Text = ImageWatch_PictureBox.Image.Width & "X" & ImageWatch_PictureBox.Image.Height
            If ImageWatch_PictureBox.Image.Width < ImageWatch_PictureBox.Image.Height Then
                ImageOrientationBook_RadioButton.Checked = True
                ImageOrientationAlbum_RadioButton.Checked = False
            Else
                ImageOrientationBook_RadioButton.Checked = False
                ImageOrientationAlbum_RadioButton.Checked = True
            End If

            ImageHeight_TextBox.Text = ImageWatch_PictureBox.Image.Height
            ImageWidth_TextBox.Text = ImageWatch_PictureBox.Image.Width
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddImageToListBox_Button.Click
        ImageProperties_GroupBox.Enabled = True
        DelImageFromListBox_Button.Enabled = False
        EditImageInListBox_Button.Enabled = False
        mode = "Добавить"
        ImageList_ListBox.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ImageClear_Button.Click
        Button3_Click(Me, New EventArgs)
    End Sub
    Sub clear()
        ImageName_TextBox.Clear()
        ImageFIleName_TextBox.Clear()
        ImagePathToFile_TextBox.Clear()
        ImageHeight_TextBox.Clear()
        ImageWidth_TextBox.Clear()
        Comment_TextBox.Clear()
        Block_NumericUpDown.Value = 0
        ImageOrientationBook_RadioButton.Checked = False
        ImageOrientationAlbum_RadioButton.Checked = False
        Alignment_ComboBox.Text = Nothing
        Console.WriteLine("Return to stock settings" & vbCrLf)
    End Sub
    Public Structure ListofImage
        Dim _name As String
        Dim _filename As String
        Dim _position As String
        Dim _pathtofile As String
        Dim _height As String
        Dim _width As String
        Dim _block As String
        Dim _orientation As String
        Dim _comment As String
    End Structure

    Public ListofImages As New List(Of ListofImage) From
    {New ListofImage With {
        ._name = "Картинка",
        ._filename = "Картинка.jpg",
        ._position = "По левому краю",
        ._pathtofile = "C:\картинка.jpg",
        ._height = "100",
        ._width = "200",
        ._block = "1",
        ._orientation = "Альбомная",
        ._comment = "Комментарий"},
        New ListofImage With {
        ._name = "Картинка 1",
        ._filename = "Картинка.jpg",
        ._position = "По левому краю",
        ._pathtofile = "C:\картинка.jpg",
        ._height = "100",
        ._width = "200",
        ._block = "1",
        ._orientation = "Альбомная",
        ._comment = "Комментарий"}
}

    Sub loadentities()
        Dim i = 0
        For Each _CurrentImage As ListofImage In ListofImages
            ImageList_ListBox.Items.Add(_CurrentImage._name)
            With Buffer_ListView
                .Items.Add(i)
                .Items.Item(Buffer_ListView.Items.Count - 1).SubItems.Add(_CurrentImage._name)
                .Items.Item(Buffer_ListView.Items.Count - 1).SubItems.Add(_CurrentImage._filename)
                .Items.Item(Buffer_ListView.Items.Count - 1).SubItems.Add(_CurrentImage._position)
                .Items.Item(Buffer_ListView.Items.Count - 1).SubItems.Add(_CurrentImage._pathtofile)
                .Items.Item(Buffer_ListView.Items.Count - 1).SubItems.Add(_CurrentImage._height)
                .Items.Item(Buffer_ListView.Items.Count - 1).SubItems.Add(_CurrentImage._width)
                .Items.Item(Buffer_ListView.Items.Count - 1).SubItems.Add(_CurrentImage._block)
                .Items.Item(Buffer_ListView.Items.Count - 1).SubItems.Add(_CurrentImage._orientation)
                .Items.Item(Buffer_ListView.Items.Count - 1).SubItems.Add(_CurrentImage._comment)
            End With
            i = i + 1
        Next
        Console.WriteLine("Load entities" & vbCrLf)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles EditImageInListBox_Button.Click
        If mode = "Добавить" Then
        Else
            EditImageInListBox()
            ImageWatch_PictureBox.ImageLocation = ImagePathToFile_TextBox.Text
            ImageProperties_GroupBox.Enabled = True
        End If

    End Sub

    Sub EditImageInListBox()
        If ImageList_ListBox.SelectedItem <> Nothing Then
            AddImageToListBox_Button.Enabled = False
            DelImageFromListBox_Button.Enabled = False
            ImageList_ListBox.Enabled = False
            For i = 0 To Buffer_ListView.Items.Count - 1
                If ImageList_ListBox.SelectedItem.ToString = Buffer_ListView.Items(i).SubItems.Item(1).Text Then
                    ImageName_TextBox.Text = Buffer_ListView.Items(i).SubItems.Item(1).Text
                    ImageFIleName_TextBox.Text = Buffer_ListView.Items(i).SubItems.Item(2).Text
                    Select Case Buffer_ListView.Items(i).SubItems.Item(3).Text
                        Case "По левому краю"
                            Alignment_ComboBox.SelectedIndex = 0
                        Case "По центру"
                            Alignment_ComboBox.SelectedIndex = 1
                        Case "По правому краю"
                            Alignment_ComboBox.SelectedIndex = 2
                    End Select
                    ImagePathToFile_TextBox.Text = Buffer_ListView.Items(i).SubItems.Item(4).Text
                    ImageHeight_TextBox.Text = Buffer_ListView.Items(i).SubItems.Item(5).Text
                    ImageWidth_TextBox.Text = Buffer_ListView.Items(i).SubItems.Item(6).Text
                    Block_NumericUpDown.Value = Buffer_ListView.Items(i).SubItems.Item(7).Text
                    If Buffer_ListView.Items(i).SubItems.Item(8).Text = "Книжная" Then
                        ImageOrientationBook_RadioButton.Checked = True
                    Else
                        ImageOrientationAlbum_RadioButton.Checked = True
                    End If
                    Comment_TextBox.Text = Buffer_ListView.Items(i).SubItems.Item(9).Text
                    fromnametoid = i
                End If
            Next
            Console.WriteLine("Edit image in listbox" & vbCrLf)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles SaveToListBox_Button.Click
        If mode = "Добавить" Then
            SyncChangesInListView()
        Else
            AddItemInListView()
        End If
        mode = ""
        clear()
        ImageProperties_GroupBox.Enabled = False
        ImageList_ListBox.Enabled = True
        AddImageToListBox_Button.Enabled = True
        DelImageFromListBox_Button.Enabled = True
        EditImageInListBox_Button.Enabled = True
    End Sub


    Sub SyncChangesInListView()
        ImageList_ListBox.Items.Add(ImageName_TextBox.Text)

        With Buffer_ListView
            .Items.Add(Buffer_ListView.Items.Count)
            .Items.Item(Buffer_ListView.Items.Count - 1).SubItems.Add(ImageName_TextBox.Text)
            .Items.Item(Buffer_ListView.Items.Count - 1).SubItems.Add(ImageFIleName_TextBox.Text)
            .Items.Item(Buffer_ListView.Items.Count - 1).SubItems.Add(Alignment_ComboBox.Text)
            .Items.Item(Buffer_ListView.Items.Count - 1).SubItems.Add(ImagePathToFile_TextBox.Text)
            .Items.Item(Buffer_ListView.Items.Count - 1).SubItems.Add(ImageHeight_TextBox.Text)
            .Items.Item(Buffer_ListView.Items.Count - 1).SubItems.Add(ImageWidth_TextBox.Text)
            .Items.Item(Buffer_ListView.Items.Count - 1).SubItems.Add(Block_NumericUpDown.Value)
        End With

        If ImageOrientationBook_RadioButton.Checked = True Then

            Buffer_ListView.Items.Item(Buffer_ListView.Items.Count - 1).SubItems.Add("Книжная")

        Else

            Buffer_ListView.Items.Item(Buffer_ListView.Items.Count - 1).SubItems.Add("Альбомная")

        End If

        Buffer_ListView.Items.Item(Buffer_ListView.Items.Count - 1).SubItems.Add(Comment_TextBox.Text)

    End Sub

    Sub AddItemInListView()
        ImageList_ListBox.Items(fromnametoid) = ImageName_TextBox.Text

        With Buffer_ListView
            .Items(fromnametoid).SubItems.Item(1).Text = ImageName_TextBox.Text
            .Items(fromnametoid).SubItems.Item(2).Text = ImageFIleName_TextBox.Text
            .Items(fromnametoid).SubItems.Item(3).Text = Alignment_ComboBox.Text
            .Items(fromnametoid).SubItems.Item(4).Text = ImagePathToFile_TextBox.Text
            .Items(fromnametoid).SubItems.Item(5).Text = ImageHeight_TextBox.Text
            .Items(fromnametoid).SubItems.Item(6).Text = ImageWidth_TextBox.Text
            .Items(fromnametoid).SubItems.Item(7).Text = Block_NumericUpDown.Value
        End With

        If ImageOrientationBook_RadioButton.Checked = True Then

            Buffer_ListView.Items(fromnametoid).SubItems.Item(8).Text = "Книжная"

        Else

            Buffer_ListView.Items(fromnametoid).SubItems.Item(8).Text = "Альбомная"

        End If

        Buffer_ListView.Items(fromnametoid).SubItems.Item(9).Text = Comment_TextBox.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles DelImageFromListBox_Button.Click
        Try
            For i = 0 To Buffer_ListView.Items.Count - 1
                If ImageList_ListBox.SelectedItem.ToString = Buffer_ListView.Items(i).SubItems.Item(1).Text Then
                    Buffer_ListView.Items(i).Remove()
                    ImageList_ListBox.Items.RemoveAt(ImageList_ListBox.SelectedIndex)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles ImageScale_TrackBar.Scroll
        ImageWatch_PictureBox.Size = New Size(firstsizewidth - (firstsizewidth * ((100 - ImageScale_TrackBar.Value) / 100)), firstsizeheight - (firstsizeheight * ((100 - ImageScale_TrackBar.Value) / 100)))
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ImageAbout_Button.Click
        frmFileInfo.Show()
    End Sub

    Private Sub ImageWidth_TextBox_TextChanged(sender As Object, e As EventArgs) Handles ImageWidth_TextBox.TextChanged, ImageHeight_TextBox.TextChanged
        If Not IsNumeric(ImageWidth_TextBox.Text) Then
            ErrorProvider1.SetError(ImageWidth_TextBox, "Необходимо ввести числовое значение")
            SaveToListBox_Button.Enabled = False
        Else
            ErrorProvider1.SetError(ImageWidth_TextBox, "")
        End If

        If Not IsNumeric(ImageHeight_TextBox.Text) Then
            ErrorProvider1.SetError(ImageHeight_TextBox, "Необходимо ввести числовое значение")
            SaveToListBox_Button.Enabled = False
        Else
            ErrorProvider1.SetError(ImageHeight_TextBox, "")
        End If

        If IsNumeric(ImageWidth_TextBox.Text) And IsNumeric(ImageHeight_TextBox.Text) Then
            SaveToListBox_Button.Enabled = True
        End If
    End Sub
End Class