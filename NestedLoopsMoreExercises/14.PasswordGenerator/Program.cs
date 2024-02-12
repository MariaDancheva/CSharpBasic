int num = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

for (int firstNum = 1; firstNum <= num; firstNum++)
{
    for (int secondNum = 1; secondNum <= num; secondNum++)
    {
        char firstChar = 'a';
        for (int firstLetter = 1; firstLetter <= num2; firstLetter++, firstChar++)
        {
            char secondChar = 'a';
            for (int secondLeter = 1; secondLeter <=num2; secondLeter++, secondChar++)
            {
                for (int thirdNum = 2; thirdNum <= num; thirdNum++)
                {
                    if(thirdNum > firstNum && thirdNum > secondNum)
                    Console.Write($"{firstNum}{secondNum}{firstChar}{secondChar}{thirdNum} ");
                }
            }
        }
    }
}
Console.WriteLine("Hello C#");