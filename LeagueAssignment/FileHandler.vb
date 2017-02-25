Imports System.IO

Public Class FileHandler

    ''' <summary>
    ''' Read the data from the input file.
    ''' </summary>
    ''' <param name="FileName"></param>
    ''' <returns></returns>
    Public Function ReadFile(ByVal FileName As String)
        If File.Exists(FileName) = True Then
            Dim Data = File.ReadAllLines(FileName)

            'For Each Line As String In Data
            '    Console.WriteLine(Line)
            'Next

            Return Data
        End If

        Return String.Empty
    End Function

End Class
