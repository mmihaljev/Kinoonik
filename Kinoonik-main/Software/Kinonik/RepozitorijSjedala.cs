using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinonik
{
    public static class RepozitorijSjedala
    {
        public static List<Termin> DohvatiTermine(Film film)
        {
            BazaPodataka.Instance.Connect();

            string upit = $"SELECT * FROM termini_prikazivanja WHERE id_filma='{film.idFilma}'";
            IDataReader datareader = BazaPodataka.Instance.GetDataReader(upit);

            List<Termin> termini = new List<Termin>();

            while (datareader.Read())
            {
                Termin noviTermin = new Termin();
                noviTermin.idTermina = int.Parse(datareader["id_prikazivanja"].ToString());
                noviTermin.idDvorane = int.Parse(datareader["id_dvorane"].ToString());
                noviTermin.idFilma = int.Parse(datareader["id_filma"].ToString());
                noviTermin.pocetak = DateTime.Parse(datareader["pocetak"].ToString());
                noviTermin.zavrsetak = DateTime.Parse(datareader["zavrsetak"].ToString());
                noviTermin.film = film;

                termini.Add(noviTermin);
            }

            datareader.Close();

            BazaPodataka.Instance.Disconnect();

            return termini;
        }

        public static Dvorana DohvatiDvoranu(int idDvorane)
        {
            BazaPodataka.Instance.Connect();

            string upit = $"SELECT * FROM dvorane";
            IDataReader datareader = BazaPodataka.Instance.GetDataReader(upit);

            Dvorana dvorana = new Dvorana();

            while (datareader.Read())
            {
                if (datareader["id_dvorane"].ToString() == idDvorane.ToString())
                {
                    dvorana.idDvorane = int.Parse(datareader["id_dvorane"].ToString());
                    dvorana.idKina = int.Parse(datareader["id_kina"].ToString());
                    dvorana.nazivDvorane = datareader["naziv_dvorane"].ToString();

                    break;
                }
            }

            datareader.Close();

            BazaPodataka.Instance.Disconnect();

            return dvorana;
        }

        public static List<UCSjedalo> DohvatiSjedala(int idDvorane)
        {
            BazaPodataka.Instance.Connect();

            string upit = $"SELECT * FROM sjedala WHERE id_dvorane='{idDvorane}'";
            IDataReader datareader = BazaPodataka.Instance.GetDataReader(upit);

            List<UCSjedalo> sjedala = new List<UCSjedalo>();

            while (datareader.Read())
            {
                UCSjedalo sjedalo = new UCSjedalo();

                sjedalo.idSjedala = int.Parse(datareader["id_sjedala"].ToString());
                sjedalo.idDvorane = int.Parse(datareader["id_dvorane"].ToString());
                sjedalo.oznakaSjedala = datareader["oznaka_sjedala"].ToString();
                sjedalo.postoji = Convert.ToBoolean(int.Parse(datareader["postoji"].ToString()));
                sjedalo.zakljucano = Convert.ToBoolean(int.Parse(datareader["zakljucano"].ToString()));
                sjedalo.red = datareader["red"].ToString();
                sjedalo.brojSjedala = int.Parse(datareader["broj_sjedala"].ToString());

                sjedala.Add(sjedalo);
            }

            datareader.Close();

            BazaPodataka.Instance.Disconnect();

            return sjedala;
        }

        public static List<Karta> DohvatiKarte(int idPrikazivanja)
        {
            BazaPodataka.Instance.Connect();

            string upit = $"SELECT * FROM karte WHERE id_prikazivanja='{idPrikazivanja}'";
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

        public static void DodajKartu(Karta karta)
        {
            ProvjeriSjedalo(karta);

            BazaPodataka.Instance.Connect();

            string upit = $"INSERT INTO karte (id_sjedala, id_prikazivanja, korisnicko_ime, email_kupca) VALUES " +
                $"('{karta.idSjedala}', '{karta.idPrikazivanja}', '{karta.korinickoIme}', '{karta.emailKupca}')";

            BazaPodataka.Instance.ExecuteCommand(upit);

            BazaPodataka.Instance.Disconnect();
        }

        private static void ProvjeriSjedalo(Karta karta)
        {
            List<Karta> kupljeneKarte = DohvatiKarte(karta.idPrikazivanja);

            foreach (Karta kupljenaKarta in kupljeneKarte)
            {
                if (karta.idSjedala == kupljenaKarta.idSjedala)
                {
                    throw new Iznimke.SjedaloException("Odabrano sjedalo je zauzeto!");
                }
            }
        }
    }
}
