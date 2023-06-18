namespace ClassLibrary1;

public interface ILibrary
{
    public void AddBook(Book book);
    public void RemoveBook(Book book);
    public void DisplayAvailableBooks();
}