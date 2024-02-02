using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    //create a BankAccount class    
    public class BankAccout
    {
        private int bal = 1000;


        public void Check_balance()
        {
            Console.WriteLine($"Your account balance is: {bal}");
        }

        public void Deposit(int change)
        {
            bal = bal + change;
            Console.WriteLine($"{change} amount is deposited to your account");
            Console.WriteLine($"Your new balance is {bal}");
        }


    }

    internal class Program
    {


        static void Main()
        {
            //create an object
            BankAccout account1 = new BankAccout();

            Console.WriteLine("type '1' for check Balance or type '2' for deposit amount");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                //calling the checkBalance method for checking the balance
                account1.Check_balance();
            }
            else if (choice == 2)
            {
                //calling the deposit method for Deposit the amount
                Console.WriteLine("Enter the amount you wish to deposit");
                int amount = int.Parse(Console.ReadLine());

                account1.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Invalid option");
            }


            Console.ReadLine();
        }


    }
}