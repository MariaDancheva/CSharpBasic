int number = int.Parse(Console.ReadLine());
string invalid = "";

if (number >= 100 && number <= 200 || number == 0)
{
    Console.WriteLine(invalid);
}
else
{
    invalid = "invalid";
    Console.WriteLine(invalid);
}
