string num = Console.ReadLine();
int minNum = int.MaxValue;

while (num != "Stop")
{
    int number = int.Parse(num);
    if (number < minNum)
        minNum = number;
    num = Console.ReadLine();
}
Console.WriteLine(minNum);