using System.Diagnostics.Metrics;

int hourExam = int.Parse(Console.ReadLine());
int minunetsExam = int.Parse(Console.ReadLine());
int hourArrival = int.Parse(Console.ReadLine());
int minutesArrival = int.Parse(Console.ReadLine());
int examStarts = hourExam * 60 + minunetsExam;
int arrivalMin = hourArrival * 60 + minutesArrival;
int difference = examStarts - arrivalMin;
int newHour = Math.Abs(difference / 60);
int newMin = Math.Abs(difference % 60);
string status = "";

switch (difference)
{
    case >= 0 and <= 30:
        status = "On time";
        break;
    case >30:
        status = "Early";
        break;
    default:
        status = "Late";
        break;
}
switch (status)
{
    case "On time":
        Console.WriteLine(status);
        if (newMin >= 1)
            Console.WriteLine($"{newMin} minutes before the start");
        break;
    case "Early":
        Console.WriteLine(status);
        
        if (newHour >= 1 && newMin <= 9)
            Console.WriteLine($"{newHour}:0{newMin} hours before the start");
        else if (newHour > 0 && newMin > 9)
            Console.WriteLine($"{newHour}:{newMin} hours before the start");
        else
            Console.WriteLine($"{newMin} minutes before the start");
        break;
    default:
        Console.WriteLine(status);
        if (newHour > 0 && newMin <= 9)
            Console.WriteLine($"{newHour}:0{newMin} hours after the start");
        else if (newHour > 0)
            Console.WriteLine($"{newHour}:{newMin} hours after the start");
        else
            Console.WriteLine($"{newMin} minutes after the start");
        break;
}