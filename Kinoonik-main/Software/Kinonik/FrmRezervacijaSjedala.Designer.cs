namespace Kinonik
{
    partial class FrmRezervacijaSjedala
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
            this.panelSjedala = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDvorana = new System.Windows.Forms.Label();
            this.labelFilm = new System.Windows.Forms.Label();
            this.labelVrijeme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnKupiKarte = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // panelSjedala
            // 
            this.panelSjedala.BackColor = System.Drawing.Color.White;
            this.panelSjedala.Location = new System.Drawing.Point(12, 101);
            this.panelSjedala.Name = "panelSjedala";
            this.panelSjedala.Size = new System.Drawing.Size(1629, 897);
            this.panelSjedala.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "PLATNO";
            // 
            // labelDvorana
            // 
            this.labelDvorana.AutoSize = true;
            this.labelDvorana.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDvorana.Location = new System.Drawing.Point(12, 9);
            this.labelDvorana.Name = "labelDvorana";
            this.labelDvorana.Size = new System.Drawing.Size(156, 31);
            this.labelDvorana.TabIndex = 14;
            this.labelDvorana.Text = "DVORANA";
            // 
            // labelFilm
            // 
            this.labelFilm.AutoSize = true;
            this.labelFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilm.Location = new System.Drawing.Point(299, 9);
            this.labelFilm.Name = "labelFilm";
            this.labelFilm.Size = new System.Drawing.Size(80, 31);
            this.labelFilm.TabIndex = 15;
            this.labelFilm.Text = "FILM";
            // 
            // labelVrijeme
            // 
            this.labelVrijeme.AutoSize = true;
            this.labelVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVrijeme.Location = new System.Drawing.Point(12, 53);
            this.labelVrijeme.Name = "labelVrijeme";
            this.labelVrijeme.Size = new System.Drawing.Size(139, 31);
            this.labelVrijeme.TabIndex = 16;
            this.labelVrijeme.Text = "VRIJEME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(883, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Email kupca:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(957, 21);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(252, 20);
            this.txtEmail.TabIndex = 18;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(1647, 948);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(107, 50);
            this.btnOdustani.TabIndex = 19;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnKupiKarte
            // 
            this.btnKupiKarte.Location = new System.Drawing.Point(1647, 892);
            this.btnKupiKarte.Name = "btnKupiKarte";
            this.btnKupiKarte.Size = new System.Drawing.Size(107, 50);
            this.btnKupiKarte.TabIndex = 20;
            this.btnKupiKarte.Text = "Kupi karte";
            this.btnKupiKarte.UseVisualStyleBackColor = true;
            this.btnKupiKarte.Click += new System.EventHandler(this.btnKupiKarte_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Roko\\Documents\\pi22-mmihaljev-arados-rmilosevi\\Software\\Kinonik\\help.chm" +
    "";
            // 
            // FrmRezervacijaSjedala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1766, 1010);
            this.Controls.Add(this.btnKupiKarte);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelVrijeme);
            this.Controls.Add(this.labelFilm);
            this.Controls.Add(this.labelDvorana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelSjedala);
            this.Name = "FrmRezervacijaSjedala";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRezervacijaSjedala";
            this.Load += new System.EventHandler(this.FrmRezervacijaSjedala_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmRezervacijaSjedala_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelSjedala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDvorana;
        private System.Windows.Forms.Label labelFilm;
        private System.Windows.Forms.Label labelVrijeme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnKupiKarte;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}