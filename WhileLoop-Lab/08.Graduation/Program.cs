string nameStudent = Console.ReadLine();
double averageGrade = 0.0;
int finishedClass = 0;
int fail = 0;


while (finishedClass <= 12)
{
    double grade = double.Parse(Console.ReadLine());
    ++finishedClass;
    if (grade < 4.00)
    {
        fail++;
      
        if (fail > 1)
        {
            --finishedClass;
            break;
        }
        //continue;

    }
    else
    {
        averageGrade += grade;
        
    }
    if (finishedClass == 12)
        break;

}

if (finishedClass == 12)
{
    Console.WriteLine($"{nameStudent} graduated. Average grade: {averageGrade / 12:F2}");
    
}
else
    Console.WriteLine($"{nameStudent} has been excluded at {finishedClass} grade");
