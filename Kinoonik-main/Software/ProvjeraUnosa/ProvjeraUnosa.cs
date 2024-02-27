using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvjeraUnosa
{
    public static class ProvjeraUnosa
    {
        public static void ProvjeriDuljinuOpisa(string tekst)
        {
            if(tekst.Length > 1000)
            {
                throw new Exception($"Duljina opisa mora biti ispod 1000 znakova! Vaš opis je trenutno dug {tekst.Length} znakova!");
            }
        }

        public static void ProvjeriDuljinuPolja(string tekst)
        {
            if (tekst.Length > 255)
            {
                throw new Exception($"Duljina tekstualnih polja mora biti ispod 255 znakova! Vaše polje je trenutno dugo {tekst.Length} znakova!");
            }
        }

        public static void ProvjeriUnosPolja(string tekst)
        {
            if(tekst=="" || tekst==null)
            {
                throw new Exception("Naziv, trajanje i cijena karte su obavezni parametri. Molimo vas da ih unesete!");
            }
        }

        public static void ProvjeriFormatPolja(string tekst, string format)
        {
            switch (format)
            {
                case "int":
                    {
                        if (!int.TryParse(tekst, out _))
                        {
                            throw new Exception("Molimo provjerite formate unesenih polja.");
                        }
                        break;
                    }
                case "double":
                    {
                        if (!double.TryParse(tekst, out _))
                        {
                            throw new Exception("Molimo provjerite formate unesenih polja.");
                        }
                        break;
                    }
            }
        }

        public static void ProvjeriTermine(DateTime pocetak, DateTime zavrsetak)
        {
            if (zavrsetak <= pocetak)
            {
                throw new Exception("Početak prikazivanja mora biti prije završetka prikazivanja!");
            }
        }
    }
}
