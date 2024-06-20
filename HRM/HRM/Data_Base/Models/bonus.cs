using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Models
{
    public class bonus
    {
        public int Id { get; set; }
        public int Worker_Id { get; set; }
        public string Worker_Name { get; set; }
        public string Worker_Otdel { get; set; }
        public string Worker_Skill { get; set; }
        public int Case_Supplied { get; set; }
        public int Case_Completed { get; set; }
        public int Hour { get; set; }
        public double KPD { get; set; }
        public string Month { get; set; }
    }
}
