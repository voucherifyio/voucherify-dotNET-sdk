using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Client.Exceptions;

namespace Voucherify.Client.Api
{
    public class ApiResponse
    {
        public VoucherifyClientException Exception { get; private set; }

        private ApiResponse() { }

        public static ApiResponse WithException(VoucherifyClientException exception)
        {
            return new ApiResponse() { Exception = exception };
        }

        public static ApiResponse WithSuccess()
        {
            return new ApiResponse();
        }
    }

    public class ApiResponse<T> 
        where T: class
    {
        public T Result { get; private set; }

        public VoucherifyClientException Exception { get; private set; }

        private ApiResponse() { }

        public static ApiResponse<TResult> WithException<TResult>(VoucherifyClientException exception)
            where TResult : class
        {
            return new ApiResponse<TResult>() { Exception = exception };
        }

        public static ApiResponse<TResult> WithResult<TResult>(TResult result)
            where TResult : class
        {
            return new ApiResponse<TResult>() { Result = result };
        }
    }
}
