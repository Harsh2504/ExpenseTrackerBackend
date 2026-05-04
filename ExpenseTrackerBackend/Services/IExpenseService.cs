using ExpenseTrackerBackend.DTOs;

namespace ExpenseTrackerBackend.Services
{
    public interface IExpenseService
    {
        ExpenseResponse AddExpense(CreateExpenseRequest request);
        GetExpensesResponse GetExpenses();
    }

}
