int openTabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());
int penalty = 0;

for (int i = 0; penalty < salary && i < openTabs; i++)
{
    string nameTab = Console.ReadLine();
    switch (nameTab)
    {
        case "Facebook":
            penalty += 150;
            break;
        case "Instagram":
            penalty += 100;
            break;
        case "Reddit":
            penalty += 50;
            break;
        default:
            break;
    }
}

int difference = salary - penalty;
if (difference <= 0)
    Console.WriteLine("You have lost your salary.");
else
    Console.WriteLine(difference);