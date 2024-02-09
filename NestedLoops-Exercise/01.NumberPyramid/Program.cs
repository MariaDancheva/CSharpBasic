int number = int.Parse(Console.ReadLine());
int n = 1;

for (int colls = 1; n <= number;colls++)
{
    for (int rolls = 1; rolls <= colls ; rolls++)
    {
        Console.Write($"{n} ");
        n++;
        if (n > number)
            break;
    }
    Console.WriteLine();
}
