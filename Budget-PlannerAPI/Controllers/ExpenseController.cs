using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Budget_PlannerAPI.Data;
using Budget_PlannerAPI.Models;

namespace Budget_PlannerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly BudgetPlannerContext _context;

        public ExpenseController(BudgetPlannerContext context)
        {
            _context = context;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetExpenses(int userId)
        {
            var expenses = await _context.Expenses.Where(e => e.UserId == userId).ToListAsync();
            return Ok(expenses);
        }

        [HttpPost]
        public async Task<IActionResult> AddExpense(Expense expense)
        {
            _context.Expenses.Add(expense);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Expense added successfully" });
        }
    }
}
