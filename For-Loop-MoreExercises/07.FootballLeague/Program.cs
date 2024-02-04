double capacity = double.Parse(Console.ReadLine());
int fansTotal = int.Parse(Console.ReadLine());

double fansA = 0.0;
double fansB = 0.0;
double fansV = 0.0;
double fansG = 0.0;

for (int i = 1; i <= fansTotal; i++)
{
    char sector = char.Parse(Console.ReadLine());

    switch (sector)
    {
        case 'A':
            fansA++;
            break;
        case 'B':
            fansB++;
            break;
        case 'V':
            fansV++;
            break;
        default:
            fansG++;
            break;
    }
}

Console.WriteLine($"{fansA * 100 / fansTotal:F2}%");
Console.WriteLine($"{fansB * 100 / fansTotal:F2}%");
Console.WriteLine($"{fansV * 100 / fansTotal:F2}%");
Console.WriteLine($"{fansG * 100 / fansTotal:F2}%");
Console.WriteLine($"{fansTotal * 100 / capacity:F2}%");