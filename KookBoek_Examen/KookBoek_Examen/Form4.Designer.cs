namespace KookBoek_Examen
{
    partial class ReceptForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptForm));
            this.Gerechtlbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Ingredientenbox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geschiedenisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Stappenplanbox = new System.Windows.Forms.TextBox();
            this.Timerlbl = new System.Windows.Forms.Label();
            this.Klaarbtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gerechtlbl
            // 
            this.Gerechtlbl.AutoSize = true;
            this.Gerechtlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gerechtlbl.Location = new System.Drawing.Point(12, 37);
            this.Gerechtlbl.Name = "Gerechtlbl";
            this.Gerechtlbl.Size = new System.Drawing.Size(119, 33);
            this.Gerechtlbl.TabIndex = 0;
            this.Gerechtlbl.Text = "Gerecht";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Ingredientenbox
            // 
            this.Ingredientenbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingredientenbox.Location = new System.Drawing.Point(18, 73);
            this.Ingredientenbox.Multiline = true;
            this.Ingredientenbox.Name = "Ingredientenbox";
            this.Ingredientenbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ingredientenbox.Size = new System.Drawing.Size(923, 209);
            this.Ingredientenbox.TabIndex = 1;
            this.Ingredientenbox.Text = "Ingredienten";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.geschiedenisToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1086, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // geschiedenisToolStripMenuItem
            // 
            this.geschiedenisToolStripMenuItem.Name = "geschiedenisToolStripMenuItem";
            this.geschiedenisToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.geschiedenisToolStripMenuItem.Text = "Geschiedenis";
            this.geschiedenisToolStripMenuItem.Click += new System.EventHandler(this.geschiedenisToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Stappenplanbox
            // 
            this.Stappenplanbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stappenplanbox.Location = new System.Drawing.Point(18, 288);
            this.Stappenplanbox.Multiline = true;
            this.Stappenplanbox.Name = "Stappenplanbox";
            this.Stappenplanbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Stappenplanbox.Size = new System.Drawing.Size(923, 622);
            this.Stappenplanbox.TabIndex = 3;
            this.Stappenplanbox.Text = "Stappenplan";
            // 
            // Timerlbl
            // 
            this.Timerlbl.AutoSize = true;
            this.Timerlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timerlbl.Location = new System.Drawing.Point(947, 809);
            this.Timerlbl.Name = "Timerlbl";
            this.Timerlbl.Size = new System.Drawing.Size(78, 25);
            this.Timerlbl.TabIndex = 5;
            this.Timerlbl.Text = "Timer: ";
            // 
            // Klaarbtn
            // 
            this.Klaarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klaarbtn.Location = new System.Drawing.Point(952, 837);
            this.Klaarbtn.Name = "Klaarbtn";
            this.Klaarbtn.Size = new System.Drawing.Size(122, 70);
            this.Klaarbtn.TabIndex = 6;
            this.Klaarbtn.Text = "Klaar";
            this.Klaarbtn.UseVisualStyleBackColor = true;
            this.Klaarbtn.Click += new System.EventHandler(this.Klaarbtn_Click);
            // 
            // ReceptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1086, 919);
            this.Controls.Add(this.Klaarbtn);
            this.Controls.Add(this.Timerlbl);
            this.Controls.Add(this.Stappenplanbox);
            this.Controls.Add(this.Ingredientenbox);
            this.Controls.Add(this.Gerechtlbl);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReceptForm";
            this.Text = "Recept";
            this.Load += new System.EventHandler(this.ReceptForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Gerechtlbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Ingredientenbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geschiedenisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox Stappenplanbox;
        private System.Windows.Forms.Label Timerlbl;
        private System.Windows.Forms.Button Klaarbtn;
    }
}