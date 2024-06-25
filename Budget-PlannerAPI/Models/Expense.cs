namespace Budget_PlannerAPI.Models
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public int UserId { get; set; }
        public string Month { get; set; }
        public string ExpenseType { get; set; }
        public decimal ExpenseAmount { get; set; }
        public User User { get; set; }
    }
}
