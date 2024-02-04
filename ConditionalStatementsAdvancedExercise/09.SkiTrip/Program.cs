int dayStay = int.Parse(Console.ReadLine()) - 1;
string roomType = Console.ReadLine();
string assessment = Console.ReadLine();

double room = dayStay * 18.0;
double apartment = dayStay * 25.0;
double presidentApartment = dayStay * 35.0;
double price = 0;

if (roomType == "apartment")
{
    if (dayStay < 10)
    {
        price = apartment * 0.7;
    }
    else if (dayStay >= 10 && dayStay <= 15)
    {
        price = apartment * 0.65;
    }
    else if (dayStay > 15)
    {
        price = apartment * 0.5;
    }
}
else if (roomType == "president apartment")
{
    if (dayStay < 10)
    {
        price = presidentApartment * 0.9;
    }
    else if (dayStay >= 10 && dayStay <= 15)
    {
        price = presidentApartment * 0.85;
    }
    else if (dayStay > 15)
    {
        price = presidentApartment * 0.8;
    }
}
else
    price = room;

if (assessment == "positive")
{
    price = price + price * 0.25;
}
else
{
    price *= 0.9;
}

Console.WriteLine($"{price:F2}");