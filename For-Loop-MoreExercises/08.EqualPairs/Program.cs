int n = int.Parse(Console.ReadLine());

int firstCouple = 0;
int secondCouple = 0;
if (n != 1)
{
    for (int i = 1; i <= n; i++)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        if (i % 2 == 0)
            firstCouple = firstNumber + secondNumber;
        else
            secondCouple = firstNumber + secondNumber;

        if (secondCouple > firstCouple && n >= 4 && i != n)
        {
            firstCouple = secondCouple;
            secondCouple = 0;

        }

    }
    if (firstCouple == secondCouple)
        Console.WriteLine($"Yes, value={firstCouple}");
    else
        Console.WriteLine($"No, maxdiff={Math.Abs(firstCouple - secondCouple)}");
}
else
{
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Yes, value={num1 + num2}");
}
