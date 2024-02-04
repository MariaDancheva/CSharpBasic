int pensils = int.Parse(Console.ReadLine());
int markers = int.Parse(Console.ReadLine());
int liters = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double pricePensils = pensils * 5.80;
double priceMarkers = markers * 7.20;
double priceLiters = liters * 1.20;

double price = pricePensils + priceMarkers + priceLiters;
double priceDiscount = price * (discount * 0.01);
double total = price - priceDiscount;

Console.WriteLine(total);
