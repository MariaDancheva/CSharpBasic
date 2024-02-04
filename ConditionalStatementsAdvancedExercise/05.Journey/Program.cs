double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string destination = "";
string vacaitionType = "";
double moneyLeft = 0;

if (budget <= 100)
{
    destination = "Bulgaria";
    if (season == "summer")
    {
        moneyLeft= budget - budget * 0.7;
        vacaitionType = "Camp";
    }
    else
    {
        moneyLeft = budget - budget * 0.3;
        vacaitionType = "Hotel";
    }
}
else if (budget <= 1000)
{
    destination = "Balkans";
    if (season == "summer")
    {
        moneyLeft = budget - budget * 0.6;
        vacaitionType = "Camp";

    }
    else
    {
        moneyLeft = budget - budget * 0.2;
        vacaitionType = "Hotel";

    }
}
else
{
    destination = "Europe";
    vacaitionType = "Hotel";
      moneyLeft = budget - budget * 0.1;
 
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{vacaitionType} - {moneyLeft:F2}");


