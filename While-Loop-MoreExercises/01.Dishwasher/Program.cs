int countBottelsDetergent = int.Parse(Console.ReadLine());
int countPlates = 0;
int countPots = 0;
int count = 0;
int ml = countBottelsDetergent * 750;
string plates = Console.ReadLine();
while (plates != "End")
{
    count++;
    int usedDetergent = 0;
    if (count == 3)
    {
        count = 0;
        countPots += int.Parse(plates);
        int currentlyWashing = int.Parse(plates);
        usedDetergent = currentlyWashing * 15;
        ml -= usedDetergent;
    }
    else
    {
        int currentlyWashing = int.Parse(plates);
        countPlates += currentlyWashing;
        usedDetergent = currentlyWashing * 5;
        ml -= usedDetergent;

    }
    if (ml < 0)
        break;
    plates = Console.ReadLine();
}
if (ml >= 0)
{
    Console.WriteLine("Detergent was enough!");
    Console.WriteLine($"{countPlates} dishes and {countPots} pots were washed.");
    Console.WriteLine($"Leftover detergent {ml} ml.");
}
else
{
    Console.WriteLine($"Not enough detergent, {Math.Abs(ml)} ml. more necessary!");
}