double vacationMoney = double.Parse(Console.ReadLine());
double availableMoney = double.Parse(Console.ReadLine());
int countDays = 0;
int spendingCount = 0;

while (availableMoney <= vacationMoney)
{
    string action = Console.ReadLine();
    double amount = double.Parse(Console.ReadLine());
    ++countDays;

    if (action == "spend")
    {
        ++spendingCount;
        if (spendingCount == 5)
        {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine($"{countDays}");
            break;
        }
        if (amount >= availableMoney)
            availableMoney = 0;
        else
            availableMoney -= amount;
    }
    else
    {
        availableMoney += amount;
        spendingCount = 0;
        if (availableMoney >= vacationMoney)
        {
            Console.WriteLine($"You saved the money for {countDays} days.");
            break;
        }
    }
}
