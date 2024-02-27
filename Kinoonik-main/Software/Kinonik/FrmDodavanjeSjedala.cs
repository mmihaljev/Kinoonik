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
    public partial class FrmDodavanjeSjedala : Form
    {
        //Oznaka reda koja se inkrementira
        private char redOznaka = 'A';
        public List<UCSjedalo> sjedala { get; set; }
        public Dvorana trenutnaDvorana { get; set; }
        public Kino trenutnoKino { get; set; }
        public FrmDodavanjeSjedala(Dvorana dvorana, Kino kino)
        {
            InitializeComponent();
            sjedala = new List<UCSjedalo>();

            trenutnaDvorana = dvorana;
            trenutnoKino = kino;
        }

        //Ako nisu unesena sjedala briše novu dvoranu
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            RepozitorijDvorane.UkloniDvoranu(trenutnaDvorana);
            Close();
        }

        //Dodaje red sjedala na panel
        private void btnDodajRed_Click(object sender, EventArgs e)
        {
            try
            {
                ProvjeraPolja();

                int maksSjedala = int.Parse(txtMaksSjedala.Text);

                txtMaksSjedala.Enabled = false;

                for (int i = 0; i < maksSjedala; i++)
                {
                    UCSjedalo sjedalo = new UCSjedalo();

                    sjedalo.red = redOznaka.ToString();
                    sjedalo.brojSjedala = i + 1;
                    sjedalo.oznakaSjedala = $"{redOznaka}{i + 1}";
                    sjedalo.idDvorane = trenutnaDvorana.idDvorane;

                    panelDvorana.Controls.Add(sjedalo);

                    sjedala.Add(sjedalo);
                }

                Label oznakaReda = new Label();
                oznakaReda.Text = this.redOznaka++.ToString();

                Font labelFont = new Font("Arial", 15, FontStyle.Bold);
                oznakaReda.Font = labelFont;

                panelDvorana.Controls.Add(oznakaReda);
                panelDvorana.SetFlowBreak(oznakaReda, true);
            }
            catch (Iznimke.PraznaPoljaException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                ProvjeraSjedala();

                foreach (UCSjedalo sjedalo in sjedala)
                {
                    sjedalo.zakljucano = true;

                    RepozitorijDvorane.DodajSjedalo(sjedalo);
                }

                Close();
            }
            catch (Iznimke.PraznaPoljaException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        //Omogućuje prikaz dvorane bez isključenih sjedala
        private void btnKonacanPregled_Click(object sender, EventArgs e)
        {
            foreach (UCSjedalo sjedalo in sjedala)
            {
                if (sjedalo.postoji == false)
                {
                    sjedalo.pboxSjedalo.BackColor = Color.White;
                    sjedalo.Enabled = false;
                }
                else
                {
                    sjedalo.pboxSjedalo.BackColor = Color.Green;
                    sjedalo.Enabled = true;
                }
            }
        }

        private void FrmDodavanjeSjedala_Load(object sender, EventArgs e)
        {
            labelKino.Text = trenutnoKino.naziv;
            labelDvorana.Text = trenutnaDvorana.nazivDvorane;
        }

        //Onemogućuje dodavanje dvorane bez sjedala
        private void ProvjeraSjedala()
        {
            if (sjedala.Count == 0)
            {
                throw new Iznimke.PraznaPoljaException("Dvorana mora imati sjedala!");
            }
        }

        private void FrmDodavanjeSjedala_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            String path = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            Help.ShowHelp(this, path, HelpNavigator.TopicId, "1004");
        }

        //Provjerava je li unesen maksimalan broj sjedala u redu
        private void ProvjeraPolja()
        {
            if (txtMaksSjedala.Text == "")
            {
                throw new Iznimke.PraznaPoljaException("Prvo morate upisati maksimalan broj sjedala!");
            }
        }
    }
}
