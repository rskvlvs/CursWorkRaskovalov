using DataBaseStorage;
using DataBaseStorage.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLogic.Repositories
{
    public class unitRepository
    {
        private context _context;
        public unitRepository(context _context)
        {
            this._context = _context;
        }

        public async Task<Guid> Create(double kh, double kha, double khv, double khb, double omegaHT,
            double omegaHV, double g0, double sigmaH, double sigmaHP, double zh, double zm,
            double ft, double b, double ea, double re, double def_sigmaH_sigmaHP)
        {
            Guid id = Guid.NewGuid();
            var uni = new unit(kh, kha, khv, khb, omegaHT, omegaHV, g0, sigmaH, sigmaHP, zh, zm, ft, b, ea, re, def_sigmaH_sigmaHP)
            {
                Id = id
            };
            await _context.AddAsync(uni);
            await _context.SaveChangesAsync();

            return id; 
        }
    }
}
