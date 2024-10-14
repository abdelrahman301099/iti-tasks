using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Tasks
{
    public class FTP
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private FTP()
        {
            Id = 1;
            Name = "FTP";
            Description = "FTP Driver";
        }


        
        static FTP obj;
        public static FTP CreateSingleObject()
        {
            if (obj == null)
            {
                obj = new FTP();
            }
            return obj;

        }
    }
}
