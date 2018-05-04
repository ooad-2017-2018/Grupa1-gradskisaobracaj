using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTrApphic
{
    public class Nezaposlen:Korisnik
    {
        int idKnjizice;

        public Nezaposlen(string ime, string prezime, string telefon, string username, string password, string jmbg, int idKnjizice) 
            : base(ime, prezime, telefon, username, password, jmbg)
        {
            IdKnjizice = idKnjizice;
        }

        public int IdKnjizice { get => idKnjizice; set => idKnjizice = value; }
    }
}
