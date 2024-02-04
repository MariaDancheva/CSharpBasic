int quantity = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= quantity; i++)
{
    int num = int.Parse(Console.ReadLine());
    sum += num;
}
Console.WriteLine(sum);