int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());
int count = 0;
int result = 0;

for (int firstNum = start; firstNum <= end; firstNum++)
{
    for (int secondNum = start; secondNum <= end; secondNum++)
    {
        count++;
        result = firstNum + secondNum;
        if (result == magicNumber)
        {
            Console.WriteLine($"Combination N:{count} ({firstNum} + {secondNum} = {result})");
            break;
        }
    }
    if (result == magicNumber)
        break;
}
if(result != magicNumber)
    Console.WriteLine($"{count} combinations - neither equals {magicNumber}");