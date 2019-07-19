Module Util

    ''' <summary>
    ''' Normalizes a string to be used in a file path.
    ''' Makes the assumption that all illegal characters
    ''' and spaces should be replaced with a char (in this
    ''' case an underscore).
    ''' </summary>
    ''' <param name="pathstring">the string to normalize</param>
    ''' <param name="replacementchar">optional replacement string</param>
    ''' <param name="persistSpaces">optional persist spaces boolean</param>
    ''' <returns>normalized string</returns>
    Function NormalizePathString(pathstring As String, Optional ByVal replacementchar As String = "_", Optional ByVal persistSpaces As Boolean = False) As String
        ' \\/:*?""<>|
        If Not persistSpaces Then
            pathstring = pathstring.Replace(" ", replacementchar)
        End If
        pathstring = pathstring.Replace("\\", replacementchar)
        pathstring = pathstring.Replace("/", replacementchar)
        pathstring = pathstring.Replace(":", replacementchar)
        pathstring = pathstring.Replace("#", replacementchar)
        pathstring = pathstring.Replace("?", replacementchar)
        pathstring = pathstring.Replace("""", replacementchar)
        pathstring = pathstring.Replace("<", replacementchar)
        pathstring = pathstring.Replace(">", replacementchar)
        pathstring = pathstring.Replace("|", replacementchar)
        Return pathstring
    End Function
End Module