using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeQuyetTien
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set;}
        public string Gender { get; set; }
        public int Age {  get; set; }
        public string Dateofbirth { get; set; }
        public string Class { get; set; }
        public double Mark1 { get; set; }
        public double Mark2 { get; set; }
        public double Mark3 { get; set; }
       /* public double Avg;*/
        public double mark_AVG()
        {
           
            return (Mark1 + Mark2 + Mark3) / 3;
        }
    }
}
