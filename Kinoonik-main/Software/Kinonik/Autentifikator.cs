using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Kinonik
{
    public class Autentifikator
    {
        public Korisnik ProvjeriKorisnickePodatke(string korisnickoIme, string lozinka)
        {
            BazaPodataka.Instance.Connect();
            string upit = $"SELECT * FROM korisnici INNER JOIN uloge_korisnika ON uloga_korisnika=id_uloge WHERE korisnicko_ime = '{korisnickoIme}' AND lozinka = '{lozinka}'";
            IDataReader datareader = BazaPodataka.Instance.GetDataReader(upit);
            Korisnik korisnik = new Korisnik();
            while(datareader.Read())
            {
                korisnik.korisnickoIme = datareader["korisnicko_ime"].ToString();
                korisnik.ime = datareader["ime"].ToString();
                korisnik.prezime = datareader["prezime"].ToString();
                korisnik.lozinka = datareader["lozinka"].ToString();
                korisnik.email = datareader["email"].ToString();
                korisnik.spol = datareader["spol"].ToString();
                korisnik.brojTelefona = datareader["broj_telefona"].ToString();
                korisnik.kino = Convert.ToInt32(datareader["zaposlen_u"].ToString());
                if(datareader["naziv_uloge"].ToString()=="Superadmin")
                {
                    korisnik.uloga = Uloga.Superadmin;
                }
                else if(datareader["naziv_uloge"].ToString() == "Administrator")
                {
                    korisnik.uloga = Uloga.Administrator;
                }
                else if (datareader["naziv_uloge"].ToString() == "Zaposlenik")
                {
                    korisnik.uloga = Uloga.Zaposlenik;
                }
            }
            datareader.Close();
            BazaPodataka.Instance.Disconnect();
            return korisnik;
        }
    }
}
