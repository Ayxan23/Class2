using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    internal class User
    {
        private string _username;
        private string _password;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length > 6)
                {
                    _username = value;
                }
                else
                {
                    Console.WriteLine("Username'i yeniden daxil edin (sozun uzunlugu 6dan boyuk olmalidir)");
                }
            }
        }
        
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                bool a = false;
                bool b = false;
                int num = 9;
                for (int i = 0; i < value.Length; i++)
                {

                    if (value[i] == char.ToUpper(value[i]))
                    {
                        a = true;
                    }
                    while (num != 0)
                    {
                        if (value[i] == num)
                        {
                            b = true;
                        }
                        num--;
                    }
                }
                if (a && b)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Password'u yeniden daxil edin (icerisinde bir eded ve bir boyuk herf olmalidir)");
                }
            }
        }


        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }




    }
}
