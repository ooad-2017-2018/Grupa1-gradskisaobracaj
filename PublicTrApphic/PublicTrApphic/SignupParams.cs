using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTrApphic
{
    public class SignupParams
    {
        public string ime = "";
        public string prezime = "";
        public string jmbg = "";
        public int opcija = 0;
        public Aplikacija aplikacija=new Aplikacija();

        public SignupParams(string name, string sname, string id, int option, Aplikacija app)
        {
            ime = name;
            prezime = sname;
            jmbg = id;
            opcija = option;
            aplikacija = app;
        }
    }
}
