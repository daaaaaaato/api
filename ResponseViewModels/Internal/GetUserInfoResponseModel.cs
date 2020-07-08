using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pensions.ResponseViewModels.Internal
{
    public class GetUserInfoResponseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Savings { get; set; }
    }
}
