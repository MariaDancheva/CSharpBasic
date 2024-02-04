// 1. Read from the console
// - days - int
int days = int.Parse(Console.ReadLine());
// - foodKg - int
int foodKg = int.Parse(Console.ReadLine());
// - dogFoodKgPerDay - double
double dogFoodKgPerDay = double.Parse(Console.ReadLine());
// - catFoodKgPerDay - double
double catFoodKgPerDay = double.Parse(Console.ReadLine());
// - turtleFoodKg  /1000- double
double turtleFoodKgPerDay = double.Parse(Console.ReadLine()) / 1000;

// 2.Calculate Food Needed
// - dogNeeds = days * dogFoodKgPerDay
double dogNeeds = days * dogFoodKgPerDay;
// - catNeeds = days * catFoodKgPerDay
double catNeeds = days * catFoodKgPerDay;
// - turtleNeeds = days * turtleFoodKg
double turtleNeeds = days * turtleFoodKgPerDay;
// - totalFoodNeeded = dogNeeds + catNeeds + turtleNeeds
double totalFoodNeeded = dogNeeds + catNeeds + turtleNeeds;
// 3. Print
// if totalFoodNeeded <= foodkg, calculate how much is left
// print "{foodLeft} kilos of food left." , rounded down (Floor) - int
if (totalFoodNeeded <= foodKg)
{
    double left = foodKg - totalFoodNeeded;
    int leftRounded = (int)Math.Floor(left);
    Console.WriteLine ($"{leftRounded} kilos of food left.");
}
// else if totalFoodNeeded > foodKg, calculate how much is left
// print “{notEnough} more kilos of food are needed.” , rounded up (ceiling) - int
else
{
    double notEnought = totalFoodNeeded - foodKg;
    int notEnoughtRounded = (int)Math.Ceiling(notEnought);
    Console.WriteLine($"{notEnoughtRounded} more kilos of food are needed.");
}
