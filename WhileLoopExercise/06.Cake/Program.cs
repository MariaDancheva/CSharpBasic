int wide = int.Parse(Console.ReadLine());
int lenght = int.Parse(Console.ReadLine());
int area = wide * lenght;
string pieceCake = Console.ReadLine();
while (area > 0 && pieceCake != "STOP")
{
    area -= int.Parse(pieceCake);
    if (area <= 0)
        break;
    pieceCake = Console.ReadLine();
}
if (pieceCake == "STOP")
Console.WriteLine($"{area} pieces are left.");
else if (area < 0)
    Console.WriteLine($"No more cake left! You need {Math.Abs(area)} pieces more.");