int goal = 10000;
while (goal >= 0)
{
    string steps = Console.ReadLine();
    if (steps == "Going home")
    {
        goal -= int.Parse(steps);
        int onTheWayHome = int.Parse(Console.ReadLine());
        goal -= onTheWayHome;
        if (goal <= 0)
            {
                Console.WriteLine("Goal reached! Good job!");
                if (goal < 0)
                   Console.WriteLine($"{Math.Abs(goal)} steps over the goal!");
                break;
            }
            else
            {
                Console.WriteLine($"{goal} more steps to reach goal.");
                break;
            }
    }
    else
    {
        goal -= int.Parse(steps);
        if (goal <= 0)
            {
                Console.WriteLine("Goal reached! Good job!");
                if (goal < 0)
                    Console.WriteLine($"{Math.Abs(goal)} steps over the goal!");
                break;
            }
            break;

    }


}
