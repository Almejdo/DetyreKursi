namespace ClassLibrary1;

public class Library : ILibrary
{
   
    private int id;
   
    private String name;
   
    private DateTime createdAt;
    private List<Book> books;

    public Library(int id, string name, DateTime createdAt)
    {
        this.id = id;
        this.name = name;
        this.createdAt = createdAt;
    }

    public Library()
    {
        
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }

    public void DisplayAvailableBooks()
    {
        Console.WriteLine("Available Books:");
        foreach (var book in books)
        {
            if (book.IsAvailable)
            {
                Console.WriteLine($"{book.Title} by {book.Author} ({book.Price})");
            }
        }
    }
}