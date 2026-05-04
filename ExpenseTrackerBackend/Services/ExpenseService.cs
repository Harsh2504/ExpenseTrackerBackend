using ExpenseTrackerBackend.DTOs;
using ExpenseTrackerBackend.Models;
using ExpenseTrackerBackend.Repositories;
using ExpenseTrackerBackend.Validations;

namespace ExpenseTrackerBackend.Services
{

    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository _repository;

        public ExpenseService(IExpenseRepository repository)
        {
            _repository = repository;
        }

        public ExpenseResponse AddExpense(CreateExpenseRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Title))
                throw new ExpenseValidationException("TITLE_REQUIRED");

            if (request.Amount <= 0)
                throw new ExpenseValidationException("INVALID_AMOUNT");

            var expense = new Expense
            {
                Title = request.Title,
                Amount = request.Amount,
                Currency = request.Currency,
                Date = request.Date,
                Category = request.Category
            };

            var saved = _repository.Add(expense);

            return Map(saved);
        }

        public GetExpensesResponse GetExpenses()
        {
            var expenses = _repository.GetAll();

            return new GetExpensesResponse
            {
                Expenses = expenses.Select(Map).ToList(),
                TotalAmount = expenses.Sum(e => e.Amount),
                Currency = expenses.FirstOrDefault()?.Currency ?? "INR"
            };
        }

        private static ExpenseResponse Map(Expense e)
        {
            return new ExpenseResponse
            {
                Id = e.Id,
                Title = e.Title,
                Amount = e.Amount,
                Currency = e.Currency,
                Date = e.Date,
                Category = e.Category
            };
        }
    }

}
