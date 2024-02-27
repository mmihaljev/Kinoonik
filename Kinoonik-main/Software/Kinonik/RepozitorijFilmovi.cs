using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Kinonik
{
    public static class RepozitorijFilmovi
    {
        public static List<Film> DohvatiFilmove()
        {
            BazaPodataka.Instance.Connect();
            string upit = $"SELECT * FROM filmovi INNER JOIN prikazuje_se ON filmovi.id_filma=prikazuje_se.id_filma WHERE id_kina='{RepozitorijPrijava.prijavljeniKorisnik.kino}'";
            IDataReader datareader = BazaPodataka.Instance.GetDataReader(upit);
            List<Film> filmovi = new List<Film>();
            while(datareader.Read())
            {
                Film noviFilm = new Film();
                noviFilm.idFilma = (int)datareader["id_filma"];
                noviFilm.nazivFilma = datareader["naziv_filma"].ToString();
                noviFilm.trajanjeFilma = (int)datareader["trajanje_min"];
                noviFilm.redateljFilma = datareader["redatelj"].ToString();
                noviFilm.opisFilma = datareader["opis"].ToString();
                noviFilm.cijenaKarte = (double)datareader["cijena_karte_kn"];
                filmovi.Add(noviFilm);
            }
            datareader.Close();
            BazaPodataka.Instance.Disconnect();
            return filmovi;
        }

        public static int UkloniFilm(Film odabraniFilm)
        {
            BazaPodataka.Instance.Connect();
            string upit = $"DELETE FROM filmovi WHERE id_filma='{odabraniFilm.idFilma}'";
            int uspjeh = BazaPodataka.Instance.ExecuteCommand(upit);
            BazaPodataka.Instance.Disconnect();
            return uspjeh;
        }

        public static int DodajFilm(Film odabraniFilm)
        {
            BazaPodataka.Instance.Connect();
            string upit = $"INSERT INTO filmovi (naziv_filma, trajanje_min, redatelj, opis, cijena_karte_kn) VALUES ('{odabraniFilm.nazivFilma}', '{odabraniFilm.trajanjeFilma}', '{odabraniFilm.redateljFilma}', '{odabraniFilm.opisFilma}', '{odabraniFilm.cijenaKarte}')";
            int uspjeh = BazaPodataka.Instance.ExecuteCommand(upit);
            BazaPodataka.Instance.Disconnect();
            AzurirajPovijestCijena(DohvatiFilm(odabraniFilm.nazivFilma));
            DodajFilmKinu(DohvatiFilm(odabraniFilm.nazivFilma));
            return uspjeh;
        }

        public static int UrediFilm(Film odabraniFilm)
        {
            Film postojeciUnos = DohvatiFilm(odabraniFilm.nazivFilma);
            BazaPodataka.Instance.Connect();
            string upit = $"UPDATE filmovi SET naziv_filma='{odabraniFilm.nazivFilma}', trajanje_min='{odabraniFilm.trajanjeFilma}', redatelj='{odabraniFilm.redateljFilma}', opis='{odabraniFilm.opisFilma}', cijena_karte_kn='{odabraniFilm.cijenaKarte}' WHERE id_filma='{odabraniFilm.idFilma}'";
            int uspjeh = BazaPodataka.Instance.ExecuteCommand(upit);
            BazaPodataka.Instance.Disconnect();
            if(postojeciUnos.cijenaKarte != odabraniFilm.cijenaKarte)
            {
                AzurirajPovijestCijena(DohvatiFilm(odabraniFilm.nazivFilma));
            }
            return uspjeh;
        }

        private static Film DohvatiFilm(string nazivFilma)
        {
            BazaPodataka.Instance.Connect();
            string upit = $"SELECT * FROM filmovi";
            IDataReader datareader = BazaPodataka.Instance.GetDataReader(upit);
            Film film = new Film();
            while (datareader.Read())
            {
                if(datareader["naziv_filma"].ToString()==nazivFilma)
                {
                    film.idFilma = (int)datareader["id_filma"];
                    film.nazivFilma = datareader["naziv_filma"].ToString();
                    film.trajanjeFilma = (int)datareader["trajanje_min"];
                    film.redateljFilma = datareader["redatelj"].ToString();
                    film.opisFilma = datareader["opis"].ToString();
                    film.cijenaKarte = (double)datareader["cijena_karte_kn"];
                }
            }
            datareader.Close();
            BazaPodataka.Instance.Disconnect();
            return film;
        }

        private static void AzurirajPovijestCijena(Film odabraniFilm)
        {
            BazaPodataka.Instance.Connect();
            if(!String.IsNullOrEmpty(odabraniFilm.idFilma.ToString()))
            {
                string upit = $"UPDATE povijest_cijena SET do_datuma='{DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")}' WHERE id_filma={odabraniFilm.idFilma} AND do_datuma IS NULL";
                BazaPodataka.Instance.ExecuteCommand(upit);
            }
            string upit2 = $"INSERT INTO povijest_cijena (id_filma, od_datuma, cijena) VALUES ('{odabraniFilm.idFilma}', '{DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")}', '{odabraniFilm.cijenaKarte}')";
            BazaPodataka.Instance.ExecuteCommand(upit2);
            BazaPodataka.Instance.Disconnect();
        }

        private static void DodajFilmKinu(Film odabraniFilm)
        {
            BazaPodataka.Instance.Connect();
            string upit = $"INSERT INTO prikazuje_se (id_kina, id_filma) VALUES ('{RepozitorijPrijava.prijavljeniKorisnik.kino}', '{odabraniFilm.idFilma}')";
            BazaPodataka.Instance.ExecuteCommand(upit);
            BazaPodataka.Instance.Disconnect();
        }
    }
}
