//1. input from console - string
string password = Console.ReadLine();
//2. if string == "s3cr3t!P@ssw0rd" => ouput "Welcome"
if (password == "s3cr3t!P@ssw0rd")
    Console.WriteLine("Welcome");
//3. else output => Wrong password!
else
    Console.WriteLine("Wrong password!");
