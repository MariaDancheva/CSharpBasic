double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string carType = "";
double price = 0;

switch (budget)
{
    case >= 10 and <= 100:
        Console.WriteLine("Economy class");
        if (season == "Summer")
        {
            carType = "Cabrio";
            price = budget * 0.35;
        }
        else
        {
            carType = "Jeep";
            price = budget * 0.65;
        }
        break;
    case > 100 and <= 500:
        Console.WriteLine("Compact class");
        if (season == "Summer")
        {
            carType = "Cabrio";
            price = budget * 0.45;
        }
        else
        {
            carType = "Jeep";
            price = budget * 0.80;
        }
         break;
    default:
         Console.WriteLine("Luxury class");
         carType = "Jeep";
         price = budget * 0.9;
        
                break;
}
Console.WriteLine($"{carType} - {price:F2}");