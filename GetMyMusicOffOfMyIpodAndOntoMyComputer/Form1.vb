Imports System.IO
Imports System.ComponentModel
Imports Microsoft.WindowsAPICodePack.Taskbar
Imports System.Security

Public Class frmMain
    Dim debug As Boolean = False
    Dim running As Boolean = False
    Dim mouseoffset As Size = Nothing
    Dim activePanel As Panel = pWelcome
    Dim summs As List(Of SongSummary) = Nothing
    Dim songsSum As Long = Nothing
    Dim activeSong As SongSummary = Nothing
    Dim writeComplete As Boolean = False
    Dim readComplete As Boolean = False

    ' w 530 h 428
    ' w 431 h 320 x50 y51
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Width = 530
        Me.Height = 428
        Dim loc As New Point With {
            .X = 50,
            .Y = 51
        }
        activePanel = pWelcome
        ' pWelcome is initially shown
        pNotConn.Hide()
        pNotConn.Width = 431
        pNotConn.Height = 320
        pNotConn.Location = loc

        pNoSpace.Hide()
        pNoSpace.Width = 431
        pNoSpace.Height = 320
        pNoSpace.Location = loc

        pProcessing.Hide()
        pProcessing.Width = 431
        pProcessing.Height = 320
        pProcessing.Location = loc

        pAbout.Hide()
        pAbout.Width = 431
        pAbout.Height = 320
        pAbout.Location = loc

        pEmptyIpod.Hide()
        pEmptyIpod.Width = 431
        pEmptyIpod.Height = 320
        pEmptyIpod.Location = loc

    End Sub

    Sub WriteTestFile(summarys As IEnumerable(Of SongSummary), Optional path As String = "")
        Try
            Dim fPath As String
            If path = "" Then
                fPath = My.Computer.FileSystem.SpecialDirectories.Desktop + "\music_debug.txt"
            Else
                fPath = path
            End If

            Dim file = My.Computer.FileSystem.OpenTextFileWriter(fPath, True)
            For Each song As SongSummary In summarys
                file.WriteLine(song.Album)
                file.WriteLine(song.Artist)
                file.WriteLine(song.Title)
                file.WriteLine(song.Path)
                file.WriteLine(song.Bitrate)
                file.WriteLine(song.Length)
                file.WriteLine(song.Extension)
                file.WriteLine(song.Size)
                file.WriteLine()
            Next
            file.Close()
        Catch s As SecurityException
            MsgBox("Security exception in WriteTestFile" & vbNewLine & s.Message)
        Catch ex As Exception
            MsgBox("Problem in WriteTestFile" & vbNewLine & ex.Message)
        End Try
    End Sub

    Sub WriteMusicFolderToDesktop(summarys As List(Of SongSummary))
        Try
            lblDrive.Text = Ipod.RootDirectory
            lblNumFiles.Text = summarys.Count.ToString
            Dim deskFldr As String = My.Computer.FileSystem.SpecialDirectories.Desktop + "\iPod_Music"
            If Not My.Computer.FileSystem.DirectoryExists(deskFldr) Then
                My.Computer.FileSystem.CreateDirectory(deskFldr)
            End If
            If debug Then
                WriteTestFile(summarys, deskFldr + "\music_debug.txt")
            End If
            progress.Maximum = summarys.Count
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal)
            TaskbarManager.Instance.SetProgressValue(1, summarys.Count)
            Dim iterator As Integer = 1

            For Each song In summarys
                Dim bwFS As BackgroundWorker = New BackgroundWorker
                bwFS.WorkerReportsProgress = False
                bwFS.WorkerSupportsCancellation = False
                AddHandler bwFS.DoWork, AddressOf SongFSWork
                AddHandler bwFS.RunWorkerCompleted, AddressOf SongFSComplete


                Dim albumPath As String = deskFldr + "\" + Util.NormalizePathString(song.Album)
                Dim songWritePath As String = albumPath + "\" + Util.NormalizePathString(song.Title) + song.Extension
                lblIpodFPath.Text = song.Path
                lblCompFPath.Text = songWritePath
                activeSong = song
                If Not bwFS.IsBusy Then
                    bwFS.RunWorkerAsync()
                End If
                Do Until writeComplete = True
                    Application.DoEvents()
                Loop
                writeComplete = False
                TaskbarManager.Instance.SetProgressValue(iterator, summarys.Count)
                progress.Value = iterator
                iterator += 1

            Next
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress)
        Catch s As SecurityException
            MsgBox("Security exception in WriteMusicFolderToDesktop" & vbNewLine & s.Message)
        Catch ex As Exception
            MsgBox("Problem in WriteMusicFolderToDesktop" & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub SongFSWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Try
            Dim song As SongSummary = activeSong
            Dim sData As Byte()
            Dim deskFldr As String = My.Computer.FileSystem.SpecialDirectories.Desktop + "\iPod_Music"
            Dim albumPath As String = deskFldr + "\" + Util.NormalizePathString(song.Album)
            Dim songWritePath As String = albumPath + "\" + Util.NormalizePathString(song.Title) + song.Extension
            If Not My.Computer.FileSystem.DirectoryExists(albumPath) Then
                My.Computer.FileSystem.CreateDirectory(albumPath)
            End If
            sData = My.Computer.FileSystem.ReadAllBytes(song.Path)
            My.Computer.FileSystem.WriteAllBytes(songWritePath, sData, True)
        Catch s As SecurityException
            MsgBox("Security exception in SongFSWork" & vbNewLine & s.Message)
        Catch ex As Exception
            MsgBox("Problem in SongFSWork" & vbNewLine & ex.Message)
        End Try
    End Sub
    Private Sub SongFSComplete(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        Me.writeComplete = True
    End Sub

    Private Sub frmMain_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            mouseoffset = New Size(e.Location)
        End If
    End Sub

    Private Sub frmMain_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If Not mouseoffset.IsEmpty Then
            Me.Location = Cursor.Position - mouseoffset
        End If
    End Sub

    Private Sub frmMain_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        mouseoffset = Nothing
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If running Then
            Me.WindowState = FormWindowState.Minimized
        Else
            Me.Close()
        End If
    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click, btnRetry.Click, btnTryAgain.Click
        If Ipod.IsConnected Then
            btnStart.Hide()
            wait.Enabled = True
            wait.Style = ProgressBarStyle.Marquee
            wait.Show()
            lblWait.Show()
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Indeterminate)

            If Ipod.FileCount = 0 Then
                ' no songs on ipod
                activePanel.Hide()
                pEmptyIpod.Show()
                activePanel = pEmptyIpod
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error)
            End If
            Dim bwGetMusicAndSumSongs As New BackgroundWorker
            bwGetMusicAndSumSongs.WorkerReportsProgress = False
            bwGetMusicAndSumSongs.WorkerSupportsCancellation = False
            AddHandler bwGetMusicAndSumSongs.DoWork, AddressOf GetMusicAndSumSongsWork
            AddHandler bwGetMusicAndSumSongs.RunWorkerCompleted, AddressOf GetMusicAndSumSongsCompleted
            If Not bwGetMusicAndSumSongs.IsBusy Then
                bwGetMusicAndSumSongs.RunWorkerAsync()
            End If
            Do Until readComplete
                Application.DoEvents()
            Loop
            If songsSum > GetMainDriveAvailabeSpace() Then
                ' not enough space to copy files
                activePanel.Hide()
                pNoSpace.Show()
                activePanel = pNoSpace
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error)
            Else
                ' lets get it on
                running = True
                activePanel.Hide()
                pProcessing.Show()
                activePanel = pProcessing
                WriteMusicFolderToDesktop(summs)
                activePanel.Hide()
                pAbout.Show()
                activePanel = pAbout
                running = False
            End If
        Else
            activePanel.Hide()
            pNotConn.Show()
            activePanel = pNotConn
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error)
        End If
    End Sub

    Private Sub GetMusicAndSumSongsCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        readComplete = True
    End Sub

    Private Sub GetMusicAndSumSongsWork(sender As Object, e As DoWorkEventArgs)
        summs = Ipod.MusicSummary()
        songsSum = SumSongSizes(summs)
    End Sub

    Private Function GetMainDriveAvailabeSpace() As ULong
        Try
            Dim allDrives() As DriveInfo = DriveInfo.GetDrives()
            Dim dtPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop
            For Each drv In allDrives
                If drv.Name = dtPath.Substring(0, 3) Then
                    Return drv.AvailableFreeSpace
                End If
            Next
        Catch s As SecurityException
            MsgBox("Security exception in GetMainDriveAvailabeSpace" & vbNewLine & s.Message)
        Catch ex As Exception
            MsgBox("Problem in GetMainDriveAvailabeSpace" & vbNewLine & ex.Message)
        End Try
        Return 0
    End Function

    Private Function SumSongSizes(summs As List(Of SongSummary)) As ULong
        Dim retLng As ULong = 0
        For Each song In summs
            retLng += song.Size
        Next
        Return retLng
    End Function

    Private Sub BtnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        btnClose.ForeColor = Color.AliceBlue
    End Sub

    Private Sub BtnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        btnClose.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
    End Sub

    Private Sub BtnMin_MouseHover(sender As Object, e As EventArgs) Handles btnMin.MouseHover
        btnMin.ForeColor = Color.AliceBlue
    End Sub

    Private Sub BtnMin_MouseLeave(sender As Object, e As EventArgs) Handles btnMin.MouseLeave
        btnMin.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
    End Sub

    Private Sub Mypic_Click(sender As Object, e As EventArgs) Handles mypic.Click
        Dim webAddress As String = "https://timothytocci.com/"
        Process.Start(webAddress)
    End Sub

    Private Sub Twitterpic_Click(sender As Object, e As EventArgs) Handles twitterpic.Click
        Dim webAddress As String = "https://twitter.com/timothytocci"
        Process.Start(webAddress)
    End Sub

    Private Sub Githubpic_Click(sender As Object, e As EventArgs) Handles githubpic.Click
        Dim webAddress As String = "https://github.com/timtocci/GetMyMusicOffOfMyIpodAndOntoMyComputer"
        Process.Start(webAddress)
    End Sub

    Private Sub Facebookpic_Click(sender As Object, e As EventArgs) Handles facebookpic.Click
        Dim webAddress As String = "https://www.facebook.com/timothy.tocci"
        Process.Start(webAddress)
    End Sub

    Private Sub Skypepic_Click(sender As Object, e As EventArgs) Handles skypepic.Click
        Dim webAddress As String = "https://join.skype.com/invite/vzI2WnBSiDqF"
        Process.Start(webAddress)
    End Sub
End Class
