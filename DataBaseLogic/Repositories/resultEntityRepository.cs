using DataBaseStorage;
using DataBaseStorage.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLogic.Repositories
{
    public class resultEntityRepository
    {
        private context _context;

        public resultEntityRepository(context _context)
        {
            this._context = _context; 
        }

        public async void Create(string result, double sigmaH, double sigmaHP, Guid detailId, Guid unitId)
        {
            Guid id = Guid.NewGuid();
            var resultE = new resultEntity(result, sigmaH, sigmaHP)
            {
                Id = id,
                detailId = detailId,
                unitId = unitId
            };
            await _context.AddAsync(resultE);
            await _context.SaveChangesAsync();; 
        }
    }
}
