
Module LeagueAssignment

    Sub Main()
        Dim ConsoleHandler As ConsoleHandler = New ConsoleHandler()
        Dim FileName As String = ConsoleHandler.GetFileInput()

        Dim FileHandler As FileHandler = New FileHandler()
        Dim Data = FileHandler.ReadFile(FileName)

        Dim ResultProcessor As ResultProcessor = New ResultProcessor()
        Dim Teams As List(Of Team) = ResultProcessor.ProcessData(Data)

        For Each CurrentTeam As Team In Teams
            CurrentTeam.Display()
        Next

        Console.ReadLine()
    End Sub

End Module
