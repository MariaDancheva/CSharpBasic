double tennisRacket = double.Parse(Console.ReadLine());
int numberRackets = int.Parse(Console.ReadLine());
int pairsSneackers = int.Parse(Console.ReadLine());

double priceSneackers = (tennisRacket / 6) * pairsSneackers;
double priceRacket = tennisRacket * numberRackets;
double other = (priceSneackers + priceRacket) * 0.2;

Console.WriteLine($"Price to be paid by Djokovic {Math.Floor((priceSneackers + priceRacket + other) * 0.125)}");
Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling((priceSneackers + priceRacket + other) * 7/8)}");