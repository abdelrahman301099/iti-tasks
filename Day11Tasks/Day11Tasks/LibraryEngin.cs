using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Tasks
{
    public delegate string MyDelegate(Book b);
    public class LibraryEngine
    {

        
        
            public static void ProcessBooks(List<Book> bList, MyDelegate fPtr)
            {
                foreach (Book B in bList)
                {
                    Console.WriteLine(fPtr(B));
                }
            }

        public static void ProcessBooksfunc(List<Book> bList
       , Func<Book, string> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }





    }
}
