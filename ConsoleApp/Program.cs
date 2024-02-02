using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LEC
{
    //creat a student class
    //var to store the name
    //var to store 3 marks(array)display the student details with the marks

    public class Student
    {
        public string name;
        public int[] marks;

        public void StoreDetails(string StudentName, int[] stuMarks)
        {
            name = StudentName;
            marks = stuMarks;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {name}");

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Marks: {marks[i]}");


            }
            Console.WriteLine("\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();

            student1.StoreDetails("ann", new int[] { 1, 2, 3 });
            student2.StoreDetails("ron", new int[] { 4, 5, 6 });

            student1.DisplayDetails();
            student2.DisplayDetails();
            Console.ReadLine();


        }
    }
}
