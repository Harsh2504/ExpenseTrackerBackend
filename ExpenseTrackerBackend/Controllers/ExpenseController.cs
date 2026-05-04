using ExpenseTrackerBackend.DTOs;
using ExpenseTrackerBackend.Services.Interfaces;
using ExpenseTrackerBackend.Validations;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTrackerBackend.Controllers
{
    [ApiController]
    [Route("api/expenses")]

    public class ExpensesController : ControllerBase
    {
        private readonly IExpenseService _service;

        private readonly IErrorMessageService _errorMessages;

        public ExpensesController(IExpenseService service,IErrorMessageService errorMessages)
        {
            _service = service;
            _errorMessages = errorMessages;
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
                    errorCode = ex.ErrorCode,
                    message = _errorMessages.GetMessage(ex.ErrorCode)
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
