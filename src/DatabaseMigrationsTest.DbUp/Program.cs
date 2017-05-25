using System;
using System.Configuration;
using System.Reflection;
using DbUp;

namespace DatabaseMigrationsTest.DbUp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            EnsureDatabase.For.SqlDatabase(connectionString);

            var upgrader = DeployChanges.To.SqlDatabase(connectionString)
                .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                .LogToConsole()
                .Build();

            var result = upgrader.PerformUpgrade();

            Console.Out.WriteLine(result.Successful ? "Migration has been successful!" : "Migration failed");
        }
    }
}
