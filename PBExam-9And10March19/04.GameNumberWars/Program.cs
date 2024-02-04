string player1 = Console.ReadLine();
string player2 = Console.ReadLine();
int pointsPlayer1 = 0;
int pointsPlayer2 = 0;
string cardP1 = Console.ReadLine();

while (cardP1 != "End of game")
{
    int cardP2 = int.Parse(Console.ReadLine());
    if (int.Parse(cardP1) > cardP2)
    {
        pointsPlayer1 += int.Parse(cardP1) - cardP2;
    }
    else if (int.Parse(cardP1) < cardP2)
    {
        pointsPlayer2 += cardP2 - int.Parse(cardP1);
    }
    else
    {
        Console.WriteLine("Number wars!");
        cardP1 = Console.ReadLine();
        cardP2 = int.Parse(Console.ReadLine());
        if (int.Parse(cardP1) > cardP2)
            Console.WriteLine($"{player1} is winner with {pointsPlayer1} points");
        else
            Console.WriteLine($"{player2} is winner with {pointsPlayer2} points");
        break;
    }
    cardP1 = Console.ReadLine();


}

if (cardP1 == "End of game")
{
    Console.WriteLine($"{player1} has {pointsPlayer1} points");
    Console.WriteLine($"{player2} has {pointsPlayer2} points");
}