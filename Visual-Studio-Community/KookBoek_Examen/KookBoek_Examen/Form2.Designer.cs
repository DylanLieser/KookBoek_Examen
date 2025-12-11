namespace KookBoek_Examen
{
    partial class KeuzeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeuzeForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geschiedenisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Personenlbl = new System.Windows.Forms.Label();
            this.Personenud = new System.Windows.Forms.NumericUpDown();
            this.Soortdrop = new System.Windows.Forms.ComboBox();
            this.Vleesdrop = new System.Windows.Forms.ComboBox();
            this.Bijgerechtdrop = new System.Windows.Forms.ComboBox();
            this.Saladedrop = new System.Windows.Forms.ComboBox();
            this.Vermijdendrop = new System.Windows.Forms.ComboBox();
            this.Zoekbtn = new System.Windows.Forms.Button();
            this.Fotobox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Personenud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fotobox)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1336, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // geschiedenisToolStripMenuItem
            // 
            this.geschiedenisToolStripMenuItem.Name = "geschiedenisToolStripMenuItem";
            this.geschiedenisToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.geschiedenisToolStripMenuItem.Text = "Geschiedenis";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Personenlbl
            // 
            this.Personenlbl.AutoSize = true;
            this.Personenlbl.BackColor = System.Drawing.Color.Transparent;
            this.Personenlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Personenlbl.Location = new System.Drawing.Point(50, 96);
            this.Personenlbl.Name = "Personenlbl";
            this.Personenlbl.Size = new System.Drawing.Size(502, 33);
            this.Personenlbl.TabIndex = 1;
            this.Personenlbl.Text = "Hoeveel personen gaan er mee eten?";
            // 
            // Personenud
            // 
            this.Personenud.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Personenud.Location = new System.Drawing.Point(583, 94);
            this.Personenud.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.Personenud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Personenud.Name = "Personenud";
            this.Personenud.Size = new System.Drawing.Size(75, 40);
            this.Personenud.TabIndex = 2;
            this.Personenud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Soortdrop
            // 
            this.Soortdrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soortdrop.FormattingEnabled = true;
            this.Soortdrop.Items.AddRange(new object[] {
            "Warm gerecht",
            "Soep",
            "Pasta",
            ""});
            this.Soortdrop.Location = new System.Drawing.Point(124, 179);
            this.Soortdrop.Name = "Soortdrop";
            this.Soortdrop.Size = new System.Drawing.Size(348, 41);
            this.Soortdrop.TabIndex = 3;
            this.Soortdrop.Text = "Soort gerecht";
            // 
            // Vleesdrop
            // 
            this.Vleesdrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vleesdrop.FormattingEnabled = true;
            this.Vleesdrop.Items.AddRange(new object[] {
            "Rundvlees",
            "Varkensvlees",
            "Kip"});
            this.Vleesdrop.Location = new System.Drawing.Point(124, 262);
            this.Vleesdrop.Name = "Vleesdrop";
            this.Vleesdrop.Size = new System.Drawing.Size(348, 41);
            this.Vleesdrop.TabIndex = 4;
            this.Vleesdrop.Text = "Vlees";
            // 
            // Bijgerechtdrop
            // 
            this.Bijgerechtdrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bijgerechtdrop.FormattingEnabled = true;
            this.Bijgerechtdrop.Items.AddRange(new object[] {
            "Frieten",
            "Gebakken aardappelen",
            "Puree",
            "Brood"});
            this.Bijgerechtdrop.Location = new System.Drawing.Point(124, 350);
            this.Bijgerechtdrop.Name = "Bijgerechtdrop";
            this.Bijgerechtdrop.Size = new System.Drawing.Size(348, 41);
            this.Bijgerechtdrop.TabIndex = 5;
            this.Bijgerechtdrop.Text = "Bijgerechten";
            // 
            // Saladedrop
            // 
            this.Saladedrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saladedrop.FormattingEnabled = true;
            this.Saladedrop.Items.AddRange(new object[] {
            "IJsbergsla",
            "Romeinse sla",
            "Kroppen sla"});
            this.Saladedrop.Location = new System.Drawing.Point(124, 437);
            this.Saladedrop.Name = "Saladedrop";
            this.Saladedrop.Size = new System.Drawing.Size(348, 41);
            this.Saladedrop.TabIndex = 6;
            this.Saladedrop.Text = "Salades";
            // 
            // Vermijdendrop
            // 
            this.Vermijdendrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vermijdendrop.FormattingEnabled = true;
            this.Vermijdendrop.Items.AddRange(new object[] {
            "Champignons",
            "Spruitjes",
            "Witloof"});
            this.Vermijdendrop.Location = new System.Drawing.Point(124, 521);
            this.Vermijdendrop.Name = "Vermijdendrop";
            this.Vermijdendrop.Size = new System.Drawing.Size(348, 41);
            this.Vermijdendrop.TabIndex = 7;
            this.Vermijdendrop.Text = "Vermijden";
            // 
            // Zoekbtn
            // 
            this.Zoekbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Zoekbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zoekbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zoekbtn.Location = new System.Drawing.Point(188, 606);
            this.Zoekbtn.Name = "Zoekbtn";
            this.Zoekbtn.Size = new System.Drawing.Size(196, 58);
            this.Zoekbtn.TabIndex = 8;
            this.Zoekbtn.Text = "Zoek een recept";
            this.Zoekbtn.UseVisualStyleBackColor = false;
            // 
            // Fotobox
            // 
            this.Fotobox.Image = global::KookBoek_Examen.Properties.Resources.kok;
            this.Fotobox.Location = new System.Drawing.Point(679, 159);
            this.Fotobox.Name = "Fotobox";
            this.Fotobox.Size = new System.Drawing.Size(550, 454);
            this.Fotobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fotobox.TabIndex = 9;
            this.Fotobox.TabStop = false;
            // 
            // KeuzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1336, 753);
            this.Controls.Add(this.Fotobox);
            this.Controls.Add(this.Zoekbtn);
            this.Controls.Add(this.Vermijdendrop);
            this.Controls.Add(this.Saladedrop);
            this.Controls.Add(this.Bijgerechtdrop);
            this.Controls.Add(this.Vleesdrop);
            this.Controls.Add(this.Soortdrop);
            this.Controls.Add(this.Personenud);
            this.Controls.Add(this.Personenlbl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KeuzeForm";
            this.Text = "Keuze Maken";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Personenud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fotobox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geschiedenisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label Personenlbl;
        private System.Windows.Forms.NumericUpDown Personenud;
        private System.Windows.Forms.ComboBox Soortdrop;
        private System.Windows.Forms.ComboBox Vleesdrop;
        private System.Windows.Forms.ComboBox Bijgerechtdrop;
        private System.Windows.Forms.ComboBox Saladedrop;
        private System.Windows.Forms.ComboBox Vermijdendrop;
        private System.Windows.Forms.Button Zoekbtn;
        private System.Windows.Forms.PictureBox Fotobox;
    }
}