using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDay1Tasks.Enteties
{
   internal class Ward
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Neurse> Neurses { get; set; } = new List<Neurse>();
    }
}
