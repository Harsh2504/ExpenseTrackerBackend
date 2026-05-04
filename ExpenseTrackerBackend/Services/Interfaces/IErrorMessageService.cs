namespace ExpenseTrackerBackend.Services.Interfaces
{
    public interface IErrorMessageService
    {
        string GetMessage(string errorCode);
    }

}
