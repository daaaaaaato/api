using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pensions
{
    public class ResponseModel<T>
    {
        public int Code { get; set; }

        public string[] Errors { get; set; }

        public object Result { get; set; }
    }
}
