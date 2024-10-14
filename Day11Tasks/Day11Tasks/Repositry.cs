using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Tasks
{
    public static class Repositery
    {
        static List<Book> books;
        public static List<Book> Books
        {
            get
            {

                return new List<Book>()
            {
                new() {ISBN ="ss", Title="title", Authors=["Ali", "Maged"], Price=2000 },
                new (){ISBN ="ss", Title="title", Authors=["Ali", "Maged"], Price=2000 },
                new (){ISBN ="ss", Title="title", Authors=["Ali", "Maged"], Price=2000 },
                new (){ISBN ="ss", Title="title", Authors=["Ali", "Maged"], Price=2000 }
            };
            }
        }
    }
}