using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class Animal
    {
      public void Speak()
        {
            Console.Write("I am an Animal  ");

        }
    }
    public class Dog : Animal 
    {
        public void NumberofLegs()
        {
            Console.Write("I have 4 Legs");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Speak();
            dog.NumberofLegs();

            Console.ReadLine();

         

        }
    }
}
