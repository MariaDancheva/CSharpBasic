// 1. read from console
// - sttring fuelType
string fuelType = Console.ReadLine();
// - double litersFuelInTak
double fuelInTank = double.Parse(Console.ReadLine());
// 2.Fuel types
// -Diesel
string diesel = "diesel";
// -Gasoline
string gasoline = "gasoline";
// -Gas
string gas = "gas";
// 3. if checks
//  - litersFuelInTank >= 25 , print You have enough {вида на горивото}.
if (fuelInTank >= 25)
{
    if (fuelType == "Diesel")
        Console.WriteLine($"You have enough {diesel}.");
    else if (fuelType == "Gasoline")
        Console.WriteLine($"You have enough {gasoline}.");
    else if (fuelType == "Gas")
        Console.WriteLine($"You have enough {gas}.");
    else
        Console.WriteLine("Invalid fuel!");
}
//  - litersFuelInTank < 25 , print "Fill your tank with {вида на горивото}!.
else if (fuelInTank < 25)
{
    if (fuelType == "Diesel")
        Console.WriteLine($"Fill your tank with {diesel}!");
    else if (fuelType == "Gasoline")
        Console.WriteLine($"Fill your tank with {gasoline}!");
    else if (fuelType == "Gas")
        Console.WriteLine($"Fill your tank with {gas}!");
    else
        Console.WriteLine("Invalid fuel!");
}
// -if fuel dont match print "Invalid fuel!"
