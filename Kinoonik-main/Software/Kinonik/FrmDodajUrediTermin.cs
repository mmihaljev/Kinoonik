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
    public partial class FrmDodajUrediTermin : Form
    {
        public Termin odabraniTermin = null;
        public Dvorana odabranaDvorana;
        List<Film> filmovi = RepozitorijFilmovi.DohvatiFilmove();
        public FrmDodajUrediTermin(Dvorana dvorana)
        {
            InitializeComponent();
            comboBoxFilm.DropDownStyle = ComboBoxStyle.DropDownList;
            odabranaDvorana = dvorana;
            foreach (Film film in filmovi)
            {
                comboBoxFilm.Items.Add(film);
            }
        }

        private void FrmDodajUrediTermin_Load(object sender, EventArgs e)
        {
            if(odabraniTermin!=null)
            {
                foreach (Film film in filmovi)
                {
                    if(film.idFilma==odabraniTermin.idFilma)
                    {
                        comboBoxFilm.SelectedItem = film;
                    }
                }
                dateTimePickerPocetak.Value = odabraniTermin.pocetak;
                dateTimePickerZavrsetak.Value = odabraniTermin.zavrsetak;
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
                ProvjeraUnosa.ProvjeraUnosa.ProvjeriTermine(dateTimePickerPocetak.Value, dateTimePickerZavrsetak.Value);
            }
            catch(Exception ex)
            {
                greska = true;
                MessageBox.Show(ex.Message);
            }
            if(greska==false)
            {
                if (odabraniTermin == null)
                {
                    Termin noviTermin = new Termin();
                    noviTermin.idDvorane = odabranaDvorana.idDvorane;
                    noviTermin.idFilma = (comboBoxFilm.SelectedItem as Film).idFilma;
                    noviTermin.pocetak = dateTimePickerPocetak.Value;
                    noviTermin.zavrsetak = dateTimePickerZavrsetak.Value;
                    noviTermin.film = comboBoxFilm.SelectedItem as Film;
                    RepozitorijTermini.DodajTermin(noviTermin);
                    this.DialogResult = DialogResult.Yes;
                    Close();
                }
                else
                {
                    odabraniTermin.idFilma = (comboBoxFilm.SelectedItem as Film).idFilma;
                    odabraniTermin.pocetak = dateTimePickerPocetak.Value;
                    odabraniTermin.zavrsetak = dateTimePickerZavrsetak.Value;
                    odabraniTermin.film = comboBoxFilm.SelectedItem as Film;
                    RepozitorijTermini.UrediTermin(odabraniTermin);
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void FrmDodajUrediTermin_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            String path = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            Help.ShowHelp(this, path, HelpNavigator.TopicId, "1015");
        }
    }
}
