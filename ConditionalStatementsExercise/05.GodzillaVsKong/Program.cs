// 1. Input from console
// - budget - double
double budget = double.Parse(Console.ReadLine());
// - extras - int
int extras = int.Parse(Console.ReadLine());
// - priceClothsPerExtra -double
double priceClothsPerExtra = double.Parse(Console.ReadLine());
// 2. decor = budget * 0.1
double decor = budget * 0.1;
// 3. clothsTotal = pricePerExtra * extras
double clothsTotal = priceClothsPerExtra * extras;
// 4. if/else if
// - if extras > 150, clothsDiscounted = 10% off from clothsTotal
// - moneyNeeded = decora +  clothsDiscounted
// if moneyNeeded <= budget, calculate how much is left and print
// "Action!" 
//"Wingard starts filming with {останалите пари:F2} leva left."
// else, calculate how much is not enought and print
//Not enough money!"
//"Wingard needs {парите недостигащи за филма:F2} leva more."
if (extras > 150)
{
    double discountCloths = clothsTotal - clothsTotal * 0.1;
    double moneyNeeded = discountCloths + decor;
    if (moneyNeeded <= budget)
    {
        double leftMoney = budget - moneyNeeded;
        Console.WriteLine("Action!");
        Console.WriteLine($"Wingard starts filming with {leftMoney:F2} leva left.");
    }
    else
    {
        double notEnoughMoney = moneyNeeded - budget;
        Console.WriteLine("Not enough money!");
        Console.WriteLine($"Wingard needs {notEnoughMoney:F2} leva more.");
    }
}
else
{
    double moneyNeeded = clothsTotal + decor;
    if (moneyNeeded <= budget)
    {
        double leftMoney = budget - moneyNeeded;
        Console.WriteLine("Action!");
        Console.WriteLine($"Wingard starts filming with {leftMoney:F2} leva left.");
    }
    else
    {
        double notEnoughMoney = moneyNeeded - budget;
        Console.WriteLine("Not enough money!");
        Console.WriteLine($"Wingard needs {notEnoughMoney:F2} leva more.");
    }

}

