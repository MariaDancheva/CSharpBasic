string month = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());
double studioPrice = 0;
double apartmentPrice = 0;
//double discount = 0;
//double discountApartment = 0;

if (month == "May" || month == "October")
{

    apartmentPrice = nights * 65;
    studioPrice = nights * 50;
}
else if (month == "June" || month == "September")
{
    apartmentPrice = nights * 68.7;
    studioPrice = nights * 75.2;
}
else
{
    apartmentPrice = nights * 77;
    studioPrice = nights * 76;

}
if (nights > 14)
{
    if (month == "May" || month == "October")
    {

        studioPrice *= 0.7;
        apartmentPrice *= 0.9;


        Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
        Console.WriteLine($"Studio: {studioPrice:F2} lv.");
    }
    else if (month == "June" || month == "September")
    {

        studioPrice *= 0.8;
        apartmentPrice *= 0.9;

        Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
        Console.WriteLine($"Studio: {studioPrice:F2} lv.");
    }
    else
    {
        apartmentPrice *= 0.9;

        Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
        Console.WriteLine($"Studio: {studioPrice:F2} lv.");
    }


}
else if (nights > 7 && month == "May" || month == "October")
{
    studioPrice *= 0.95;

    Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
    Console.WriteLine($"Studio: {studioPrice:F2} lv.");
}
else
{
    Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
    Console.WriteLine($"Studio: {studioPrice:F2} lv.");
}
