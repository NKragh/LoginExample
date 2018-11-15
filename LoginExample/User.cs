using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginExample
{
    class User
    {
        private string _username { get; }
        private string _password { get; }

        public User(string Username, string Password)
        {
            _username = Username;
            _password = Password;
        }
    }
}
