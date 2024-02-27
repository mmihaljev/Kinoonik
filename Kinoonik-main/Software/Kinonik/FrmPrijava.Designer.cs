
namespace Kinonik
{
    partial class FrmPrijava
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
            this.textBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPrijaviSe = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.helpProviderPrijava = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime:";
            // 
            // textBoxKorisnickoIme
            // 
            this.textBoxKorisnickoIme.Location = new System.Drawing.Point(100, 14);
            this.textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            this.textBoxKorisnickoIme.Size = new System.Drawing.Size(129, 20);
            this.textBoxKorisnickoIme.TabIndex = 1;
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(100, 49);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.PasswordChar = '*';
            this.textBoxLozinka.Size = new System.Drawing.Size(129, 20);
            this.textBoxLozinka.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lozinka:";
            // 
            // buttonPrijaviSe
            // 
            this.buttonPrijaviSe.Location = new System.Drawing.Point(32, 86);
            this.buttonPrijaviSe.Name = "buttonPrijaviSe";
            this.buttonPrijaviSe.Size = new System.Drawing.Size(75, 23);
            this.buttonPrijaviSe.TabIndex = 4;
            this.buttonPrijaviSe.Text = "Prijavi se";
            this.buttonPrijaviSe.UseVisualStyleBackColor = true;
            this.buttonPrijaviSe.Click += new System.EventHandler(this.buttonPrijaviSe_Click);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(127, 86);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(75, 23);
            this.buttonOdustani.TabIndex = 5;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // helpProviderPrijava
            // 
            this.helpProviderPrijava.HelpNamespace = "C:\\Users\\Roko\\Documents\\pi22-mmihaljev-arados-rmilosevi\\Software\\Kinonik\\help.chm" +
    "";
            // 
            // FrmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 125);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonPrijaviSe);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKorisnickoIme);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrijava";
            this.helpProviderPrijava.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrijava";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmPrijava_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKorisnickoIme;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPrijaviSe;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.HelpProvider helpProviderPrijava;
    }
}