int hours = 0;
int minutes = 0;
while (hours < 24)
{
    while (minutes <= 59)
    {
        Console.WriteLine($"{hours}:{minutes}");
        minutes++;
    }
    minutes = 0;
    hours++;
}