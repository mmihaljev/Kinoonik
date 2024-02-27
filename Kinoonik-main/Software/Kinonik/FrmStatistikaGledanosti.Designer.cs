namespace Kinonik
{
    partial class FrmStatistikaGledanosti
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKino = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelProdaneUkupno = new System.Windows.Forms.Label();
            this.dgvPoFilmu = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartGledanost = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerZavrsetak = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPocetak = new System.Windows.Forms.DateTimePicker();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.labelProdaneDatumi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoFilmu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGledanost)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "STASTIKA GLEDANOSTI";
            // 
            // labelKino
            // 
            this.labelKino.AutoSize = true;
            this.labelKino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKino.Location = new System.Drawing.Point(422, 34);
            this.labelKino.Name = "labelKino";
            this.labelKino.Size = new System.Drawing.Size(65, 25);
            this.labelKino.TabIndex = 1;
            this.labelKino.Text = "KINO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelProdaneUkupno);
            this.groupBox1.Controls.Add(this.dgvPoFilmu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 501);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sveukupno";
            // 
            // labelProdaneUkupno
            // 
            this.labelProdaneUkupno.AutoSize = true;
            this.labelProdaneUkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdaneUkupno.Location = new System.Drawing.Point(91, 89);
            this.labelProdaneUkupno.Name = "labelProdaneUkupno";
            this.labelProdaneUkupno.Size = new System.Drawing.Size(66, 46);
            this.labelProdaneUkupno.TabIndex = 4;
            this.labelProdaneUkupno.Text = "50";
            // 
            // dgvPoFilmu
            // 
            this.dgvPoFilmu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoFilmu.Location = new System.Drawing.Point(7, 185);
            this.dgvPoFilmu.Name = "dgvPoFilmu";
            this.dgvPoFilmu.Size = new System.Drawing.Size(234, 310);
            this.dgvPoFilmu.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gledanost po filmu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Broj prodanih karata:";
            // 
            // chartGledanost
            // 
            this.chartGledanost.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartGledanost.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGledanost.Legends.Add(legend1);
            this.chartGledanost.Location = new System.Drawing.Point(623, 92);
            this.chartGledanost.Name = "chartGledanost";
            this.chartGledanost.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Gledanost";
            this.chartGledanost.Series.Add(series1);
            this.chartGledanost.Size = new System.Drawing.Size(447, 491);
            this.chartGledanost.TabIndex = 4;
            this.chartGledanost.Text = "Gledanost";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerZavrsetak);
            this.groupBox2.Controls.Add(this.dateTimePickerPocetak);
            this.groupBox2.Controls.Add(this.btnPotvrdi);
            this.groupBox2.Controls.Add(this.labelProdaneDatumi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.l);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(265, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 501);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Za datume";
            // 
            // dateTimePickerZavrsetak
            // 
            this.dateTimePickerZavrsetak.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerZavrsetak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerZavrsetak.Location = new System.Drawing.Point(98, 160);
            this.dateTimePickerZavrsetak.Name = "dateTimePickerZavrsetak";
            this.dateTimePickerZavrsetak.ShowUpDown = true;
            this.dateTimePickerZavrsetak.Size = new System.Drawing.Size(149, 26);
            this.dateTimePickerZavrsetak.TabIndex = 10;
            // 
            // dateTimePickerPocetak
            // 
            this.dateTimePickerPocetak.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerPocetak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPocetak.Location = new System.Drawing.Point(98, 69);
            this.dateTimePickerPocetak.Name = "dateTimePickerPocetak";
            this.dateTimePickerPocetak.ShowUpDown = true;
            this.dateTimePickerPocetak.Size = new System.Drawing.Size(149, 26);
            this.dateTimePickerPocetak.TabIndex = 9;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(124, 228);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(109, 46);
            this.btnPotvrdi.TabIndex = 8;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // labelProdaneDatumi
            // 
            this.labelProdaneDatumi.AutoSize = true;
            this.labelProdaneDatumi.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdaneDatumi.Location = new System.Drawing.Point(133, 412);
            this.labelProdaneDatumi.Name = "labelProdaneDatumi";
            this.labelProdaneDatumi.Size = new System.Drawing.Size(43, 46);
            this.labelProdaneDatumi.TabIndex = 6;
            this.labelProdaneDatumi.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ukupno gledatelja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Završni datum:";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(120, 46);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(115, 20);
            this.l.TabIndex = 1;
            this.l.Text = "Početni datum:";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Roko\\Documents\\pi22-mmihaljev-arados-rmilosevi\\Software\\Kinonik\\help.chm" +
    "";
            // 
            // FrmStatistikaGledanosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 595);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chartGledanost);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelKino);
            this.Controls.Add(this.label1);
            this.Name = "FrmStatistikaGledanosti";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStatistikaGledanosti";
            this.Load += new System.EventHandler(this.FrmStatistikaGledanosti_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmStatistikaGledanosti_HelpRequested);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoFilmu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGledanost)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGledanost;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelProdaneUkupno;
        private System.Windows.Forms.DataGridView dgvPoFilmu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelProdaneDatumi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.DateTimePicker dateTimePickerZavrsetak;
        private System.Windows.Forms.DateTimePicker dateTimePickerPocetak;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}