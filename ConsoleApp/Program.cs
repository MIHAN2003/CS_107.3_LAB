using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    public class TempuratureTracker
    {
        public int[] temp = new int[7];


    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            TempuratureTracker obj1 = new TempuratureTracker();

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Enter the Tempurature:");
                obj1.temp[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Weekly Tempurature Report");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"{obj1.temp[i]} celcius");
            }
            Console.ReadLine();

        }



    }
}