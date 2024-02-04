string userName = Console.ReadLine();
string password = Console.ReadLine();

string paswordCheck = Console.ReadLine();
while (password != paswordCheck)
{
    paswordCheck = Console.ReadLine();
}
Console.WriteLine($"Welcome {userName}!");