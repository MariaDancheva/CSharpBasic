int climbersGroups = int.Parse(Console.ReadLine());
double musala = 0.0;
double monblan = 0.0;
double kilimanjaro = 0.0;
double k2 = 0.0;
double everest = 0.0;
int climbersTotal = 0;
for (int i = 0; i < climbersGroups; i++)
{
    int climbersPerGroup = int.Parse(Console.ReadLine());
    switch (climbersPerGroup)
    {
        case >= 1 and <= 5:
            climbersTotal += climbersPerGroup;
            musala += climbersPerGroup;
            break;
        case >= 6 and <= 12:
            climbersTotal += climbersPerGroup;
            monblan += climbersPerGroup;
            break;
        case >= 13 and <= 25:
            climbersTotal += climbersPerGroup;
            kilimanjaro += climbersPerGroup;
            break;
        case >= 26 and <= 40:
            climbersTotal += climbersPerGroup;
            k2 += climbersPerGroup;
            break;

        default:
            climbersTotal += climbersPerGroup;
            everest += climbersPerGroup;
            break;
    }
}
double persentMusala = (musala * 100) / climbersTotal;
double persentMonblan = (monblan * 100) / climbersTotal;
double persentKilimanjaro = (kilimanjaro * 100) / climbersTotal;
double persentK2 = (k2 * 100) / climbersTotal;
double persentEverest = (everest * 100) / climbersTotal;


Console.WriteLine($"{persentMusala:F2}%");
Console.WriteLine($"{persentMonblan:F2}%");
Console.WriteLine($"{persentKilimanjaro:F2}%");
Console.WriteLine($"{persentK2:F2}%");
Console.WriteLine($"{persentEverest:F2}%");