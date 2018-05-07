using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTrApphic
{
    public class Penzioner : Korisnik
    {
        int idPenzione;

        public Penzioner(string ime, string prezime, string telefon, string jmbg, int idPenzione) 
            : base(ime, prezime, telefon, jmbg)
        {
            IdPenzione = idPenzione;
        }

        public int IdPenzione { get => idPenzione; set => idPenzione = value; }
    }
}
