using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KookBoek_Examen
{
    public partial class GeschiedenisForm : Form
    {
        public GeschiedenisForm()
        {
            InitializeComponent();
        }

        private void GeschiedenisForm_Load(object sender, EventArgs e)
        {
            // Belangrijk: anders krijg je dubbele kolommen (Designer + AutoGenerate)
            Geschiedenisdata.AutoGenerateColumns = false;

            // Die ster-rij weg
            Geschiedenisdata.AllowUserToAddRows = false;

            // (optioneel) linkse grijze kolom weg
            Geschiedenisdata.RowHeadersVisible = false;

            // Data binden
            Geschiedenisdata.DataSource = null;
            Geschiedenisdata.DataSource = AppState.Geschiedenis;

            // Mooie opvulling
            Geschiedenisdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void Opslaanbtn_Click(object sender, EventArgs e)
        {
            string pad = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "geschiedenis.csv"
            );

            using (StreamWriter sw = new StreamWriter(pad))
            {
                sw.WriteLine("NaamVanGerecht;Datum;AantalPersonen;Tijdsduur;Commentaar");

                foreach (GeschiedenisItem item in AppState.Geschiedenis)
                {
                    string commentaar = (item.Commentaar ?? "").Replace(";", ",");

                    sw.WriteLine(
                        $"{item.NaamVanGerecht};{item.Datum:yyyy-MM-dd HH:mm};{item.AantalPersonen};{item.Tijdsduur};{commentaar}"
                    );
                }
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeForm f = new HomeForm();
            f.Show();
            this.Hide();
        }

        private void keuzeMakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeuzeForm f = new KeuzeForm();
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
