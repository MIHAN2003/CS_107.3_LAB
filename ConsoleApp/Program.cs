using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Mark: ");
            int mark = int.Parse(Console.ReadLine());

            string grade;

            if (mark >= 100)
            {
                Console.WriteLine("Wrong Marks");
                grade = "error";
            }
            else if (mark >= 75)
            {
                grade = "A";
            }
            else if (mark >= 60)
            {
                grade = "B";
            }
            else if (mark >= 50)
            {
                grade = "C";
            }
            else if (mark >= 40)
            {
                grade = "D";
            }
            else
            {
                grade = "Failed";
            }

            Console.WriteLine(name + " your Grade is " + grade);
            Console.ReadLine();

        }



    }
}