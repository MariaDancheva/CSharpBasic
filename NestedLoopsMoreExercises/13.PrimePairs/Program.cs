int firstPairStart = int.Parse(Console.ReadLine());
int secondPairStart = int.Parse(Console.ReadLine());
int differenceFirstPair = int.Parse(Console.ReadLine());
int differenceSecondPair = int.Parse(Console.ReadLine());

for (int firstPair = firstPairStart; firstPair <= firstPairStart + differenceFirstPair; firstPair++)
{
    for (int secondPair = secondPairStart; secondPair <= secondPairStart + differenceSecondPair; secondPair++)
    {
        if(firstPair % 2 != 0 && firstPair % 3 != 0 && firstPair % 5 != 0 && firstPair % 7 != 0)
        {
            if(secondPair % 2 != 0 && secondPair % 3 != 0 && secondPair % 5 != 0 && secondPair % 7 != 0)
            {
                Console.WriteLine($"{firstPair}{secondPair}"); ;
            }
        }

    }
}