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
    public partial class ReceptForm : Form
    {
        // Dit is de naam van het recept dat we kregen uit de lijst
        private string _receptNaam;

        // Teller voor de timer (aantal seconden dat je bezig bent)
        private int _seconden = 0;

        public ReceptForm()
        {
            InitializeComponent();
        }

        private void ReceptForm_Load(object sender, EventArgs e)
        {
            // Recept ophalen uit AppState
            Recipe r = AppState.GekozenRecept;

            if (r == null)
            {
                MessageBox.Show("Geen recept gekozen.");
                return;
            }

            Gerechtlbl.Text = r.Name;

            // Ingrediënten schalen
            var lijnen = r.GetIngredientsForPersons(AppState.AantalPersonen);
            Ingredientenbox.Text =
                "Voor " + AppState.AantalPersonen + " personen:\r\n\r\n" +
                string.Join("\r\n", lijnen);

            // Stappenplan
            Stappenplanbox.Text = string.Join("\r\n", r.Steps);

            // Timer starten
            _seconden = 0;
            Timerlbl.Text = "00:00";
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _seconden++; // 1 seconde erbij

            // omzetten naar minuten + seconden
            int minuten = _seconden / 60;
            int secondenRest = _seconden % 60;

            // mooi tonen met 2 cijfers
            Timerlbl.Text = $"{minuten:00}:{secondenRest:00}";

        }

        private void Klaarbtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            // Recept toevoegen aan geschiedenis
            GeschiedenisItem item = new GeschiedenisItem
            {
                NaamVanGerecht = AppState.GekozenRecept.Name,
                Datum = DateTime.Now,
                AantalPersonen = AppState.AantalPersonen,
                Tijdsduur = Timerlbl.Text,
                Commentaar = ""
            };

            AppState.Geschiedenis.Add(item);

            GeschiedenisForm f = new GeschiedenisForm();
            f.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // veilig: timer niet laten doorlopen
            HomeForm f = new HomeForm();
            f.Show();
            this.Hide();
        }

        private void geschiedenisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // veilig
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

        private void Ingredientenbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
