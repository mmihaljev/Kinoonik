
namespace Kinonik
{
    partial class FrmUpravljanjeFilmovima
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
            this.dgvFilmovi = new System.Windows.Forms.DataGridView();
            this.buttonDodajFilm = new System.Windows.Forms.Button();
            this.buttonUrediFilm = new System.Windows.Forms.Button();
            this.buttonUkloniFilm = new System.Windows.Forms.Button();
            this.labelObavijest = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filmovi:";
            // 
            // dgvFilmovi
            // 
            this.dgvFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmovi.Location = new System.Drawing.Point(4, 22);
            this.dgvFilmovi.Name = "dgvFilmovi";
            this.dgvFilmovi.Size = new System.Drawing.Size(708, 276);
            this.dgvFilmovi.TabIndex = 1;
            // 
            // buttonDodajFilm
            // 
            this.buttonDodajFilm.Location = new System.Drawing.Point(4, 304);
            this.buttonDodajFilm.Name = "buttonDodajFilm";
            this.buttonDodajFilm.Size = new System.Drawing.Size(91, 46);
            this.buttonDodajFilm.TabIndex = 2;
            this.buttonDodajFilm.Text = "Dodaj film";
            this.buttonDodajFilm.UseVisualStyleBackColor = true;
            this.buttonDodajFilm.Click += new System.EventHandler(this.buttonDodajFilm_Click);
            // 
            // buttonUrediFilm
            // 
            this.buttonUrediFilm.Location = new System.Drawing.Point(101, 304);
            this.buttonUrediFilm.Name = "buttonUrediFilm";
            this.buttonUrediFilm.Size = new System.Drawing.Size(91, 46);
            this.buttonUrediFilm.TabIndex = 3;
            this.buttonUrediFilm.Text = "Uredi film";
            this.buttonUrediFilm.UseVisualStyleBackColor = true;
            this.buttonUrediFilm.Click += new System.EventHandler(this.buttonUrediFilm_Click);
            // 
            // buttonUkloniFilm
            // 
            this.buttonUkloniFilm.Location = new System.Drawing.Point(198, 304);
            this.buttonUkloniFilm.Name = "buttonUkloniFilm";
            this.buttonUkloniFilm.Size = new System.Drawing.Size(91, 46);
            this.buttonUkloniFilm.TabIndex = 4;
            this.buttonUkloniFilm.Text = "Ukloni film";
            this.buttonUkloniFilm.UseVisualStyleBackColor = true;
            this.buttonUkloniFilm.Click += new System.EventHandler(this.buttonUkloniFilm_Click);
            // 
            // labelObavijest
            // 
            this.labelObavijest.AutoSize = true;
            this.labelObavijest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObavijest.Location = new System.Drawing.Point(345, 316);
            this.labelObavijest.Name = "labelObavijest";
            this.labelObavijest.Size = new System.Drawing.Size(90, 20);
            this.labelObavijest.TabIndex = 5;
            this.labelObavijest.Text = "Obavijest ...";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Roko\\Documents\\pi22-mmihaljev-arados-rmilosevi\\Software\\Kinonik\\help.chm" +
    "";
            // 
            // FrmUpravljanjeFilmovima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 359);
            this.Controls.Add(this.labelObavijest);
            this.Controls.Add(this.buttonUkloniFilm);
            this.Controls.Add(this.buttonUrediFilm);
            this.Controls.Add(this.buttonDodajFilm);
            this.Controls.Add(this.dgvFilmovi);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpravljanjeFilmovima";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upravljanje filmovima";
            this.Load += new System.EventHandler(this.FrmUpravljanjeFilmovima_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmUpravljanjeFilmovima_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFilmovi;
        private System.Windows.Forms.Button buttonDodajFilm;
        private System.Windows.Forms.Button buttonUrediFilm;
        private System.Windows.Forms.Button buttonUkloniFilm;
        private System.Windows.Forms.Label labelObavijest;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}