int upperBorderHundreds = int.Parse(Console.ReadLine());
int upperBorderTens = int.Parse(Console.ReadLine());
int upperBorderOnes = int.Parse(Console.ReadLine());

for (int hundreds = 2; hundreds <= upperBorderHundreds; hundreds += 2)
{
    for (int tens = 2; tens <= upperBorderTens; tens++)
    {
        for (int ones = 2; ones <= upperBorderOnes; ones += 2)
        {
            if(tens == 2 || tens == 3 || tens == 5 || tens == 7)
                Console.WriteLine($"{hundreds} {tens} {ones}");
        }
    }
}