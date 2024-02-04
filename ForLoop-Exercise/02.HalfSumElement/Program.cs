int num = int.Parse(Console.ReadLine());
int sum = 0;
int max = int.MinValue;

for (int i = 1; i <= num; i++)
{
    int number = int.Parse(Console.ReadLine());

    sum += number;
    if (number > max)
    {
        max = number;
    }
   



}
sum -= max;
if (max == sum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {sum}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(max - sum)}");
}