using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk
{
    class AliException : Exception
    {
        private string errorCode;
        private string errorMsg;

        public AliException()
            : base()
        {
        }

        public AliException(string message)
            : base(message)
        {
        }


        public AliException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public AliException(string errorCode, string errorMsg)
            : base(errorCode + ":" + errorMsg)
        {
            this.errorCode = errorCode;
            this.errorMsg = errorMsg;
        }

        public string ErrorCode
        {
            get { return this.errorCode; }
        }

        public string ErrorMsg
        {
            get { return this.errorMsg; }
        }
    }

}
