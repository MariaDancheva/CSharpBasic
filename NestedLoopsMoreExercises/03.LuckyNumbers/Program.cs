int number = int.Parse(Console.ReadLine());

for (int first = 1; first <= 9; first++)
{
    for (int second = 1; second <= 9; second++)
    {
        for (int third = 1; third <= 9; third++)
        {
            for (int forth = 1; forth <= 9; forth++)
            {
                if (first + second == third + forth && number % (first + second) == 0)
                    Console.Write($"{first}{second}{third}{forth} ");
            }
        }
    }
}