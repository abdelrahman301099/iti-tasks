
using System;

namespace Day11Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var books = Repositery.Books;
            
            MyDelegate del1= new MyDelegate(BookFunctions.GetTitle);
            MyDelegate del2= new MyDelegate(BookFunctions.GetPrice);
            MyDelegate del3= new MyDelegate(BookFunctions.GetAuthors);
            LibraryEngine.ProcessBooks(books, del1);
            LibraryEngine.ProcessBooks(books, del2);
            LibraryEngine.ProcessBooks(books, del3);

            //////////////////


            Func<Book, string>  del4= BookFunctions.GetTitle;
            LibraryEngine.ProcessBooksfunc(books, del4);
            /////////////////


            LibraryEngine.ProcessBooks(books, delegate(Book book) {return book.ISBN; });

            ///////////////////
            Func<Book, string> del5=x=> x.PublicationDate.ToLongDateString();
            foreach (var item in books)
            {
                Console.WriteLine(del5(item));
            }



        }
    }
}
