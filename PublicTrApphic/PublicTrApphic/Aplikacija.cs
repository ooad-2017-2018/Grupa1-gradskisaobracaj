using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTrApphic
{
    public class Aplikacija
    {
        public List<Uloga> korisnici;

        public Aplikacija()
        {
            korisnici = new List<Uloga>(); 
        }

        public void AddZaposlenog(Zaposlen zaposlen)
        {
            korisnici.Add(zaposlen);
        }

        public void AddStudenta(Student student)
        {
            korisnici.Add(student);
        }

        public void AddNezaposlenog(Nezaposlen nezaposlen)
        {
            korisnici.Add(nezaposlen);
        }

        public void AddPenzionera(Penzioner penzioner)
        {
            korisnici.Add(penzioner);
        }

        public void AddAdmina(Admin admin)
        {
            korisnici.Add(admin);
        }
    }
}
