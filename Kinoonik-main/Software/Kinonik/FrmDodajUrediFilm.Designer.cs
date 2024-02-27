
namespace Kinonik
{
    partial class FrmDodajUrediFilm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNazivFilma = new System.Windows.Forms.TextBox();
            this.textBoxTrajanjeFilma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRedatelj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCijenaKarte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPotvrdi = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv filma:";
            // 
            // textBoxNazivFilma
            // 
            this.textBoxNazivFilma.Location = new System.Drawing.Point(32, 32);
            this.textBoxNazivFilma.Name = "textBoxNazivFilma";
            this.textBoxNazivFilma.Size = new System.Drawing.Size(168, 20);
            this.textBoxNazivFilma.TabIndex = 1;
            // 
            // textBoxTrajanjeFilma
            // 
            this.textBoxTrajanjeFilma.Location = new System.Drawing.Point(32, 79);
            this.textBoxTrajanjeFilma.Name = "textBoxTrajanjeFilma";
            this.textBoxTrajanjeFilma.Size = new System.Drawing.Size(168, 20);
            this.textBoxTrajanjeFilma.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trajanje filma (u minutama):";
            // 
            // textBoxRedatelj
            // 
            this.textBoxRedatelj.Location = new System.Drawing.Point(32, 127);
            this.textBoxRedatelj.Name = "textBoxRedatelj";
            this.textBoxRedatelj.Size = new System.Drawing.Size(168, 20);
            this.textBoxRedatelj.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Redatelj:";
            // 
            // textBoxCijenaKarte
            // 
            this.textBoxCijenaKarte.Location = new System.Drawing.Point(32, 176);
            this.textBoxCijenaKarte.Name = "textBoxCijenaKarte";
            this.textBoxCijenaKarte.Size = new System.Drawing.Size(168, 20);
            this.textBoxCijenaKarte.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cijena karte (u kunama):";
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(32, 227);
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(168, 141);
            this.textBoxOpis.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Opis:";
            // 
            // buttonPotvrdi
            // 
            this.buttonPotvrdi.Location = new System.Drawing.Point(21, 383);
            this.buttonPotvrdi.Name = "buttonPotvrdi";
            this.buttonPotvrdi.Size = new System.Drawing.Size(96, 30);
            this.buttonPotvrdi.TabIndex = 10;
            this.buttonPotvrdi.Text = "Potvrdi";
            this.buttonPotvrdi.UseVisualStyleBackColor = true;
            this.buttonPotvrdi.Click += new System.EventHandler(this.buttonPotvrdi_Click);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(123, 383);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(96, 30);
            this.buttonOdustani.TabIndex = 11;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Roko\\Documents\\pi22-mmihaljev-arados-rmilosevi\\Software\\Kinonik\\help.chm" +
    "";
            // 
            // FrmDodajUrediFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 450);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonPotvrdi);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCijenaKarte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRedatelj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTrajanjeFilma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNazivFilma);
            this.Controls.Add(this.label1);
            this.Name = "FrmDodajUrediFilm";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje/uređivanje filma";
            this.Load += new System.EventHandler(this.FrmDodajUrediFilm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmDodajUrediFilm_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNazivFilma;
        private System.Windows.Forms.TextBox textBoxTrajanjeFilma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRedatelj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCijenaKarte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPotvrdi;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}