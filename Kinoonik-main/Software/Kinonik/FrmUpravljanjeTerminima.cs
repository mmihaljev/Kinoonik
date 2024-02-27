using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ProvjeraUnosa;
using System.Reflection;
using System.IO;

namespace Kinonik
{
    public partial class FrmUpravljanjeTerminima : Form
    {
        public FrmUpravljanjeTerminima()
        {
            InitializeComponent();
            dgvTermini.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            comboBoxDvorane.DropDownStyle = ComboBoxStyle.DropDownList;
            labelObavijest.Text = "";
        }

        private void FrmUpravljanjeTerminima_Load(object sender, EventArgs e)
        {
            comboBoxDvorane.DataSource = RepozitorijTermini.DohvatiDvorane();
            labelObavijest.Text = "";
            OsvjeziTermine();
        }

        // Funkcija pokreće dretvu koja postavlja tekst obavijesti na željeni tekst te nakon X sekundi vraća tekst obavijesti na prazan string.
        private void PrikaziObavijest(string obavijest, int sekunde)
        {
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (s, ea) => Thread.Sleep(sekunde * 1000);
            backgroundWorker.RunWorkerCompleted += (s, ea) =>
            {
                labelObavijest.Text = "";
            };
            labelObavijest.Text = obavijest;
            backgroundWorker.RunWorkerAsync();
        }

        private void OsvjeziTermine()
        {
            Dvorana odabranaDvorana = comboBoxDvorane.SelectedItem as Dvorana;
            List<Termin> termini;
            if (checkBoxDanas.Checked==true)
            {
                termini = new List<Termin>();
                foreach (Termin termin in RepozitorijTermini.DohvatiTermine(odabranaDvorana.idDvorane))
                {
                    if(termin.pocetak.Date == DateTime.Now.Date)
                    {
                        termini.Add(termin);
                    }
                }
            }
            else
            {
                termini = RepozitorijTermini.DohvatiTermine(odabranaDvorana.idDvorane);
            }
            dgvTermini.DataSource = null;
            dgvTermini.DataSource = termini;
            dgvTermini.Columns[0].Visible = false;
            dgvTermini.Columns[1].Visible = false;
            dgvTermini.Columns[2].Visible = false;
            dgvTermini.Columns[3].HeaderText = "Početak prikazivanja";
            dgvTermini.Columns[4].HeaderText = "Završetak prikazivanja";
            dgvTermini.Columns[5].HeaderText = "Film";
            dgvTermini.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            buttonUrediTermin.Enabled = false;
            buttonUkloniTermin.Enabled = false;
        }

        private void comboBoxDvorane_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsvjeziTermine();
        }

        private void checkBoxDanas_CheckedChanged(object sender, EventArgs e)
        {
            OsvjeziTermine();
        }

        private void buttonDodajTermin_Click(object sender, EventArgs e)
        {
            Dvorana odabranaDvorana = comboBoxDvorane.SelectedItem as Dvorana;
            FrmDodajUrediTermin form = new FrmDodajUrediTermin(odabranaDvorana);
            var rezultat = form.ShowDialog();
            if (rezultat == DialogResult.Yes)
            {
                PrikaziObavijest("Termin uspješno dodan", 2);
            }
            OsvjeziTermine();
        }

        private void buttonUrediTermin_Click(object sender, EventArgs e)
        {
            Dvorana odabranaDvorana = comboBoxDvorane.SelectedItem as Dvorana;
            FrmDodajUrediTermin form = new FrmDodajUrediTermin(odabranaDvorana);
            form.odabraniTermin = dgvTermini.CurrentRow.DataBoundItem as Termin;
            var rezultat = form.ShowDialog();
            if (rezultat == DialogResult.OK)
            {
                PrikaziObavijest("Termin uspješno uređen", 2);
            }
            OsvjeziTermine();
        }

        private void buttonUkloniTermin_Click(object sender, EventArgs e)
        {
            Termin odabraniTermin = dgvTermini.CurrentRow.DataBoundItem as Termin;
            int uspjeh = RepozitorijTermini.UkloniTermin(odabraniTermin);
            if(uspjeh != 0)
            {
                PrikaziObavijest("Termin uspješno uklonjen!", 2);
            }
            OsvjeziTermine();
        }

        // Funkcije služe za to da spriječe korisnika da klikne na gumb prije nego selektira termin iz data grid view-a

        private void dgvTermini_SelectionChanged(object sender, EventArgs e)
        {
            buttonUrediTermin.Enabled = true;
            buttonUkloniTermin.Enabled = true;
        }

        private void dgvTermini_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonUrediTermin.Enabled = true;
            buttonUkloniTermin.Enabled = true;
        }

        private void FrmUpravljanjeTerminima_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            String path = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            Help.ShowHelp(this, path, HelpNavigator.TopicId, "1006");
        }
    }
}
