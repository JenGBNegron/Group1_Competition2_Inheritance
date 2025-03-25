// Book.cs
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int AvailableCopies { get; set; }
    public string Genre { get; set; } // Random detail ra!

    public Book(string title, string author, string isbn, int copies, string genre = "")
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        AvailableCopies = copies;
        Genre = genre;
    }

    public override string ToString()
    {
        if (!string.IsNullOrEmpty(Genre))
            return $"Title: {Title}, Author: {Author}, Available Copies: {AvailableCopies}, Genre: {Genre}";
        return $"Title: {Title}, Author: {Author}, Available Copies: {AvailableCopies}";
    }
}