string tournamentName = Console.ReadLine();
int win = 0;
int loss = 0;
int countGames = 0;

while (tournamentName != "End of tournaments")
{
    int gamesPerTournament = int.Parse(Console.ReadLine());
    for (int i = 1; i <= gamesPerTournament; i++)
    {
        countGames++;
        int pointsJessy = int.Parse(Console.ReadLine());
        int pointsOpponent = int.Parse(Console.ReadLine());

        if (pointsJessy > pointsOpponent)
        {
            win++;
            Console.WriteLine($"Game {i} of tournament {tournamentName}: win with {pointsJessy - pointsOpponent} points.");
            continue;
        }
        loss++;
        Console.WriteLine($"Game {i} of tournament {tournamentName}: lost with {pointsOpponent - pointsJessy} points.");
    }
    tournamentName = Console.ReadLine();
}
Console.WriteLine($"{(double)win / countGames * 100:F2}% matches win");
Console.WriteLine($"{(double)loss / countGames * 100:F2}% matches lost");