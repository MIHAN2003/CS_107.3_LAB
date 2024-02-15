using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    public class LibraryBook
    {
        public string Title;
        public string Authour;
        public string Availablity = "available";

        public LibraryBook(string title, string authour)
        {
            Title = title;
            Authour = authour;
        }

        public void BorrorwBook()
        {
            Availablity = "Not available";
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            LibraryBook book1 = new LibraryBook("title1", "authour1");
            LibraryBook book2 = new LibraryBook("title2", "authour2");
            LibraryBook book3 = new LibraryBook("title3", "authour3");

            book2.BorrorwBook();
            book3.BorrorwBook();

            Console.WriteLine($"{book1.Title} book written by {book1.Authour} is {book1.Availablity}");
            Console.WriteLine($"{book2.Title} book written by {book2.Authour} is {book2.Availablity}");
            Console.WriteLine($"{book3.Title} book written by {book3.Authour} is {book3.Availablity}");

            Console.ReadLine();
        }



    }
}