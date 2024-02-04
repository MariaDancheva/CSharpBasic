int hightGoal = int.Parse(Console.ReadLine());
int failCount = 0;
int practiceHight = hightGoal - 30; 
int practiceJump = int.Parse(Console.ReadLine());
int jumpCount = 0;

while (failCount != 3 )
{
    ++jumpCount;
    
    if (practiceJump > practiceHight)
    {
        practiceHight += 5;
        failCount = 0;
        
    }
    else
    {
        failCount++;
        if (failCount == 3)
            break;
    }
    if (practiceHight > hightGoal && practiceJump > hightGoal)
        break;
    practiceJump = int.Parse(Console.ReadLine());
}

if(failCount == 3)
    Console.WriteLine($"Tihomir failed at {practiceHight}cm after {jumpCount} jumps.");
else
    Console.WriteLine($"Tihomir succeeded, he jumped over {hightGoal}cm after {jumpCount} jumps.");