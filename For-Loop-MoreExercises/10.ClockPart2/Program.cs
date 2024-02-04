
int hour = 0;
int min = 0;

for (int sec = 0; hour <= 23; sec++)
{
    Console.WriteLine($"{hour} : {min} : {sec} ");
    if (sec == 59)
    {
        sec -= 60;
        min++;
        if (min >= 60)
        {
            min -= 60;
            hour++;
        }
    }
    if (hour == 24)
        break;


}