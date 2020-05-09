using System;

namespace SquadRegisterApi.Auxiliar
{
    public static class ExceptionExtension
    {
        public static string GetInnerException(this Exception exception)
        {
            if (exception.InnerException == null) return exception.Message;
            return GetInnerException(exception.InnerException);
        }
    }
}