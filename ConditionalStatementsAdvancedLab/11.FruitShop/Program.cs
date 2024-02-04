string fruit = Console.ReadLine();
string day = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());
double price = 0;

if (fruit != "grapes" && fruit != "pineapple" && fruit != "kiwi" && fruit != "grapefruit" && fruit != "orange" && fruit != "apple" && fruit != "banana")
    Console.WriteLine("error");
else if (day != "Monday" && day != "Tuesday" && day != "Wednesday" && day != "Thursday" && day != "Friday" && day != "Saturday" && day != "Sunday")
    Console.WriteLine("error");





else if (day == "Saturday" || day == "Sunday")
{


    if (fruit == "banana")
        price = quantity * 2.7;


    else if (fruit == "apple")
        price = quantity * 1.25;

    else if (fruit == "orange")
        price = quantity * 0.9;

    else if (fruit == "grapefruit")
        price = quantity * 1.6;

    else if (fruit == "kiwi")
        price = quantity * 3.0;

    else if (fruit == "pineapple")
        price = quantity * 5.6;

    else if (fruit == "grapes")
        price = quantity * 4.2;


    Console.WriteLine($"{price:F2}");


}
else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
{

    if (fruit == "banana")
        price = quantity * 2.5;

    else if (fruit == "apple")
        price = quantity * 1.2;

    else if (fruit == "orange")
        price = quantity * 0.85;

    else if (fruit == "grapefruit")
        price = quantity * 1.45;

    else if (fruit == "kiwi")
        price = quantity * 2.7;

    else if (fruit == "pineapple")
        price = quantity * 5.5;

    else if (fruit == "grapes")
        price = quantity * 3.85;


    Console.WriteLine($"{price:F2}");



}




