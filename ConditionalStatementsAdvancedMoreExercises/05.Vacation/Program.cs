double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string location = "";
string place = "";
double price = 0;

if (budget <= 1000)
{
    place = "Camp";
    switch (season)
    {
        case "Summer":
            location = "Alaska";
            price = budget * 0.65;
            break;
        default:
            location = "Morocco";
            price = budget * 0.45;
            break;
    }
}
else if (budget > 1000 && budget <= 3000)
{
    place = "Hut";
    switch (season)
    {
        case "Summer":
            location = "Alaska";
            price = budget * 0.8;
            break;
        default:
            location = "Morocco";
            price = budget * 0.6;
            break;
    }
}
else
{
    place = "Hotel";
    switch (season)
    {
        case "Summer":
            location = "Alaska";
            price = budget * 0.9;
            break;
        default:
            location = "Morocco";
            price = budget * 0.9;
            break;
    }
}

Console.WriteLine($"{location} - {place} - {price:F2}");