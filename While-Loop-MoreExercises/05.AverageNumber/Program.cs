int n = int.Parse(Console.ReadLine());
double average = 0.0;
for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    average += num;
}
Console.WriteLine($"{average/n:F2}");