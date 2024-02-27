using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace Kinonik
{
    public partial class FrmRezervacijaSjedala : Form
    {
        public Termin trenutniTermin { get; set; }
        public List<UCSjedalo> sjedala { get; set; }
        public FrmRezervacijaSjedala(Termin termin)
        {
            InitializeComponent();

            trenutniTermin = termin;

            sjedala = RepozitorijSjedala.DohvatiSjedala(trenutniTermin.idDvorane);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmRezervacijaSjedala_Load(object sender, EventArgs e)
        {
            OznaciSjedala();

            GenerirajSjedala();
        }

        private void GenerirajSjedala()
        {
            string trenutniRed = sjedala[0].red;

            Font labelFont = new Font("Arial", 15, FontStyle.Bold);

            //Generiraju se sjedala
            foreach (UCSjedalo sjedalo in sjedala)
            {
                if (sjedalo.red == trenutniRed)
                {
                    panelSjedala.Controls.Add(sjedalo);
                }
                else
                {
                    //Radi novi label koji označava kraj reda
                    Label oznakaReda = new Label();
                    oznakaReda.Text = trenutniRed;
                    oznakaReda.Font = labelFont;

                    panelSjedala.Controls.Add(oznakaReda);
                    panelSjedala.SetFlowBreak(oznakaReda, true);

                    //Dodaje novo sjedalo
                    panelSjedala.Controls.Add(sjedalo);

                    trenutniRed = sjedalo.red;
                }
            }

            Label zadnjaOznakaReda = new Label();
            zadnjaOznakaReda.Text = trenutniRed;
            zadnjaOznakaReda.Font = labelFont;

            panelSjedala.Controls.Add(zadnjaOznakaReda);
        }

        //Disable-a sjedala koja ne postoje u dovrani i kupljena sjedala
        private void OznaciSjedala()
        {
            List<Karta> kupljeneKarte = RepozitorijSjedala.DohvatiKarte(trenutniTermin.idTermina);

            foreach (UCSjedalo sjedalo in sjedala)
            {
                if (sjedalo.postoji != true)
                {
                    sjedalo.pboxSjedalo.BackColor = Color.White;
                    sjedalo.Enabled = false;
                }
                foreach (Karta karta in kupljeneKarte)
                {
                    if (sjedalo.idSjedala == karta.idSjedala)
                    {
                        sjedalo.pboxSjedalo.BackColor = Color.Red;
                        sjedalo.Enabled = false;
                    }
                }
            }
        }

        private void btnKupiKarte_Click(object sender, EventArgs e)
        {
            foreach (UCSjedalo sjedalo in sjedala)
            {
                if (sjedalo.rezervirano == true)
                {
                    Karta novaKarta = new Karta();

                    novaKarta.idPrikazivanja = trenutniTermin.idTermina;
                    novaKarta.idSjedala = sjedalo.idSjedala;
                    novaKarta.emailKupca = txtEmail.Text;
                    novaKarta.korinickoIme = RepozitorijPrijava.prijavljeniKorisnik.korisnickoIme;

                    try
                    {
                        RepozitorijSjedala.DodajKartu(novaKarta);
                    }
                    catch (Iznimke.SjedaloException ex)
                    {
                        MessageBox.Show(ex.Poruka);
                    }
                }
            }

            Close();
        }

        private void FrmRezervacijaSjedala_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            String path = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            Help.ShowHelp(this, path, HelpNavigator.TopicId, "1009");
        }
    }
}
