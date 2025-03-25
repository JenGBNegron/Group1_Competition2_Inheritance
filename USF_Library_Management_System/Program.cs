// Program.cs
using System;
using Classes; 
class Program
{
    static void Main()
    {
        // Create book objects
        Book book1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
        Book book2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
        Book book3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);
 
        // Create student objects
        Student student1 = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
        Student student2 = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);
 
        // Create staff objects
        Staff staff1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");
 
        // Create library and add books and patrons
        Library library = new Library();
        library.Books.Add(book1);
        library.Books.Add(book2);
        library.Books.Add(book3);
        library.Patrons.Add(student1);
        library.Patrons.Add(student2);
        library.Patrons.Add(staff1);
 
        // Display initial information
        library.DisplayBooks();
        library.DisplayPatrons();
 
        // Borrowing books
        Console.WriteLine("\nBorrowing Books...");
        book2.BorrowBook();  // Sandeep borrows 'Business Insights with AI'
        book3.BorrowBook();  // Akhil borrows 'Analytics in Action'
 
        // Display updated information
        Console.WriteLine("\nBooks after borrowing:");
        library.DisplayBooks();
    }
}