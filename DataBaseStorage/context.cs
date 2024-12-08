using DataBaseStorage.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseStorage
{
    public class context : DbContext
    {
        public DbSet<detail> details { get; set; }
        public DbSet<resultEntity> resultEntities { get; set; }
        public DbSet<unit> units { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=DBForKursWork;User ID=sa;Password=frjenekjnv123!adsad;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
    }
}
