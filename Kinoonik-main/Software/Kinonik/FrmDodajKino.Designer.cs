namespace Kinonik
{
    partial class FrmDodajKino
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
            this.groupKino = new System.Windows.Forms.GroupBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.txtVlasnik = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtKompanija = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupKino.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupKino
            // 
            this.groupKino.Controls.Add(this.txtKontakt);
            this.groupKino.Controls.Add(this.txtVlasnik);
            this.groupKino.Controls.Add(this.txtAdresa);
            this.groupKino.Controls.Add(this.txtKompanija);
            this.groupKino.Controls.Add(this.txtNaziv);
            this.groupKino.Controls.Add(this.label5);
            this.groupKino.Controls.Add(this.label4);
            this.groupKino.Controls.Add(this.label3);
            this.groupKino.Controls.Add(this.label2);
            this.groupKino.Controls.Add(this.label1);
            this.groupKino.Location = new System.Drawing.Point(12, 12);
            this.groupKino.Name = "groupKino";
            this.groupKino.Size = new System.Drawing.Size(257, 164);
            this.groupKino.TabIndex = 0;
            this.groupKino.TabStop = false;
            this.groupKino.Text = "Kino:";
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(108, 129);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(143, 20);
            this.txtKontakt.TabIndex = 10;
            // 
            // txtVlasnik
            // 
            this.txtVlasnik.Location = new System.Drawing.Point(108, 103);
            this.txtVlasnik.Name = "txtVlasnik";
            this.txtVlasnik.Size = new System.Drawing.Size(143, 20);
            this.txtVlasnik.TabIndex = 9;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(108, 77);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(143, 20);
            this.txtAdresa.TabIndex = 8;
            // 
            // txtKompanija
            // 
            this.txtKompanija.Location = new System.Drawing.Point(108, 50);
            this.txtKompanija.Name = "txtKompanija";
            this.txtKompanija.Size = new System.Drawing.Size(143, 20);
            this.txtKompanija.TabIndex = 7;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(108, 23);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(143, 20);
            this.txtNaziv.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kontakt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vlasnik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kompanija:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv:";
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(31, 191);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(89, 40);
            this.btnPotvrdi.TabIndex = 2;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(146, 191);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(89, 40);
            this.btnOdustani.TabIndex = 3;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Roko\\Documents\\pi22-mmihaljev-arados-rmilosevi\\Software\\Kinonik\\help.chm" +
    "";
            // 
            // FrmDodajKino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 249);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.groupKino);
            this.Name = "FrmDodajKino";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDodajKino";
            this.Load += new System.EventHandler(this.FrmDodajKino_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmDodajKino_HelpRequested);
            this.groupKino.ResumeLayout(false);
            this.groupKino.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupKino;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.TextBox txtVlasnik;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtKompanija;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}