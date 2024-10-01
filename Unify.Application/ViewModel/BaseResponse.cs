using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unify.Application.ViewModel
{
    public class BaseResponse
    {
        public string Message { get; set; } = string.Empty;
        public bool IsSuccessful { get; set; }
    }

    public class BaseResponse<T>: BaseResponse
    {
        public T Result { get; set; } = default!;
    }
}
