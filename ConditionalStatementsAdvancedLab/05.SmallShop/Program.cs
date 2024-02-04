string product = Console.ReadLine();
string city = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());
double price = 0;

if (product == "coffee")
{
    if (city == "Sofia")
    {
        price = quantity * 0.5;
    }
    else if (city == "Plovdiv")
    {
        price = quantity * 0.4;
    }
    else
    {
        price = quantity * 0.45;
    }
}
else if (product == "water")
{
    if (city == "Sofia")
    {
        price = quantity * 0.8;
    }
    else if (city == "Plovdiv")
    {
        price = quantity * 0.7;
    }
    else
    {
        price = quantity * 0.70;
    }
}
else if (product == "beer")
{
    if (city == "Sofia")
    {
        price = quantity * 1.2;
    }
    else if (city == "Plovdiv")
    {
        price = quantity * 1.15;
    }
    else
    {
        price = quantity * 1.1;
    }
}
else if (product == "sweets")
{
    if (city == "Sofia")
    {
        price = quantity * 1.45;
    }
    else if (city == "Plovdiv")
    {
        price = quantity * 1.3;
    }
    else
    {
        price = quantity * 1.35;
    }
}
else if (product == "peanuts")
{
    if (city == "Sofia")
    {
        price = quantity * 1.6;
    }
    else if (city == "Plovdiv")
    {
        price = quantity * 1.5;
    }
    else
    {
        price = quantity * 1.55;
    }
}
Console.WriteLine(price);
