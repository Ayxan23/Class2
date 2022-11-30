using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    internal class Admin:User
    {
        public bool IsSuperAdmin;
        public string Section;

        public Admin(bool isSuperAdmin, string section, string username, string password):base(username, password)
        {
            if (username != "" && password != "" )
            {
                IsSuperAdmin = isSuperAdmin;
                Section = section;
            }
        }

        public void AllDala()
        {
            Console.WriteLine("Username: " + Username + ", Password: " + Password + ", IsSuperAdmin: " + IsSuperAdmin + ", Section: " + Section);
        }







    }
}
