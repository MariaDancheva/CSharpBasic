// 1. Input from console
// - excursionPrice - double
double excursionPrice = double.Parse(Console.ReadLine());
// - quantityPuzzels - int
int quantityPuzzels = int.Parse(Console.ReadLine());
// - quantityDolls - int
int quantityDolls = int.Parse(Console.ReadLine());
// - quantityBears - int
int quantityTeddyBears = int.Parse(Console.ReadLine());
// - quantityMinions - int
int quantityMinions = int.Parse(Console.ReadLine());
// - quantityTruck - int
int quantityTrucks = int.Parse(Console.ReadLine());
// 2. Prices
// - pricePuzzel = quantityPuzzels * 2.60
double pricePuzzles = quantityPuzzels * 2.6;
// - dolls * 3
int priceDolls = quantityDolls * 3;
// - teddyBear * 4.10
double priceTeddyBear = quantityTeddyBears * 4.1;
// - minions * 8.20
double priceMinions = quantityMinions * 8.2;
// - truck * 2
int priceTrucks = quantityTrucks * 2;
// - total money
double totalMoney = priceTrucks + priceTeddyBear + pricePuzzles + priceMinions + priceDolls;
int quantityToys = quantityTrucks + quantityTeddyBears + quantityPuzzels + quantityMinions + quantityDolls;

// 3. if / else if
// - total quantity of toys if >= 50 => total = total money - totalMoney *0.25
if (quantityToys >= 50)
{
    double money = totalMoney - totalMoney * 0.25;
    double rent = money * 0.1;
    double moneyEarned = money - rent;
    if (moneyEarned >= excursionPrice)
    {
        double left = moneyEarned - excursionPrice;
        //double moneyLeftRounded = (double)Math.Round(left, 2);
        Console.WriteLine($"Yes! {left:F2} lv left.");
    }
    else
    {
        double notEnoughtMoney = excursionPrice - moneyEarned;
        //double notEnoughtRounded = (double)Math.Round(notEnoughtMoney, 2);
        Console.WriteLine($"Not enough money! {notEnoughtMoney:F2} lv needed.");
    }
}
// - rent = total * 0.1 => earned = totalMoney - total - rent
// - if toys < 50 , compare excurision price with money earned in every situation
// 4. Print - "Yes! {оставащите пари} lv left." if excursion price is enough {0:F2}
// - "Not enough money! {недостигащите пари} lv needed." {0:F2}
else
{
    double rent = totalMoney * 0.1;
    double moneyEarned = totalMoney - rent;
    if (moneyEarned >= excursionPrice)
    {
        double moneyLeft = moneyEarned - excursionPrice;
        //double moneyRounded = (double)Math.Round(moneyLeft, 2);
        Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
    }
    else
    {
        double notEnoughtMoney = excursionPrice - moneyEarned;
        //double moneyRounded = (double)Math.Round(notEnoughtMoney, 2);
        Console.WriteLine($"Not enough money! {notEnoughtMoney:F2} lv needed.");
    }
}
