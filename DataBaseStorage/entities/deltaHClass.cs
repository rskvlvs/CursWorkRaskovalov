using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseStorage.entities
{
    public class deltaHClass
    {
        public double deltaH {  get; set; }

        public deltaHClass(string teethType, double hb)
        {
            switch (teethType)
            {
                case "Прямые без модификации головки":
                    if (hb <= 350)
                        deltaH = 0.006;
                    else
                        deltaH = 0.014;
                    break;
                case "Прямые с модификацией головки":
                    if (hb <= 350)
                        deltaH = 0.004;
                    else
                        deltaH = 0.01; 
                    break;
                case "Косые":
                    if (hb <= 350)
                        deltaH = 0.002;
                    else
                        deltaH = 0.004;
                    break;
            }
        }
    }
}
