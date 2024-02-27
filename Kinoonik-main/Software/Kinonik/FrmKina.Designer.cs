namespace Kinonik
{
    partial class FrmKina
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
            this.dgvKina = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAdmini = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajKino = new System.Windows.Forms.Button();
            this.btnUrediKino = new System.Windows.Forms.Button();
            this.btnUkloniKino = new System.Windows.Forms.Button();
            this.btnPosaljiPristupnePodatke = new System.Windows.Forms.Button();
            this.btnUkloniAdmina = new System.Windows.Forms.Button();
            this.btnDodajAdmina = new System.Windows.Forms.Button();
            this.btnUrediAdmina = new System.Windows.Forms.Button();
            this.labelPoruka = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmini)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKina
            // 
            this.dgvKina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKina.Location = new System.Drawing.Point(12, 25);
            this.dgvKina.Name = "dgvKina";
            this.dgvKina.Size = new System.Drawing.Size(344, 214);
            this.dgvKina.TabIndex = 0;
            this.dgvKina.SelectionChanged += new System.EventHandler(this.dgvKina_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kina:";
            // 
            // dgvAdmini
            // 
            this.dgvAdmini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmini.Location = new System.Drawing.Point(408, 25);
            this.dgvAdmini.Name = "dgvAdmini";
            this.dgvAdmini.Size = new System.Drawing.Size(344, 104);
            this.dgvAdmini.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admini:";
            // 
            // btnDodajKino
            // 
            this.btnDodajKino.Location = new System.Drawing.Point(24, 254);
            this.btnDodajKino.Name = "btnDodajKino";
            this.btnDodajKino.Size = new System.Drawing.Size(92, 47);
            this.btnDodajKino.TabIndex = 4;
            this.btnDodajKino.Text = "Dodaj kino";
            this.btnDodajKino.UseVisualStyleBackColor = true;
            this.btnDodajKino.Click += new System.EventHandler(this.btnDodajKino_Click);
            // 
            // btnUrediKino
            // 
            this.btnUrediKino.Location = new System.Drawing.Point(131, 254);
            this.btnUrediKino.Name = "btnUrediKino";
            this.btnUrediKino.Size = new System.Drawing.Size(92, 47);
            this.btnUrediKino.TabIndex = 5;
            this.btnUrediKino.Text = "Uredi kino";
            this.btnUrediKino.UseVisualStyleBackColor = true;
            this.btnUrediKino.Click += new System.EventHandler(this.btnUrediKino_Click);
            // 
            // btnUkloniKino
            // 
            this.btnUkloniKino.Location = new System.Drawing.Point(240, 254);
            this.btnUkloniKino.Name = "btnUkloniKino";
            this.btnUkloniKino.Size = new System.Drawing.Size(92, 47);
            this.btnUkloniKino.TabIndex = 6;
            this.btnUkloniKino.Text = "Ukloni kino";
            this.btnUkloniKino.UseVisualStyleBackColor = true;
            this.btnUkloniKino.Click += new System.EventHandler(this.btnUkloniKino_Click);
            // 
            // btnPosaljiPristupnePodatke
            // 
            this.btnPosaljiPristupnePodatke.Location = new System.Drawing.Point(427, 192);
            this.btnPosaljiPristupnePodatke.Name = "btnPosaljiPristupnePodatke";
            this.btnPosaljiPristupnePodatke.Size = new System.Drawing.Size(306, 47);
            this.btnPosaljiPristupnePodatke.TabIndex = 9;
            this.btnPosaljiPristupnePodatke.Text = "Pošalji pristupne podatke";
            this.btnPosaljiPristupnePodatke.UseVisualStyleBackColor = true;
            this.btnPosaljiPristupnePodatke.Click += new System.EventHandler(this.btnPosaljiPristupnePodatke_Click);
            // 
            // btnUkloniAdmina
            // 
            this.btnUkloniAdmina.Location = new System.Drawing.Point(641, 135);
            this.btnUkloniAdmina.Name = "btnUkloniAdmina";
            this.btnUkloniAdmina.Size = new System.Drawing.Size(92, 47);
            this.btnUkloniAdmina.TabIndex = 8;
            this.btnUkloniAdmina.Text = "Ukloni admina";
            this.btnUkloniAdmina.UseVisualStyleBackColor = true;
            this.btnUkloniAdmina.Click += new System.EventHandler(this.btnUkloniAdmina_Click);
            // 
            // btnDodajAdmina
            // 
            this.btnDodajAdmina.Location = new System.Drawing.Point(427, 135);
            this.btnDodajAdmina.Name = "btnDodajAdmina";
            this.btnDodajAdmina.Size = new System.Drawing.Size(92, 47);
            this.btnDodajAdmina.TabIndex = 7;
            this.btnDodajAdmina.Text = "Dodaj admina";
            this.btnDodajAdmina.UseVisualStyleBackColor = true;
            this.btnDodajAdmina.Click += new System.EventHandler(this.btnDodajAdmina_Click);
            // 
            // btnUrediAdmina
            // 
            this.btnUrediAdmina.Location = new System.Drawing.Point(534, 135);
            this.btnUrediAdmina.Name = "btnUrediAdmina";
            this.btnUrediAdmina.Size = new System.Drawing.Size(92, 47);
            this.btnUrediAdmina.TabIndex = 10;
            this.btnUrediAdmina.Text = "Uredi admina";
            this.btnUrediAdmina.UseVisualStyleBackColor = true;
            this.btnUrediAdmina.Click += new System.EventHandler(this.btnUrediAdmina_Click);
            // 
            // labelPoruka
            // 
            this.labelPoruka.AutoSize = true;
            this.labelPoruka.BackColor = System.Drawing.SystemColors.Control;
            this.labelPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoruka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelPoruka.Location = new System.Drawing.Point(462, 266);
            this.labelPoruka.Name = "labelPoruka";
            this.labelPoruka.Size = new System.Drawing.Size(0, 20);
            this.labelPoruka.TabIndex = 11;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Roko\\Documents\\pi22-mmihaljev-arados-rmilosevi\\Software\\Kinonik\\help.chm" +
    "";
            // 
            // FrmKina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 317);
            this.Controls.Add(this.labelPoruka);
            this.Controls.Add(this.btnUrediAdmina);
            this.Controls.Add(this.btnPosaljiPristupnePodatke);
            this.Controls.Add(this.btnUkloniAdmina);
            this.Controls.Add(this.btnDodajAdmina);
            this.Controls.Add(this.btnUkloniKino);
            this.Controls.Add(this.btnUrediKino);
            this.Controls.Add(this.btnDodajKino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAdmini);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKina);
            this.Name = "FrmKina";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKina";
            this.Load += new System.EventHandler(this.FrmKina_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmKina_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAdmini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajKino;
        private System.Windows.Forms.Button btnUrediKino;
        private System.Windows.Forms.Button btnUkloniKino;
        private System.Windows.Forms.Button btnPosaljiPristupnePodatke;
        private System.Windows.Forms.Button btnUkloniAdmina;
        private System.Windows.Forms.Button btnDodajAdmina;
        private System.Windows.Forms.Button btnUrediAdmina;
        private System.Windows.Forms.Label labelPoruka;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}