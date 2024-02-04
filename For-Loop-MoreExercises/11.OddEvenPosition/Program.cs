int number = int.Parse(Console.ReadLine());

double oddSum = 0.0;
double oddMin = double.MaxValue;
double oddMax = double.MinValue;
double evenSum = 0.0;
double evenMin = double.MaxValue;
double evenMax = double.MinValue;

if (number >= 1)
{
    for (int i = 1; i <= number; i++)
    {
        double num = double.Parse(Console.ReadLine());

        if (i % 2 == 0)
        {
            evenSum += num;
            if (num > evenMax)
                evenMax = num;
            if (num < evenMin)
                evenMin = num;
        }
        else
        {
            oddSum += num;
            if (num > oddMax)
                oddMax = num;
            if (num < oddMin)
                oddMin = num;
        }

    }
    if (evenMin != double.MaxValue && evenMax != double.MinValue)
    {
        Console.WriteLine($"OddSum={oddSum:F2},");
        Console.WriteLine($"OddMin={oddMin:F2},");
        Console.WriteLine($"OddMax={oddMax:F2},");
        Console.WriteLine($"EvenSum={evenSum:F2},");
        Console.WriteLine($"EvenMin={evenMin:F2},");
        Console.WriteLine($"EvenMax={evenMax:F2}");

    }
    else
    {
        Console.WriteLine($"OddSum={oddSum:F2},");
        Console.WriteLine($"OddMin={oddMin:F2},");
        Console.WriteLine($"OddMax={oddMax:F2},");
        Console.WriteLine($"EvenSum=0.00,");
        Console.WriteLine($"EvenMin=No,");
        Console.WriteLine($"EvenMax=No");
    }
}
else
{
    Console.WriteLine("OddSum=0.00,");
    Console.WriteLine("OddMin=No,");
    Console.WriteLine("OddMax=No,");
    Console.WriteLine("EvenSum=0.00,");
    Console.WriteLine("EvenMin=No,");
    Console.WriteLine("EvenMax=No");

}
