int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int magicNum = int.Parse(Console.ReadLine());
int magicCount = 0;
int numberCombination = 0;

for (int i = num1; i <= num2; i++)
{
    for (int k = num1; k <= num2; k++)
    {
        numberCombination++;
        int sum = i + k;
        if (sum == magicNum)
        {
            magicCount++;
            Console.WriteLine($"Combination N:{numberCombination} ({i} + {k} = {magicNum})");
            break;
        }

    }
    if (magicCount == 1)
        break;

}
if (magicCount == 0)
    Console.WriteLine($"{numberCombination} combinations - neither equals {magicNum}");