//1. Input from the console
// - price for the mackerel per kilogram - double
double meckerelPerKg = double.Parse(Console.ReadLine());
// - price per kilogram for the sprat - double
double spratPerKg = double.Parse(Console.ReadLine());
// - kilograms of belted bonito - double
double beltedBonitoKgs = double.Parse(Console.ReadLine());
// - kilograms of scad - double
double scadKgs = double.Parse(Console.ReadLine());
// - kilograms mussels - int
double mussels = double.Parse(Console.ReadLine()) * 7.5;

//2. find the total price
// - price for belted bonito => mackerel * 0.6 + mackerel
double beltedBonitoPerKg = meckerelPerKg * 0.6 + meckerelPerKg;
// - total price for belted bonito per kg
double totalCostBeltedBonito = beltedBonitoKgs * beltedBonitoPerKg;
// - price for scad per kg => sprat *0.8 + sprat
double scadPerKg = spratPerKg * 0.8 + spratPerKg;
// - total price for sprat
double totalCostScad = scadPerKg * scadKgs;

// - Find the bill = total price for: belted bonito + scad + mussels
double bill = mussels + totalCostBeltedBonito + totalCostScad;

//3. Output the bill formated to two digits after the decimal point
Console.WriteLine("{0:F2}", bill);
