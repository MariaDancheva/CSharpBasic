string city = Console.ReadLine();
double sellsQuantity = double.Parse(Console.ReadLine());
double cut = 0.00;

if (city != "Sofia" && city != "Varna" && city != "Plovdiv")
    Console.WriteLine("error");

else if (sellsQuantity < 0)
    Console.WriteLine("error");

else if (sellsQuantity > 10000)
{
    switch (city)
    {
        case "Sofia":
            cut = sellsQuantity * 0.12;
            break;
        case "Varna":
            cut = sellsQuantity * 0.13;
            break;
        case "Plovdiv":
            cut = sellsQuantity * 0.145;
            break;
    }
    Console.WriteLine($"{cut:F2}");
}
else if (sellsQuantity <= 10000 && sellsQuantity > 1000)
{
    switch (city)
    {
        case "Sofia":
            cut = sellsQuantity * 0.08;
            break;
        case "Varna":
            cut = sellsQuantity * 0.1;
            break;
        case "Plovdiv":
            cut = sellsQuantity * 0.12;
            break;
    }
    Console.WriteLine($"{cut:F2}");
}
else if (sellsQuantity<= 1000 && sellsQuantity > 500)
{
    switch (city)
    {
        case "Sofia":
            cut = sellsQuantity * 0.07;
            break;
        case "Varna":
            cut = sellsQuantity * 0.075;
            break;
        case "Plovdiv":
            cut = sellsQuantity * 0.08;
            break;
    }
    Console.WriteLine($"{cut:F2}");
}
else if (sellsQuantity>= 0 && sellsQuantity <= 500)
{
    switch (city)
    {
        case "Sofia":
            cut = sellsQuantity * 0.05;
            break;
        case "Varna":
            cut = sellsQuantity * 0.045;
            break;
        case "Plovdiv":
            cut = sellsQuantity * 0.055;
            break;
    }
    Console.WriteLine($"{cut:F2}");
}

