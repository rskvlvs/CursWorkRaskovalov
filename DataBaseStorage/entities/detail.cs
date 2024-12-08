using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseStorage.entities
{
    public class detail
    {
        public detail(double dm1, double delta_h, double vm, double sigmastr, double u, string type, double khl, double ze)
        {
            this.dm1 = dm1;
            this.delta_h = delta_h;
            Vm = vm;
            this.sigmastr = sigmastr;
            this.u = u;
            this.type = type;
            Khl = khl;
            Ze = ze;
        }
        public Guid Id {  get; set; }      

        public double dm1 {  get; set; }
        public double delta_h { get; set; }
        public double Vm {  get; set; }
        public double sigmastr {  get; set; }
        public double u {get; set; }
        public string type { get; set; }
        public double Khl { get; set; }
        public double Ze { get; set; }

    }
}
