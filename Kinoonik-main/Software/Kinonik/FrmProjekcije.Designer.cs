namespace Kinonik
{
    partial class FrmProjekcije
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
            this.dgvProjekcije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKupiKarte = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.dgvFilmovi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekcije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProjekcije
            // 
            this.dgvProjekcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjekcije.Location = new System.Drawing.Point(228, 32);
            this.dgvProjekcije.Name = "dgvProjekcije";
            this.dgvProjekcije.Size = new System.Drawing.Size(372, 262);
            this.dgvProjekcije.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Projekcije:";
            // 
            // btnKupiKarte
            // 
            this.btnKupiKarte.Location = new System.Drawing.Point(12, 300);
            this.btnKupiKarte.Name = "btnKupiKarte";
            this.btnKupiKarte.Size = new System.Drawing.Size(90, 47);
            this.btnKupiKarte.TabIndex = 2;
            this.btnKupiKarte.Text = "Kupi karte";
            this.btnKupiKarte.UseVisualStyleBackColor = true;
            this.btnKupiKarte.Click += new System.EventHandler(this.btnKupiKarte_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(108, 300);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(90, 47);
            this.btnOdustani.TabIndex = 3;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // dgvFilmovi
            // 
            this.dgvFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmovi.Location = new System.Drawing.Point(12, 32);
            this.dgvFilmovi.Name = "dgvFilmovi";
            this.dgvFilmovi.Size = new System.Drawing.Size(186, 262);
            this.dgvFilmovi.TabIndex = 4;
            this.dgvFilmovi.SelectionChanged += new System.EventHandler(this.dgvFilmovi_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filmovi:";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Roko\\Documents\\pi22-mmihaljev-arados-rmilosevi\\Software\\Kinonik\\help.chm" +
    "";
            // 
            // FrmProjekcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 359);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFilmovi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnKupiKarte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProjekcije);
            this.Name = "FrmProjekcije";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProjekcije";
            this.Load += new System.EventHandler(this.FrmProjekcije_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmProjekcije_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekcije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProjekcije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKupiKarte;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.DataGridView dgvFilmovi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}