using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseStorage.entities
{
    public class ZmClass
    {
        public double zm;
        public ZmClass(string material)
        {
            switch (material)
            {
                case "Сталь-сталь":
                    zm = 274;
                    break;
                case "Сталь-чугун":
                    zm = 234;
                    break;
                case "Сталь-бронза":
                    zm = 225;
                    break;
                case "Чугун-чугун":
                    zm = 209;
                    break;
                case "Текстолит-сталь":
                    zm = 69.5;
                    break;
                case "ДСП-сталь":
                    zm = 35;
                    break;
                case "Полиамид-сталь":
                    zm = 47.5;
                    break;
                default:
                    zm = 274;
                    break;
            }
        }
    }
}
