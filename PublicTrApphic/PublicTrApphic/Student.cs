using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTrApphic
{
    public class Student:Korisnik
    {
        int index;
        string nazivFakulteta;

        public Student(string ime, string prezime, string telefon, string username, string password, string jmbg, int index, string nazivFakulteta) 
            : base(ime, prezime, telefon, username, password, jmbg)
        {
            Index = index;
            NazivFakulteta = nazivFakulteta;
        }

        public int Index { get => index; set => index = value; }
        public string NazivFakulteta { get => nazivFakulteta; set => nazivFakulteta = value; }
    }
}
