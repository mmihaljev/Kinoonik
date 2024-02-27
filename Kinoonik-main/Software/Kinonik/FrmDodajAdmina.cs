using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneratorPodatakaDll;
using System.Reflection;
using System.IO;

namespace Kinonik
{
    public partial class FrmDodajAdmina : Form
    {
        public Kino kinoAdmina { get; set; } = null;
        public Korisnik administrator { get; set; } = null;
        public FrmDodajAdmina(Kino kino)
        {
            InitializeComponent();
            kinoAdmina = kino;
        }
        public FrmDodajAdmina(Kino kino, Korisnik admin)
        {
            InitializeComponent();
            kinoAdmina = kino;
            administrator = admin;
        }

        private void FrmDodajAdmina_Load(object sender, EventArgs e)
        {
            txtKino.Text = kinoAdmina.naziv;
            txtKino.Enabled = false;

            List<string> spol = new List<string>() {"Muško", "Žensko"};
            cmbSpol.DataSource = spol;

            //Ako je uređivanje onda se učitavaju podaci
            if (administrator != null)
            {
                txtIme.Text = administrator.ime;
                txtPrezime.Text = administrator.prezime;
                txtEmail.Text = administrator.email;
                txtTel.Text = administrator.email;
                cmbSpol.SelectedItem = administrator.spol;
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Dodaje ili uređuje trenutnog admina
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            try
            {
                ProvjeriUnosPolja();

                if (administrator == null)
                {
                    Korisnik noviAdmin = new Korisnik();
                    noviAdmin.ime = txtIme.Text;
                    noviAdmin.prezime = txtPrezime.Text;
                    noviAdmin.uloga = Uloga.Administrator;
                    noviAdmin.email = txtEmail.Text;
                    noviAdmin.spol = cmbSpol.Text;
                    noviAdmin.brojTelefona = txtTel.Text;

                    GeneratorPristupnihPodataka generator = new GeneratorPristupnihPodataka();
                    noviAdmin.korisnickoIme = generator.GenerirajKorisnickoIme(noviAdmin.ime, noviAdmin.prezime);
                    noviAdmin.lozinka = generator.GenerirajLozinku();

                    noviAdmin.kino = kinoAdmina.idKina;

                    RepozitorijKina.DodajAdmina(noviAdmin);

                    Close();
                }
                else
                {
                    administrator.ime = txtIme.Text;
                    administrator.prezime = txtPrezime.Text;
                    administrator.uloga = Uloga.Administrator;
                    administrator.email = txtEmail.Text;
                    administrator.spol = cmbSpol.Text;
                    administrator.brojTelefona = txtTel.Text;

                    RepozitorijKina.UrediAdmina(administrator);

                    Close();
                }
            }
            catch (Iznimke.PraznaPoljaException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        //Provjerava jesu li upisani svi podaci
        private void ProvjeriUnosPolja()
        {
            if (txtIme.Text == "" || txtPrezime.Text == "" || txtEmail.Text == "" || txtTel.Text == "")
            {
                throw new Iznimke.PraznaPoljaException("Sva polja moraju biti popunjena");
            }
        }

        private void FrmDodajAdmina_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            String path = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            Help.ShowHelp(this, path, HelpNavigator.TopicId, "1018");
        }
    }
}
