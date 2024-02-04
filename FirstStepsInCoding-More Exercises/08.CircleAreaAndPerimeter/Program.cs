// 1. Console input radius - double
double radius = double.Parse(Console.ReadLine());
// 2. Calculate the area and parameter
// - area = Math.PI * radius * radius
double area = Math.PI * radius * radius;
// - circumference = 2 * Math.PI * radius
double circumference = 2 * Math.PI * radius;
// 3. Print result  separete 0:F2
Console.WriteLine("{0:F2}", area );
Console.WriteLine("{0:F2}",circumference );
