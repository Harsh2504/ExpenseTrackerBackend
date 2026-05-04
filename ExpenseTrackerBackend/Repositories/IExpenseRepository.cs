using ExpenseTrackerBackend.Models;

namespace ExpenseTrackerBackend.Repositories
{
    public interface IExpenseRepository
    {
        Expense Add(Expense expense);
        IReadOnlyList<Expense> GetAll();
    }

}
