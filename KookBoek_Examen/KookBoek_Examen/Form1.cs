using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KookBoek_Examen
{
    public partial class HomeForm : System.Windows.Forms.Form
    {
        public HomeForm()
        {
            // Initialiseert visuele componenten
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        // Klik op "Begin met koken"
        private void Keuzebtn_Click(object sender, EventArgs e)
        {
            KeuzeForm f = new KeuzeForm();
            f.Show();
            this.Hide();
        }

        // Klik op "Geschiedenis"
        private void Geschiedenisbtn_Click(object sender, EventArgs e)
        {
            GeschiedenisForm f = new GeschiedenisForm();
            f.Show();
            this.Hide();
        }

        // Menu: Home
        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm f = new HelpForm();
            f.Show();
            this.Hide();
        }

        // Menu: Geschiedenis
        private void GeschiedenisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Geschiedenisbtn_Click(sender, e);
        }

        // Menu: Keuze maken
        private void KeuzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Keuzebtn_Click(sender, e);
        }

        // Form afsluiten
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Als je via X sluit: app volledig afsluiten
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }

            base.OnFormClosing(e);
        }
    }
}
