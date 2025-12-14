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
    public partial class ReceptKeuzeForm : Form
    {
        // Hier bewaren we de lijst recepten die we tonen.
        private List<string> _receptNamen = new List<string>();

        public ReceptKeuzeForm()
        {
            InitializeComponent();
        }

        private void ReceptKeuzeForm_Load(object sender, EventArgs e)
        {
            GevondenReceptlbl.Text = "Gevonden recepten:";

            listBox1.Items.Clear();

            // Recepten uit AppState laden
            if (AppState.LaatsteRecepten == null || AppState.LaatsteRecepten.Count == 0)
            {
                listBox1.Items.Add("Geen recepten gevonden");
                vScrollBar1.Minimum = 0;
                vScrollBar1.Maximum = 0;
                vScrollBar1.Value = 0;
                return;
            }

            // Receptnamen toevoegen aan listbox
            foreach (Recipe r in AppState.LaatsteRecepten)
            {
                listBox1.Items.Add(r.Name);
            }

            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = AppState.LaatsteRecepten.Count - 1;
            vScrollBar1.SmallChange = 1;
            vScrollBar1.LargeChange = 1;
            vScrollBar1.Value = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Dubbelklik op een recept => open receptscherm
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;

            AppState.GekozenRecept = AppState.LaatsteRecepten[listBox1.SelectedIndex];

            ReceptForm f = new ReceptForm();
            f.Show();
            this.Hide();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int index = vScrollBar1.Value;

            // Selecteer het item in de listbox dat overeenkomt met de scrollbar waarde
            if (index >= 0 && index < listBox1.Items.Count)
            {
                listBox1.SelectedIndex = index;
                listBox1.TopIndex = index;
            }

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeForm f = new HomeForm();
            f.Show();
            this.Hide();
        }

        private void geschiedenisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeschiedenisForm f = new GeschiedenisForm();
            f.Show();
            this.Hide();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm f = new HelpForm();
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
