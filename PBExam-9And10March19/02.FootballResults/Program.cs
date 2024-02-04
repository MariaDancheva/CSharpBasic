string firstGame = Console.ReadLine();
string secondGame = Console.ReadLine();
string thirdGame = Console.ReadLine();

int won = 0;
int lost = 0;
int draw = 0;
int firstHome = firstGame[0];
int firstGuests = firstGame[2];
int secondHome = secondGame[0];
int secondGuests = secondGame[2];
int thirdHome = thirdGame[0];
int thirdGuests = thirdGame[2];

if (firstHome > firstGuests)
    won++;
else if (firstGuests == firstHome)
    draw++;
else
    lost++;
if (secondHome > secondGuests)
    won++;
else if (secondHome == secondGuests)
    draw++;
else
    lost++;
if (thirdHome > thirdGuests)
    won++;
else if (thirdHome == thirdGuests)
    draw++;
else
    lost++;

Console.WriteLine($"Team won {won} games.");
Console.WriteLine($"Team lost {lost} games.");
Console.WriteLine($" Drawn games: {draw}");
