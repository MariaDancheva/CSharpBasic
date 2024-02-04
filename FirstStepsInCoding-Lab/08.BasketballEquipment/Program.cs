int anualFee = int.Parse(Console.ReadLine());
double shoes = anualFee - (anualFee * 0.40 );
double jersey = shoes - (shoes * 0.20);
double ball = jersey * 0.25;
double accessories = ball * 0.20;

double total = anualFee + shoes + jersey + ball + accessories;
Console.WriteLine(total);