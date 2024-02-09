int number = int.Parse(Console.ReadLine());
int num;


for ( int first = 1; first <= 9; first++)
{
    for (int seconf = 1; seconf <= 9; seconf++)
    {
        for (int third = 1; third <= 9; third++)
        {
            for (int forth = 1; forth <= 9; forth++)
            {
                num = first * 1000 + seconf * 100 + third * 10 + forth;
                if (number % first == 0 && number % seconf == 0 && number % third == 0 && number % forth == 0)
                {
                    Console.Write($"{num} ");
                }
                if (num == 9999)
                {
                    break;
                }
            }
        }
    }
}


