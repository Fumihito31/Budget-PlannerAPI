using Budget_PlannerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Budget_PlannerAPI.Data
{
    public class BudgetPlannerContext : DbContext
    {
        public BudgetPlannerContext(DbContextOptions<BudgetPlannerContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Income> Incomes { get; set; }
    }
}
