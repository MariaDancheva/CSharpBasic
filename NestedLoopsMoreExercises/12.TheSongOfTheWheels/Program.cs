int controlM = int.Parse(Console.ReadLine());
int countPassword = 0;
string password = "";

for (int a = 1; a <= 9; a++)
{
    for (int b = 1; b <= 9; b++)
    {
        for (int c = 1; c <= 9; c++)
        {
            for (int d = 1; d <= 9; d++)
            {
                if (a < b && c > d)
                {
                    if (a * b + c * d == controlM)
                    {
                        countPassword++;
                        Console.Write($"{a}{b}{c}{d} ");
                        if (countPassword == 4)
                            password = $"{a}{b}{c}{d}";
                    }
                }
            }
        }
    }
}
Console.WriteLine();
if(password != string.Empty)
{
    Console.WriteLine($"Password: {password}");
}
else
{
    Console.WriteLine("No!");
}