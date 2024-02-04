double budget = double.Parse(Console.ReadLine());
string category = Console.ReadLine();
int people = int.Parse(Console.ReadLine());

double ticketVIP = 499.99;
double ticketNormal = 249.99;
double tickets = 0;
double transport = 0;

switch (category)
{
    case "VIP":
        tickets = ticketVIP * people;
        break;
    default:
        tickets = ticketNormal * people;
        break;
}

switch (people)
{
    case >= 1 and <= 4:
        transport = budget * 0.25;
        break;
    case >= 5 and <= 9:
        transport = budget * 0.4;
        break;
    case >= 10 and <= 24:
        transport = budget * 0.5;
        break;
    case >= 25 and <= 49:
        transport = budget * 0.6;
        break;
    default:
        transport = budget * 0.75;
        break;

}
double moneyLeft = Math.Abs(transport - tickets);
 if (transport >= tickets)
{
    Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
}
 else
{
    Console.WriteLine($"Not enough money! You need {moneyLeft:F2} leva.");
}