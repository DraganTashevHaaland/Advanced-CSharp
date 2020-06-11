using AbstractClasses.Entites;
using AbstractClasses.Interfaces;
using System;
using System.Collections.Generic;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Student dragan = new Student() { Grades = new List<int> { 7, 7, 8, 9, 9 }, Name = "Dragan", UserName = "Dragan94", Password = "asd", PerId = 1207, };
            dragan.PrintUser(dragan);

            Teacher dejan = new Teacher()
            {
                Name = "Dejan",
                UserName = "DekiBlazhevski98",
                Password = "ffg",
                Subject = "C#",
            };
            dejan.PrintUser(dejan);

            Console.ReadLine();
            //Console.ReadKey();
        }
    }
}
