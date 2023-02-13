global using Microsoft.EntityFrameworkCore;
using GestionEmployee.Models;

namespace GestionEmployee.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress; Database=agrodb;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
