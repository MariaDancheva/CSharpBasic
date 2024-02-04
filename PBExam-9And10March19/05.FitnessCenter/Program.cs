int countVisitors = int.Parse(Console.ReadLine());
int back = 0;
int chest = 0;
int legs = 0;
int abs = 0;
int proteinShake = 0;
int proteinBar = 0;

for (int i = 0; i < countVisitors; i++)
{
    string activity = Console.ReadLine();
    switch (activity)
    {
        case "Back":
            back++;
            break;
        case "Chest":
            chest++;
            break;
        case "Legs":
            legs++;
            break;
        case "Abs":
            abs++;
            break;
        case "Protein shake":
            proteinShake++;
            break;
        default:
            proteinBar++;
            break;
    }
}
Console.WriteLine($"{back} - back");
Console.WriteLine($"{chest} - chest");
Console.WriteLine($"{legs} - legs");
Console.WriteLine($"{abs} - abs");
Console.WriteLine($"{proteinShake} - protein shake");
Console.WriteLine($"{proteinBar} - protein bar");
Console.WriteLine($"{(double)(back+chest+legs+abs)/ countVisitors * 100:F2}% - work out");
Console.WriteLine($"{(double)(proteinBar+proteinShake)/ countVisitors * 100:F2}% - protein");
