string stage = Console.ReadLine();
string ticketType = Console.ReadLine();
int ticketQuantity = int.Parse(Console.ReadLine());
char picture = char.Parse(Console.ReadLine());

double price = 0;

switch (stage)
{
    case "Semi final":
        switch (ticketType)
        {
            case "VIP":
                price = 300.40 * ticketQuantity;
                break;
            case "Standard":
                price = 75.88 * ticketQuantity;
                break;
            default:
                price = 125.22 * ticketQuantity;
                break;
        }
        break;
    case "Final":
        switch (ticketType)
        {
            case "VIP":
                price = 400.0 * ticketQuantity;
                break;
            case "Standard":
                price = 110.1 * ticketQuantity;
                break;
            default:
                price = 160.66 * ticketQuantity;
                break;
        }
        break;
    default:
        switch (ticketType)
        {
            case "VIP":
                price = 118.9 * ticketQuantity;
                break;
            case "Standard":
                price = 55.50 * ticketQuantity;
                break;
            default:
                price = 105.2 * ticketQuantity;
                break;
        }
        break;
}

if (price > 4000)
{
    price *= 0.75;
    Console.WriteLine($"{price:F2}");
}
else if (price > 2500)
{
    price *= 0.9;
    if (picture == 'N')
        Console.WriteLine($"{price:F2}");
    else
        Console.WriteLine($"{price + 40 * ticketQuantity:F2}");
}
else
{
    if (picture == 'N')
        Console.WriteLine($"{price:F2}");
    else
        Console.WriteLine($"{price + 40 * ticketQuantity:F2}");
}
