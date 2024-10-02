using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unify.Application.Common;

namespace Unify.Application.ViewModel
{
    public class BaseResponse
    {
        public string Message { get; set; } = string.Empty;
        public bool IsSuccessful { get; set; }
    }

    public class GenericResponse<T>: BaseResponse
    {
        public new bool IsSuccessful { get; set; }
        public T Result { get; set; } = default!;
    }


    public static class Responses<T>
    {
        public static GenericResponse<T> Successful(T model, string message = Constants.SuccessResponse)
        {
            return new GenericResponse<T>
            {
                IsSuccessful = true,
                Message = message,
                Result = model
            };
        }

        public static GenericResponse<T> Failed(T model, string message = Constants.ErrorResponse)
        {
            return new GenericResponse<T>
            {
                IsSuccessful = false,
                Message = message,
                Result = model
            };
        }       
    }

    public static class Responses
    {
        public static BaseResponse Successful(string message = Constants.SuccessResponse)
        {
            return new BaseResponse
            {
                IsSuccessful = true,
                Message = message
            };
        }

        public static BaseResponse Failed(string message = Constants.ErrorResponse)
        {
            return new BaseResponse
            {
                IsSuccessful = false,
                Message = message
            };
        }
    }

    
}
