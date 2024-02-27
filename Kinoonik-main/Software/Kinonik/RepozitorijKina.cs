using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinonik
{
    public static class RepozitorijKina
    {
        public static List<Kino> DohvatiKina()
        {
            BazaPodataka.Instance.Connect();

            string upit = "SELECT * FROM kina";
            IDataReader datareader = BazaPodataka.Instance.GetDataReader(upit);

            List<Kino> kina = new List<Kino>();

            while (datareader.Read())
            {
                Kino kino = new Kino();

                kino.idKina = int.Parse(datareader["id_kina"].ToString());
                kino.naziv = datareader["naziv_kina"].ToString();
                kino.kompanija = datareader["kompanija"].ToString();
                kino.adresa = datareader["adresa"].ToString();
                kino.vlasnik = datareader["vlasnik"].ToString();
                kino.kontakt = datareader["kontakt"].ToString();

                kina.Add(kino);
            }

            datareader.Close();

            BazaPodataka.Instance.Disconnect();

            return kina;
        }

        public static void DodajKino(Kino novoKino)
        {
            BazaPodataka.Instance.Connect();

            string upit = $"INSERT INTO kina (naziv_kina, kompanija, adresa, vlasnik, kontakt) VALUES ('{novoKino.naziv}', '{novoKino.kompanija}', '{novoKino.adresa}', '{novoKino.vlasnik}', '{novoKino.kontakt}')";
            BazaPodataka.Instance.ExecuteCommand(upit);

            BazaPodataka.Instance.Disconnect();
        }

        public static void UkloniKino(Kino odabranoKino)
        {
            BazaPodataka.Instance.Connect();

            string upit1 = $"DELETE FROM korisnici WHERE zaposlen_u='{odabranoKino.idKina}'";
            BazaPodataka.Instance.ExecuteCommand(upit1);

            string upit2 = $"DELETE FROM kina WHERE id_kina='{odabranoKino.idKina}'";
            BazaPodataka.Instance.ExecuteCommand(upit2);

            BazaPodataka.Instance.Disconnect();
        }
        public static void UrediKino(Kino odabranoKino)
        {

            BazaPodataka.Instance.Connect();

            string upit = $"UPDATE kina SET naziv_kina='{odabranoKino.naziv}', kompanija='{odabranoKino.kompanija}', adresa='{odabranoKino.adresa}', vlasnik='{odabranoKino.vlasnik}', kontakt='{odabranoKino.kontakt}' WHERE id_kina='{odabranoKino.idKina}'";
            BazaPodataka.Instance.ExecuteCommand(upit);

            BazaPodataka.Instance.Disconnect();
        }

        public static List<Korisnik> DohvatiAdmine(Kino odabranoKino)
        {
            BazaPodataka.Instance.Connect();

            string upit = $"SELECT * FROM korisnici WHERE uloga_korisnika='2' AND zaposlen_u='{odabranoKino.idKina}'";
            IDataReader datareader = BazaPodataka.Instance.GetDataReader(upit);

            List<Korisnik> admini = new List<Korisnik>();

            while (datareader.Read())
            {
                Korisnik korisnik = new Korisnik();

                korisnik.korisnickoIme = datareader["korisnicko_ime"].ToString();
                korisnik.ime = datareader["ime"].ToString();
                korisnik.prezime = datareader["prezime"].ToString();
                korisnik.lozinka = datareader["lozinka"].ToString();
                korisnik.email = datareader["email"].ToString();
                korisnik.spol = datareader["spol"].ToString();
                korisnik.brojTelefona = datareader["broj_telefona"].ToString();
                korisnik.kino = Convert.ToInt32(datareader["zaposlen_u"].ToString());
                korisnik.uloga = Uloga.Administrator;

                admini.Add(korisnik);
            }

            datareader.Close();

            BazaPodataka.Instance.Disconnect();

            return admini;
        }

        public static void DodajAdmina(Korisnik noviAdmin)
        {
            BazaPodataka.Instance.Connect();

            string upit = $"INSERT INTO korisnici (korisnicko_ime, uloga_korisnika, zaposlen_u, ime, prezime, lozinka, email, spol, broj_telefona) " +
                $"VALUES ('{noviAdmin.korisnickoIme}', '2', '{noviAdmin.kino}', '{noviAdmin.ime}', '{noviAdmin.prezime}', '{noviAdmin.lozinka}', " +
                $"'{noviAdmin.email}', '{noviAdmin.spol}', '{noviAdmin.brojTelefona}')";

            BazaPodataka.Instance.ExecuteCommand(upit);

            BazaPodataka.Instance.Disconnect();
        }
        public static void UkloniAdmina(Korisnik odabraniAdmin)
        {
            BazaPodataka.Instance.Connect();

            string upit = $"DELETE FROM korisnici WHERE korisnicko_ime='{odabraniAdmin.korisnickoIme}'";
            BazaPodataka.Instance.ExecuteCommand(upit);

            BazaPodataka.Instance.Disconnect();
        }
        public static void UrediAdmina(Korisnik odabraniKorisnik)
        {

            BazaPodataka.Instance.Connect();

            string upit = $"UPDATE korisnici SET ime='{odabraniKorisnik.ime}', prezime='{odabraniKorisnik.prezime}', email='{odabraniKorisnik.email}', spol='{odabraniKorisnik.spol}', broj_telefona='{odabraniKorisnik.brojTelefona}' WHERE korisnicko_ime='{odabraniKorisnik.korisnickoIme}'";
            BazaPodataka.Instance.ExecuteCommand(upit);

            BazaPodataka.Instance.Disconnect();
        }

    }
}
