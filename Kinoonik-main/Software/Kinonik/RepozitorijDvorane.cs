using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinonik
{
    public static class RepozitorijDvorane
    {
        public static void DodajDvorane(Dvorana novaDvorana)
        {
            BazaPodataka.Instance.Connect();

            string upit = $"INSERT INTO dvorane (id_kina, naziv_dvorane) VALUES ('{novaDvorana.idKina}', '{novaDvorana.nazivDvorane}')";
            BazaPodataka.Instance.ExecuteCommand(upit);

            BazaPodataka.Instance.Disconnect();
        }
        public static void UkloniDvoranu(Dvorana odabranaDvorana)
        {
            BazaPodataka.Instance.Connect();

            string upitDvorane = $"DELETE FROM dvorane WHERE id_dvorane='{odabranaDvorana.idDvorane}'";
            BazaPodataka.Instance.ExecuteCommand(upitDvorane);

            string upitSjedala = $"DELETE FROM sjedala WHERE id_dvorane='{odabranaDvorana.idDvorane}'";
            BazaPodataka.Instance.ExecuteCommand(upitSjedala);

            BazaPodataka.Instance.Disconnect();
        }
        public static List<Dvorana> DohvatiDvorane(Kino kino)
        {
            BazaPodataka.Instance.Connect();

            string upit = $"SELECT * FROM dvorane WHERE id_kina={kino.idKina}";
            IDataReader datareader = BazaPodataka.Instance.GetDataReader(upit);

            List<Dvorana> dvorane = new List<Dvorana>();

            while (datareader.Read())
            {
                Dvorana dvorana = new Dvorana();

                dvorana.idDvorane = int.Parse(datareader["id_dvorane"].ToString());
                dvorana.idKina = int.Parse(datareader["id_kina"].ToString());
                dvorana.nazivDvorane = datareader["naziv_dvorane"].ToString();

                dvorane.Add(dvorana);
            }

            datareader.Close();

            BazaPodataka.Instance.Disconnect();

            return dvorane;
        }

        public static void DodajSjedalo(UCSjedalo sjedalo)
        {
            BazaPodataka.Instance.Connect();

            string upit = $"INSERT INTO sjedala (id_dvorane, oznaka_sjedala, postoji, zakljucano, red, broj_sjedala) " +
                $"VALUES ('{sjedalo.idDvorane}', '{sjedalo.oznakaSjedala}', '{Convert.ToInt32(sjedalo.postoji)}', " +
                $"'{Convert.ToInt32(sjedalo.zakljucano)}', '{sjedalo.red}', '{sjedalo.brojSjedala}')";

            BazaPodataka.Instance.ExecuteCommand(upit);

            BazaPodataka.Instance.Disconnect();
        }

        public static Dvorana DohvatiDvoranu(string naziv_dvorane, int id_kina)
        {
            BazaPodataka.Instance.Connect();

            string upit = $"SELECT * FROM dvorane";
            IDataReader datareader = BazaPodataka.Instance.GetDataReader(upit);

            Dvorana dvorana = new Dvorana();

            while (datareader.Read())
            {
                if (int.Parse(datareader["id_kina"].ToString()) == id_kina && datareader["naziv_dvorane"].ToString() == naziv_dvorane)
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

        public static Kino DohvatiKino(Korisnik korisnik)
        {
            BazaPodataka.Instance.Connect();

            string upit = $"SELECT * FROM kina";
            IDataReader datareader = BazaPodataka.Instance.GetDataReader(upit);

            Kino kino = new Kino();

            while (datareader.Read())
            {
                if (korisnik.kino == int.Parse(datareader["id_kina"].ToString()))
                {
                    kino.idKina = int.Parse(datareader["id_kina"].ToString());
                    kino.naziv = datareader["naziv_kina"].ToString();
                    kino.kompanija = datareader["kompanija"].ToString();
                    kino.adresa = datareader["adresa"].ToString();
                    kino.vlasnik = datareader["vlasnik"].ToString();
                    kino.kontakt = datareader["kontakt"].ToString();

                    break;
                }
            }

            datareader.Close();

            BazaPodataka.Instance.Disconnect();

            return kino;
        }
    }
}
