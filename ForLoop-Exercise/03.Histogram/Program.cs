int number = int.Parse(Console.ReadLine());
//p1 < 200
double p1 = 0;
double persentP1 = 0;
// p2 <= 399
double p2 = 0;
double persentP2 = 0;
//p3 <= 599
double p3 = 0;
double persentP3 = 0;
//p4 <= 799
double p4 = 0;
double persentP4 = 0;
//p5 >800
double p5 = 0;
double persentP5 = 0;

for (int i = 0; i < number; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num < 200 && num >= 1)
        ++p1;
    else if (num <= 399)
        ++p2;
    else if (num <= 599)
        ++p3;
    else if (num <= 799)
        ++p4;
    else
        ++p5;
}

persentP1 = p1 * 100 / number;
persentP2 = p2 * 100 / number;
persentP3 = p3 * 100 / number;
persentP4 = p4 * 100 / number;
persentP5 = p5 * 100 / number;

Console.WriteLine($"{persentP1:F2}%");
Console.WriteLine($"{persentP2:F2}%");
Console.WriteLine($"{persentP3:F2}%");
Console.WriteLine($"{persentP4:F2}%");
Console.WriteLine($"{persentP5:F2}%");
