int dogsFood = int.Parse(Console.ReadLine());
int catsFood = int.Parse(Console.ReadLine());
double priceCatsFood = catsFood * 4.0;
double priceDogsFood = dogsFood * 2.50;
double totalPrice = priceCatsFood + priceDogsFood;
Console.WriteLine($" {totalPrice} lv.");
