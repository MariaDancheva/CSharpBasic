int number = int.Parse(Console.ReadLine());
int even = 0;
int odd = 0;
//int difference = 0;

for (int i = 0; i < number; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (i % 2 == 0)
        even += num;
    else
        odd += num;
}

if (even == odd)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {even}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(even - odd)}");
}