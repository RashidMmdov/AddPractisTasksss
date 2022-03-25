
using System;

namespace Praktika_HomeWork_Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full name: ");
            string FullName = Console.ReadLine();
            Console.WriteLine("Enter group: ");
            string Group = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            int Age = Convert.ToInt32(Console.ReadLine());

            Student st = new Student(FullName, Group, Age);
            Console.Write($"Fullname: {st.FullName} | Age: {st.Age}");
            if (Student.CheckGroupNo(Group) == false)
            {
                Console.WriteLine($" | Group No: WRONG");
            }
            else
            {
                Console.WriteLine($" | Group No: {st.GroupNo}");
            }


            Console.WriteLine("----------");
            Console.WriteLine("Qrup Formati: " + Student.CheckGroupNo(Group));
            Console.WriteLine("FullName Formati: "+Student.CheckFullName(FullName));
        }

    }
}

