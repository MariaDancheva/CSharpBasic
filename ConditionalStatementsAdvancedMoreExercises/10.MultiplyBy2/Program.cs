double number = double.Parse(Console.ReadLine());

for ( int i = 0 ;number >= 0; i ++)
{
    if (number >= 0)
    {
        double sum = number * 2.00;
        Console.WriteLine($"Result: {sum:F2}");
    }
    number = double.Parse(Console.ReadLine());

}
Console.WriteLine("Negative number!");