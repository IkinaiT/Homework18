using Homework18.Models.Interfaces.Books;

namespace Homework18.Models.Runtime.Books
{
    public class BookWriter
    {
        private IBookSaveMode Mode { get; set; }

        public BookWriter(IBookSaveMode mode)
        {
            Mode = mode;
        }

        public void Save(Book book)
        {
            Mode.SaveBook(book);
        }
    }
}
