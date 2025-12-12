namespace KookBoek_Examen
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GeschiedenisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeuzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Keuzebtn = new System.Windows.Forms.Button();
            this.Geschiedenisbtn = new System.Windows.Forms.Button();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GeschiedenisToolStripMenuItem,
            this.KeuzeToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1219, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GeschiedenisToolStripMenuItem
            // 
            this.GeschiedenisToolStripMenuItem.Name = "GeschiedenisToolStripMenuItem";
            this.GeschiedenisToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.GeschiedenisToolStripMenuItem.Text = "Geschiedenis";
            this.GeschiedenisToolStripMenuItem.Click += new System.EventHandler(this.GeschiedenisToolStripMenuItem_Click);
            // 
            // KeuzeToolStripMenuItem
            // 
            this.KeuzeToolStripMenuItem.Name = "KeuzeToolStripMenuItem";
            this.KeuzeToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.KeuzeToolStripMenuItem.Text = "Keuze maken";
            this.KeuzeToolStripMenuItem.Click += new System.EventHandler(this.KeuzeToolStripMenuItem_Click);
            // 
            // Keuzebtn
            // 
            this.Keuzebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Keuzebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keuzebtn.Location = new System.Drawing.Point(274, 332);
            this.Keuzebtn.Name = "Keuzebtn";
            this.Keuzebtn.Size = new System.Drawing.Size(287, 183);
            this.Keuzebtn.TabIndex = 1;
            this.Keuzebtn.Text = "Begin met koken";
            this.Keuzebtn.UseVisualStyleBackColor = false;
            this.Keuzebtn.Click += new System.EventHandler(this.Keuzebtn_Click);
            // 
            // Geschiedenisbtn
            // 
            this.Geschiedenisbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Geschiedenisbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Geschiedenisbtn.Location = new System.Drawing.Point(677, 332);
            this.Geschiedenisbtn.Name = "Geschiedenisbtn";
            this.Geschiedenisbtn.Size = new System.Drawing.Size(287, 183);
            this.Geschiedenisbtn.TabIndex = 2;
            this.Geschiedenisbtn.Text = "Bekijk geschiedenis";
            this.Geschiedenisbtn.UseVisualStyleBackColor = false;
            this.Geschiedenisbtn.Click += new System.EventHandler(this.Geschiedenisbtn_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::KookBoek_Examen.Properties.Resources.koken;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1219, 752);
            this.Controls.Add(this.Geschiedenisbtn);
            this.Controls.Add(this.Keuzebtn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GeschiedenisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KeuzeToolStripMenuItem;
        private System.Windows.Forms.Button Keuzebtn;
        private System.Windows.Forms.Button Geschiedenisbtn;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
    }
}

