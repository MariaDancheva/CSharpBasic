// 1. read from the console a number - int
int number = int.Parse(Console.ReadLine());
// 2. calsulate the bonus point
// - if number <= 100 + 5 point
if (number <= 100)
{
    double bonus = 5;
    int odd = number % 2;
    int endToFive = number % 10;
    if (odd == 0)
    {
        double totalBonus = bonus + 1;
        double totalNumber = totalBonus + number;
        Console.WriteLine(totalBonus);
        Console.WriteLine(totalNumber);
        
    }
    
    else if (endToFive == 5)
    {
        double totalBonus = bonus + 2;
        double totalNumber = number + totalBonus;
        Console.WriteLine(totalBonus);
        Console.WriteLine(totalNumber);
    }
    else
    {
        double totalNumber = number + bonus;
        Console.WriteLine(bonus);
        Console.WriteLine(totalNumber);
    }
}
// - if number > 1000 => bonus = number * 0.1
else if (number > 1000)
{
    double bonus = number * 0.1;
    int odd = number % 2;
    int endToFive = number % 10;
    if (odd == 0)
    {
        double totalBonus = bonus + 1;
        double totalNumber = totalBonus + number;
        Console.WriteLine(totalBonus);
        Console.WriteLine(totalNumber);

    }
    else if (endToFive == 5)
    {
        double totalBonus = bonus + 2;
        double totalNumber = number + totalBonus;
        Console.WriteLine(totalBonus);
        Console.WriteLine(totalNumber);
    }
    else
    {
        double totalNumber = number + bonus;
        Console.WriteLine(bonus);
        Console.WriteLine(totalNumber);
    }
}
// - if number >= 100 => bonus = number * 0.2
else if (number >= 100)
{
    double bonus = number * 0.2;
    int odd = number % 2;
    int endToFive = number % 10;
    if (odd == 0)
    {
        double totalBonus = bonus + 1;
        double totalNumber = totalBonus + number;
        Console.WriteLine(totalBonus);
        Console.WriteLine(totalNumber);

    }
    else if (endToFive == 5)
    {
        double totalBonus = bonus + 2;
        double totalNumber = number + totalBonus;
        Console.WriteLine(totalBonus);
        Console.WriteLine(totalNumber);
    }
    else
    {
        double totalNumber = number + bonus;
        Console.WriteLine(bonus);
        Console.WriteLine(totalNumber);
    }
}
//  - if number % 2 = 0 => + 1
// - in number ends in 5 => + 2
// 3. print in every case two numbers one that is the bonus points received
// and one the total points
