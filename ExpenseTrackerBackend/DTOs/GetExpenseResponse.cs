namespace ExpenseTrackerBackend.DTOs
{
    public class GetExpensesResponse
    {
        public List<ExpenseResponse> Expenses { get; set; } = new();
        public decimal TotalAmount { get; set; }
        public string Currency { get; set; } = string.Empty;
    }

}
