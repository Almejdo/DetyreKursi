namespace ClassLibrary1;

public class Order : IOrder
{
   
    private int id  { get; set; }
    private Double totalAmount { get; set; }
    private DateTime createdAt { get; set; }
    private List<Book> Books { get; set; }
    private User user { get; set; }
    


    public Order(int id, double totalAmount, DateTime createdAt, List<Book> books, User user)
    {
        this.id = id;
        this.totalAmount = totalAmount;
        this.createdAt = createdAt;
        Books = books;
        this.user = user;
    }

    public Order()
    {
        
    }

    public void PlaceOrder(User u, List<Book> books, Double totalAmount)
    {
        Order order = new Order
        {
            id = id++,
            totalAmount = totalAmount,
            createdAt = DateTime.Now,
            Books = books,
            user = u

        };
        Console.WriteLine($"Order placed successfully. Order Number: {order.id}, Date: {order.createdAt}, Amount: {totalAmount}");
    }
}