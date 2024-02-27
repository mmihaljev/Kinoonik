
namespace Kinonik
{
    partial class FrmDodajUrediTermin
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
            this.comboBoxFilm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerPocetak = new System.Windows.Forms.DateTimePicker();
            this.buttonPotvrdi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerZavrsetak = new System.Windows.Forms.DateTimePicker();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film:";
            // 
            // comboBoxFilm
            // 
            this.comboBoxFilm.FormattingEnabled = true;
            this.comboBoxFilm.Location = new System.Drawing.Point(12, 31);
            this.comboBoxFilm.Name = "comboBoxFilm";
            this.comboBoxFilm.Size = new System.Drawing.Size(149, 21);
            this.comboBoxFilm.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Početak:";
            // 
            // dateTimePickerPocetak
            // 
            this.dateTimePickerPocetak.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerPocetak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPocetak.Location = new System.Drawing.Point(12, 77);
            this.dateTimePickerPocetak.Name = "dateTimePickerPocetak";
            this.dateTimePickerPocetak.ShowUpDown = true;
            this.dateTimePickerPocetak.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerPocetak.TabIndex = 3;
            // 
            // buttonPotvrdi
            // 
            this.buttonPotvrdi.Location = new System.Drawing.Point(12, 157);
            this.buttonPotvrdi.Name = "buttonPotvrdi";
            this.buttonPotvrdi.Size = new System.Drawing.Size(74, 27);
            this.buttonPotvrdi.TabIndex = 8;
            this.buttonPotvrdi.Text = "Potvrdi";
            this.buttonPotvrdi.UseVisualStyleBackColor = true;
            this.buttonPotvrdi.Click += new System.EventHandler(this.buttonPotvrdi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Završetak:";
            // 
            // dateTimePickerZavrsetak
            // 
            this.dateTimePickerZavrsetak.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerZavrsetak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerZavrsetak.Location = new System.Drawing.Point(12, 122);
            this.dateTimePickerZavrsetak.Name = "dateTimePickerZavrsetak";
            this.dateTimePickerZavrsetak.ShowUpDown = true;
            this.dateTimePickerZavrsetak.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerZavrsetak.TabIndex = 11;
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(87, 157);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(74, 27);
            this.buttonOdustani.TabIndex = 12;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Roko\\Documents\\pi22-mmihaljev-arados-rmilosevi\\Software\\Kinonik\\help.chm" +
    "";
            // 
            // FrmDodajUrediTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 196);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.dateTimePickerZavrsetak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPotvrdi);
            this.Controls.Add(this.dateTimePickerPocetak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFilm);
            this.Controls.Add(this.label1);
            this.Name = "FrmDodajUrediTermin";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje/uređivanje termina";
            this.Load += new System.EventHandler(this.FrmDodajUrediTermin_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmDodajUrediTermin_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFilm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerPocetak;
        private System.Windows.Forms.Button buttonPotvrdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerZavrsetak;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}