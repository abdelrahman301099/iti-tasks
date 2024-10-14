using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Tasks
{
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
           return $"{B.Title}";
        }



        public static string GetAuthors(Book B)
        {
            var stringBuilder = new StringBuilder();

            foreach (var item in B.Authors)
            {
                stringBuilder.Append(item.ToString()+' ');
            }
            return stringBuilder.ToString();
        }



        public static string GetPrice(Book B)
        {
            return B.Price.ToString();
        }
    }

}
