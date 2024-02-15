using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    public class Course
    {
        private string courseName;
        private string instructorName;
        private double grade;

        public Course(string courseName)//constructor takes a courseName parameter
        {
            if (string.IsNullOrEmpty(courseName))
            {
                throw new ArgumentException("Course name cannot be empty.");
            }
            this.courseName = courseName;
        }

        public string CourseName => courseName;//read-only property CourseName

        public double Grade
        {
            get => grade;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    grade = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Grade must be between 0 and 100.");
                }
            }
        }

        public void SetInstructorName(string instructorName)//method to get instructor name
        {
            if (string.IsNullOrEmpty(instructorName))
            {
                throw new ArgumentException("Instructor name cannot be empty.");
            }
            this.instructorName = instructorName;
        }

        private string CalculateGrade()//method to calculate grade
        {
            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        public void PrintCourseInfo()//method to print course information
        {
            Console.WriteLine($"Course Name: {courseName}");
            Console.WriteLine($"Instructor Name: {instructorName}");
            Console.WriteLine($"Letter Grade: {CalculateGrade()}");
        }
    }


    internal class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Enter course name: ");
            string courseName = Console.ReadLine();

            Console.Write("Enter instructor name: ");
            string instructorName = Console.ReadLine();

            Console.Write("Enter grade (0-100): ");
            double grade = double.Parse(Console.ReadLine());


            Course course = new Course(courseName);

            course.SetInstructorName(instructorName);
            course.Grade = grade;

            course.PrintCourseInfo();

            Console.ReadLine();
        }
    }



}