using ExpenseTrackerBackend.DTOs;
using ExpenseTrackerBackend.Services;
using ExpenseTrackerBackend.Validations;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTrackerBackend.Controllers
{
    [ApiController]
    [Route("api/expenses")]

    public class ExpensesController : ControllerBase
    {
        private readonly IExpenseService _service;

        public ExpensesController(IExpenseService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult AddExpense([FromBody] CreateExpenseRequest request)
        {
            try
            {
                var result = _service.AddExpense(request);
                return Ok(result);
            }
            catch (ExpenseValidationException ex)
            {
                return BadRequest(new
                {
                    errorCode = ex.ErrorCode
                });
            }
        }

        [HttpGet]
        public IActionResult GetExpenses()
        {
            return Ok(_service.GetExpenses());
        }
    }

}
