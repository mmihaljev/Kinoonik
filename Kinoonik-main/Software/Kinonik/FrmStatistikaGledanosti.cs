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
    public partial class FrmStatistikaGledanosti : Form
    {
        public Kino trenutnoKino { get; set; }
        public FrmStatistikaGledanosti()
        {
            InitializeComponent();
        }

        private void FrmStatistikaGledanosti_Load(object sender, EventArgs e)
        {
            trenutnoKino = RepozitorijDvorane.DohvatiKino(RepozitorijPrijava.prijavljeniKorisnik);

            labelKino.Text = trenutnoKino.naziv;
            //Upisuje ukupan broj prodanih karata
            labelProdaneUkupno.Text = RepozitorijGledanost.dohvatiBrojKarata(trenutnoKino.idKina).ToString();

            //Podloga za dgv za gledanost po filmu
            dgvPoFilmu.DataSource = RepozitorijGledanost.dohvatiBrojKarataPoFilmu(trenutnoKino.idKina);
            dgvPoFilmu.Columns[0].HeaderText = "Film";
            dgvPoFilmu.Columns[1].HeaderText = "Broj gledatelja";

            //Postavljanje grafa
            List<KeyValuePair<Film, int>> filmovi = RepozitorijGledanost.dohvatiBrojKarataPoFilmu(trenutnoKino.idKina);

            foreach (KeyValuePair<Film, int> film in filmovi)
            {
                chartGledanost.Series["Gledanost"].Points.AddXY(film.Key.nazivFilma, film.Value);
            }

            chartGledanost.Titles.Add("Gledanost po filmu");
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            labelProdaneDatumi.Text = RepozitorijGledanost.dohvatiBrojKarataPoDatumu(trenutnoKino.idKina, dateTimePickerPocetak.Value, dateTimePickerZavrsetak.Value).ToString();
        }

        private void FrmStatistikaGledanosti_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            String path = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            Help.ShowHelp(this, path, HelpNavigator.TopicId, "1008");
        }
    }
}
