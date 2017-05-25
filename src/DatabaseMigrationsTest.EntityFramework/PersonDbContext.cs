using System.Data.Entity;

namespace DatabaseMigrationsTest.EntityFramework
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext() : base("PersonDbContext")
        {
            
        }

        public DbSet<Person> Person { get; set; }
    }
}