double deposit = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double persent = double.Parse(Console.ReadLine());

double persentUntilNow = deposit * (persent * 0.01);
double persentPerMonth = persentUntilNow / 12;
double sum = deposit + persentPerMonth * months;
Console.WriteLine(sum);