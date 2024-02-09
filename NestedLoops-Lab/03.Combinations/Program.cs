int num = int.Parse(Console.ReadLine());
int validSum = 0;
for (int a = 0; a <= num; a++)
{
    for (int b = 0; b <= num; b++)
    {
        for (int c = 0; c <= num; c++)
        {

            int sum = a + b + c;
            if (sum == num)
                validSum++;
        }
    }
}
Console.WriteLine($"{validSum}");