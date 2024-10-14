using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day9Tasks
{
     class SingleTone
    {
        
       

        public string Manufacture { get; set; }
        public long MAC_Address { get; set; }
        public Type Type { get; set; }

        // public static SingleTone obj { get; } = new SingleTone();
        static SingleTone obj;
        private static SingleTone Obj
        {
            get
            {
                if (obj == null) { obj = new SingleTone(); }
                return obj;
            }
        }

        public override string ToString()
        {
            return $"{Manufacture} : {MAC_Address} : {Type}";
        }

    }

    enum Type
    {
        Ethernet , token_ring
    }
}
