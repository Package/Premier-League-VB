Public Class ResultProcessor

    ''' <summary>
    ''' Process the result data and build the league table out of it.
    ''' </summary>
    ''' <param name="Data"></param>
    ''' <returns></returns>
    Public Function ProcessData(ByVal Data() As String)
        Dim Teams As List(Of Team) = New List(Of Team)

        For Each Line As String In Data
            Dim Result = Line.Split(",")

            ' Parse the team data
            Dim HomeTeamName As String = Result(0)
            Dim AwayTeamName As String = Result(1)
            Dim Score As String = Result(2)

            ' Parse the score data
            Dim ScoreData = Score.Split("-")
            Dim HomeScore As Integer = ScoreData(0)
            Dim AwayScore As Integer = ScoreData(1)

            ' Find the teams in the table
            Dim HomeTeam As Team = Teams.FirstOrDefault(Function(t) String.Compare(t.Name, HomeTeamName) = 0)
            Dim AwayTeam As Team = Teams.FirstOrDefault(Function(t) String.Compare(t.Name, AwayTeamName) = 0)

            ' Or set them up if they don't exist
            If HomeTeam Is Nothing Then
                HomeTeam = New Team(HomeTeamName, 0)
                Teams.Add(HomeTeam)
            End If
            If AwayTeam Is Nothing Then
                AwayTeam = New Team(AwayTeamName, 0)
                Teams.Add(AwayTeam)
            End If

            ' Work out who won and apply correct points
            If HomeScore > AwayScore Then
                HomeTeam.Points += 3
                HomeTeam.Wins += 1
                AwayTeam.Loses += 1
            ElseIf AwayScore > HomeScore Then
                AwayTeam.Points += 3
                AwayTeam.Wins += 1
                HomeTeam.Loses += 1
            Else
                HomeTeam.Points += 1
                AwayTeam.Points += 1
                HomeTeam.Draws += 1
                AwayTeam.Draws += 1
            End If

            ' And goal differences
            HomeTeam.GoalsFor += HomeScore
            HomeTeam.GoalsAgainst += AwayScore
            AwayTeam.GoalsFor += AwayScore
            AwayTeam.GoalsAgainst += HomeScore

        Next

        Return OrderResults(Teams)
    End Function


    ''' <summary>
    ''' Orders the league table by the team with the most points.
    ''' </summary>
    ''' <param name="Teams"></param>
    ''' <returns></returns>
    Private Function OrderResults(ByVal Teams As List(Of Team)) As List(Of Team)
        Return Teams.OrderByDescending(Function(t) t.Points).ThenByDescending(Function(t) t.Name).ToList()
    End Function

End Class
