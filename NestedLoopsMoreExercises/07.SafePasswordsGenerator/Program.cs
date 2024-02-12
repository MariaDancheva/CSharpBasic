int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int maxNumPasswords = int.Parse(Console.ReadLine());
char originalA = '#';
char startingeB = '@';
char currentA = '#';
char currentB = '@';
bool xY = true ;
int countPasswords = 0;

   for (int currentX = 1; currentX <= a; currentX++)
    {
        for (int currentY = 1; currentY <= b; currentY++)
        {
            for (int b1 = 1; b1 <= 1; b1++, currentB++)
            {
                for (int a1 = 1; a1 <= 1; a1++, currentA++)
                {
                    if (currentA > 55)
                    {
                        currentA = originalA;
                    }
                    if (currentB > 96)
                    {
                        currentB = startingeB;
                    }
                    countPasswords++;
                    Console.Write($"{currentA}{currentB}{currentX}{currentY}{currentB}{currentA}|");
                     if (currentX == a && currentY == b)
                        xY = false;
                     if (maxNumPasswords == countPasswords || xY == false)
                        break;
                }
                if (maxNumPasswords == countPasswords || xY == false)
                    break;
            }
            if (maxNumPasswords == countPasswords || xY == false)
                break;
               
        }
        if (maxNumPasswords == countPasswords || xY == false)
            break;
    }
