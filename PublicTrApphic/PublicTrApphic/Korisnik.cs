using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTrApphic
{
    public abstract class Korisnik:Uloga
    {
        static int brojac=0;
        int id;
        string ime;
        string prezime;
        string telefon;
        string jmbg;

        public Korisnik(string ime, string prezime, string telefon, string jmbg): base()
        { 
            brojac++;
            Id = brojac;
            Ime = ime;
            Prezime = prezime;
            Telefon = telefon;
            Jmbg = jmbg;
            string username = "";
            username = Ime[0] + Prezime + Id;
            Random x = new Random();
            string pw = "";
            for (int i = 0; i < 12; i++)
            {
                pw += Convert.ToChar(x.Next(65, 98));
            }
            Username = username;
            Password = pw;
        }

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Jmbg { get => jmbg; set => jmbg = value; }
    }
}
