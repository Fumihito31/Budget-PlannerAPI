namespace Budget_PlannerAPI.Models
{
    public class Income
    {
        public int IncomeId { get; set; }
        public int UserId { get; set; }
        public string Month { get; set; }
        public string Source { get; set; }
        public decimal Amount { get; set; }
        public string Investments { get; set; }
        public User User { get; set; }

    }
}
