int numberStudents = int.Parse(Console.ReadLine());

double topStudents = 0;
double goodStudents = 0.0;
double passStudents = 0.0;
double failStudents = 0.0;
double averageGrade = 0.0;

for (int i = 1; i <= numberStudents; i++)
{
    double grade = double.Parse(Console.ReadLine());
    switch (grade)
    {
        case <= 2.99:
            failStudents++;
            averageGrade += grade;
            break;
        case >= 3.00 and <= 3.99:
            passStudents++;
            averageGrade += grade;
            break;
        case >= 4.00 and <= 4.99:
            goodStudents++;
            averageGrade += grade;
            break;
        default :
            topStudents++;
            averageGrade += grade;
            break;
    }
}

averageGrade /= numberStudents;
Console.WriteLine($"Top students: {topStudents * 100 / numberStudents:F2}%");
Console.WriteLine($"Between 4.00 and 4.99: {goodStudents * 100 / numberStudents:F2}%");
Console.WriteLine($"Between 3.00 and 3.99: {passStudents * 100 / numberStudents:F2}%");
Console.WriteLine($"Fail: {failStudents * 100 / numberStudents:F2}%");
Console.WriteLine($"Average: {averageGrade:F2}");