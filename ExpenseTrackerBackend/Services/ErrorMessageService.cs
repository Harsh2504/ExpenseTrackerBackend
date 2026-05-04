using Microsoft.Extensions.Localization;
using ExpenseTrackerBackend.Resources;
using ExpenseTrackerBackend.Services.Interfaces;

namespace ExpenseTrackerBackend.Services
{
    public class ErrorMessageService : IErrorMessageService
    {
        private readonly IStringLocalizer _localizer;

        public ErrorMessageService(IStringLocalizerFactory factory)
        {
            var type = typeof(ErrorResourceMarker);
            _localizer = factory.Create("Errors", type.Assembly.GetName().Name!);
        }

        public string GetMessage(string errorCode)
        {
            return _localizer[errorCode];
        }
    }
}
