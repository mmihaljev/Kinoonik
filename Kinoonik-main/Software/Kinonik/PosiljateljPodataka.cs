using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net.Mail;
using System.Net;

namespace Kinonik
{
    public static class PosiljateljPodataka
    {
        public static void PosaljiMail(string korisnikoIme, string lozinka, string nazivKina, string email, string ime, string prezime)
        {
            SmtpClient mail = new SmtpClient("smtp.gmail.com")
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Port = 587,
                Credentials = new NetworkCredential("programskoinzenjerstvo2244@gmail.com", "mudiahzsyfusjosi")
            };

            string subject = "[Kinonik] Pristupni podaci za aplikaciju";
            string body = $"Poštovani {ime} {prezime}, {System.Environment.NewLine}" +
                $"Ova poruka sadržava pristupne podatke za aplikaciju Kinonik. Vaši pristupni podaci za kino {nazivKina} su: {System.Environment.NewLine}" +
                $"Korisničko ime: {korisnikoIme} {System.Environment.NewLine}" +
                $"Lozinka: {lozinka}";
            mail.Send("programskoinzenjerstvo2244@gmail.com", email, subject, body);
        }
    }
}
