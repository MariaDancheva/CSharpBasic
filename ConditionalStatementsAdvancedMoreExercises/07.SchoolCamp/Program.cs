string season = Console.ReadLine();
string groupOf = Console.ReadLine();
int students = int.Parse(Console.ReadLine()); 
int nights = int.Parse(Console.ReadLine());

double price = 0;
string sport = "";

switch (season)
{
    case "Winter":
        switch (groupOf)
        {
            case "boys":
                price = nights * students * 9.6;
                sport = "Judo";
                break;
            case "girls":
                price = nights * students * 9.6;
                sport = "Gymnastics";
                break;
            default:
                price = nights * students * 10.0;
                sport = "Ski";
                break;
        }
        break;
    case "Spring":
        switch (groupOf)
        {
            case "boys":
                price = nights * students * 7.2;
                sport = "Tennis";
                break;
            case "girls":
                price = nights * students * 7.2;
                sport = "Athletics";
                break;
            default:
                price = nights *  students * 9.5;
                sport = "Cycling";
                break;
        }
        break;
    default:
        switch (groupOf)
        {
            case "boys":
                price = nights * students * 15.0;
                sport = "Football";
                break;
            case "girls":
                price = nights * students * 15.0;
                sport = "Volleyball";
                break;
            default:
                price = nights * students * 20.0;
                sport = "Swimming";
                break;
        }
        break;
}

if (students >= 10 && students < 20)
    price *= 0.95;
else if (students >= 20 && students < 50)
    price *= 0.85;
else if ( students >= 50)
    price *= 0.5;

Console.WriteLine($"{sport} {price:F2} lv.");