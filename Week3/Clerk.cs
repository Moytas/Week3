using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    internal class Clerk : Person
    {
        public Clerk()
        {
            Name = "";
            Password = "";

        }

        public Clerk(string newName, string newPassword)
        {
            Name = newName;
            Password = newPassword;
        }
    }
}
