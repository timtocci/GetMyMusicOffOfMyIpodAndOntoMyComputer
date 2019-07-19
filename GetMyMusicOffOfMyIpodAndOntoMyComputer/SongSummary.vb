
''' <summary>
''' Class that holds song data and performs comparison of Songs for sorting.
''' </summary>
Public Class SongSummary
    Implements IEquatable(Of SongSummary)
    Implements IComparable(Of SongSummary)

    Public Property Artist As String = ""
    Public Property Album As String = ""
    Public Property Title As String = ""
    Public Property Path As String = ""
    Public Property Extension As String = ""
    Public Property Length As String = ""
    Public Property Bitrate As String = ""
    Public Property TrackNum As Integer = 0
    Public Property Size As ULong = 0


    Public Overrides Function Equals(other As Object) As Boolean
        If other Is Nothing Then
            Return False
        End If
        Dim objOther As SongSummary = TryCast(other, SongSummary)
        If objOther Is Nothing Then
            Return False
        Else
            Return Equals(objOther)
        End If
    End Function

    Public Overloads Function Equals(other As SongSummary) As Boolean Implements IEquatable(Of SongSummary).Equals
        If other Is Nothing Then
            Return False
        End If
        Return (Me.Album.Equals(other.Album))
    End Function

    ' default sorting by Album
    Public Function CompareTo(other As SongSummary) As Integer Implements IComparable(Of SongSummary).CompareTo
        If other Is Nothing Then
            Return 1
        End If
        Return Me.Album.CompareTo(other.Album)
    End Function
End Class
