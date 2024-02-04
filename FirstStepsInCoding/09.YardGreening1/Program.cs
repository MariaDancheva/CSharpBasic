double kvMeteers = double.Parse(Console.ReadLine());
double price = kvMeteers * 7.61;
double discount = price * 0.18;
double total = price - discount;
Console.WriteLine($"The final price is: {total} lv.");
Console.WriteLine($"The discount is: {discount} lv.");
