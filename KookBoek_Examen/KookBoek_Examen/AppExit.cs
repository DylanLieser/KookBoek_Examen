using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KookBoek_Examen
{
    public static class AppExit
    {
        public static void ForceExit(Form f)
        {
            Application.Exit();
        }
    }
}
