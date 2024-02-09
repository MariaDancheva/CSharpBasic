int firstMultiplier = 1;
int secondMultiplier = 1;
int result = 1;

while (result != 100)
{
    while (secondMultiplier < 11)
    {
        result = firstMultiplier * secondMultiplier;
        Console.WriteLine($"{firstMultiplier} * {secondMultiplier} = {result}");
        secondMultiplier++;
    }
    secondMultiplier = 1;
    firstMultiplier++;
}