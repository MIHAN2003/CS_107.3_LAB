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
            Console.WriteLine("Enter the number of Fibonacci term:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci number:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            Console.ReadLine();
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

    }
}