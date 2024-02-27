using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorPodatakaDll
{
    public class GeneratorPristupnihPodataka
    {
        public string GenerirajKorisnickoIme(string ime, string prezime)
        {
            string korisnickoIme = "";
            string brojevi = "1234567890";

            korisnickoIme += ime.ToLower().Substring(0, 3);
            korisnickoIme += prezime.ToLower();
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                korisnickoIme += brojevi[random.Next(brojevi.Length)];
            }

            return korisnickoIme;
        }

        public string GenerirajLozinku()
        {
            string lozinka = "";

            string znakovi = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            Random random = new Random();

            while (lozinka.Length < 11)
            {
                lozinka += znakovi[random.Next(znakovi.Length)];
            }

            return lozinka;
        }
    }
}
