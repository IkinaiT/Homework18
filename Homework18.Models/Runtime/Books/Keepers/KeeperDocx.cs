using Homework18.Models.Interfaces.Books;

namespace Homework18.Models.Runtime.Books.Keepers
{
    public class KeeperDocx : IBookSaveMode
    {
        public void SaveBook(Book book)
        {
            using (StreamWriter sw = new($"{book.Author} - {book.Name}.docx"))
            {
                sw.WriteLine(book.Content);
            }
        }
    }
}
