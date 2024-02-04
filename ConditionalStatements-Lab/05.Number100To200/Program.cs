//1. read an int number from th console
int number = int.Parse(Console.ReadLine());

//2. if number < 100 => write "Less than 100"
if (number < 100)
    Console.WriteLine("Less than 100");
//3. else if number >= 100 , number <= 200 =>"Between 100 and 200"
else if (number <= 200)
{
    if (number >= 100)
        Console.WriteLine("Between 100 and 200");
}
//4. else if number >200 => "Greater than 200"
else if (number > 200)
    Console.WriteLine("Greater than 200");
