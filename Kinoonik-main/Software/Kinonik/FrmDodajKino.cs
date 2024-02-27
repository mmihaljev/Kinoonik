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
    public partial class FrmDodajKino : Form
    {
        public Kino odabranoKino { get; set; } = null;
        public FrmDodajKino()
        {
            InitializeComponent();
        }
        public FrmDodajKino(Kino kino)
        {
            InitializeComponent();
            odabranoKino = kino;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            try
            {
                provjeriPolja();

                if (odabranoKino == null)
                {
                    Kino novoKino = new Kino();

                    novoKino.naziv = txtNaziv.Text;
                    novoKino.kompanija = txtKompanija.Text;
                    novoKino.kontakt = txtKontakt.Text;
                    novoKino.adresa = txtAdresa.Text;
                    novoKino.vlasnik = txtVlasnik.Text;

                    RepozitorijKina.DodajKino(novoKino);

                    Close();
                }
                else
                {
                    odabranoKino.naziv = txtNaziv.Text;
                    odabranoKino.kompanija = txtKompanija.Text;
                    odabranoKino.kontakt = txtKontakt.Text;
                    odabranoKino.adresa = txtAdresa.Text;
                    odabranoKino.vlasnik = txtVlasnik.Text;

                    RepozitorijKina.UrediKino(odabranoKino);

                    Close();
                }
            }
            catch (Iznimke.PraznaPoljaException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        //Učitava podatke ako se uređuje u formi
        private void FrmDodajKino_Load(object sender, EventArgs e)
        {
            if (odabranoKino != null)
            {
                txtNaziv.Text = odabranoKino.naziv;
                txtKompanija.Text = odabranoKino.kompanija;
                txtKontakt.Text = odabranoKino.kontakt;
                txtAdresa.Text = odabranoKino.adresa;
                txtVlasnik.Text = odabranoKino.vlasnik;
            }
        }

        public void provjeriPolja()
        {
            if (txtNaziv.Text == "" || txtKompanija.Text == "" || txtKontakt.Text == "" || txtAdresa.Text == "" || txtVlasnik.Text == "")
            {
                throw new Iznimke.PraznaPoljaException("Sva polja moraju biti popunjena");
            }
        }

        private void FrmDodajKino_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            String path = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            Help.ShowHelp(this, path, HelpNavigator.TopicId, "1017");
        }
    }
}
