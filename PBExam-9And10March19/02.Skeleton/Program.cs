int minControlPoint = int.Parse(Console.ReadLine());
int secControlPoint = int.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
int secPer100m = int.Parse(Console.ReadLine());

int quota = minControlPoint * 60 + secControlPoint;
double time = (distance / 100) * secPer100m - (distance / 120) * 2.5;

if( time <= quota)
{
    Console.WriteLine("Marin Bangiev won an Olympic quota!");
    Console.WriteLine($"His time is {time:F3}.");
}
else
{
    Console.WriteLine($"No, Marin failed! He was {time - quota:F3} second slower.");
}