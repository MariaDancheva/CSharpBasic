int months = int.Parse(Console.ReadLine());

int water = 0;
int internet = 0;
double others = 0.0;
double electricity = 0.0;

for (int i = 1; i <= months; i++)
{
    double electricityPerMonth = double.Parse(Console.ReadLine());
    electricity += electricityPerMonth;
    water += 20;
    internet += 15;
    others = (electricity + water + internet) + (water + electricity + internet) * 0.2;

}

Console.WriteLine($"Electricity: {electricity:F2} lv");
Console.WriteLine($"Water: {water:F2} lv");
Console.WriteLine($"Internet: {internet:F2} lv");
Console.WriteLine($"Other: {others:F2} lv");
Console.WriteLine($"Average: {(water + electricity + internet + others) / months:F2} lv");
