using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pensions.RequestViewModels.Internal
{
    public class GetUserInfoRequestModel
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }
    }
}
