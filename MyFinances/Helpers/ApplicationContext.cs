using MyFinances.Models;
using System.Data.Entity;

namespace MyFinances.Helpers
{
    // File to connect to the database

    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection")
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Debt> Debts { get; set; }

        public DbSet<Accumulation> Accumulations { get; set; }

    }
}
