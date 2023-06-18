namespace ClassLibrary1;

public class MainClass
{
    private IOrder order;
    static public void Main(String[] args)
    {
        User user = new User
        {
            FirstName = "Laki",
            LastName = "Luk",
           UserName = "LakiLuk",
           CreatedAt = DateTime.Now

        };
        Category category = new Category
        {
            Name = "Thriller",
            CreatedAt = DateTime.Now
        };

        List<Book> book = new List<Book>();
        Book book1 = new Book();
        book1.Author = "Kadare";
        book1.Category = category;
        book1.CreatedAt = DateTime.Now;
        book1.Quantity = 3;
        book1.Title = "Keshtjella";
        book1.Price = 32.2;
        
        Book book2 = new Book();
        book1.Author = "Gjon Buzuku";
        book1.Category = category;
        book1.CreatedAt = DateTime.Now;
        book1.Quantity = 2;
        book1.Title = "Meshari";
        book1.Price = 54.3;
        book.Add(book1);
        book.Add(book2);
        
        Order order = new Order();
        order.PlaceOrder(user,book,32);

        Library library = new Library();
        library.AddBook(book1);
        library.AddBook(book2);
        library.RemoveBook(book1);
        library.DisplayAvailableBooks();
    }
}