using System;

namespace Iamopen.Common.DB.StoredProcedures.SpResult
{
    public abstract class SpResultBase<T>
    {
        public SpResultCode ResultCode;
        public string ErrorMessage = String.Empty;

        protected SpResultBase()
        {
            ResultCode = SpResultCode.UnexpectedError;
        }

        public SpResultBase(string errorMessage)
        {
            this.ErrorMessage = errorMessage;
            this.ResultCode = SpResultCode.UnexpectedError;
        }
    }

    public enum SpResultCode
    {
        OK = 0,
        EmptyResult = 1,
        UnexpectedError = 2
    }
}
