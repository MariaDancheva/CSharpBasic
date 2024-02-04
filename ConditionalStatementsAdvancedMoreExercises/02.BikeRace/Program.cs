int juniors = int.Parse(Console.ReadLine());
int seniors = int.Parse(Console.ReadLine());
string type = Console.ReadLine();

double price = 0;

switch (type)
{
    case "trail":
        price = juniors * 5.50 + seniors * 7;
        break;
    case "cross-country":
        price = juniors * 8 + seniors * 9.5;
        if (seniors + juniors >= 50)
            price *= 0.75;
        break;
    case "downhill":
        price = juniors * 12.25 + seniors * 13.75;
        break;
    default:
        price = juniors * 20 + seniors * 21.50;
        break;
}
double charity = price * 0.95;
Console.WriteLine($"{charity:F2}");