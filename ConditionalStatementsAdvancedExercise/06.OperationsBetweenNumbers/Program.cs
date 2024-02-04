double num1 = double.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
char operationType = Console.ReadLine()[0], Method;
string oddOrEven = "";
double sum = 0;

if ( num2 == 0 )
{
    if (operationType == '/' || operationType == '%')
        Console.WriteLine($"Cannot divide {num1} by zero");


}


else if (operationType == '+')
{
    sum = num1 + num2;
    if (sum % 2 == 0)
        oddOrEven = "even";
    else
        oddOrEven = "odd";

}
else if (operationType == '-')
{
    sum = num1 - num2;
    if (sum % 2 == 0)
        oddOrEven = "even";
    else
        oddOrEven = "odd";
}
else if (operationType == '*')
{
    sum = num1 * num2;
    if (sum % 2 == 0)
        oddOrEven = "even";
    else
        oddOrEven = "odd";
}

if (operationType == '+' || operationType == '-' || operationType == '*')
    Console.WriteLine($"{num1} {operationType} {num2} = {sum} - {oddOrEven}");

else if (operationType == '/' && num2 != 0)
{
    sum = num1 / num2;
    Console.WriteLine($"{num1} {operationType} {num2} = {sum:F2}");

}
else if (operationType == '%' && num2 != 0)
{
    sum = num1 % num2;
    Console.WriteLine($"{num1} {operationType} {num2} = {sum}");

}