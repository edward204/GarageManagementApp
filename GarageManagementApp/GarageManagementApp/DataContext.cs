using System.Configuration;
using GarageManagementApp.Data;
using Microsoft.EntityFrameworkCore;

namespace GarageManagementApp
{
    public class DataContext : DbContext
    {

        public DbSet<Login> Login { get; set; }
        public DbSet<Customer> Customer { get; set; }

        public DbSet<Vehicle> Vehicle { get; set; }
        
        public DbSet<Job> Job { get; set; }

        public string DbPath { get; private set; }

        public DataContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}ldmc.db";
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        }

    }

}