using ExpenseTrackerBackend.Models;

namespace ExpenseTrackerBackend.DTOs
{
    public class CreateExpenseRequest
    {
        public string Title { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Currency { get; set; } = "INR";
        public DateTime Date { get; set; }
        public string Category { get; set; } = string.Empty;
    }

}
