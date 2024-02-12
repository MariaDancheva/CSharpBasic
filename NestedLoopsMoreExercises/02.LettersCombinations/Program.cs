char start = char.Parse(Console.ReadLine());
char end = char.Parse(Console.ReadLine());
char skip = char.Parse(Console.ReadLine());
string combinations = "";
int combinationsCount = 0;

for (int firstLetter = (int)start; firstLetter <= (int)end; firstLetter++)
{
    for (int secondLetter = (int)start; secondLetter <= (int)end; secondLetter++)
    {
        for (int thirdLetter = (int)start; thirdLetter <= (int)end; thirdLetter++)
        {
            if (firstLetter != (int)skip && secondLetter != (int)skip && (thirdLetter) != (int)skip)
            {
                combinationsCount++;
                combinations += $"{(char)firstLetter}{(char)secondLetter}{(char)thirdLetter} ";
            }
        }
    }
}
Console.Write($"{combinations}{combinationsCount}");
