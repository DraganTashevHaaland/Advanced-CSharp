using AbstractClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses.Entites
{
    public abstract class User : IUser
    {
        public abstract string Name { get; set; }
        public abstract string UserName { get; set; }
        public abstract int PerId { get; set; }
        public abstract string Password { get; set; }



        public abstract void PrintUser(IUser user);
    }
}
