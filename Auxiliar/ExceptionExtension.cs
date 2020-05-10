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
      //TODO: if (exception.InnerException == null) return new Error { Message = exception.Message };
      if (exception.InnerException == null) return exception.Message;
      return GetInnerException(exception.InnerException);
    }
  }
}