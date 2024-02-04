double change = double.Parse(Console.ReadLine());
int coinsCount = 0;
double coins = change * 100;

while (coins != 0)
{
   int smallChange = Convert.ToInt32(coins % 10);
    if (change < 5)
    {

        switch (smallChange)
        {
            case 0:
                coins /= 10;
                break;
            case 1:
                coins -= 1;
                ++coinsCount;
                break;
            case 2:
                coins -= 2;
                ++coinsCount;
                break;
            case 3:
                coins -= 3;
                coinsCount += 2;
                break;
            case 4:
                coins -= 4;
                coinsCount += 2;
                break;
            case 5:
                coins -= 5;
                ++coinsCount;
                break;
            case 6:
                coins -= 6;
                coinsCount += 2;
                break;
            case 7:
                coins -= 7;
                coinsCount += 2;
                break;
            case 8:
                coins -= 8;
                coinsCount += 3;
                break;
            case 9:
                coins -= 9;
                coinsCount += 3;
                break;
        }
    }
    else
    {
        switch (smallChange)
        {
            case 0:
                coins /= 10;
                break;
            case 1:
                coins -= 1;
                ++coinsCount;
                break;
            case 2:
                coins -= 2;
                ++coinsCount;
                break;
            case 3:
                coins -= 3;
                coinsCount += 2;
                break;
            case 4:
                coins -= 4;
                coinsCount += 2;
                break;
            case 5:
                coins -= 5;
                coinsCount += 3;
                break;
            case 6:
                coins -= 6;
                coinsCount += 2;
                break;
            case 7:
                coins -= 7;
                coinsCount += 2;
                break;
            case 8:
                coins -= 8;
                coinsCount += 3;
                break;
            case 9:
                coins -= 9;
                coinsCount += 3;
                break;
        }
    }
}
Console.WriteLine(coinsCount);