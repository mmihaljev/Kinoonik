
namespace Kinonik
{
    partial class FrmUpravljanjeTerminima
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
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.buttonDodajTermin = new System.Windows.Forms.Button();
            this.buttonUrediTermin = new System.Windows.Forms.Button();
            this.buttonUkloniTermin = new System.Windows.Forms.Button();
            this.checkBoxDanas = new System.Windows.Forms.CheckBox();
            this.comboBoxDvorane = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelObavijest = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raspored prikazivanja filmova:";
            // 
            // dgvTermini
            // 
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Location = new System.Drawing.Point(12, 37);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.Size = new System.Drawing.Size(651, 213);
            this.dgvTermini.TabIndex = 1;
            this.dgvTermini.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTermini_CellContentClick);
            this.dgvTermini.SelectionChanged += new System.EventHandler(this.dgvTermini_SelectionChanged);
            // 
            // buttonDodajTermin
            // 
            this.buttonDodajTermin.Location = new System.Drawing.Point(12, 256);
            this.buttonDodajTermin.Name = "buttonDodajTermin";
            this.buttonDodajTermin.Size = new System.Drawing.Size(103, 42);
            this.buttonDodajTermin.TabIndex = 2;
            this.buttonDodajTermin.Text = "Dodaj termin";
            this.buttonDodajTermin.UseVisualStyleBackColor = true;
            this.buttonDodajTermin.Click += new System.EventHandler(this.buttonDodajTermin_Click);
            // 
            // buttonUrediTermin
            // 
            this.buttonUrediTermin.Location = new System.Drawing.Point(121, 256);
            this.buttonUrediTermin.Name = "buttonUrediTermin";
            this.buttonUrediTermin.Size = new System.Drawing.Size(103, 42);
            this.buttonUrediTermin.TabIndex = 3;
            this.buttonUrediTermin.Text = "Uredi termin";
            this.buttonUrediTermin.UseVisualStyleBackColor = true;
            this.buttonUrediTermin.Click += new System.EventHandler(this.buttonUrediTermin_Click);
            // 
            // buttonUkloniTermin
            // 
            this.buttonUkloniTermin.Location = new System.Drawing.Point(230, 256);
            this.buttonUkloniTermin.Name = "buttonUkloniTermin";
            this.buttonUkloniTermin.Size = new System.Drawing.Size(103, 42);
            this.buttonUkloniTermin.TabIndex = 4;
            this.buttonUkloniTermin.Text = "Ukloni termin";
            this.buttonUkloniTermin.UseVisualStyleBackColor = true;
            this.buttonUkloniTermin.Click += new System.EventHandler(this.buttonUkloniTermin_Click);
            // 
            // checkBoxDanas
            // 
            this.checkBoxDanas.AutoSize = true;
            this.checkBoxDanas.Location = new System.Drawing.Point(536, 10);
            this.checkBoxDanas.Name = "checkBoxDanas";
            this.checkBoxDanas.Size = new System.Drawing.Size(127, 17);
            this.checkBoxDanas.TabIndex = 5;
            this.checkBoxDanas.Text = "Samo današnji datum";
            this.checkBoxDanas.UseVisualStyleBackColor = true;
            this.checkBoxDanas.CheckedChanged += new System.EventHandler(this.checkBoxDanas_CheckedChanged);
            // 
            // comboBoxDvorane
            // 
            this.comboBoxDvorane.FormattingEnabled = true;
            this.comboBoxDvorane.Location = new System.Drawing.Point(345, 8);
            this.comboBoxDvorane.Name = "comboBoxDvorane";
            this.comboBoxDvorane.Size = new System.Drawing.Size(176, 21);
            this.comboBoxDvorane.TabIndex = 6;
            this.comboBoxDvorane.SelectedIndexChanged += new System.EventHandler(this.comboBoxDvorane_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dvorana:";
            // 
            // labelObavijest
            // 
            this.labelObavijest.AutoSize = true;
            this.labelObavijest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObavijest.Location = new System.Drawing.Point(363, 266);
            this.labelObavijest.Name = "labelObavijest";
            this.labelObavijest.Size = new System.Drawing.Size(90, 20);
            this.labelObavijest.TabIndex = 8;
            this.labelObavijest.Text = "Obavijest ...";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Roko\\Documents\\pi22-mmihaljev-arados-rmilosevi\\Software\\Kinonik\\help.chm" +
    "";
            // 
            // FrmUpravljanjeTerminima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 316);
            this.Controls.Add(this.labelObavijest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDvorane);
            this.Controls.Add(this.checkBoxDanas);
            this.Controls.Add(this.buttonUkloniTermin);
            this.Controls.Add(this.buttonUrediTermin);
            this.Controls.Add(this.buttonDodajTermin);
            this.Controls.Add(this.dgvTermini);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpravljanjeTerminima";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upravljanje terminima prikazivanja filmova";
            this.Load += new System.EventHandler(this.FrmUpravljanjeTerminima_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmUpravljanjeTerminima_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.Button buttonDodajTermin;
        private System.Windows.Forms.Button buttonUrediTermin;
        private System.Windows.Forms.Button buttonUkloniTermin;
        private System.Windows.Forms.CheckBox checkBoxDanas;
        private System.Windows.Forms.ComboBox comboBoxDvorane;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelObavijest;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}