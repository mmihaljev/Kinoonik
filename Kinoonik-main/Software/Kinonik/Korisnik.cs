using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinonik
{
    public class Korisnik
    {
        public string korisnickoIme { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string email { get; set; }
        public string lozinka { get; set; }
        public string spol { get; set; }
        public string brojTelefona { get; set; }
        public Uloga uloga { get; set; }
        public int kino { get; set; }


    }
}
