using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOADGradskiSaobracaj.Models
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Jmbg { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

    }
}