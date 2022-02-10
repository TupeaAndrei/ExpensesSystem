using ExpensesSystem.DAL.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSystem.DAL.Migrations
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseObject> ExpenseObjects { get; set; }
        public DbSet<ExpensesSystem.DAL.Models.Object> Objects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
