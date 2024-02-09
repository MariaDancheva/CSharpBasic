int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

for (int i = num1 + 1; i < num2; i++)
{
    int evenSum = 0;
    int oddSum = 0;


    for (int k = 1; k <= 6; k++)
    {
        int currentNum = i;
        switch (k)
        {
            case 2:
                currentNum /= 10;
                currentNum %= 10;
                oddSum += currentNum;
                break;
            case 4:
                currentNum /= 1000;
                currentNum %= 10;
                oddSum += currentNum;
                break;
            case 6:
                currentNum /= 100000;
                currentNum %= 10;
                oddSum += currentNum;
                break;
            case 1:
                currentNum %= 10;
                evenSum += currentNum;
                break;
            case 3:
                currentNum /= 100;
                currentNum %= 10;
                evenSum += currentNum;
                break;
            case 5:
                currentNum /= 10000;
                currentNum %= 10;
                evenSum += currentNum;
                break;
        }
    }
    if (oddSum == evenSum)
    {
        Console.Write($"{i} ");
    }

}