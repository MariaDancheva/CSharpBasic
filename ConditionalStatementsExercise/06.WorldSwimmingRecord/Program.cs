// 1. Input from console
// - record - doublw
double worldRecord = double.Parse(Console.ReadLine());
// - distance (in meters) - double
double distance = double.Parse(Console.ReadLine());
// - secundsPerMeter - double
double timePerMeter = double.Parse(Console.ReadLine());
// 2. calculate
// - the total time
double totalTime = distance * timePerMeter;
// 3. for every 15m water resistence slowers the swimmer with 12.5 secunds
if (distance >= 15.0)
{
    int waterResistence = (int)Math.Floor(distance / 15);
    double recordAtempt = (waterResistence * 12.5) + totalTime;
    if (recordAtempt >= worldRecord)
    {
        double slowerBy = recordAtempt - worldRecord;
        Console.WriteLine($"No, he failed! He was {slowerBy:F2} seconds slower.");
    }
    else if (recordAtempt < worldRecord)
        Console.WriteLine($"Yes, he succeeded! The new world record is {recordAtempt:F2} seconds.");

}
else
{
    if (totalTime >= worldRecord)
    {
        double slowerBy = totalTime - worldRecord;
        Console.WriteLine($"No, he failed! He was {slowerBy:F2} seconds slower.");

    }
    else if (totalTime < worldRecord)
        Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");

}
