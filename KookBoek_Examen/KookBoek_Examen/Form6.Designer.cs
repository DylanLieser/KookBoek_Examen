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
            this.Opslaanbtn = new System.Windows.Forms.Button();
            this.NaamVanGerecht = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // keuzeMakenToolStripMenuItem
            // 
            this.keuzeMakenToolStripMenuItem.Name = "keuzeMakenToolStripMenuItem";
            this.keuzeMakenToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.keuzeMakenToolStripMenuItem.Text = "Keuze maken";
            this.keuzeMakenToolStripMenuItem.Click += new System.EventHandler(this.keuzeMakenToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Geschiedenisdata
            // 
            this.Geschiedenisdata.AllowUserToAddRows = false;
            this.Geschiedenisdata.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.Geschiedenisdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Geschiedenisdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NaamVanGerecht,
            this.Datum,
            this.AantalPersonen,
            this.Tijdsduur,
            this.Commentaar});
            this.Geschiedenisdata.Location = new System.Drawing.Point(5, 29);
            this.Geschiedenisdata.Name = "Geschiedenisdata";
            this.Geschiedenisdata.RowHeadersVisible = false;
            this.Geschiedenisdata.Size = new System.Drawing.Size(663, 409);
            this.Geschiedenisdata.TabIndex = 2;
            // 
            // Opslaanbtn
            // 
            this.Opslaanbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Opslaanbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Opslaanbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opslaanbtn.Location = new System.Drawing.Point(674, 364);
            this.Opslaanbtn.Name = "Opslaanbtn";
            this.Opslaanbtn.Size = new System.Drawing.Size(114, 74);
            this.Opslaanbtn.TabIndex = 3;
            this.Opslaanbtn.Text = "Opslaan";
            this.Opslaanbtn.UseVisualStyleBackColor = false;
            this.Opslaanbtn.Click += new System.EventHandler(this.Opslaanbtn_Click);
            // 
            // NaamVanGerecht
            // 
            this.NaamVanGerecht.DataPropertyName = "NaamVanGerecht";
            this.NaamVanGerecht.HeaderText = "Naam van Gerecht";
            this.NaamVanGerecht.Name = "NaamVanGerecht";
            this.NaamVanGerecht.ReadOnly = true;
            this.NaamVanGerecht.Width = 200;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 70;
            // 
            // AantalPersonen
            // 
            this.AantalPersonen.DataPropertyName = "AantalPersonen";
            this.AantalPersonen.HeaderText = "Aantal Personen";
            this.AantalPersonen.Name = "AantalPersonen";
            this.AantalPersonen.ReadOnly = true;
            this.AantalPersonen.Width = 109;
            // 
            // Tijdsduur
            // 
            this.Tijdsduur.DataPropertyName = "Tijdsduur";
            this.Tijdsduur.HeaderText = "Tijdsduur";
            this.Tijdsduur.Name = "Tijdsduur";
            this.Tijdsduur.ReadOnly = true;
            this.Tijdsduur.Width = 70;
            // 
            // Commentaar
            // 
            this.Commentaar.DataPropertyName = "Commentaar";
            this.Commentaar.HeaderText = "Commentaar";
            this.Commentaar.Name = "Commentaar";
            this.Commentaar.Width = 170;
            // 
            // GeschiedenisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Opslaanbtn);
            this.Controls.Add(this.Geschiedenisdata);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GeschiedenisForm";
            this.Text = "Geschiedenis";
            this.Load += new System.EventHandler(this.GeschiedenisForm_Load);
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
        private System.Windows.Forms.Button Opslaanbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaamVanGerecht;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AantalPersonen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tijdsduur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commentaar;
    }
}