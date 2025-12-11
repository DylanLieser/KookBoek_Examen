namespace KookBoek_Examen
{
    partial class GeschiedenisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeschiedenisForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keuzeMakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Geschiedenisdata = new System.Windows.Forms.DataGridView();
            this.NaamGerecht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AantalPersonen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tijdsduur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commentaar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Geschiedenisdata)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.keuzeMakenToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // keuzeMakenToolStripMenuItem
            // 
            this.keuzeMakenToolStripMenuItem.Name = "keuzeMakenToolStripMenuItem";
            this.keuzeMakenToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.keuzeMakenToolStripMenuItem.Text = "Keuze maken";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Geschiedenisdata
            // 
            this.Geschiedenisdata.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.Geschiedenisdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Geschiedenisdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NaamGerecht,
            this.Datum,
            this.AantalPersonen,
            this.Tijdsduur,
            this.Commentaar});
            this.Geschiedenisdata.Location = new System.Drawing.Point(5, 29);
            this.Geschiedenisdata.Name = "Geschiedenisdata";
            this.Geschiedenisdata.Size = new System.Drawing.Size(546, 409);
            this.Geschiedenisdata.TabIndex = 2;
            // 
            // NaamGerecht
            // 
            this.NaamGerecht.HeaderText = "Naam van Gerecht";
            this.NaamGerecht.Name = "NaamGerecht";
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // AantalPersonen
            // 
            this.AantalPersonen.HeaderText = "Aantal Personen";
            this.AantalPersonen.Name = "AantalPersonen";
            // 
            // Tijdsduur
            // 
            this.Tijdsduur.HeaderText = "Tijdsduur";
            this.Tijdsduur.Name = "Tijdsduur";
            // 
            // Commentaar
            // 
            this.Commentaar.HeaderText = "Commentaar";
            this.Commentaar.Name = "Commentaar";
            // 
            // GeschiedenisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Geschiedenisdata);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GeschiedenisForm";
            this.Text = "Geschiedenis";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Geschiedenisdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keuzeMakenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView Geschiedenisdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaamGerecht;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AantalPersonen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tijdsduur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commentaar;
    }
}