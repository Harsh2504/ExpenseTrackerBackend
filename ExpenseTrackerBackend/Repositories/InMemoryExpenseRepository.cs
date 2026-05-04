using ExpenseTrackerBackend.Models;

namespace ExpenseTrackerBackend.Repositories
{
    public class InMemoryExpenseRepository : IExpenseRepository
    {
        private readonly List<Expense> _expenses = new();
        private int _idCounter = 1;

        public Expense Add(Expense expense)
        {
            expense.Id = _idCounter++;
            _expenses.Add(expense);
            return expense;
        }

        public IReadOnlyList<Expense> GetAll()
        {
            return _expenses;
        }
    }

}
