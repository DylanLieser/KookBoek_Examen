using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KookBoek_Examen
{
    public partial class KeuzeForm : Form
    {
        public KeuzeForm()
        {
            InitializeComponent();
        }

        private void KeuzeForm_Load(object sender, EventArgs e)
        {
            // NumericUpDown instellen
            Personenud.Minimum = 1;
            Personenud.Maximum = 20;
            Personenud.Value = 1;

            // ComboBoxen alleen selecteerbaar maken (niet typen)
            Soortdrop.DropDownStyle = ComboBoxStyle.DropDownList;
            Vleesdrop.DropDownStyle = ComboBoxStyle.DropDownList;
            Bijgerechtdrop.DropDownStyle = ComboBoxStyle.DropDownList;
            Saladedrop.DropDownStyle = ComboBoxStyle.DropDownList;
            Vermijdendrop.DropDownStyle = ComboBoxStyle.DropDownList;

            // Eerst alles leegmaken
            Soortdrop.Items.Clear();
            Vleesdrop.Items.Clear();
            Bijgerechtdrop.Items.Clear();
            Saladedrop.Items.Clear();
            Vermijdendrop.Items.Clear();

            // Placeholder-items (eerste keuze)
            Soortdrop.Items.Add("Selecteer soort gerecht");
            Vleesdrop.Items.Add("Selecteer vlees");
            Bijgerechtdrop.Items.Add("Selecteer bijgerecht");
            Saladedrop.Items.Add("Selecteer salade");
            Vermijdendrop.Items.Add("Selecteer te vermijden");

            // Soort gerecht
            Soortdrop.Items.Add("Hoofdgerecht");
            Soortdrop.Items.Add("Soep");
            Soortdrop.Items.Add("Koud");
            Soortdrop.Items.Add("Dessert");

            // Vlees / hoofdcomponent
            Vleesdrop.Items.Add("Biefstuk");
            Vleesdrop.Items.Add("Kip");
            Vleesdrop.Items.Add("Lam");
            Vleesdrop.Items.Add("Veggie");

            // Bijgerechten
            Bijgerechtdrop.Items.Add("Puree");
            Bijgerechtdrop.Items.Add("Rijst");
            Bijgerechtdrop.Items.Add("Gekookte aardappelen");
            Bijgerechtdrop.Items.Add("Pasta");

            // Salades
            Saladedrop.Items.Add("Geen");
            Saladedrop.Items.Add("Caesar");
            Saladedrop.Items.Add("Tomaat-komkommer");
            Saladedrop.Items.Add("Gemengde salade");

            // Vermijden
            Vermijdendrop.Items.Add("Geen");
            Vermijdendrop.Items.Add("Pikant");
            Vermijdendrop.Items.Add("Vis");
            Vermijdendrop.Items.Add("Lactose");

            // Standaard selectie op placeholder
            Soortdrop.SelectedIndex = 0;
            Vleesdrop.SelectedIndex = 0;
            Bijgerechtdrop.SelectedIndex = 0;
            Saladedrop.SelectedIndex = 0;
            Vermijdendrop.SelectedIndex = 0;
        }


        private void Zoekbtn_Click(object sender, EventArgs e)
        {
            //Controleer of alle keuzes gemaakt zijn
            if (Soortdrop.SelectedIndex == 0 ||
                Vleesdrop.SelectedIndex == 0 ||
                Bijgerechtdrop.SelectedIndex == 0 ||
                Saladedrop.SelectedIndex == 0 ||
                Vermijdendrop.SelectedIndex == 0)
            {
                MessageBox.Show("Maak eerst alle keuzes aub.");
                return;
            }

            //Waarden ophalen uit de controls
            int aantalPersonen = (int)Personenud.Value;
            string soortGerecht = Soortdrop.SelectedItem.ToString();
            string vlees = Vleesdrop.SelectedItem.ToString();
            string bijgerecht = Bijgerechtdrop.SelectedItem.ToString();
            string salade = Saladedrop.SelectedItem.ToString();
            string vermijden = Vermijdendrop.SelectedItem.ToString();

            //Bewaar aantal personen (zodat andere forms dit kunnen gebruiken)
            AppState.AantalPersonen = aantalPersonen;

            AppState.LaatsteRecepten = RecipeGenerator.GenerateRecipes(
                soortGerecht,
                vlees,
                bijgerecht,
                salade,
                vermijden,
                aantalPersonen
            );

            //Ga naar recept-keuze lijst
            ReceptKeuzeForm f = new ReceptKeuzeForm();
            f.Show();
            this.Hide();
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

        // Zorg dat bij het sluiten van het formulier de hele app afsluit
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Als je via X sluit: app volledig afsluiten
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }

            base.OnFormClosing(e);
        }

        private void Vleesdrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Soortdrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
