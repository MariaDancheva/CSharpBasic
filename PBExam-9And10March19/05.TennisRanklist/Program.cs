int tournamentsCount = int.Parse(Console.ReadLine());
int points = int.Parse(Console.ReadLine());
int win = 0;
int pointsWon = 0;

for (int i = 0; i < tournamentsCount; i++)
{
    string stage = Console.ReadLine();
    switch (stage)
    {
        case "W":
            win++;
            pointsWon += 2000;
            break;
        case "F":
            pointsWon += 1200;
            break;
        default:
            pointsWon += 720;
            break;
    }
}
Console.WriteLine($"Final points: {points + pointsWon}");
Console.WriteLine($"Average points: {pointsWon/tournamentsCount}");
Console.WriteLine($"{(double)win/tournamentsCount * 100:F2}%");