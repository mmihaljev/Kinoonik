using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net.Mail;
using System.Net;

namespace SlanjeObavijesti
{
    public static class RepozitorijObavijest
    {
        // Funkcija provjerava vrijeme i ako je vrijeme točno 24 sata prije termina prikazivanja filma - poziva funkciju za slanje maila kupcu karte
        public static void ProvjeriUvjete()
        {
            DateTime trenutnoVrijeme = DateTime.Now;
            BazaPodataka.Instance.Connect();
            string upit = $"SELECT * FROM filmovi INNER JOIN termini_prikazivanja ON filmovi.id_filma=termini_prikazivanja.id_filma INNER JOIN karte ON termini_prikazivanja.id_prikazivanja=karte.id_prikazivanja INNER JOIN dvorane ON termini_prikazivanja.id_dvorane=dvorane.id_dvorane INNER JOIN kina ON dvorane.id_kina=kina.id_kina INNER JOIN sjedala ON sjedala.id_sjedala=karte.id_sjedala";
            IDataReader datareader = BazaPodataka.Instance.GetDataReader(upit);
            while (datareader.Read())
            {
                DateTime pocetakPrikazivanja = (DateTime)datareader["pocetak"];
                if(trenutnoVrijeme.Year == pocetakPrikazivanja.Year && trenutnoVrijeme.Month == pocetakPrikazivanja.Month && (trenutnoVrijeme.Day + 1) == pocetakPrikazivanja.Day && trenutnoVrijeme.Hour == pocetakPrikazivanja.Hour && trenutnoVrijeme.Minute == pocetakPrikazivanja.Minute && trenutnoVrijeme.Second == pocetakPrikazivanja.Second)
                {
                    PosaljiMail(datareader["naziv_kina"].ToString(), datareader["naziv_dvorane"].ToString(), datareader["oznaka_sjedala"].ToString() , datareader["naziv_filma"].ToString(), datareader["email_kupca"].ToString(), (DateTime)datareader["pocetak"]);
                }
            }
            datareader.Close();
            BazaPodataka.Instance.Disconnect();
        }

        private static void PosaljiMail(string nazivKina, string nazivDvorane, string oznakaSjedala, string nazivFilma, string email, DateTime pocetakPrikazivanja)
        {
            SmtpClient mail = new SmtpClient("smtp.gmail.com")
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Port = 587,
                Credentials = new NetworkCredential("programskoinzenjerstvo2244@gmail.com", "mudiahzsyfusjosi")
            };
            string subject = "[Kinonik] Podsjetnik na prikazivanje filma";
            string body = $"Ovo je automatski podsjetnik na termin prikazivanja filma za koji ste kupili kartu. {System.Environment.NewLine}" +
                $"Datum početka prikazivanja: {pocetakPrikazivanja.Date.ToString("yyyy.MM.dd")} {System.Environment.NewLine}" +
                $"Vrijeme početka prikazivanja: {pocetakPrikazivanja.TimeOfDay} {System.Environment.NewLine}" +
                $"Naziv filma: {nazivFilma} {System.Environment.NewLine}" +
                $"Naziv kina: {nazivKina} {System.Environment.NewLine}" +
                $"Naziv dvorane: {nazivDvorane} {System.Environment.NewLine}" +
                $"Oznaka sjedala: {oznakaSjedala} {System.Environment.NewLine}";
            mail.Send("programskoinzenjerstvo2244@gmail.com", email, subject, body);
        }
    }
}
