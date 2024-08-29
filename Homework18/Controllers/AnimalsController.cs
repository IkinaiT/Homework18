using Homework18.DataBase;
using Homework18.Factotories;
using Homework18.Models;
using Homework18.Models.Runtime.ClientModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Homework18.Controllers
{
    public class AnimalsController : Controller
    {
        private DataBaseContext _dataBaseContext;

        public AnimalsController()
        {
            var optionsMSSQL = new DbContextOptionsBuilder<DataBaseContext>();

            optionsMSSQL.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=homework18;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            _dataBaseContext = new(optionsMSSQL.Options);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new AnimalsViewModel(_dataBaseContext.Amphibians.ToList(), _dataBaseContext.Birds.ToList(), _dataBaseContext.Mammals.ToList(), _dataBaseContext.Unknowns.ToList()));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewAnimal newAnimal)
        {
            await AnimalFactory.CreateNewAnimal(newAnimal, _dataBaseContext);

            return View("Index", new AnimalsViewModel(_dataBaseContext.Amphibians.ToList(), _dataBaseContext.Birds.ToList(), _dataBaseContext.Mammals.ToList(), _dataBaseContext.Unknowns.ToList()));
        }
    }
}
