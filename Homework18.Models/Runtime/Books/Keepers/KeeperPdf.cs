using Homework18.Models.Interfaces.Books;

namespace Homework18.Models.Runtime.Books.Keepers
{
    public class KeeperPdf : IBookSaveMode
    {
        public void SaveBook(Book book)
        {
            using (StreamWriter sw = new($"{book.Author} - {book.Name}.pdf"))
            {
                sw.WriteLine(book.Content);
            }
        }
    }
}
