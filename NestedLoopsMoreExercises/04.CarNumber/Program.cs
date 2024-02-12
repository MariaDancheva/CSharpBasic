int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for (int first = start + 1; first <= end; first++)
{
    for (int second = start; second <= end; second++)
    {
        for (int third = start; third <= end; third++)
        {
            for (int forth = start; forth <= end; forth++)
            {

                if(first % 2 == 0 && forth % 2 != 0 || first % 2 != 0 && forth % 2 == 0)
                {
                    if ((second + third) % 2 == 0 && first > forth)
                        Console.Write($"{first}{second}{third}{forth} ");
                }

            }
        }
    }
}