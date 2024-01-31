using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program

    {
        static void Area(int x, int y)
        {
            int area = x * y;

            Console.WriteLine("Area of the Rectangle is: " + area);
            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height: ");
            string input1 = Console.ReadLine();
            int num1 = int.Parse(input1);
            Console.WriteLine("Enter the width: ");
            int num2 = int.Parse(Console.ReadLine());

            Area(num1,num2);
        }
    }
}
