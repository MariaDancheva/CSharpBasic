string nameActor = Console.ReadLine();
double points = double.Parse(Console.ReadLine());
int numberOfAssessors = int.Parse(Console.ReadLine());
double nominationPoints = 1250.5;

for (int i = 0; i < numberOfAssessors && points < nominationPoints; i++)
{
    string assessorsName = Console.ReadLine();
    double assessorsPoints = double.Parse(Console.ReadLine());
    int nameLengtht = assessorsName.Length;
    points += ((nameLengtht * assessorsPoints) / 2); 
}
double notEnoughBy = nominationPoints - points;

if (points >= nominationPoints)
    Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {points:F1}!");
else
    Console.WriteLine($"Sorry, {nameActor} you need {notEnoughBy:F1} more!");