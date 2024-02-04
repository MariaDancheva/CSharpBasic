// 1. Read from the console
// - quantityOfMagnolias - int
int numberMagnolias = int.Parse(Console.ReadLine());
// - quantityOfHyacinths - int
int numberHyacinths = int.Parse(Console.ReadLine());
// - quantityOfRoses - int
int numberRoses = int.Parse(Console.ReadLine());
// - quantityOfCactuses - int
int numberCactuses = int.Parse(Console.ReadLine());
// - giftPrice - doublint
double giftPrice = double.Parse(Console.ReadLine());

// 2. Flower prices
// - magnolias = quantityOfMagnolias * 3.25
double magnoliasPrice = numberMagnolias * 3.25;
// - hyacinths = quantityOfHyacinths * 4
int hyacinthsPrice = numberHyacinths * 4;
// - roses = quantityOfRoses * 3.5
double rosesPrice = numberRoses * 3.5;
// - cactus = quantityOfCactus * 8
int cactusesPrice = numberCactuses * 8;
// - total = magnolias + hyacinths + roses + cactus
double total = magnoliasPrice + hyacinthsPrice + rosesPrice + cactusesPrice;
// - gift = giftPrice * 0.05 + giftPrice
double afterTax = total - total * 0.05  ;
// 3. print
// - if total <= qift , calculate how much are left
// round it to Floor - int ,print "She is left with {left} leva."
if (afterTax >= giftPrice)
{
    double left = afterTax - giftPrice;
    int leftRounded = (int)Math.Floor(left);
    Console.WriteLine($"She is left with {leftRounded} leva.");
}
// - else , calculate how much are not enough
// round to the Ceiling - int, print "She will have to borrow {останали} leva."
else
{
    double notEnought = giftPrice - afterTax;
    int notEnoughtRounded = (int)Math.Ceiling(notEnought);
    Console.WriteLine($"She will have to borrow {notEnoughtRounded} leva.");
}