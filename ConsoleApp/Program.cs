using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class EncapData
    {
        public double Radius;
        private double Pi = 3.14;

        public double radius
        {
            get{ return Radius; }
            set{ Radius = value; }
        }
        public double Area()
        { 
            double area = Pi * Radius * Radius;
            return area;
        }
        public double Circumference()
        {
            double circum = Pi * Radius * Radius;
            return circum;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            EncapData data = new EncapData();
        Console.WriteLine("Enter the Radius of the circle");
        double radius = double.Parse(Console.ReadLine());

        data.radius = radius;

        Console.WriteLine($"Area of the circle is  {data.Area()}");
        Console.WriteLine($"Circumference of the circle is  {data.Circumference()}");

        Console.ReadLine();

        }
    }
}
