using AbstractClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses.Entites
{
    public class Teacher : User, ITeacher
    {
        public override string Name { get; set; }
        public override string UserName { get; set; }
        public override int PerId { get; set; }
        public override string Password { get; set; }



        public string Subject {get; set;}

        public Teacher() { }
        
        public override void PrintUser(IUser user)
        {
            Console.WriteLine($"Here is {Subject}");
        }
    }
}
