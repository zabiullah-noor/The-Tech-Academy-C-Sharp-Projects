using System;

namespace Final_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                ctx.Database.EnsureCreated();

                var student = new Student()
                {
                    StudentName = "Bill"
                };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }

            Console.WriteLine("Student added successfully!");

            Console.ReadLine();
        }
    }
}