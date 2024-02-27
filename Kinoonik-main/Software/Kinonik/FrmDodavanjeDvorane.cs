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
    public partial class FrmDodavanjeDvorane : Form
    {
        public FrmDodavanjeDvorane()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            //Prvo se dodaje nova dvorana
            Kino trenutnoKino = RepozitorijDvorane.DohvatiKino(RepozitorijPrijava.prijavljeniKorisnik);

            Dvorana dvorana = new Dvorana();

            dvorana.idKina = trenutnoKino.idKina;
            dvorana.nazivDvorane = txtNazivDvorane.Text;

            RepozitorijDvorane.DodajDvorane(dvorana);

            //Dohvaca se isto iz baze za id
            dvorana = RepozitorijDvorane.DohvatiDvoranu(txtNazivDvorane.Text, trenutnoKino.idKina);

            //Poziva se forma sa sjedalima
            FrmDodavanjeSjedala formDodajDvoranu = new FrmDodavanjeSjedala(dvorana, trenutnoKino);
            this.Hide();
            formDodajDvoranu.ShowDialog();
            Close();
        }

        private void FrmDodavanjeDvorane_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            String path = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            Help.ShowHelp(this, path, HelpNavigator.TopicId, "1014");
        }
    }
}
