using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pensions.Data
{
    public interface IRepository
    {
        void Save();
        decimal GetUserPesionSavings();
        string GetUserById(int id);
    }
}
