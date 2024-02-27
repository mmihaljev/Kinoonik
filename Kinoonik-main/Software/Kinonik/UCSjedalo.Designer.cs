namespace Kinonik
{
    partial class UCSjedalo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pboxSjedalo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSjedalo)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxSjedalo
            // 
            this.pboxSjedalo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxSjedalo.BackColor = System.Drawing.Color.Green;
            this.pboxSjedalo.Location = new System.Drawing.Point(16, 12);
            this.pboxSjedalo.Name = "pboxSjedalo";
            this.pboxSjedalo.Size = new System.Drawing.Size(25, 25);
            this.pboxSjedalo.TabIndex = 0;
            this.pboxSjedalo.TabStop = false;
            this.pboxSjedalo.Click += new System.EventHandler(this.pboxSjedalo_Click);
            // 
            // UCSjedalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pboxSjedalo);
            this.Name = "UCSjedalo";
            this.Size = new System.Drawing.Size(58, 50);
            this.Load += new System.EventHandler(this.UCSjedalo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxSjedalo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pboxSjedalo;
    }
}
