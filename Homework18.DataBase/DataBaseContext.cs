using Homework18.Models.Runtime.Animals;
using Homework18.Models.Runtime.Books;
using Microsoft.EntityFrameworkCore;

namespace Homework18.DataBase
{
    public class DataBaseContext : DbContext
    {
        #region Animals

        public DbSet<Amphibian> Amphibians { get; set; }
        public DbSet<Bird> Birds { get; set; }
        public DbSet<Mammal> Mammals { get; set; }
        public DbSet<NullAnimal> Unknowns { get; set; }

        #endregion

        #region Books

        public DbSet<Book> Books { get; set; }

        #endregion


        public DataBaseContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
