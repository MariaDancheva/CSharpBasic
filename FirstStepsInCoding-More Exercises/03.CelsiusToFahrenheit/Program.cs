//1. Read from the console a double digit (Celsius)
double celsius = double.Parse(Console.ReadLine());

// 2. Calculate how much is the farenheight with this formula F = °C × (9/5) + 32
double fahrenheit = celsius * 9 /5 + 32;

//3. write the result formated to two digits from the decimal point
Console.WriteLine("{0:F2}", fahrenheit);
