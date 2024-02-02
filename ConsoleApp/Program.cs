using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    internal class Program
    {

        static void Bal()
        {
            Console.WriteLine("your balance is xxxxx.");
        }

        static void Dep()
        {
            Console.WriteLine("Enter the money through counter thank you.");
        }

        static void Widraw()
        {
            Console.WriteLine("Enter the Amount you want to withdraw");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 + " amout is ready to withdarw");

        }

        static void Main()
        {
            Console.WriteLine("How do you want to proceed?");
            Console.WriteLine("type '1' for check the balance");
            Console.WriteLine("type '2' for deposit money");
            Console.WriteLine("type '3' for withdraw money");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                Bal();
            }
            else if (num == 2)
            {
                Dep();
            }
            else if (num == 3)
            {
                Widraw();
            }
            else
            {
                Console.WriteLine("Invalid command");
            }

            Console.ReadLine();

        }


    }
}