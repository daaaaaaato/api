using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pensions.Data
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
        public string GetUserById(int id)
        {
            return id == 20 ? "gela gela" : null;
        }

        public decimal GetUserPesionSavings()
        {
            return 50M;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
