using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Models.Data
{
    public class FinanceAppContext : DbContext
    {
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options):base (options) { }

        DbSet<Expense> Expenses { get; set; }
    }
}
