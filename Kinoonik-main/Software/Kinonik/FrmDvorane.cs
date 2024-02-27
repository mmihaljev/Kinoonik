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
    public partial class FrmDvorane : Form
    {
        public FrmDvorane()
        {
            InitializeComponent();
        }

        private void btnDodajDvoranu_Click(object sender, EventArgs e)
        {
            FrmDodavanjeDvorane formDodajDvoranu = new FrmDodavanjeDvorane();
            this.Hide();
            formDodajDvoranu.ShowDialog();
            this.Show();

            OsvjeziDvorane();
        }

        private void FrmDvorane_Load(object sender, EventArgs e)
        {
            OsvjeziDvorane();

            labelKino.Text = RepozitorijDvorane.DohvatiKino(RepozitorijPrijava.prijavljeniKorisnik).naziv;
        }

        private void OsvjeziDvorane()
        {
            dgvDvorane.DataSource = null;
            dgvDvorane.DataSource = RepozitorijDvorane.DohvatiDvorane(RepozitorijDvorane.DohvatiKino(RepozitorijPrijava.prijavljeniKorisnik));

            dgvDvorane.Columns[0].Visible = false;
            dgvDvorane.Columns[1].Visible = false;
            dgvDvorane.Columns[2].HeaderText = "Dvorana";
        }

        private void btnUkloniDvoranu_Click(object sender, EventArgs e)
        {
            Dvorana odabranaDvorana = dgvDvorane.CurrentRow.DataBoundItem as Dvorana;

            RepozitorijDvorane.UkloniDvoranu(odabranaDvorana);

            OsvjeziDvorane();
        }

        private void FrmDvorane_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            String path = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            Help.ShowHelp(this, path, HelpNavigator.TopicId, "1013");
        }
    }
}
