using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KookBoek_Examen
{
    public class GeschiedenisItem
    {
        public string NaamVanGerecht { get; set; }
        public DateTime Datum { get; set; }
        public int AantalPersonen { get; set; }
        public string Tijdsduur { get; set; }
        public string Commentaar { get; set; }
    }
}
