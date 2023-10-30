using Core.Models;

namespace WhatsappNarminTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //no interface sorry)
            Book book = new Book("Book Sample", 20, "Cool Author", 100, 4);
            Console.WriteLine("Creating new book");
            Library.AddBook(book);
            Library.ShowAllBooks();
            Library.GetBookById(1).ShowInfo();
            book.ShowInfo();
            Console.WriteLine("Remove this book");
            book.Sell();
            book.ShowInfo();
            book.Sell();
            book.ShowInfo();
            book.Sell();
            book.ShowInfo();
            book.Sell();
            book.ShowInfo();
            book.Sell();
            book.ShowInfo();
            Book.GetIncome();
        }
    }
}