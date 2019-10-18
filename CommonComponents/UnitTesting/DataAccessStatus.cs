using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonComponents.UnitTesting
{
    public class DataAccessStatus
    {
        public string Status { get; set; }
        public bool OperationSucceded { get; set; }
        public string ExceptionMessage { get; set; }
        public string CustomMessage { get; set; }
        public string HelpLink { get; set; }
        public int ErrorCode { get; set; }
        public string StackTrace { get; set; }

        public void SetValues(string status, bool operationSucceded, string exceptionMessage, string customMessage, 
            string helpLink, int errorCode, string stackTrace)
        {
            Status = status ?? string.Copy("");
            OperationSucceded = operationSucceded;
            CustomMessage = customMessage ?? string.Copy("");
            ExceptionMessage = exceptionMessage ?? string.Copy("");
            CustomMessage = customMessage ?? string.Copy("");
            HelpLink = helpLink ?? string.Copy("");
            ErrorCode = errorCode;
            StackTrace = stackTrace ?? string.Copy("");
        }

        public string GetFormattedValues()
        {
            return $"{ nameof(Status) }--> { Status }" +
                $"\n{ nameof(OperationSucceded) }--> { OperationSucceded }" +
                $"\n{ nameof(CustomMessage) }--> { CustomMessage }" +
                $"\n{ nameof(ExceptionMessage) }-->{ ExceptionMessage }" +
                $"\n{ nameof(HelpLink) }--> { HelpLink }" +
                $"\n{ nameof(ErrorCode) }--> { ErrorCode }" +
                $"\n{ nameof(StackTrace) }--> { StackTrace }";
        }
    }
}
