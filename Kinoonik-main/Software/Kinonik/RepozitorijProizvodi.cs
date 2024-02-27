using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinonik
{
    public static class RepozitorijProizvodi
    {
        public static List<Proizvod> DohvatiProizvode()
        {
            BazaPodataka.Instance.Connect();

            string upit = "SELECT * FROM proizvodi";
            IDataReader datareader = BazaPodataka.Instance.GetDataReader(upit);

            List<Proizvod> proizvodi = new List<Proizvod>();

            while (datareader.Read())
            {
                Proizvod noviProizvod = new Proizvod();

                noviProizvod.idProizvoda = int.Parse(datareader["id_proizvoda"].ToString());
                noviProizvod.naziv = datareader["naziv_proizvoda"].ToString();
                noviProizvod.cijena = double.Parse(datareader["cijena_proizvoda"].ToString());

                proizvodi.Add(noviProizvod);
            }

            datareader.Close();

            BazaPodataka.Instance.Disconnect();

            return proizvodi;
        }

        public static void DodajProizvod(Proizvod odabraniProizvod)
        {
            BazaPodataka.Instance.Connect();

            string upit = $"INSERT INTO proizvodi (naziv_proizvoda, cijena_proizvoda) VALUES ('{odabraniProizvod.naziv}', '{odabraniProizvod.cijena}')";
            BazaPodataka.Instance.ExecuteCommand(upit);
            
            BazaPodataka.Instance.Disconnect();
        }

        public static void UkloniProizvod(Proizvod odabraniProizvod)
        {
            BazaPodataka.Instance.Connect();

            string upit = $"DELETE FROM proizvodi WHERE id_proizvoda='{odabraniProizvod.idProizvoda}'";
            BazaPodataka.Instance.ExecuteCommand(upit);

            BazaPodataka.Instance.Disconnect();
        }

        public static void UrediProizvod(Proizvod odabraniProizvod)
        {

            BazaPodataka.Instance.Connect();

            string upit = $"UPDATE proizvodi SET naziv_proizvoda='{odabraniProizvod.naziv}', cijena_proizvoda='{odabraniProizvod.cijena}' WHERE id_proizvoda='{odabraniProizvod.idProizvoda}'";
            BazaPodataka.Instance.ExecuteCommand(upit);

            BazaPodataka.Instance.Disconnect();
        }
    }
}
