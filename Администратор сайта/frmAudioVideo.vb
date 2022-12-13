Imports AxWMPLib
Public Class frmAudioVideo
    Dim FileName As String
    Dim AutoPlay As Boolean = False
    Dim PlayFileIndex As Integer
    Dim AutoFileChange As Boolean = False

    Private Sub VideoPlayerAdd_Button_Click(sender As Object, e As EventArgs) Handles VideoPlayListAdd_Button.Click
        OpenMultiMediaFile()
    End Sub

    Sub OpenMultiMediaFile()
        With OpenFileDialog1
            .Title = "Выберите файл"
            .Filter = "Только файлы| *.mp4;*.avi;*.mkv;*.flv;*.mp3 |Все файлы| *.*"
            .FileName = ""
            .InitialDirectory = "C:\"
            .Multiselect = False
        End With

        Try
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                If OpenFileDialog1.FileName <> Nothing Then
                    FileName = OpenFileDialog1.FileName
                    VideoPlayList_ListBox.Items.Add(FileName)
                End If
            End If
            Console.WriteLine("Open File: " & FileName & vbCrLf)
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message & vbCrLf)
        End Try
    End Sub
    Private Sub chbAutoPlay_CheckedChanged(sender As Object, e As EventArgs) Handles VideoAutoPlay_CheckBox.CheckedChanged
        Console.WriteLine("Change AutoLaunch: " & sender.ToString() & vbCrLf)
        If VideoAutoPlay_CheckBox.Checked Then
            VideoNextPlay_CheckBox.Enabled = True
            AutoPlay = True
        Else
            VideoNextPlay_CheckBox.Enabled = False
            VideoNextPlay_CheckBox.Checked = False
            AutoPlay = False
        End If
    End Sub

    Private Sub AxWindowsMediaPlayer1_PlayStateChange(sender As Object, e As _WMPOCXEvents_PlayStateChangeEvent)
        Console.WriteLine("Change PlayState: " & sender.ToString() & " " & WindowsMediaPlayer.playState.ToString() & vbCrLf)
        If WindowsMediaPlayer.playState = WMPLib.WMPPlayState.wmppsMediaEnded Then
            If AutoFileChange = True Then
                VideoPlayList_ListBox.SelectedIndex = VideoPlayList_ListBox.SelectedIndex + 1
                PlayFileIndex = VideoPlayList_ListBox.SelectedIndex
                PlayFile(PlayFileIndex)
            End If
        End If
    End Sub

    Private Sub chbСontlyPlay_CheckedChanged(sender As Object, e As EventArgs) Handles VideoNextPlay_CheckBox.CheckedChanged
        Console.WriteLine("Change AutoChangeFile: " & sender.ToString() & vbCrLf)
        If VideoNextPlay_CheckBox.Checked Then
            AutoFileChange = True
        Else
            AutoFileChange = False
        End If
    End Sub

    Sub PlayFile(ByVal PlayFileIndex As Integer)
        Console.WriteLine("Playing file: " & VideoPlayList_ListBox.Items(PlayFileIndex).ToString() & vbCrLf)
        Try
            If AutoPlay = True Or AutoFileChange = True Then
                WindowsMediaPlayer.URL = VideoPlayList_ListBox.Items(PlayFileIndex)
                Timer1.Enabled = True
            Else
                If AutoPlay = False Then
                    WindowsMediaPlayer.URL = VideoPlayList_ListBox.Items(PlayFileIndex)
                    WindowsMediaPlayer.Ctlcontrols.stop()
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        WindowsMediaPlayer.Ctlcontrols.play()
        Timer1.Enabled = False
    End Sub

    Private Sub playListBox_Click(sender As Object, e As EventArgs) Handles VideoPlayList_ListBox.Click
        Try
            PlayFileIndex = VideoPlayList_ListBox.SelectedIndex
            PlayFile(PlayFileIndex)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub VideoDel_Button_Click(sender As Object, e As EventArgs) Handles VideoPlayListDel_Button.Click
        If VideoPlayList_ListBox.SelectedIndex <> Nothing Then
            VideoPlayList_ListBox.Items.RemoveAt(VideoPlayList_ListBox.SelectedIndex)
            Console.WriteLine("Remove file from: " & sender.ToString() & vbCrLf)
        End If
    End Sub

    Private Sub VideosClear_Button_Click(sender As Object, e As EventArgs) Handles VideoPlayListClear_Button.Click
        WindowsMediaPlayer.URL = ""
        VideoPlayList_ListBox.Items.Clear()
        Console.WriteLine("Clear all files from: " & sender.ToString() & vbCrLf)
    End Sub

    Private Sub VideoPlayerClose_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Console.WriteLine("frmAudioVideo close: " & sender.ToString() & vbCrLf)
        Me.Close()
    End Sub

    Private Sub VideoPlayListAdd_Button_MouseHover(sender As Object, e As EventArgs) Handles VideoPlayListAdd_Button.MouseHover
        ToolTip1.Show("Данная кнопка добавляет видео/аудио в список воспроизведения", VideoPlayListAdd_Button)
    End Sub

    Private Sub VideoPlayListDel_Button_MouseHover(sender As Object, e As EventArgs) Handles VideoPlayListDel_Button.MouseHover
        ToolTip1.Show("Данная кнопка удаляет выделенное видео/аудио из списка воспроизведения", VideoPlayListDel_Button)
    End Sub

    Private Sub VideoPlayListClear_Button_MouseHover(sender As Object, e As EventArgs) Handles VideoPlayListClear_Button.MouseHover
        ToolTip1.Show("Данная кнопка полностью очищает список", VideoPlayListClear_Button)
    End Sub

    Private Sub Exit_Button_MouseHover(sender As Object, e As EventArgs) Handles Exit_Button.MouseHover
        ToolTip1.Show("Закрыть", Exit_Button)
    End Sub
End Class