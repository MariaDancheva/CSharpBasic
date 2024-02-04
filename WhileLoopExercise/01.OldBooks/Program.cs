string favoriteBook = Console.ReadLine();
int countBooks = 0;
string searchBook = Console.ReadLine();
while (favoriteBook != searchBook )
{
    searchBook = Console.ReadLine();
    countBooks++;
    if (searchBook == "No More Books")
    {
        Console.WriteLine("The book you search is not here!");
        Console.WriteLine($"You checked {countBooks} books.");
        break;
    }
        
}
if (favoriteBook == searchBook)
    Console.WriteLine($"You checked {countBooks} books and found it.");