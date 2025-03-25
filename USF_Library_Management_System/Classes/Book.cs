
namespace Classes
{
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int AvailableCopies { get; set; }
 
    public Book(string title, string author, string isbn, int availableCopies)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        AvailableCopies = availableCopies;
    }
 
    public void BorrowBook()
    {
        if (AvailableCopies > 0)
        {
            AvailableCopies--;
            Console.WriteLine($"Book '{Title}' has been borrowed.");
        }
        else
        {
            Console.WriteLine($"Sorry, '{Title}' is currently unavailable.");
        }
    }
}
}