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
    public partial class FrmKina : Form
    {
        public FrmKina()
        {
            InitializeComponent();
        }

        private void btnDodajKino_Click(object sender, EventArgs e)
        {
            FrmDodajKino formDodajKino = new FrmDodajKino();
            this.Hide();
            formDodajKino.ShowDialog();
            this.Show();

            OsvjeziKina();
        }

        private void OsvjeziKina()
        {
            dgvKina.DataSource = null;
            dgvKina.DataSource = RepozitorijKina.DohvatiKina();

            dgvAdmini.DataSource = null;
            dgvAdmini.DataSource = RepozitorijKina.DohvatiAdmine(dohvatiTrenutnoKino());
        }

        private void FrmKina_Load(object sender, EventArgs e)
        {
            OsvjeziKina();
        }

        private void dgvKina_SelectionChanged(object sender, EventArgs e)
        {
            dgvAdmini.DataSource = null;
            dgvAdmini.DataSource = RepozitorijKina.DohvatiAdmine(dohvatiTrenutnoKino());
        }

        private void btnUrediKino_Click(object sender, EventArgs e)
        {
            FrmDodajKino formDodajKino = new FrmDodajKino(dohvatiTrenutnoKino());
            this.Hide();
            formDodajKino.ShowDialog();
            this.Show();

            OsvjeziKina();
        }

        private Kino dohvatiTrenutnoKino()
        {
            Kino odabranoKino = dgvKina.CurrentRow.DataBoundItem as Kino;
            return odabranoKino;
        }

        private Korisnik dohvatiTrenutnogAdmina()
        {
            Korisnik odabraniAdmin = dgvAdmini.CurrentRow.DataBoundItem as Korisnik;
            return odabraniAdmin;
        }

        private void btnUkloniKino_Click(object sender, EventArgs e)
        {
            RepozitorijKina.UkloniKino(dohvatiTrenutnoKino());

            OsvjeziKina();
        }

        private void btnDodajAdmina_Click(object sender, EventArgs e)
        {
            FrmDodajAdmina formDodajAdmina = new FrmDodajAdmina(dohvatiTrenutnoKino());
            this.Hide();
            formDodajAdmina.ShowDialog();
            this.Show();

            OsvjeziKina();
        }

        private void btnUrediAdmina_Click(object sender, EventArgs e)
        {
            FrmDodajAdmina formDodajAdmina = new FrmDodajAdmina(dohvatiTrenutnoKino(), dohvatiTrenutnogAdmina());
            this.Hide();
            formDodajAdmina.ShowDialog();
            this.Show();

            OsvjeziKina();
        }

        private void btnUkloniAdmina_Click(object sender, EventArgs e)
        {
            RepozitorijKina.UkloniAdmina(dohvatiTrenutnogAdmina());

            OsvjeziKina();
        }

        private void btnPosaljiPristupnePodatke_Click(object sender, EventArgs e)
        {
            Korisnik admin = dohvatiTrenutnogAdmina();
            Kino kino = dohvatiTrenutnoKino();

            PosiljateljPodataka.PosaljiMail(admin.korisnickoIme, admin.lozinka, kino.naziv, admin.email, admin.ime, admin.prezime);

            labelPoruka.Text = $"Uspješno poslani podaci na adresu {admin.email}!";
        }

        private void FrmKina_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            String path = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            Help.ShowHelp(this, path, HelpNavigator.TopicId, "1012");
        }
    }
}
