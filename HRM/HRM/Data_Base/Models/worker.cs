using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Models
{
    public class worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Document_info { get; set; }
        public string Department { get; set; }
        public string Grade { get; set; }
        public double Salary { get; set; }
        public double Experience { get; set; }
        public string Education { get; set; }
        public string Img { get; set; }
    }
}
