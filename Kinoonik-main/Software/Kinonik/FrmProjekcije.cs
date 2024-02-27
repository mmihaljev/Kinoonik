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
    public partial class FrmProjekcije : Form
    {
        public FrmProjekcije()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmProjekcije_Load(object sender, EventArgs e)
        {
            OsvjeziProjekcije();
        }

        private void OsvjeziProjekcije()
        {
            dgvFilmovi.DataSource = null;
            dgvFilmovi.DataSource = RepozitorijFilmovi.DohvatiFilmove();

            dgvFilmovi.Columns[0].Visible = false;
            dgvFilmovi.Columns[1].HeaderText = "Naziv filma";
            dgvFilmovi.Columns[2].Visible = false;
            dgvFilmovi.Columns[3].Visible = false;
            dgvFilmovi.Columns[4].Visible = false;
            dgvFilmovi.Columns[5].Visible = false;
        }

        private Film DohvatiTrenutniFilm()
        {
            Film film = dgvFilmovi.CurrentRow.DataBoundItem as Film;

            return film;
        }

        private void dgvFilmovi_SelectionChanged(object sender, EventArgs e)
        {
            dgvProjekcije.DataSource = null;
            dgvProjekcije.DataSource = RepozitorijSjedala.DohvatiTermine(DohvatiTrenutniFilm());

            dgvProjekcije.Columns[0].Visible = false;
            dgvProjekcije.Columns[1].HeaderText = "Dvorana";
            dgvProjekcije.Columns[2].Visible = false;
            dgvProjekcije.Columns[3].HeaderText = "Pocetak filma";
            dgvProjekcije.Columns[4].HeaderText = "Zavrsetak filma";
            dgvProjekcije.Columns[5].Visible = false;
        }

        private void btnKupiKarte_Click(object sender, EventArgs e)
        {
            FrmRezervacijaSjedala formRezervacijaSjedala = new FrmRezervacijaSjedala(dgvProjekcije.CurrentRow.DataBoundItem as Termin);
            this.Hide();
            formRezervacijaSjedala.ShowDialog();
            this.Show();
        }

        private void FrmProjekcije_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            String path = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            Help.ShowHelp(this, path, HelpNavigator.TopicId, "1010");
        }
    }
}
