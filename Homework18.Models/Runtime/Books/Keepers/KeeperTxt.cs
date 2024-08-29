using Homework18.Models.Interfaces.Books;

namespace Homework18.Models.Runtime.Books.Keepers
{
    public class KeeperTxt : IBookSaveMode
    {
        public void SaveBook(Book book)
        {
            using (StreamWriter sw = new($"{book.Author} - {book.Name}.txt"))
            {
                sw.WriteLine(book.Content);
            }
        }
    }
}
