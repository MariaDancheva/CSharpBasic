int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int numberFishermen = int.Parse(Console.ReadLine());

int springRent = 3000;
int summerAnDAutumnRent = 4200;
int winterRent = 2600;
double discount = 0.0;
double rent = 0;

if (numberFishermen <= 6)
    discount = 0.1;
else if (numberFishermen >= 7 && numberFishermen <= 11)
    discount = 0.15;
else
    discount = 0.25;

if (season == "Spring")
{
    rent = springRent;
}
else if (season == "Winter")
    rent = winterRent;
else
   rent = summerAnDAutumnRent;
    

 rent = rent - rent * discount;

if (numberFishermen % 2 == 0)
{
    if (season != "Autumn")
        rent *= 0.95;
}

double moneyLeft = Math.Abs(budget - rent);

if (budget >= rent)
    Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
else
    Console.WriteLine($"Not enough money! You need {moneyLeft:F2} leva.");
