string playerName = Console.ReadLine();
int points = 301;
int shotsMade = 0;
int unsuccessfulShots = 0;
for (int i = 0; points >= 0; i++)
{
    string area = Console.ReadLine();
    if (area == "Retire")
    {
        Console.WriteLine($"{playerName} retired after {unsuccessfulShots} unsuccessful shots.");
        break;
    }

    int score = int.Parse(Console.ReadLine());

    switch (area)
    {
        case "Single":
            break;
        case "Double":
            score *= 2;
            break;
        case "Triple":
            score *= 3;
            break;
    }
    

    if (score > points)
    {
        unsuccessfulShots++;
        score = 0;
    }
    else
    {
        shotsMade++;
        points -= score;
        if (points == 0)
            break;
    }
}

if(points == 0)
    Console.WriteLine($"{playerName} won the leg with {shotsMade} shots.");