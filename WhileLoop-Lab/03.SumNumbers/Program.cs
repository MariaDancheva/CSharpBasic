int number = int.Parse(Console.ReadLine());
int sum = 0;
while (number >= sum)
{
    sum += int.Parse(Console.ReadLine());
    if (sum == number)
        break;
}
Console.WriteLine(sum);