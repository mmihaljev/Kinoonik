using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinonik
{
    public partial class UCSjedalo : UserControl
    {
        public int idSjedala { get; set; }
        public string red { get; set; }
        public int brojSjedala { get; set; }
        public bool postoji { get; set; } = true;
        public bool rezervirano { get; set; } = false;
        public bool zakljucano { get; set; } = false;
        public int idDvorane { get; set; }
        public string oznakaSjedala { get; set; }
        public UCSjedalo()
        {
            InitializeComponent();
        }

        private void pboxSjedalo_Click(object sender, EventArgs e)
        {
            if (this.zakljucano == false && this.postoji == true)
            {
                this.postoji = false;
                pboxSjedalo.BackColor = Color.Red;
            }
            else if (this.zakljucano == false && this.postoji == false)
            {
                this.postoji = true;
                pboxSjedalo.BackColor = Color.Green;
            }
            else if (this.zakljucano == true && this.postoji == true && this.rezervirano == false)
            {
                this.rezervirano = true;
                pboxSjedalo.BackColor = Color.Blue;
            }
            else if (this.zakljucano == true && this.postoji == true && this.rezervirano == true)
            {
                this.rezervirano = false;
                pboxSjedalo.BackColor = Color.Green;
            }
        }

        private void UCSjedalo_Load(object sender, EventArgs e)
        {
            /*
            pboxSjedalo.BackColor = Color.Green;
            this.postoji = true;
            this.zakljucano = false;
            this.rezervirano = false;
            this.kupljeno = false;
            */
        }
    }
}
