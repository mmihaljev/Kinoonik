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
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPrijaviSe_Click(object sender, EventArgs e)
        {
            if(RepozitorijPrijava.PrijaviSe(textBoxKorisnickoIme.Text, textBoxLozinka.Text)==true)
            {
                Form form = new PocetnaForma();
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Netočni korisnički podaci!");
            }
            textBoxKorisnickoIme.Clear();
            textBoxLozinka.Clear();
            this.Show();
        }

        // Funkcija izračunava relativnu putanju do .chm datoteke i daje do znanja koju stranicu .chm datoteke je potrebno otvoriti
        private void FrmPrijava_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            String path = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            Help.ShowHelp(this, path, HelpNavigator.TopicId, "1000");
        }
    }
}
