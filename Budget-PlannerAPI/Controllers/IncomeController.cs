using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Budget_PlannerAPI.Data;
using Budget_PlannerAPI.Models;

namespace Budget_PlannerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncomeController : ControllerBase
    {
        private readonly BudgetPlannerContext _context;

        public IncomeController(BudgetPlannerContext context)
        {
            _context = context;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetIncomes(int userId)
        {
            var incomes = await _context.Incomes.Where(i => i.UserId == userId).ToListAsync();
            return Ok(incomes);
        }

        [HttpPost]
        public async Task<IActionResult> AddIncome(Income income)
        {
            _context.Incomes.Add(income);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Income added successfully" });
        }
    }
}
