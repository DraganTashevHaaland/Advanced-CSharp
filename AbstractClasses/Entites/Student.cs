using AbstractClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses.Entites
{
    public class Student : User, IStudent
    {
        public override string Name { get; set; }
        public override string UserName { get; set; }
        public override int PerId { get; set; }
        public override string Password { get; set; }

        public List<int> Grades { get; set; }

        public Student()
        {

        }
        public override void PrintUser(IUser user)
        {
            foreach (var items in Grades)
            {
                Console.WriteLine($"Here is {items}");
            }

            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine(i);
            //    }

        }
    }
}
