using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data;

namespace Kinonik
{
    public static class RepozitorijGledanost
    {
        public static int dohvatiBrojKarata(int idKina)
        {
            BazaPodataka.Instance.Connect();

            string upit = $"SELECT COUNT(*) FROM karte INNER JOIN korisnici ON karte.korisnicko_ime=korisnici.korisnicko_ime " +
                $"WHERE korisnici.zaposlen_u={idKina}";
            int brojKarata = int.Parse(BazaPodataka.Instance.GetValue(upit).ToString());

            BazaPodataka.Instance.Disconnect();

            return brojKarata;
        }

        public static int dohvatiBrojKarataPoDatumu(int idKina, DateTime pocetak, DateTime zavrsetak)
        {
            BazaPodataka.Instance.Connect();

            string upit = $"SELECT COUNT(*) FROM karte INNER JOIN korisnici ON karte.korisnicko_ime=korisnici.korisnicko_ime " +
                $"INNER JOIN termini_prikazivanja ON karte.id_prikazivanja=termini_prikazivanja.id_prikazivanja WHERE korisnici.zaposlen_u={idKina}" +
                $"AND termini_prikazivanja.pocetak>='{pocetak.ToString("yyyy-MM-dd H:mm:ss")}' AND termini_prikazivanja.zavrsetak<='{zavrsetak.ToString("yyyy-MM-dd H:mm:ss")}'";
            int brojKarata = int.Parse(BazaPodataka.Instance.GetValue(upit).ToString());

            BazaPodataka.Instance.Disconnect();

            return brojKarata;
        }

        public static List<KeyValuePair<Film, int>> dohvatiBrojKarataPoFilmu(int idKina)
        {
            Dictionary<Film, int> glednostFilmova = new Dictionary<Film, int>();

            List<Film> filmoviLista = RepozitorijFilmovi.DohvatiFilmove();

            BazaPodataka.Instance.Connect();

            foreach (Film film in filmoviLista)
            {
                string upit = $"SELECT COUNT(*) FROM karte INNER JOIN termini_prikazivanja ON karte.id_prikazivanja=termini_prikazivanja.id_prikazivanja WHERE id_filma={film.idFilma}";

                int brojKarata = int.Parse(BazaPodataka.Instance.GetValue(upit).ToString());

                glednostFilmova.Add(film, brojKarata);
            }

            BazaPodataka.Instance.Disconnect();

            List<KeyValuePair<Film, int>> filmovi = glednostFilmova.ToList();

            return filmovi;
        }

        public static List<Karta> DohvatiKarte()
        {
            int idKina = RepozitorijDvorane.DohvatiKino(RepozitorijPrijava.prijavljeniKorisnik).idKina;

            BazaPodataka.Instance.Connect();

            string upit = $"SELECT * FROM karte INNER JOIN korisnici ON karte.korisnicko_ime=korisnici.korisnicko_ime " +
                $"WHERE korisnici.zaposlen_u='{idKina}'";
            IDataReader datareader = BazaPodataka.Instance.GetDataReader(upit);

            List<Karta> karte = new List<Karta>();

            while (datareader.Read())
            {
                Karta karta = new Karta();

                karta.idKarte = int.Parse(datareader["id_karte"].ToString());
                karta.idSjedala = int.Parse(datareader["id_sjedala"].ToString());
                karta.idPrikazivanja = int.Parse(datareader["id_prikazivanja"].ToString());
                karta.korinickoIme = datareader["korisnicko_ime"].ToString();
                karta.emailKupca = datareader["email_kupca"].ToString();

                karte.Add(karta);
            }

            datareader.Close();

            BazaPodataka.Instance.Disconnect();

            return karte;
        }
    }
}