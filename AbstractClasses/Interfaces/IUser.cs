using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses.Interfaces
{
    public interface IUser
    {       
        public string Name { get; set; }
        public string UserName { get; set; }
        public int PerId { get; set; }
        public string Password { get; set; }

        public void PrintUser(IUser user);
    }
}
