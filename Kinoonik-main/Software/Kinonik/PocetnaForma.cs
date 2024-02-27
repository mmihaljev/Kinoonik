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
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {
            switch(RepozitorijPrijava.prijavljeniKorisnik.uloga)
            {
                case Uloga.Zaposlenik:
                    {
                        buttonUpravljanjeFilmovima.Visible = false;
                        buttonUpravljanjeTerminima.Visible = true;
                        btnUpravljanjeKinima.Visible = false;
                        btnUpravljanjeDvoranama.Visible = false;
                        buttonUpravljanjeProizvodima.Visible = false;
                        btnStatistikaGledanosti.Visible = false;
                        break;
                    };
                case Uloga.Administrator:
                    {
                        buttonUpravljanjeFilmovima.Visible = true;
                        buttonUpravljanjeTerminima.Visible = true;
                        btnUpravljanjeKinima.Visible = false;
                        break;
                    }
                case Uloga.Superadmin:
                    {
                        buttonUpravljanjeFilmovima.Visible = false;
                        buttonUpravljanjeTerminima.Visible = false;
                        btnKupiKartu.Visible = false;
                        btnUpravljanjeDvoranama.Visible = false;
                        buttonUpravljanjeProizvodima.Visible = false;
                        btnStatistikaGledanosti.Visible = false;
                        break;
                    }
            }
            labelKorisnickoIme.Text = $"Korisničko ime: {RepozitorijPrijava.prijavljeniKorisnik.korisnickoIme}";
            labelUloga.Text = $"Uloga: {RepozitorijPrijava.prijavljeniKorisnik.uloga}";

        }

        private void buttonUpravljanjeFilmovima_Click(object sender, EventArgs e)
        {
            FrmUpravljanjeFilmovima form = new FrmUpravljanjeFilmovima();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void buttonUpravljanjeTerminima_Click(object sender, EventArgs e)
        {
            FrmUpravljanjeTerminima form = new FrmUpravljanjeTerminima();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void buttonUpravljanjeProizvodima_Click(object sender, EventArgs e)
        {
            FrmProizvodi formProizvodi = new FrmProizvodi();
            this.Hide();
            formProizvodi.ShowDialog();
            this.Show();
        }

        private void btnUpravljanjeKinima_Click(object sender, EventArgs e)
        {
            FrmKina formKina = new FrmKina();
            this.Hide();
            formKina.ShowDialog();
            this.Show();
        }

        private void btnUpravljanjeDvoranama_Click(object sender, EventArgs e)
        {
            FrmDvorane formDvorane = new FrmDvorane();
            this.Hide();
            formDvorane.ShowDialog();
            this.Show();
        }

        private void btnKupiKartu_Click(object sender, EventArgs e)
        {
            FrmProjekcije formProjekcije = new FrmProjekcije();
            this.Hide();
            formProjekcije.ShowDialog();
            this.Show();
        }

        private void btnStatistikaGledanosti_Click(object sender, EventArgs e)
        {
            FrmStatistikaGledanosti formGledanost = new FrmStatistikaGledanosti();
            this.Hide();
            formGledanost.ShowDialog();
            this.Show();
        }

        private void PocetnaForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            String path = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            if(RepozitorijPrijava.prijavljeniKorisnik.uloga == Uloga.Administrator)
            {
                Help.ShowHelp(this, path, HelpNavigator.TopicId, "1001");
            }
            else if(RepozitorijPrijava.prijavljeniKorisnik.uloga == Uloga.Superadmin)
            {
                Help.ShowHelp(this, path, HelpNavigator.TopicId, "1003");
            }
            else
            {
                Help.ShowHelp(this, path, HelpNavigator.TopicId, "1002");
            }
            
        }
    }
}
