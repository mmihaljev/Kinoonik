using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinonik
{
    public static class RepozitorijPrijava
    {
        public static Korisnik prijavljeniKorisnik { get; set; }
        public static Autentifikator autentifikator = new Autentifikator();

        public static bool PrijaviSe(string korisnickoIme, string lozinka)
        {
            prijavljeniKorisnik = autentifikator.ProvjeriKorisnickePodatke(korisnickoIme, lozinka);
            if (prijavljeniKorisnik.korisnickoIme!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
