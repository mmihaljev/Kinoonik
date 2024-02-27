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
using System.Reflection;
using System.IO;

namespace Kinonik
{
    public partial class FrmUpravljanjeFilmovima : Form
    {
        public FrmUpravljanjeFilmovima()
        {
            InitializeComponent();
        }

        private void FrmUpravljanjeFilmovima_Load(object sender, EventArgs e)
        {
            labelObavijest.Text = "";
            OsvjeziFilmove();
        }

        private void OsvjeziFilmove()
        {
            dgvFilmovi.DataSource = null;
            dgvFilmovi.DataSource = RepozitorijFilmovi.DohvatiFilmove();
            dgvFilmovi.Columns[0].HeaderText = "ID Filma";
            dgvFilmovi.Columns[1].HeaderText = "Naziv";
            dgvFilmovi.Columns[2].HeaderText = "Trajanje filma (min)";
            dgvFilmovi.Columns[3].HeaderText = "Redatelj";
            dgvFilmovi.Columns[4].HeaderText = "Opis";
            dgvFilmovi.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFilmovi.Columns[5].HeaderText = "Cijena karte (kn)";
        }

        private void PrikaziObavijest(string obavijest, int sekunde)
        {
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (s, ea) => Thread.Sleep(sekunde*1000);
            backgroundWorker.RunWorkerCompleted += (s, ea) =>
            {
                labelObavijest.Text = "";
            };
            labelObavijest.Text = obavijest;
            backgroundWorker.RunWorkerAsync();
        }

        private void buttonUkloniFilm_Click(object sender, EventArgs e)
        {
            Film odabraniFilm = dgvFilmovi.CurrentRow.DataBoundItem as Film;
            int uspjeh = RepozitorijFilmovi.UkloniFilm(odabraniFilm);
            OsvjeziFilmove();
            if (uspjeh != 0)
            {
                PrikaziObavijest("Film uspješno uklonjen!", 2);
            }
        }

        private void buttonDodajFilm_Click(object sender, EventArgs e)
        {
            FrmDodajUrediFilm form = new FrmDodajUrediFilm();
            var rezultat = form.ShowDialog();
            if(rezultat == DialogResult.Yes)
            {
                PrikaziObavijest("Film uspješno dodan!", 2);
            }
            OsvjeziFilmove();
        }

        private void buttonUrediFilm_Click(object sender, EventArgs e)
        {
            Film odabraniFilm = dgvFilmovi.CurrentRow.DataBoundItem as Film;
            FrmDodajUrediFilm form = new FrmDodajUrediFilm();
            form.odabraniFilm = odabraniFilm;
            var rezultat = form.ShowDialog();
            if(rezultat == DialogResult.OK)
            {
                PrikaziObavijest("Film uspješno uređen!", 2);
            }
            OsvjeziFilmove();
        }

        private void FrmUpravljanjeFilmovima_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            String path = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            Help.ShowHelp(this, path, HelpNavigator.TopicId, "1007");
        }
    }
}
