int numberOfJudges = int.Parse(Console.ReadLine());
double assesments = 0;
double assesmentsAverage = 0;
int presentationCount = 0;

string presentationName = Console.ReadLine();
while (presentationName != "Finish")
{
    presentationCount++;
    for (int i = 0; i < numberOfJudges; i++)
    {
        assesments += double.Parse(Console.ReadLine());
    }
    assesmentsAverage += assesments / numberOfJudges;
    Console.WriteLine($"{presentationName} - {assesments / numberOfJudges:F2}.");
    assesments = 0;
    presentationName = Console.ReadLine();
}
Console.WriteLine($"Student's final assessment is {assesmentsAverage / presentationCount:F2}.");