using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    public class Employee
    {
        private int EmployeeID;
        private string FullName;
        public double Salary;

        public Employee(int employeeID, string name, double salary)
        {
            EmployeeID = employeeID;
            FullName = name;
            Salary = salary;
        }


        public int employeeID => EmployeeID;//read-only property for employeeID

        public string fullName
        {
            get
            {
                return FullName;
            }
            set
            {
                FullName = value;
            }
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee's ID: {employeeID}");
            Console.WriteLine($"Employee's Name: {FullName}");
            Console.WriteLine($"Employee's Salary: {Salary}");
        }


    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee(101, "John Doe", 50000);
            Console.WriteLine("Enter the new Name of the Employee: ");
            emp1.fullName = Console.ReadLine();

            Console.WriteLine("Enter the new Salary of the Emplyee: ");
            emp1.Salary = double.Parse(Console.ReadLine());

            emp1.DisplayEmployeeInfo();




            Console.ReadLine();
        }



    }
}