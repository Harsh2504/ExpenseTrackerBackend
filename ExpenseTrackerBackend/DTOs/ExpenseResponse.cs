using ExpenseTrackerBackend.Models;

namespace ExpenseTrackerBackend.DTOs
{
    public class ExpenseResponse
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Currency { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public ExpenseCategory Category { get; set; }
    }

}
