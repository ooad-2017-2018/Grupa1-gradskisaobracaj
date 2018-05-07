using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTrApphic
{
    public abstract class Uloga
    {
        string username;
        string password;

        public Uloga()
        {            
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
