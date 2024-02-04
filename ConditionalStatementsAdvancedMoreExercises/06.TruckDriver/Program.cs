string season = Console.ReadLine();
double kmPerMonth = double.Parse(Console.ReadLine());
double income = 0;

if (kmPerMonth >= 10 && kmPerMonth <= 5000)
{
    switch (season)
    {
        case "Spring":
        case "Autumn":
            income = (kmPerMonth * 4) * 0.75;
            break;
        case "Summer":
            income = (kmPerMonth * 4)* 0.9;
            break;
        default:
            income = (kmPerMonth * 4) * 1.05;
            break;
    }
}
else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
{
    switch (season)
    {
        case "Spring":
        case "Autumn":
            income = (kmPerMonth * 4) * 0.95;
            break;
        case "Summer":
            income = (kmPerMonth * 4) * 1.1;
            break;
        default:
            income = (kmPerMonth * 4) * 1.25;
            break;
    }
}
else
{
    income = (kmPerMonth * 4) * 1.45;
}

income *= 0.9;
Console.WriteLine($"{income:F2}");