using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Kinonik
{
    public static class RepozitorijTermini
    {
        public static List<Dvorana> DohvatiDvorane()
        {
            BazaPodataka.Instance.Connect();
            string upit = $"SELECT * FROM dvorane WHERE id_kina='{RepozitorijPrijava.prijavljeniKorisnik.kino}'";
            IDataReader datareader = BazaPodataka.Instance.GetDataReader(upit);
            List<Dvorana> dvorane = new List<Dvorana>();
            while (datareader.Read())
            {
                Dvorana novaDvorana = new Dvorana();
                novaDvorana.idDvorane = (int)datareader["id_dvorane"];
                novaDvorana.idKina = (int)datareader["id_kina"];
                novaDvorana.nazivDvorane = datareader["naziv_dvorane"].ToString();
                dvorane.Add(novaDvorana);
            }
            datareader.Close();
            BazaPodataka.Instance.Disconnect();
            return dvorane;
        }

        public static List<Termin> DohvatiTermine(int idDvorane)
        {
            BazaPodataka.Instance.Connect();
            string upit = $"SELECT * FROM termini_prikazivanja WHERE id_dvorane='{idDvorane}'";
            IDataReader datareader = BazaPodataka.Instance.GetDataReader(upit);
            List<Termin> termini = new List<Termin>();
            while (datareader.Read())
            {
                Termin noviTermin = new Termin();
                noviTermin.idTermina = (int)datareader["id_prikazivanja"];
                noviTermin.idDvorane = (int)datareader["id_dvorane"];
                noviTermin.idFilma = (int)datareader["id_filma"];
                noviTermin.pocetak = (DateTime)datareader["pocetak"];
                noviTermin.zavrsetak = (DateTime)datareader["zavrsetak"];
                noviTermin.film = DohvatiFilm(noviTermin.idFilma);
                termini.Add(noviTermin);
            }
            datareader.Close();
            BazaPodataka.Instance.Disconnect();
            return termini;
        }

        public static int DodajTermin(Termin odabraniTermin)
        {
            BazaPodataka.Instance.Connect();
            string upit = $"INSERT INTO termini_prikazivanja (id_dvorane, id_filma, pocetak, zavrsetak) VALUES ('{odabraniTermin.idDvorane}', '{odabraniTermin.idFilma}', '{odabraniTermin.pocetak.ToString("yyyy-MM-dd H:mm:ss")}', '{odabraniTermin.zavrsetak.ToString("yyyy-MM-dd H:mm:ss")}')";
            int uspjeh = BazaPodataka.Instance.ExecuteCommand(upit);
            BazaPodataka.Instance.Disconnect();
            return uspjeh;
        }

        public static int UrediTermin(Termin odabraniTermin)
        {
            BazaPodataka.Instance.Connect();
            string upit = $"UPDATE termini_prikazivanja SET id_dvorane='{odabraniTermin.idDvorane}', id_filma='{odabraniTermin.idFilma}', pocetak='{odabraniTermin.pocetak.ToString("yyyy-MM-dd H:mm:ss")}', zavrsetak='{odabraniTermin.zavrsetak.ToString("yyyy-MM-dd H:mm:ss")}' WHERE id_prikazivanja='{odabraniTermin.idTermina}'";
            int uspjeh = BazaPodataka.Instance.ExecuteCommand(upit);
            BazaPodataka.Instance.Disconnect();
            return uspjeh;
        }

        public static int UkloniTermin(Termin odabraniTermin)
        {
            BazaPodataka.Instance.Connect();
            string upit = $"DELETE FROM termini_prikazivanja WHERE id_prikazivanja='{odabraniTermin.idTermina}'";
            int uspjeh = BazaPodataka.Instance.ExecuteCommand(upit);
            BazaPodataka.Instance.Disconnect();
            return uspjeh;
        }

        private static Film DohvatiFilm(int idFilma)
        {
            BazaPodataka.Instance.Connect();
            string upit = $"SELECT * FROM filmovi INNER JOIN prikazuje_se ON filmovi.id_filma=prikazuje_se.id_filma WHERE id_kina='{RepozitorijPrijava.prijavljeniKorisnik.kino}'";
            IDataReader datareader = BazaPodataka.Instance.GetDataReader(upit);
            Film film = new Film();
            while (datareader.Read())
            {
                if (datareader["id_filma"].ToString() == idFilma.ToString())
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
    }
}
