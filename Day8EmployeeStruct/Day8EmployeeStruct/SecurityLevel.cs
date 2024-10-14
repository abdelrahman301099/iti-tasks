using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8EmployeeStruct
{
    [Flags]
   public enum SecurityLevel
    {
        developer=0,
        DBA=2,
        secretary=4,
        guest=8,
        CEO = developer|DBA|secretary|guest 
    }
}
