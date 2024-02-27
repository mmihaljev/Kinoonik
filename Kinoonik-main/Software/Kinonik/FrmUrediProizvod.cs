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
    public partial class FrmUrediProizvod : Form
    {
        public Proizvod odabraniProizvod { get; set; } = null;

        public FrmUrediProizvod()
        {
            InitializeComponent();
        }

        public FrmUrediProizvod(Proizvod proizvod)
        {
            InitializeComponent();
            odabraniProizvod = proizvod;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            try
            {
                ProvjeraPolja();

                if (odabraniProizvod == null)
                {
                    Proizvod noviProizvod = new Proizvod();

                    noviProizvod.naziv = txtNazivProizvoda.Text;
                    noviProizvod.cijena = double.Parse(txtCijena.Text);

                    RepozitorijProizvodi.DodajProizvod(noviProizvod);

                    Close();
                }
                else
                {
                    odabraniProizvod.naziv = txtNazivProizvoda.Text;
                    odabraniProizvod.cijena = double.Parse(txtCijena.Text);

                    RepozitorijProizvodi.UrediProizvod(odabraniProizvod);

                    Close();
                }
            }
            catch (Iznimke.PraznaPoljaException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private void FrmUrediProizvod_Load(object sender, EventArgs e)
        {
            if (odabraniProizvod != null)
            {
                txtNazivProizvoda.Text = odabraniProizvod.naziv;
                txtCijena.Text = odabraniProizvod.cijena.ToString();
            }
        }

        private void ProvjeraPolja()
        {
            if (txtCijena.Text == "" || txtCijena.Text == "")
            {
                throw new Iznimke.PraznaPoljaException("Sva polja moraju biti popunjena!");
            }
        }

        private void FrmUrediProizvod_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            String path = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            Help.ShowHelp(this, path, HelpNavigator.TopicId, "1005");
        }
    }
}
