
int hour = 0;

for (int min = 0; hour <= 23; min++)
{
    Console.WriteLine($"{hour} : {min}");
      if (min == 59)
    {
        min -= 60;
        hour++;
    }
    if (hour == 24)
        break;


}