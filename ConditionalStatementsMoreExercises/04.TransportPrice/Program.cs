// 1. Input from the console
// - km - int
int km = int.Parse(Console.ReadLine());
// - partOfTheDay - string
// 2. Ways of transportation
string partOfTheDay = Console.ReadLine();
// - taxi startPriceDay = 0.7 , dayPrice = 0.79 , nightPrice = 0.9
// - bus priicePerKm = 0.09 , km >= 20 km
// - train pricePerKM = 0.06 , km >= 100
if (km >= 100)
{
    double trainPrice = km * 0.06;
    Console.WriteLine("{0:F2}", trainPrice);
}
else if (km >= 20)
{
    double busPrice = km * 0.09;
    Console.WriteLine("{0:F2}", busPrice);
}
else
{
    double startPrice = 0.7;
    if (partOfTheDay == "day")
    {
        double price = km * 0.79 + startPrice;
        Console.WriteLine("{0:F2}", price);
    }
    else if (partOfTheDay == "night")
    {
        double price = km * 0.9 + startPrice;
    Console.WriteLine("{0:F2}", price);
    }


}