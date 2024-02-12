int quantityCoins1 = int.Parse(Console.ReadLine());
int quantityCoins2 = int.Parse(Console.ReadLine());
int quantityBills5 = int.Parse(Console.ReadLine());
int amount = int.Parse(Console.ReadLine());

for (int one = 0; one <= quantityCoins1; one++)
{
    for (int two = 0; two <= quantityCoins2; two++)
    {
        for (int five = 0; five <= quantityBills5; five++)
        {
            if(one * 1 + two * 2 + five * 5 == amount)
                Console.WriteLine($"{one} * 1 lv. + {two} * 2 lv. + {five} * 5 lv. = {amount} lv.");
        }
    }
}