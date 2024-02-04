string num = Console.ReadLine();
int maxNum = int.MinValue;

while (num != "Stop")
{
   int number = int.Parse(num);
    if (number > maxNum)
        maxNum = number;
    num = Console.ReadLine();
}
Console.WriteLine(maxNum);