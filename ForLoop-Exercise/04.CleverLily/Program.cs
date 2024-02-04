int age = int.Parse(Console.ReadLine());
double washingMAchine = double.Parse(Console.ReadLine());
int pricePerToy = int.Parse(Console.ReadLine());

int toysquantity = 0;
double moneyReaceived = 0.0;
double birthdayMoney = 9.0;

for (int i = 0; i < age; i++)
{
    if (i % 2 == 0)
        toysquantity++;
    else
    {
        moneyReaceived += birthdayMoney;
        birthdayMoney += 10;
    }
}

double moneyTotal = moneyReaceived + toysquantity * pricePerToy;

if (moneyTotal >= washingMAchine)
    Console.WriteLine($"Yes! {moneyTotal - washingMAchine:F2}");
else
    Console.WriteLine($"No! {washingMAchine - moneyTotal:F2}");