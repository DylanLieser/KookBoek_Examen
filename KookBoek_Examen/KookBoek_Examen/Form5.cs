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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void geschiedenisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeschiedenisForm f = new GeschiedenisForm();
            f.Show();
            this.Hide();
        }

        private void keuzeMakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeuzeForm f = new KeuzeForm();
            f.Show();
            this.Hide();
        }
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
