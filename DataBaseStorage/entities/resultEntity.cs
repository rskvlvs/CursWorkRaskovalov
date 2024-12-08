using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseStorage.entities
{
    public class resultEntity
    {
        public resultEntity(string result, double sigmaH, double sigmaHP)
        {
            this.result = result;
            this.sigmaH = sigmaH;
            this.sigmaHP = sigmaHP;
        }

        public Guid Id{  get; set; }
        public Guid detailId { get; set; }
        public detail detail { get; set; }
        public Guid unitId { get; set; }
        public unit unit { get; set; }


        public string result {  get; set; }
        public double sigmaH { get; set; }
        public double sigmaHP {  get; set; }

    }
}
