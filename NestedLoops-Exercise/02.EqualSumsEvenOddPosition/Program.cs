int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

for (int i = num1; i <= num2; i++)
{
    int evenSum = 0;
    int oddSum = 0;

    for (int k = 0; k < 6; k++)
    {
        string currentNumber = i.ToString();
        char currentIndex = currentNumber[k];
        if (k == 0 || k == 2 || k == 4)
            evenSum += (int)currentIndex;
        else
            oddSum += (int)currentIndex;
        
    }
    if (oddSum == evenSum)
    {
        Console.Write($"{i} ");
    }

}