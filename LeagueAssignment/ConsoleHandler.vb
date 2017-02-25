Public Class ConsoleHandler

    ''' <summary>
    ''' Get the name of the input file that contains the data the user would like to process.
    ''' </summary>
    ''' <returns></returns>
    Public Function GetFileInput() As String
        Dim Desktop As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim Directory As String = "\Data\"
        Dim FileName As String = ""

        Console.WriteLine("Which league do you want to process?")
        Console.WriteLine("Enter 1 for Premier League")
        Console.WriteLine("Enter 2 for Championship")
        Console.WriteLine("Enter 3 for League One")
        Console.WriteLine("Enter 4 for League Two")
        Console.WriteLine("Enter 5 for Conference")
        Dim Input As Integer = Convert.ToInt32(Console.ReadLine())

        Select Case Input
            Case 1
                FileName = "PremierLeague"
            Case 2
                FileName = "Championship"
            Case 3
                FileName = "LeagueOne"
            Case 4
                FileName = "LeagueTwo"
            Case 5
                FileName = "Conference"
            Case Else
                Console.WriteLine("Sorry, I didn't understand that. I'm going to show you the premier league table.")
        End Select

        Return Desktop & Directory & FileName & ".csv"

    End Function

End Class
