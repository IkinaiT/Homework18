using Homework18.Models.Interfaces.Books;

namespace Homework18.Models.Runtime.Books.Keepers
{
    public class KeeperNull : IBookSaveMode
    {
        public void SaveBook(Book book)
        {
            using (StreamWriter sw = new($"{book.Author} - {book.Name}"))
            {
                sw.WriteLine(book.Content);
            }
        }
    }
}
