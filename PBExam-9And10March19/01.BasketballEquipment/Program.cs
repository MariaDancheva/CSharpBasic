int fee = int.Parse(Console.ReadLine());

double shoes = fee * 0.6;
double jersey = shoes * 0.8;
double ball = jersey * 1/4;
double accessories = ball * 1/5;

Console.WriteLine($"{fee + shoes + jersey + ball + accessories:F2}");