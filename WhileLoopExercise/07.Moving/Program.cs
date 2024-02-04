int wideFreeSpace = int.Parse(Console.ReadLine());
int lenghtFreeSpace = int.Parse(Console.ReadLine());
int hightFreeSpace = int.Parse(Console.ReadLine());
int freeArea = wideFreeSpace * lenghtFreeSpace * hightFreeSpace;
string boxes = Console.ReadLine();
while (boxes != "Done" && freeArea > 0)
{
    freeArea -= int.Parse(boxes);
    if (freeArea < 0)
        break;

    boxes = Console.ReadLine();
}

if(boxes == "Done")
    Console.WriteLine($"{freeArea} Cubic meters left.");
else
    Console.WriteLine($"No more free space! You need {Math.Abs(freeArea)} Cubic meters more.");