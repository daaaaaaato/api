using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pensions
{
    public static class ResponseManager<T>
    {
        public static ResponseModel<T> CreateResponse(int code, string[] errors, T result)
        {
            return new ResponseModel<T>()
            {
                Code = code,
                Errors = errors,
                Result = result
            };
        }
    }
}
