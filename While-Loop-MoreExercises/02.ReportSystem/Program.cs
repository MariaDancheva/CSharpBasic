int donation = int.Parse(Console.ReadLine());
int cashPayments = 0;
int peoplePayingCash = 0;
int cardPayments = 0;
int peoplePayingCard = 0;
int countObjects = 0;
string objectPrice = Console.ReadLine();

while (objectPrice != "End")
{
    ++countObjects;
    if (countObjects % 2 != 0)
    {
        if (int.Parse(objectPrice) > 100)
        {
            Console.WriteLine("Error in transaction!");
        }
        else
        {
            peoplePayingCash++;
            cashPayments += int.Parse(objectPrice);
            Console.WriteLine("Product sold!");
        }
    }
    else if (countObjects % 2 == 0)
    {
        if (int.Parse(objectPrice) < 10)
            Console.WriteLine("Error in transaction!");
        else
        {
            peoplePayingCard++;
            cardPayments += int.Parse(objectPrice);
            Console.WriteLine("Product sold!");
        }
    }
    if (cardPayments + cashPayments >= donation)
        break;

    objectPrice = Console.ReadLine();
}

if(cardPayments + cashPayments >= donation)
{
    Console.WriteLine($"Average CS: {(double)cashPayments / peoplePayingCash:F2}");
    Console.WriteLine($"Average CC: {(double)cardPayments / peoplePayingCard:F2}");
}
else
    Console.WriteLine("Failed to collect required money for charity.");