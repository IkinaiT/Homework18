using Homework18.DataBase;
using Homework18.Factotories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Homework18.Controllers
{
    public class BooksController : Controller
    {
        private DataBaseContext _dataBaseContext;

        public BooksController()
        {
            var optionsMSSQL = new DbContextOptionsBuilder<DataBaseContext>();

            optionsMSSQL.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=homework18;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            _dataBaseContext = new(optionsMSSQL.Options);

            if(_dataBaseContext.Books.Count() < 1)
            {
                Task.Run(async () => 
                {
                    await _dataBaseContext.Books.AddRangeAsync([
                        new(){
                            Author = "Дж. К. Роулинг",
                            Name = "Гарри Поттер и философский камень",
                            Content = "Первая книга серии"
                        },
                        new(){
                            Author = "Дж. К. Роулинг",
                            Name = "Гарри Поттер и тайная комната",
                            Content = "Вторая книга серии"
                        },
                        new(){
                            Author = "Дж. К. Роулинг",
                            Name = "Гарри Поттер и узник азкабана",
                            Content = "Третья книга серии"
                        },
                        new(){
                            Author = "Дж. К. Роулинг",
                            Name = "Гарри Поттер и кубок огня",
                            Content = "Четвертая книга серии"
                        },
                        new(){
                            Author = "Дж. К. Роулинг",
                            Name = "Гарри Поттер и орден феникса",
                            Content = "Пятая книга серии"
                        },
                        new(){
                            Author = "Дж. К. Роулинг",
                            Name = "Гарри Поттер и принц-полукровка",
                            Content = "Шестая книга серии"
                        },
                        new(){
                            Author = "Дж. К. Роулинг",
                            Name = "Гарри Поттер и дары смерти",
                            Content = "Седьмая книга серии"
                        }
                        ]);

                    await _dataBaseContext.SaveChangesAsync();
                });
            }
        }

        public IActionResult Index()
        {
            return View(_dataBaseContext.Books.ToList());
        }

        public void DownloadAsTxt(int bookId)
        {
            var book = _dataBaseContext.Books.Where(_ => _.Id == bookId).FirstOrDefault();

            if (book != null)
                BooksFactory.DownloadBook(book, "txt");
        }

        public void DownloadAsDocx(int bookId)
        {
            var book = _dataBaseContext.Books.Where(_ => _.Id == bookId).FirstOrDefault();

            if (book != null)
                BooksFactory.DownloadBook(book, "docx");
        }

        public void DownloadAsPdf(int bookId)
        {
            var book = _dataBaseContext.Books.Where(_ => _.Id == bookId).FirstOrDefault();

            if (book != null)
                BooksFactory.DownloadBook(book, "pdf");
        }
    }
}
