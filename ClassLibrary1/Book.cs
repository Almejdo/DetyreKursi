namespace ClassLibrary1;

public class Book
{

    private int id;
    private String title;
    private String author;
    private Double price;
    private int quantity;
    private DateTime createdAt;
    private Category category;
    private bool isAvailable;
    public Book(int id, string title, string author, double price, int quantity, DateTime createdAt, Category category)
    {
        this.id ++;
        this.title = title;
        this.author = author;
        this.price = price;
        this.quantity = quantity;
        this.createdAt = createdAt;
        this.category = category;
    }

    public Book()
    {
        
    }
    public String Title
    {
        get { return title; }
        set { title = value; }
    }
    public String Author
    {
        get { return author; }
        set { author = value; }
    }
    public DateTime CreatedAt
    {
        get { return createdAt; }
        set { createdAt = value; }
    }
    public Double Price
    {
        get { return price; }
        set { price = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }
    public Category Category
    {
        get { return category; }
        set { category = value; }
    }

    public bool IsAvailable
    {
        get { return isAvailable; }
        set { isAvailable = value; }
    }
}