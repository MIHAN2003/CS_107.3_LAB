using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    public class Shape
    {
        public string colour;
        public double properties;
        public virtual void Draw()
        {

        }
        public void CalculateArea()
        {

        }
    }
    public class Circle : Shape
    {
        private string pass;
        public Circle(string Pass)
        {
            pass = Pass;
            if (pass != "password")
            {
                throw new ArgumentException("Password is invalid", nameof(pass));
            }
        }

        public override void Draw()
        {
            Console.Write("this is a circle");
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle("password");
            circle.Draw();

            Console.ReadLine();
        }



    }
}