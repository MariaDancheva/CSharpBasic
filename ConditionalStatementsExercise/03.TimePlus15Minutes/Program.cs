// 1. input from console
// - hour  -int
int hour = int.Parse(Console.ReadLine());
// - minutes -int
int minutes = int.Parse(Console.ReadLine());
//2. Calculte
// - add = 15 + minutes;
int add = minutes + 15;
// - what time is it ? if minutes >= 60, if hour < 23 ,newHour = hour + 1
if (add >= 60)
{
    int newMinutes = add - 60;
    if (hour < 23)
    {
        int newHour = hour + 1;
        if (newMinutes < 10)
        {
            Console.WriteLine($"{newHour}:0{newMinutes}");
        }
        else
        {
            Console.WriteLine($"{newHour}:{newMinutes}");
        }
    }
    else if (hour >= 23)
    {
        int newHour = hour - 23;
        if (newMinutes < 10)
        {
            Console.WriteLine($"{newHour}:0{newMinutes}");
        }
        else
        {
            Console.WriteLine($"{newHour}:{newMinutes}");
        }
    }
}
else 
{
    Console.WriteLine($"{hour}:{add}");
}
