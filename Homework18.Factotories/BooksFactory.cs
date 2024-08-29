using Homework18.Models.Interfaces.Books;
using Homework18.Models.Runtime.Books;
using Homework18.Models.Runtime.Books.Keepers;

namespace Homework18.Factotories
{
    public static class BooksFactory
    {
        public static void DownloadBook(Book book, string mode)
        {
            BookWriter bw;

            switch (mode.ToLower())
            {
                case "txt":
                    bw = new(new KeeperTxt());
                    bw.Save(book);
                    break;

                case "pdf":
                    bw = new(new KeeperPdf());
                    bw.Save(book);
                    break;

                case "docx":
                    bw = new(new KeeperDocx());
                    bw.Save(book);
                    break;

                default:
                    bw = new(new KeeperNull());
                    bw.Save(book);
                    break;
            }
        }
    }
}
