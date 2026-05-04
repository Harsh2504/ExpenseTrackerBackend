namespace ExpenseTrackerBackend.Models;
public class Expense
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string Currency { get; set; } = "INR"; 
    public DateTime Date { get; set; }
    public ExpenseCategory Category { get; set; }
}
