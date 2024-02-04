string flowerType = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double moneyNeeded = 0.0;
int roses = 5;
double dahlia = 3.8;
double tulip = 2.8;
int narcissus = 3;
double gladiolus = 2.5;

if (flowerType == "Roses")
{
    moneyNeeded = quantity * roses;
    if (quantity > 80)
        moneyNeeded *= 0.9;
}
else if (flowerType == "Dahlias")
{
    moneyNeeded = quantity * dahlia;
    if (quantity > 90)
        moneyNeeded *= 0.85;
}
else if (flowerType == "Tulips")
{
    moneyNeeded = quantity * tulip;
    if (quantity > 80)
        moneyNeeded *= 0.85;
}
else if (flowerType == "Narcissus")
{
    moneyNeeded = quantity * narcissus;
    if (quantity < 120)
        moneyNeeded = moneyNeeded + moneyNeeded * 0.15;
}
else
{
    moneyNeeded = quantity * gladiolus;
    if (quantity < 80)
        moneyNeeded = moneyNeeded + moneyNeeded * 0.2;
}


double moneyLeft = Math.Abs(budget - moneyNeeded);

if (budget >= moneyNeeded)
{
    Console.WriteLine($"Hey, you have a great garden with {quantity} {flowerType} and {moneyLeft:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {moneyLeft:F2} leva more.");
}
