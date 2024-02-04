// 1. Input from the console
// - one double number vegetebles for a kilogram price in lv
double pricePerKIlogramVegetables = double.Parse(Console.ReadLine());

// - one double number fruits per kilogram in lv
double pricePerKilogramFruite = double.Parse(Console.ReadLine());

// - total amout of vegetables in kilograms - int
int kilogramsVegetables = int.Parse(Console.ReadLine());

// - total kilograms of fruits - int
int kilogramsFruits = int.Parse(Console.ReadLine());

// 2. Calculate the total income
// - vegetables = (price for vegetables lv * kilograms )
double incomeFromVegetables = pricePerKIlogramVegetables * kilogramsVegetables;

// - fruits = (price for fruits lv * kilograms)
double incomeFromFruits = pricePerKilogramFruite * kilogramsFruits;

// - total = (vegetables + fruits) / 1.94
double totalIncome = (incomeFromFruits + incomeFromVegetables) / 1.94 ;

// 3. Print the result formated tot wo digits after the decimal point
Console.WriteLine("{0:F2}", totalIncome);
 