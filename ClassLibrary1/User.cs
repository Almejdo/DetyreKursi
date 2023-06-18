namespace ClassLibrary1;

public class User
{
   
    private int id;
    private String firstName;
    private String lastName;
    private String userName;
    private DateTime createdAt;
    private List<Order> orders;

    public User( string firstname, string lastname, string username,  DateTime createdAt)
    {
        this.id++;
        this.firstName = firstname;
        this.lastName = lastname;
        this.userName = username;
        this.createdAt = createdAt;
        orders = new List<Order>();

    }

    public User()
    {
        
    }

    public String FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    public DateTime CreatedAt
    {
        get { return createdAt; }
        set { createdAt = value; }
    }
    public String LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public String UserName
    {
        get { return userName; }
        set { userName = value; }
    }
    public List<Order> Orders
    {
        get { return orders; }
        set { orders = value; }
    }
}