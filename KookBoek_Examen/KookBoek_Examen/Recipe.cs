using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KookBoek_Examen
{
    public class Recipe
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }     // lokaal pad (bv "Images\\kip.jpg")
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public List<string> Steps { get; set; } = new List<string>();

        // Handig om ingrediënten “te schalen” naar aantal personen
        public List<string> GetIngredientsForPersons(int persons)
        {
            return Ingredients
                .Select(i => $"{i.AmountPerPerson * persons} {i.Unit} {i.Name}")
                .ToList();
        }

    }
}
