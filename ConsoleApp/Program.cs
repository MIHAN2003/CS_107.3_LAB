using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    public class Product
    {
        public string ProductName;
        public int Price;

        public Product(string productName, int price)
        {
            ProductName = productName;
            Price = price;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Product product1 = new Product("apple", 50);

            Console.WriteLine($"Product name is {product1.ProductName} and it's price is {product1.Price}.");
            Console.ReadLine();
        }



    }
}