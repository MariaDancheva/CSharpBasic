// 1. Read fro console
// - area = int
int area = int.Parse(Console.ReadLine());
// - kg grapes per 1 - double
double kgGrapes = double.Parse(Console.ReadLine());
// - wineNeeded - int
int wineNeeded = int.Parse(Console.ReadLine());
// - workers - int
int numberWorkers = int.Parse(Console.ReadLine());
// 2. Calculations
// - harvest = area * kgGrapes
double harvest = area * kgGrapes;
// - setAsideGrapes = harvest * 0.4
//double setASide = harvest * 0.4;
// - wineMade = setASside / 2.5
double wineMade = (harvest * 0.4) / 2.5;
// 3. Print
//  if wineMade < wineNeeded
// - lessBy = wineNeeded - wineMade
// - Math.Floor (less)
// - print $“It will be a tough winter! More {lessBy} liters wine needed.”
if (wineMade < wineNeeded)
{
    double lessBy = wineNeeded - wineMade;
    int lessByRounded = (int)Math.Floor(lessBy);
    Console.WriteLine($"It will be a tough winter! More {lessByRounded} liters wine needed.");
}
//  else if (wineMade >= wineNeeded)
// - bonus = wineMade - wineNeeded
// - bonusPerWorker = bonus / workers
// - Math.Floor (wineMade)
// print $"Good harvest this year! Total wine: {wineMade} liters.”
// print $“{bonus} liters left -> {bonusPerWorker} liters per person.”
else if (wineMade >= wineNeeded)
{
    double bonusWine = wineMade - wineNeeded;
    double bonusPerWorker = bonusWine / numberWorkers;
    int bonusWineRounded = (int)Math.Ceiling(bonusWine);
    int bonusPerWorkerRounded =(int)Math.Ceiling(bonusPerWorker);
    Console.WriteLine($"Good harvest this year! Total wine: {wineMade} liters.");
    Console.WriteLine($"{bonusWineRounded} liters left -> {bonusPerWorkerRounded} liters per person.");
}


