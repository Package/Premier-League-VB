Public Class Team
    Public Name As String
    Public Points As Integer
    Public Wins As Integer
    Public Draws As Integer
    Public Loses As Integer
    Public GoalsFor As Integer
    Public GoalsAgainst As Integer

    Public ReadOnly Property GoalDifference As Integer
        Get
            Return GoalsFor - GoalsAgainst
        End Get
    End Property

    Public ReadOnly Property Played As Integer
        Get
            Return Wins + Draws + Loses
        End Get
    End Property

    Public Sub New(ByVal name As String, ByVal points As Integer)
        Me.Name = name
        Me.Points = points
    End Sub

    ''' <summary>
    ''' Display the details about this team, e.g their name, points, games won, lost, drawn etc.
    ''' </summary>
    Public Sub Display()
        Console.WriteLine(Name & " W: " & Wins.ToString() & " D: " & Draws.ToString() & " L: " & Loses.ToString() &
                          " GF: " & GoalsFor.ToString() & " GA: " + GoalsAgainst.ToString() & " GD: " & GoalDifference.ToString() & " Pts: " & Points.ToString())
    End Sub
End Class