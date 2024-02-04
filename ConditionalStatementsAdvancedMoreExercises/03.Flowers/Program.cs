int chrysanthemums = int.Parse(Console.ReadLine());
int roses = int.Parse(Console.ReadLine());
int tulip = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
char holiday = char.Parse(Console.ReadLine());
int arrangement = 2;
double price = 0;
int quantityFlowers = roses + chrysanthemums + tulip;

switch (holiday)
{
    case 'N':
        switch (season)
        {
            case "Spring":
            case "Summer":
                price = chrysanthemums * 2.00 + roses * 4.1 + tulip * 2.5;
                if (season == "Spring" && tulip > 7)
                    price *= 0.95;
                if (quantityFlowers > 20)
                    price *= 0.8;
                break;
            default:
                price = chrysanthemums * 3.75 + roses * 4.5 + tulip * 4.15 ;
                if (season == "Winter" && roses >= 10)
                    price *= 0.9;
                if (quantityFlowers > 20)
                    price *= 0.8;
                break;
        }
        break;
    default:
        switch (season)
        {
            case "Spring":
            case "Summer":
                price = chrysanthemums * 2.0 + roses * 4.1 + tulip * 2.5;
                price = price + price * 0.15;
                if (season == "Spring" && tulip > 7)
                    price *= 0.95;
                if (quantityFlowers > 20)
                    price *= 0.8;
                break;
            default:
                price = chrysanthemums * 3.75 + roses * 4.5 + tulip * 4.15;
                price = price + price * 0.15;
                if (season == "Winter" && roses >= 10)
                    price *= 0.9;
                if (quantityFlowers > 20)
                    price *= 0.8;
                break;

        }

        break;
}
price += 2;
Console.WriteLine($"{price:F2}");