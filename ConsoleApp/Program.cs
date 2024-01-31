using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void sumAll(int x)
        {
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {

                sum = sum + i;

            }
            Console.WriteLine("Sum is: " + sum);
        }

        static void Main()
        {
            Console.WriteLine("Enter a positive Intiger: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                sumAll(num);

            }
            else { Console.WriteLine("ERROR"); }
            Console.ReadLine();


        }
    }
}