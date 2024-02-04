double inheritedMoney = double.Parse(Console.ReadLine());
int yearLivingTo = int.Parse(Console.ReadLine());

double expenses = 0.0;
int age = 18;

for (int i = 1800; i <= yearLivingTo; i++)
{
    if (i % 2 == 0)
    {
        expenses += 12000;
        age++;
    }
    else
    {
        expenses += 12000 + 50 * age;
        age++;
    }
}

if (inheritedMoney >= expenses)
    Console.WriteLine($"Yes! He will live a carefree life and will have {inheritedMoney - expenses:F2} dollars left.");
else
    Console.WriteLine($"He will need {expenses - inheritedMoney:F2} dollars to survive.");