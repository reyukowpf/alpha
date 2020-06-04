using System;

namespace Reyuko.Utils.Error
{
    public interface IAppException
    {
        int ErrorCode { get; set; }
        string MethodName { get; set; }
        int TraceID { get; set; }
        Exception ErrorDetail { get; set; }
    }
}
