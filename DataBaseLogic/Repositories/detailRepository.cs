using DataBaseStorage;
using DataBaseStorage.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLogic.Repositories
{
    public class detailRepository
    {
        private context _context; 
        public detailRepository(context _context)
        {
            this._context = _context;
        }

        public async Task<Guid> Create(double _dm1, double _delta_h, double _Vm,
            double _sigmastr, double _u, string _type, double _Khl, double _Ze )
        {
            Guid id = Guid.NewGuid();
            var det = new detail(_dm1, _delta_h, _Vm, _sigmastr, _u, _type, _Khl, _Ze)
            {
                Id = id,
            };
            await _context.AddAsync(det); 
            await _context.SaveChangesAsync();
            return id;
        }
    }
}
