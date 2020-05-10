using System;

namespace SquadRegisterApi.Auxiliar
{
    public class Error
    {
        public string Message { get; set; }
    }
    public static class ExceptionExtension
    {
        public static dynamic GetInnerException(this Exception exception)
        {
            Console.Write("Esse é o erro",exception.InnerException);
            //TODO: if (exception.InnerException == null) return new Error { Message = exception.Message };
            if (exception.InnerException == null) return exception.Message;
            return GetInnerException(exception.InnerException);
        }
    }
}