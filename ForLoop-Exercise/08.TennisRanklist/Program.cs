int numberTournaments = int.Parse(Console.ReadLine());
int startingPoints = int.Parse(Console.ReadLine());
int pointsEarned = 0;
double win = 0.0;

for (int i = 0; i < numberTournaments; i++)
{
    string stageReached = Console.ReadLine();
    switch (stageReached)
    {
        case "W":
            pointsEarned += 2000;
            win++;
            break;
        case "F":
            pointsEarned += 1200;
            break;
        default:
            pointsEarned += 720;
            break;
    }
}
int averagePoints =pointsEarned / numberTournaments;
double winPersentage = win * 100 / numberTournaments;

Console.WriteLine($"Final points: {pointsEarned + startingPoints}");
Console.WriteLine($"Average points: {averagePoints}");
Console.WriteLine($"{winPersentage:F2}%");