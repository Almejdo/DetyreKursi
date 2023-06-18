namespace ClassLibrary1;

public interface IOrder
{
    public void PlaceOrder(User u, List<Book> books, Double totalAmount);

}