string installments = Console.ReadLine();
double total = 0.0;

    while (installments != "NoMoreMoney")
    {
    double increased = 0.0;

        increased = Convert.ToDouble(installments);
        if (increased < 0)
        {
            Console.WriteLine("Invalid operation!");
            break;

        }
    Console.WriteLine($"Increase: {increased:F2}");

    installments = Console.ReadLine();
        total += increased;
    }

    Console.WriteLine($"Total: {total:F2}");
