int men = int.Parse(Console.ReadLine());
int women = int.Parse(Console.ReadLine());
int tables = int.Parse(Console.ReadLine());

for (int man = 1; man <= men; man++)
{
    for (int woman = 1; woman <= women; woman++)
    {
        Console.Write($"({man} <-> {woman}) ");
        tables -= 1;
        if (tables == 0)
            return;
    }
}