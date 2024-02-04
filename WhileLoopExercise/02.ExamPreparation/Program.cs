int inadequateGrades = int.Parse(Console.ReadLine());
int inadequateCount = 0;
int averageGrade = 0;//:F2
int count = 0;
string lastProbemName = "";

string problemName = Console.ReadLine();
while (problemName != "Enough")
{
    int grade = int.Parse(Console.ReadLine());

    ++count;
    averageGrade += grade;

    if (grade <= 4)
    {
        ++inadequateCount;
        if (inadequateCount == inadequateGrades)
        {
            Console.WriteLine($"You need a break, {inadequateCount} poor grades.");
            break;
        }
    }
    else
    {
        lastProbemName = problemName;
    }
    problemName = Console.ReadLine();
}
if (problemName == "Enough")
{
    Console.WriteLine($"Average score: {(double)averageGrade / count:F2}");
    Console.WriteLine($"Number of problems: {count}");
    Console.WriteLine($"Last problem: {lastProbemName}");
}
