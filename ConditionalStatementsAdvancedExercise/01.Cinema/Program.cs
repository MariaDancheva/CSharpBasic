string type = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());
int seats = rows * columns;
double income = 0.0;

switch (type)
{
    case "Premiere":
        income = seats * 12.00;
        break;
    case "Normal":
        income = seats * 7.5;
        break;
    default:
        income = seats * 5.0;
        break;
}
Console.WriteLine($"{income:F2} leva");
