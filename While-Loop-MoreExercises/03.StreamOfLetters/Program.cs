string secret = "";
int countC = 0;
int countO = 0;
int countN = 0;
string word = "";
string test = "";
while (true)
{
    string symbol = Console.ReadLine();
    if (symbol == "End")
        break;
    switch(symbol)
    {
        case "A" or "a":
        case "B" or "b":
        case "C":
        case "D" or "d":
        case "E" or "e":
        case "F" or "f":
        case "G" or "g":
        case "H" or "h":
        case "I" or "i":
        case "J" or "j":
        case "K" or "k":
        case "L" or "l":
        case "M" or "m":
        case "N":
        case "O":
        case "P" or "p":
        case "Q" or "q":
        case "R" or "r":
        case "S" or "s":
        case "T" or "t":
        case "U" or "u":
        case "V" or "v":
        case "W" or "w":
        case "X" or "x":
        case "Y" or "y":
        case "Z" or "z":
            test += symbol;
            break;
        case "c":
            countC++;
            if (countC == 1)
                secret += symbol;
            else
                test += symbol;           
            break;
        case "o":
            countO++;
            if (countO == 1)
                secret += symbol;
            else
                test += symbol;
            break;
        case "n":
            countN++;
            if (countN == 1)
                secret += symbol;
            else
                test += symbol;
            break;
        default:
            break;
    }
    if (secret.Length == 3)
    {
        word += test + " ";
        test = "";
        secret = "";
        countN = 0;
        countC = 0;
        countO = 0;
    }
}
Console.WriteLine($"{word}");