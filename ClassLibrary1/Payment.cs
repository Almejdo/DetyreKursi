namespace ClassLibrary1;

public class Payment
{
    
    private int id;
    private Double amount;
    private String transactionId;
    private DateTime createdAt;
    private Order order;

    public Payment(int id, double amount, string transactionId, DateTime createdAt, Order order)
    {
        this.id = id;
        this.amount = amount;
        this.transactionId = transactionId;
        this.createdAt = createdAt;
        this.order = order;
    }

    public Double Amount
    {
        get { return amount; }
        set { amount = value; }
    }

    public Order Order
    {
        get { return order; }
        set { order = value; }
    }

    public String TransactionId
    {
        get { return transactionId; }
        set { transactionId = value; }
    }
}