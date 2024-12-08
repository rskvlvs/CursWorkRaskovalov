using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataBaseStorage.entities
{
    public class ZhClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public double angle;
        public double coefficient;
        public double? zh;

        

        [JsonConstructor]
        public ZhClass(double angle, double coefficient, double? zh)
        {
            this.angle = angle;
            this.coefficient = coefficient;
            this.zh = zh;
        }

        public ZhClass(double angle, double coefficient, string filePath)
        {
            this.angle = angle;
            this.coefficient = coefficient;

            string jsonContent = File.ReadAllText(filePath);
            var Combinations = JsonConvert.DeserializeObject<List<ZhClass>>(jsonContent);

            // Находим подходящую комбинацию
            var match = Combinations.Find(c => c.angle == angle && c.coefficient == coefficient);

            // Присваиваем значение zh, если найдена комбинация
            if (match != null)
            {
                zh = match.zh;
            }
            else
            {
                throw new ArgumentException("Комбинация angle и coefficient не найдена.");
            }
        }

    }
}
