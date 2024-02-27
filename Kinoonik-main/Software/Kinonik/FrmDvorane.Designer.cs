namespace Kinonik
{
    partial class FrmDvorane
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
            this.labelKino = new System.Windows.Forms.Label();
            this.dgvDvorane = new System.Windows.Forms.DataGridView();
            this.btnDodajDvoranu = new System.Windows.Forms.Button();
            this.btnUkloniDvoranu = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDvorane)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popis dvorana:";
            // 
            // labelKino
            // 
            this.labelKino.AutoSize = true;
            this.labelKino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKino.Location = new System.Drawing.Point(11, 19);
            this.labelKino.Name = "labelKino";
            this.labelKino.Size = new System.Drawing.Size(44, 20);
            this.labelKino.TabIndex = 1;
            this.labelKino.Text = "Kino";
            // 
            // dgvDvorane
            // 
            this.dgvDvorane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDvorane.Location = new System.Drawing.Point(15, 66);
            this.dgvDvorane.Name = "dgvDvorane";
            this.dgvDvorane.Size = new System.Drawing.Size(345, 158);
            this.dgvDvorane.TabIndex = 2;
            // 
            // btnDodajDvoranu
            // 
            this.btnDodajDvoranu.Location = new System.Drawing.Point(15, 230);
            this.btnDodajDvoranu.Name = "btnDodajDvoranu";
            this.btnDodajDvoranu.Size = new System.Drawing.Size(89, 43);
            this.btnDodajDvoranu.TabIndex = 3;
            this.btnDodajDvoranu.Text = "Dodaj dvoranu";
            this.btnDodajDvoranu.UseVisualStyleBackColor = true;
            this.btnDodajDvoranu.Click += new System.EventHandler(this.btnDodajDvoranu_Click);
            // 
            // btnUkloniDvoranu
            // 
            this.btnUkloniDvoranu.Location = new System.Drawing.Point(110, 230);
            this.btnUkloniDvoranu.Name = "btnUkloniDvoranu";
            this.btnUkloniDvoranu.Size = new System.Drawing.Size(89, 43);
            this.btnUkloniDvoranu.TabIndex = 5;
            this.btnUkloniDvoranu.Text = "Ukloni dvoranu";
            this.btnUkloniDvoranu.UseVisualStyleBackColor = true;
            this.btnUkloniDvoranu.Click += new System.EventHandler(this.btnUkloniDvoranu_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Roko\\Documents\\pi22-mmihaljev-arados-rmilosevi\\Software\\Kinonik\\help.chm" +
    "";
            // 
            // FrmDvorane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 299);
            this.Controls.Add(this.btnUkloniDvoranu);
            this.Controls.Add(this.btnDodajDvoranu);
            this.Controls.Add(this.dgvDvorane);
            this.Controls.Add(this.labelKino);
            this.Controls.Add(this.label1);
            this.Name = "FrmDvorane";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDvorane";
            this.Load += new System.EventHandler(this.FrmDvorane_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmDvorane_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDvorane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKino;
        private System.Windows.Forms.DataGridView dgvDvorane;
        private System.Windows.Forms.Button btnDodajDvoranu;
        private System.Windows.Forms.Button btnUkloniDvoranu;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}