int quantityLoads = int.Parse(Console.ReadLine());

int tonsTotal = 0;

double vanLoad = 0.0;
double truckLoad = 0.0;
double trainLoad = 0.0;
double totalPrice = 0;


for (int i = 1; i <= quantityLoads; i++)
{
    int tonsPerLoad = int.Parse(Console.ReadLine());
    switch (tonsPerLoad)
    {
        case <= 3:
            totalPrice += 200.0 * tonsPerLoad;
            tonsTotal += tonsPerLoad;
            vanLoad += tonsPerLoad;
            break;
        case >= 4 and <= 11:
            totalPrice += 175.0 * tonsPerLoad;
            tonsTotal += tonsPerLoad;
            truckLoad += tonsPerLoad;
            break;
        default:
            totalPrice += 120.0 * tonsPerLoad;
            tonsTotal += tonsPerLoad;
            trainLoad += tonsPerLoad;
            break;
    }
}
double averagePricePerTon = totalPrice / tonsTotal;

Console.WriteLine($"{averagePricePerTon:F2}");
Console.WriteLine($"{vanLoad * 100 / tonsTotal:F2}%");
Console.WriteLine($"{truckLoad * 100 / tonsTotal:F2}%");
Console.WriteLine($"{trainLoad * 100 / tonsTotal:F2}%");