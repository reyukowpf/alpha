using System;

namespace Reyuko.Utils.Error
{
    public class AppException : Exception, IAppException
    {
        public int ErrorCode { get; set; }
        public string MethodName { get; set; }
        public int TraceID { get; set; }
        public Exception ErrorDetail { get; set; }

        public AppException(int code, string method, int trace, Exception ex)
        {
            ErrorCode = code;
            MethodName = method;
            TraceID = trace;
            ErrorDetail = ex;
        }
    }
}
