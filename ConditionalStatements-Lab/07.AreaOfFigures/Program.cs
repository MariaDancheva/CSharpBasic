//1. read input from the console
string figure = Console.ReadLine();
//2. if input == square =>vread from the console a double number
if (figure == "square")
{
    double side = double.Parse(Console.ReadLine());
    double area = side * side;
    Console.WriteLine("{0:F3}", area);
}
//3. else if input == rectangle => 2 double numbers (sides) red from the console
else if (figure == "rectangle")
{
    double sideA = double.Parse(Console.ReadLine());
    double sideB = double.Parse(Console.ReadLine());
    double area = sideA * sideB;
    Console.WriteLine("{0:F3}", area);
}
//4. else if input == triangle => 2 double numbers (hight and lenght) from the console
else if (figure == "triangle")
{
    double lenght = double.Parse(Console.ReadLine());
    double hight = double.Parse(Console.ReadLine());
    double area = (lenght * hight) * 0.5;
    Console.WriteLine("{0:F3}", area);
}

//5. else if input == circle => 1 double number the radious
else if (figure == "circle")
{ 
    double radious = double.Parse(Console.ReadLine());
    double area = Math.PI * radious * radious;
    Console.WriteLine("{0:F3}", area);
}
