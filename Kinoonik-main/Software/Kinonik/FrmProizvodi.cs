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
    public partial class FrmProizvodi : Form
    {
        public FrmProizvodi()
        {
            InitializeComponent();
        }

        private void btnDodajProizvod_Click(object sender, EventArgs e)
        {
            FrmUrediProizvod frmUrediProizvod = new FrmUrediProizvod();
            frmUrediProizvod.ShowDialog();

            OsvjeziProizvode();
        }

        private void FrmProizvodi_Load(object sender, EventArgs e)
        {
            OsvjeziProizvode();
        }

        private void OsvjeziProizvode()
        {
            dgvProizvodi.DataSource = null;
            dgvProizvodi.DataSource = RepozitorijProizvodi.DohvatiProizvode();
            dgvProizvodi.Columns[0].HeaderText = "Šifra proizvoda";
            dgvProizvodi.Columns[1].HeaderText = "Naziv proizvoda";
            dgvProizvodi.Columns[2].HeaderText = "Cijena proizvoda (HRK)";
        }

        private void btnUkloniProizvod_Click(object sender, EventArgs e)
        {
            Proizvod odabraniProizvod = DohvatiOdabraniProizvod();
            RepozitorijProizvodi.UkloniProizvod(odabraniProizvod);

            OsvjeziProizvode();
        }

        private Proizvod DohvatiOdabraniProizvod()
        {
            Proizvod proizvod = dgvProizvodi.CurrentRow.DataBoundItem as Proizvod;
            return proizvod;
        }

        private void btnUrediProizvod_Click(object sender, EventArgs e)
        {
            FrmUrediProizvod frmUrediProizvod = new FrmUrediProizvod(DohvatiOdabraniProizvod());
            frmUrediProizvod.ShowDialog();

            OsvjeziProizvode();
        }

        private void FrmProizvodi_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            String path = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            Help.ShowHelp(this, path, HelpNavigator.TopicId, "1011");
        }
    }
}
