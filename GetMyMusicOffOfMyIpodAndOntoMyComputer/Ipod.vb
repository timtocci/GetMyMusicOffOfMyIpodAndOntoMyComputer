Imports System.IO
Imports System.Security

Public Class Ipod
    Public Shared RootDirectory As String = ""
    Public Shared ControlDirectory As String = ""
    Public Shared MusicDirectory As String = ""

    ''' <summary>
    ''' Checks for the iPod control folder in all removable drives
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Shared Function IsConnected() As Boolean
        Try
            Dim drives() As DriveInfo = DriveInfo.GetDrives()
            For Each drive In drives
                If drive.IsReady = True And drive.DriveType = DriveType.Removable Then
                    If Directory.Exists(drive.Name & "iPod_Control") Then
                        RootDirectory = drive.RootDirectory.ToString
                        ControlDirectory = drive.RootDirectory.ToString & "iPod_Control"
                        If Directory.Exists(drive.RootDirectory.ToString & "iPod_Control\Music") Then
                            MusicDirectory = drive.RootDirectory.ToString & "iPod_Control\Music"
                        End If
                        Return vbTrue
                    End If
                End If
            Next
        Catch s As SecurityException
            MsgBox(s.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return vbFalse
    End Function

    Public Shared Function MusicSummary() As List(Of SongSummary)
        Dim summs As New List(Of SongSummary)
        summs.AddRange(GetMusicFileSummary)
        Return summs
    End Function

    Public Shared Function FileCount() As Integer
        Return EnumerateMusicFiles.Count
    End Function

    ''' <summary>
    ''' Returns a list of file paths to music files on the iPod
    ''' </summary>
    ''' <returns>List Of File Paths</returns>
    Private Shared Function EnumerateMusicFiles() As List(Of String)
        Try
            Dim dirs As IEnumerable(Of String) = Directory.EnumerateDirectories(MusicDirectory)
            Dim files As New List(Of String)
            For Each d In dirs
                files.AddRange(Directory.EnumerateFiles(d.ToString))
            Next
            Return files
        Catch s As SecurityException
            MsgBox(s.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function


    ' this can probably be refactored to be faster
    Private Shared Function GetMusicFileSummary() As List(Of SongSummary)
        ' https://stackoverflow.com/questions/26142723/get-extended-file-information-details
        Dim summs As New List(Of SongSummary)
        ' https://stackoverflow.com/questions/220097/read-write-extended-file-properties-c?noredirect=1&lq=1
        'Dim shell As New Shell32.Shell ' <--problems!?...
        ' do it the long way
        Dim shellType = Type.GetTypeFromProgID("Shell.Application")
        Dim shell = Activator.CreateInstance(shellType)

        Dim sFolder As Shell32.Folder
        Dim key As String = ""
        Try
            Dim dirs As IEnumerable(Of String) = Directory.EnumerateDirectories(MusicDirectory)
            For Each d In dirs
                sFolder = shell.NameSpace(d.ToString)
                For Each f In sFolder.Items
                    Dim summ As New SongSummary
                    ' below returns formatted size - need bytes
                    ' summ.Size = sFolder.GetDetailsOf(f, 1)
                    Dim ndx As Int32 = 0
                    key = sFolder.GetDetailsOf(sFolder.Items, ndx)
                    Do Until String.IsNullOrEmpty(key) AndAlso ndx > 310
                        If String.IsNullOrEmpty(key) = False Then
                            If key = "Authors" Then
                                summ.Artist = sFolder.GetDetailsOf(f, ndx)
                            ElseIf key = "Title" Then
                                summ.Title = sFolder.GetDetailsOf(f, ndx)
                            ElseIf key = "Path" Then
                                summ.Path = sFolder.GetDetailsOf(f, ndx)
                            ElseIf key = "Album" Then
                                summ.Album = sFolder.GetDetailsOf(f, ndx)
                            ElseIf key = "File extension" Then
                                summ.Extension = sFolder.GetDetailsOf(f, ndx)
                                If IsMovieFile(summ.Extension) Then
                                    summ.Album = "Movies"
                                    summ.Artist = "Video"
                                End If
                            ElseIf key = "Length" Then
                                summ.Length = sFolder.GetDetailsOf(f, ndx)
                            ElseIf key = "Bit rate" Then
                                summ.Bitrate = sFolder.GetDetailsOf(f, ndx)
                            End If
                        End If
                        ndx += 1
                        key = sFolder.GetDetailsOf(sFolder.Items, ndx)
                    Loop
                    ' this gives up the byte length
                    summ.Size = My.Computer.FileSystem.GetFileInfo(summ.Path).Length
                    ' for singles songs
                    If summ.Album = "" Then
                        summ.Album = "Singles"
                    End If
                    summs.Add(summ)
                Next
                sFolder = Nothing
            Next
        Catch s As SecurityException
            MsgBox(s.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' use default CompareTo (by album)
        summs.Sort()
        Return summs
    End Function

    ''' <summary>
    ''' Tests the file extension for movie file types
    ''' (for now only iTunes imported DVD type included).
    ''' </summary>
    ''' <param name="extension">extension with period</param>
    ''' <returns>Boolean if extension is movie type</returns>
    Private Shared Function IsMovieFile(extension As String) As Boolean
        Dim extensions As List(Of String) = New List(Of String)
        extensions.Add(".m4v")
        ' add others here as needed
        For Each ext As String In extensions
            If extension = ext Then
                Return True
            End If
        Next
        Return False
    End Function
End Class
