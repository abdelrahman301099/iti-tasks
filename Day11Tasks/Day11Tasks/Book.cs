using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Tasks
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }


        public Book(string _ISBN, string _Title,
        string[] _Authors, DateTime _PublicationDate,
       decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;

        }

        public Book()
        {
            ISBN = "111-111-111";
            Title= "Title01";
            Authors = new string[] { "Ahmed", "Ali" };
            PublicationDate = new DateTime(22 / 11 / 2021);
            Price = 1200;
        }

        public override string ToString()
        {
            return $"{ISBN} : { Title} : { BookFunctions.GetAuthors(this)} : {PublicationDate} : { Price}";
        }

       
    }
}
