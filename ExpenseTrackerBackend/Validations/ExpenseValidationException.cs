namespace ExpenseTrackerBackend.Validations
{
    public class ExpenseValidationException : Exception
    {
        public string ErrorCode { get; }

        public ExpenseValidationException(string errorCode) : base(errorCode)
        {
            ErrorCode = errorCode;
        }
    }
}
