using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KookBoek_Examen
{
    public static class AppState
    {
        public static int AantalPersonen = 1;

        public static List<Recipe> LaatsteRecepten = new List<Recipe>();
        public static Recipe GekozenRecept = null;

        public static List<GeschiedenisItem> Geschiedenis = new List<GeschiedenisItem>();
    }
}
