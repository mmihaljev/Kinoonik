using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProvjeraUnosa;
using System.Reflection;
using System.IO;

namespace Kinonik
{
    public partial class FrmDodajUrediFilm : Form
    {
        public Film odabraniFilm = null;
        public FrmDodajUrediFilm()
        {
            InitializeComponent();
        }

        private void FrmDodajUrediFilm_Load(object sender, EventArgs e)
        {
            if (odabraniFilm != null)
            {
                textBoxNazivFilma.Text = odabraniFilm.nazivFilma;
                textBoxTrajanjeFilma.Text = odabraniFilm.trajanjeFilma.ToString();
                textBoxRedatelj.Text = odabraniFilm.redateljFilma;
                textBoxCijenaKarte.Text = odabraniFilm.cijenaKarte.ToString();
                textBoxOpis.Text = odabraniFilm.opisFilma;
            }
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            bool greska = false;
            try
            {
                ProvjeraUnosa.ProvjeraUnosa.ProvjeriDuljinuOpisa(textBoxOpis.Text);
                ProvjeraUnosa.ProvjeraUnosa.ProvjeriUnosPolja(textBoxNazivFilma.Text);
                ProvjeraUnosa.ProvjeraUnosa.ProvjeriUnosPolja(textBoxTrajanjeFilma.Text);
                ProvjeraUnosa.ProvjeraUnosa.ProvjeriUnosPolja(textBoxCijenaKarte.Text);
                ProvjeraUnosa.ProvjeraUnosa.ProvjeriDuljinuPolja(textBoxRedatelj.Text);
                ProvjeraUnosa.ProvjeraUnosa.ProvjeriDuljinuPolja(textBoxNazivFilma.Text);
                ProvjeraUnosa.ProvjeraUnosa.ProvjeriFormatPolja(textBoxTrajanjeFilma.Text, "int");
                ProvjeraUnosa.ProvjeraUnosa.ProvjeriFormatPolja(textBoxCijenaKarte.Text, "double");
            }
            catch(Exception ex)
            {
                greska = true;
                MessageBox.Show(ex.Message);
            }
            if(greska==false)
            {
                if (odabraniFilm == null)
                {
                    Film film = new Film();
                    film.nazivFilma = textBoxNazivFilma.Text;
                    film.trajanjeFilma = Convert.ToInt32(textBoxTrajanjeFilma.Text);
                    film.redateljFilma = textBoxRedatelj.Text;
                    film.cijenaKarte = Convert.ToDouble(textBoxCijenaKarte.Text);
                    film.opisFilma = textBoxOpis.Text;
                    RepozitorijFilmovi.DodajFilm(film);
                    this.DialogResult = DialogResult.Yes;
                    Close();
                }
                else
                {
                    odabraniFilm.nazivFilma = textBoxNazivFilma.Text;
                    odabraniFilm.trajanjeFilma = Convert.ToInt32(textBoxTrajanjeFilma.Text);
                    odabraniFilm.redateljFilma = textBoxRedatelj.Text;
                    odabraniFilm.cijenaKarte = Convert.ToDouble(textBoxCijenaKarte.Text);
                    odabraniFilm.opisFilma = textBoxOpis.Text;
                    RepozitorijFilmovi.UrediFilm(odabraniFilm);
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }          
        }

        private void FrmDodajUrediFilm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            String path = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            Help.ShowHelp(this, path, HelpNavigator.TopicId, "1016");
        }
    }
}
