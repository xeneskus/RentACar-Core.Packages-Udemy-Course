using Core.CrossCuttingConcerns.Exceptions.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions.Handlers
{
    public abstract class ExceptionHandler
    {
        public Task HandleExceptionAsync(Exception exception) =>
            exception switch
            {
                BusinessException businessException => HandleException(businessException),
                ValidationException validationException => HandleException(validationException),
                _ => HandleException(exception),
            };
        protected abstract Task HandleException(BusinessException businessException); //business ise bu çalışacak değil ise alt kısımdaki 
        protected abstract Task HandleException(ValidationException validationException); // ise bu çalışacak değil ise alt kısımdaki 
        protected abstract Task HandleException(Exception exception);

    }
}
