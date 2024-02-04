// 1. Console input a double number
double degreece = double.Parse(Console.ReadLine());
// 2. Compare the number and print a line
// if degreece <= 11.9 also >= 5 print Cold
if (degreece <= 11.9)
{
    if (degreece >= 5)
        Console.WriteLine("Cold");
    else
        Console.WriteLine("unknown");
}
//  else if degreece <= 14.9 also >= 12 => Cool
else if (degreece <= 14.9)
{
    if (degreece >= 12)
        Console.WriteLine("Cool");
    else
        Console.WriteLine("unknown");
}
// else if degreece <= 20 also >= 15 => Mild
else if (degreece <= 20)
{
    if (degreece >= 15)
        Console.WriteLine("Mild");
    else
        Console.WriteLine("unknown");
}
// else if degeece <= 25.9 also  >= 20.1 => Warm
else if (degreece <= 25.9)
{
    if (degreece >= 20.1)
        Console.WriteLine("Warm");
    else
        Console.WriteLine("unknown");
}
// else if degreece <= 35 also >= 26 => Hot
else if (degreece <= 35)
{
    if (degreece >= 26.00)
        Console.WriteLine("Hot");
    else
        Console.WriteLine("unknown");
}
// else => unknown
else
    Console.WriteLine("unknown");

