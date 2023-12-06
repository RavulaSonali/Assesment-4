using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
namespace Assesment_4
{
    public class Program
    {
        static List<Students> students = new List<Students>();
        static List<Teachers> teachers = new List<Teachers>();
        static List<Subjects> subjects = new List<Subjects>();
        public static void AddData()
        {
            students.Add(new Students("Ravula Sonali", "12th"));
            students.Add(new Students("Pranaveer", "8th"));
            students.Add(new Students("Manoj", "11th"));
            students.Add(new Students("Supriya", "8th"));
            students.Add(new Students("Sara", "11th"));
            students.Add(new Students("Anil", "10th"));
            students.Add(new Students("Nikil", "12th"));
            students.Add(new Students("Summa", "9th"));
            students.Add(new Students("John", "10th"));
            students.Add(new Students("Jane", "9th"));
            students.Add(new Students("Smith Raj", "12th"));
            students.Add(new Students("Rani", "11th"));
            students.Add(new Students("Priya", "8th"));
            students.Add(new Students("Karthik", "12th"));
            students.Add(new Students("Sundari", "10th"));
            students.Add(new Students("Vijay", "9th"));
            students.Add(new Students("Kumar", "11th"));
            students.Add(new Students("Shara ", "10th"));
            students.Add(new Students("Vikram", "12th"));
            students.Add(new Students("Amutha", "8th"));
            teachers.Add(new Teachers("Mr.Kumar", "10th"));
            teachers.Add(new Teachers("Mrs.Rani", "11th"));
            teachers.Add(new Teachers("Mr.Balaji", "12th"));
            teachers.Add(new Teachers("Ms.Priya", "9th"));
            teachers.Add(new Teachers("Mr.Rajesh", "8th"));
            subjects.Add(new Subjects("Mathematics", 101, "Mr.Vel"));
            subjects.Add(new Subjects("Physics", 102, "Mrs.Kumari"));
            subjects.Add(new Subjects("Chemistry", 103, "Mr.Balaji"));
            subjects.Add(new Subjects("English", 104, "Ms.Priya"));
            subjects.Add(new Subjects ("Biology", 105, "Mr.Rajesh"));
            subjects.Add(new Subjects("Computer Science", 106, "Mr.Kumar"));
            subjects.Add(new Subjects("Economics", 107, "Mrs.Rani"));
            subjects.Add(new Subjects("History", 108, "Mr.Balaji"));
            subjects.Add(new Subjects("Geography", 109, "Ms.Priya"));
            subjects.Add(new Subjects("Environmental Science", 110, "Mr.Rajesh"));
        }
        public static void DisplayStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Student Name : {student.Name}, Class : {student.Section} ");
            }
        }
        public static void DisplayTeachers()
        {
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"Teacher Name : {teacher.Name}, Class : {teacher.Section}");
            }
        }
        public static void DisplaySubjects()
        {
            foreach (var subject in subjects)
            {
                Console.WriteLine($"Subject Name : {subject.SubName}, Subject Code : {subject.SubCode}, Teacher Name : {subject.Teacher} ");
            }
        }
        public static void StudentsInClass(string cl)
        {
            int count = 0;
            foreach (var student in students)
            {
                if (student.Section.Equals(cl))
                {
                    count++;
                    Console.WriteLine($"Student Name : {student.Name}, Class : {student.Section} ");
                }
            }
            if (count == 0)
                Console.WriteLine("There is no such class or You must have entered the wrong class");
        }
        public static void SubjectsTaughtByTeacher(string name)
        {
            int count = 0;
            Console.WriteLine($"\n Subject taught by {name}\n");
            foreach (var subject in subjects)
            {
                if (subject.Teacher.Equals(name))
                {
                    count++;
                    Console.WriteLine($"Subject Name : {subject.SubName}, Subject Code: {subject.SubCode}");
                }
            }
            if (count == 0)
                Console.WriteLine("There is no such teacher or You must have entered the wrong name");
        }
        static void Main(string[] args)
        {
            try
            {
                AddData();
                Console.WriteLine("Choose one option to Perform\n\n1.Display All Data\n2.Display Students in Specific Class\n3.Display Subject taught by Specific Teacher\n\nEnter the Function number");
            Again:
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            Console.WriteLine("The List of Students\n");
                            DisplayStudents();
                            Console.WriteLine("\nThe List of Teachers\n");
                            DisplayTeachers();
                            Console.WriteLine("\nThe List of Subjects\n");
                            DisplaySubjects();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\nEnter the Class");
                            string input = Console.ReadLine();
                            Console.WriteLine($"\nThe List of Students in Class {input}\n");
                            StudentsInClass(input);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter Teacher Name");
                            string input = Console.ReadLine();
                            SubjectsTaughtByTeacher(input);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Oops!!!\n Wrong Option\nSelect Again");
                            goto Again;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}