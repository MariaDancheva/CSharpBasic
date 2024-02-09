int sumPrimeNumbers = 0;
int sumNonPrimeNumbers = 0;
string number = Console.ReadLine();
while (number != "stop")
{
    int num = int.Parse(number);
    if(num < 0)
    {
        Console.WriteLine("Number is negative.");
    }
    else
    {
        if (num == 0)
            sumNonPrimeNumbers += num;
        else if (num % 2 == 0 && num != 2 || num % 3 == 0 && num != 3)
            sumNonPrimeNumbers += num;
        else
            sumPrimeNumbers += num;
    }

    number = Console.ReadLine();
}

Console.WriteLine($"Sum of all prime numbers is: {sumPrimeNumbers}");
Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimeNumbers}");