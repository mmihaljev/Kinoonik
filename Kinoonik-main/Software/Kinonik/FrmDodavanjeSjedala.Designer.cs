namespace Kinonik
{
    partial class FrmDodavanjeSjedala
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
            this.btnDodajRed = new System.Windows.Forms.Button();
            this.txtMaksSjedala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDvorana = new System.Windows.Forms.FlowLayoutPanel();
            this.labelKino = new System.Windows.Forms.Label();
            this.btnKonacanPregled = new System.Windows.Forms.Button();
            this.labelDvorana = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // btnDodajRed
            // 
            this.btnDodajRed.Location = new System.Drawing.Point(1647, 101);
            this.btnDodajRed.Name = "btnDodajRed";
            this.btnDodajRed.Size = new System.Drawing.Size(107, 44);
            this.btnDodajRed.TabIndex = 1;
            this.btnDodajRed.Text = "Dodaj red";
            this.btnDodajRed.UseVisualStyleBackColor = true;
            this.btnDodajRed.Click += new System.EventHandler(this.btnDodajRed_Click);
            // 
            // txtMaksSjedala
            // 
            this.txtMaksSjedala.Location = new System.Drawing.Point(1001, 68);
            this.txtMaksSjedala.Name = "txtMaksSjedala";
            this.txtMaksSjedala.Size = new System.Drawing.Size(149, 20);
            this.txtMaksSjedala.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(737, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Maksimalan broj sjedala u jednom redu:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(1647, 954);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(107, 44);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(1647, 904);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(107, 44);
            this.btnSpremi.TabIndex = 5;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "PLATNO";
            // 
            // panelDvorana
            // 
            this.panelDvorana.BackColor = System.Drawing.Color.White;
            this.panelDvorana.Location = new System.Drawing.Point(12, 101);
            this.panelDvorana.Name = "panelDvorana";
            this.panelDvorana.Size = new System.Drawing.Size(1629, 897);
            this.panelDvorana.TabIndex = 8;
            // 
            // labelKino
            // 
            this.labelKino.AutoSize = true;
            this.labelKino.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKino.Location = new System.Drawing.Point(12, 9);
            this.labelKino.Name = "labelKino";
            this.labelKino.Size = new System.Drawing.Size(85, 31);
            this.labelKino.TabIndex = 9;
            this.labelKino.Text = "KINO";
            // 
            // btnKonacanPregled
            // 
            this.btnKonacanPregled.Location = new System.Drawing.Point(1647, 587);
            this.btnKonacanPregled.Name = "btnKonacanPregled";
            this.btnKonacanPregled.Size = new System.Drawing.Size(107, 44);
            this.btnKonacanPregled.TabIndex = 12;
            this.btnKonacanPregled.Text = "Konačan prikaz dvorane";
            this.btnKonacanPregled.UseVisualStyleBackColor = true;
            this.btnKonacanPregled.Click += new System.EventHandler(this.btnKonacanPregled_Click);
            // 
            // labelDvorana
            // 
            this.labelDvorana.AutoSize = true;
            this.labelDvorana.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDvorana.Location = new System.Drawing.Point(12, 54);
            this.labelDvorana.Name = "labelDvorana";
            this.labelDvorana.Size = new System.Drawing.Size(156, 31);
            this.labelDvorana.TabIndex = 13;
            this.labelDvorana.Text = "DVORANA";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Roko\\Documents\\pi22-mmihaljev-arados-rmilosevi\\Software\\Kinonik\\help.chm" +
    "";
            // 
            // FrmDodavanjeSjedala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1766, 1010);
            this.Controls.Add(this.labelDvorana);
            this.Controls.Add(this.btnKonacanPregled);
            this.Controls.Add(this.labelKino);
            this.Controls.Add(this.panelDvorana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaksSjedala);
            this.Controls.Add(this.btnDodajRed);
            this.Name = "FrmDodavanjeSjedala";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDodavanjeDvorane";
            this.Load += new System.EventHandler(this.FrmDodavanjeSjedala_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmDodavanjeSjedala_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajRed;
        private System.Windows.Forms.TextBox txtMaksSjedala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.FlowLayoutPanel panelDvorana;
        private System.Windows.Forms.Label labelKino;
        private System.Windows.Forms.Button btnKonacanPregled;
        private System.Windows.Forms.Label labelDvorana;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}