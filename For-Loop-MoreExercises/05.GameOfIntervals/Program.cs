int moves = int.Parse(Console.ReadLine());

double result = 0.0;
double invalidNumber = 0.0;
double hundredPoints = 0.0;
double fiftyPoints = 0.0;
double fourtyPersent = 0.0;
double thirtyPersent = 0.0;
double twentyPersent = 0.0;

for (int i = 1; i <= moves; i++)
{
    int points = int.Parse(Console.ReadLine());
    switch (points)
    {
        case >= 0 and <= 9:
            result += points * 0.2;
            twentyPersent++;

            break;
        case >= 10 and <= 19:
            result += points * 0.3;
            thirtyPersent++;
            break;
        case >= 20 and <= 29:
            result += points * 0.4;
            fourtyPersent++;
            break;
        case >= 30 and <= 39:
            result += 50.0;
            fiftyPoints++;
            break;
        case >= 40 and <= 50:
            result += 100.0;
            hundredPoints++;
            break;
        default:
            result /= 2;
            invalidNumber++;
            break;
    }
}

Console.WriteLine($"{result:F2}");
Console.WriteLine($"From 0 to 9: {twentyPersent * 100 / moves:F2}%");
Console.WriteLine($"From 10 to 19: {thirtyPersent * 100 / moves:F2}%");
Console.WriteLine($"From 20 to 29: {fourtyPersent * 100 / moves:F2}%");
Console.WriteLine($"From 30 to 39: {fiftyPoints * 100 / moves:F2}%");
Console.WriteLine($"From 40 to 50: {hundredPoints * 100 / moves:F2}%");
Console.WriteLine($"Invalid numbers: {invalidNumber * 100 / moves:F2}%");
