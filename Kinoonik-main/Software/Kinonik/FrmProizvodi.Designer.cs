namespace Kinonik
{
    partial class FrmProizvodi
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
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.btnDodajProizvod = new System.Windows.Forms.Button();
            this.btnUrediProizvod = new System.Windows.Forms.Button();
            this.btnUkloniProizvod = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popis proizvoda:";
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(15, 35);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.Size = new System.Drawing.Size(534, 269);
            this.dgvProizvodi.TabIndex = 1;
            // 
            // btnDodajProizvod
            // 
            this.btnDodajProizvod.Location = new System.Drawing.Point(15, 310);
            this.btnDodajProizvod.Name = "btnDodajProizvod";
            this.btnDodajProizvod.Size = new System.Drawing.Size(116, 46);
            this.btnDodajProizvod.TabIndex = 2;
            this.btnDodajProizvod.Text = "Dodaj proizvod";
            this.btnDodajProizvod.UseVisualStyleBackColor = true;
            this.btnDodajProizvod.Click += new System.EventHandler(this.btnDodajProizvod_Click);
            // 
            // btnUrediProizvod
            // 
            this.btnUrediProizvod.Location = new System.Drawing.Point(137, 310);
            this.btnUrediProizvod.Name = "btnUrediProizvod";
            this.btnUrediProizvod.Size = new System.Drawing.Size(116, 46);
            this.btnUrediProizvod.TabIndex = 3;
            this.btnUrediProizvod.Text = "Uredi proizvod";
            this.btnUrediProizvod.UseVisualStyleBackColor = true;
            this.btnUrediProizvod.Click += new System.EventHandler(this.btnUrediProizvod_Click);
            // 
            // btnUkloniProizvod
            // 
            this.btnUkloniProizvod.Location = new System.Drawing.Point(259, 310);
            this.btnUkloniProizvod.Name = "btnUkloniProizvod";
            this.btnUkloniProizvod.Size = new System.Drawing.Size(116, 46);
            this.btnUkloniProizvod.TabIndex = 4;
            this.btnUkloniProizvod.Text = "Ukloni proizvod";
            this.btnUkloniProizvod.UseVisualStyleBackColor = true;
            this.btnUkloniProizvod.Click += new System.EventHandler(this.btnUkloniProizvod_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Roko\\Documents\\pi22-mmihaljev-arados-rmilosevi\\Software\\Kinonik\\help.chm" +
    "";
            // 
            // FrmProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 370);
            this.Controls.Add(this.btnUkloniProizvod);
            this.Controls.Add(this.btnUrediProizvod);
            this.Controls.Add(this.btnDodajProizvod);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.label1);
            this.Name = "FrmProizvodi";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProizvodi";
            this.Load += new System.EventHandler(this.FrmProizvodi_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmProizvodi_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.Button btnDodajProizvod;
        private System.Windows.Forms.Button btnUrediProizvod;
        private System.Windows.Forms.Button btnUkloniProizvod;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}