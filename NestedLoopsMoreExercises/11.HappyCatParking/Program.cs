int numberDays = int.Parse(Console.ReadLine());
int numberHoursPerDay = int.Parse(Console.ReadLine());
double totalBill = 0;
double billPerDay = 0;

for (int day = 1; day <= numberDays; day++)
{
    for (int hour = 1; hour <= numberHoursPerDay; hour++)
    {
        if (day % 2 != 0 && hour % 2 == 0)
        {
            billPerDay += 1.25;
        }
        else if (day % 2 == 0 && hour % 2 != 0)
        {
            billPerDay += 2.5;
        }
        else
        {
            billPerDay++;
        }
    }
    totalBill += billPerDay;
    Console.WriteLine($"Day: {day} - {billPerDay:F2} leva");
    billPerDay = 0;
}
Console.WriteLine($"Total: {totalBill:F2} leva");