using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTool.Entities
{
    internal class Dapartment
    {
        public int ID { get; set; }
        public string Dept_Name{ get; set; }
        public virtual List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
