using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDay1Tasks.Enteties
{
   internal class Neurse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public virtual Ward? ward { get; set; }
    }
}
