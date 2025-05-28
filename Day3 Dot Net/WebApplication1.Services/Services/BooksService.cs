using WebApplication1.Models;

namespace WebApplication1.Services
{
    // For CRUD on books
    public class BooksService
    {
        private List<Book> _books;

        public BooksService() {
            _books = new List<Book>();
        }

        // To Add Book
        public void AddBook(Book book)
        {
            _books.Add(book);
        }
        public List<Book> GetAll()
        {
            return _books;
        }

        public Book? GetBookById(int id)
        {
            return _books.Find(x => x.Id == id);
        }
    }
}
