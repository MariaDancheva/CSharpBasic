string serialName = Console.ReadLine();
int episode = int.Parse(Console.ReadLine());
int lunchBreack = int.Parse(Console.ReadLine());

double lunchTime = lunchBreack * 0.125;
double relaxTime = lunchBreack * 0.25;
double timeNeeded =(double)Math.Round( episode + lunchTime + relaxTime, 2);

if(lunchBreack >= timeNeeded)
{
    int leftTime =(int)Math.Ceiling(lunchBreack - timeNeeded);
    Console.WriteLine($"You have enough time to watch {serialName} and left with {leftTime} minutes free time.");
}
else  
{
    int needMore =(int)Math.Ceiling(timeNeeded - lunchBreack);
    Console.WriteLine($"You don't have enough time to watch {serialName}, you need {needMore} more minutes.");
}
