namespace ClassLibrary1;

public class Category
{
    
    private int id;
    
    private String name;
   
    private DateTime createdAt;

    public Category(int id, string name, DateTime createdAt)
    {
        this.id ++;
        this.name = name;
        this.createdAt = createdAt;
    }

    public Category()
    {
        
    }

    public String Name
    {
        get { return Name; }
        set { Name = value; }
    }
    public DateTime CreatedAt
    {
        get { return createdAt; }
        set { createdAt = value; }
    }
}