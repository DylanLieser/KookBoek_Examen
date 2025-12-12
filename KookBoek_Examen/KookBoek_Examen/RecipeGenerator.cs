using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KookBoek_Examen
{
    public static class RecipeGenerator
    {
        public static List<Recipe> GenerateRecipes(
            string gerecht,
            string vlees,
            string bijgerecht,
            string sla,
            string vermijden,
            int persons)
        {
            // basis hoeveelheden per persoon
            Dictionary<string, (double amount, string unit)> baseAmounts =
                new Dictionary<string, (double amount, string unit)>
                {
                    ["Biefstuk"] = (150, "g"),
                    ["Kip"] = (150, "g"),
                    ["Lam"] = (150, "g"),
                    ["Veggie"] = (150, "g"),

                    ["Frieten"] = (200, "g"),
                    ["Rijst"] = (200, "g"),
                    ["Puree"] = (180, "g"),
                    ["Gekookte aardappelen"] = (200, "g"),
                    ["Pasta"] = (200, "g"),

                    ["Caesar"] = (50, "g"),
                    ["Tomaat-komkommer"] = (50, "g"),
                    ["Gemengde salade"] = (50, "g"),
                    ["Geen"] = (0, "g")
                };

            // 3 varianten per combinatie
            string[] styles = { "klassiek", "oven", "éénpans" };

            List<Recipe> recipes = new List<Recipe>();

            foreach (string style in styles)
            {
                Recipe r = new Recipe();
                r.Name = $"{gerecht} met {vlees.ToLower()}, {bijgerecht.ToLower()} en {sla.ToLower()} ({style})";
                r.ImagePath = ""; // later eventueel invullen

                // ingrediënten
                if (baseAmounts.ContainsKey(vlees))
                {
                    r.Ingredients.Add(new Ingredient
                    {
                        Name = vlees,
                        AmountPerPerson = baseAmounts[vlees].amount,
                        Unit = baseAmounts[vlees].unit
                    });
                }

                if (baseAmounts.ContainsKey(bijgerecht))
                {
                    r.Ingredients.Add(new Ingredient
                    {
                        Name = bijgerecht,
                        AmountPerPerson = baseAmounts[bijgerecht].amount,
                        Unit = baseAmounts[bijgerecht].unit
                    });
                }

                if (baseAmounts.ContainsKey(sla) && sla != "Geen")
                {
                    r.Ingredients.Add(new Ingredient
                    {
                        Name = sla,
                        AmountPerPerson = baseAmounts[sla].amount,
                        Unit = baseAmounts[sla].unit
                    });
                }

                // stappen
                r.Steps.Add($"1) Bereid het vlees ({vlees.ToLower()}) en kruid naar smaak.");
                r.Steps.Add($"2) Maak het bijgerecht ({bijgerecht.ToLower()}) klaar.");
                r.Steps.Add($"3) Maak de salade ({sla.ToLower()}) klaar (zonder {vermijden.ToLower()}).");
                r.Steps.Add("4) Combineer alles op een bord.");
                r.Steps.Add("5) Serveer warm.");

                recipes.Add(r);
            }

            // ✅ BELANGRIJK: return op het einde
            return recipes;
        }
    }
}