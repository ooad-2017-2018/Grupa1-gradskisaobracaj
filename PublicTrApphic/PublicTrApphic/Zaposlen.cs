using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTrApphic
{
    public class Zaposlen : Korisnik
    {
        int idKnjizice;
        string nazivFirme;

        public Zaposlen(string ime, string prezime, string telefon, string username, string password, string jmbg, int idKnjizice, string nazivFirme)
            : base(ime, prezime, telefon, username, password, jmbg)
        {
            IdKnjizice = idKnjizice;
            NazivFirme = nazivFirme;
        }

        public int IdKnjizice { get => idKnjizice; set => idKnjizice = value; }
        public string NazivFirme { get => nazivFirme; set => nazivFirme = value; }
    }
}
