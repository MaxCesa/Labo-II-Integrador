using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2
{
    internal class Lenguajes
    {
        public static List<string> lenguajes = new List<string>()
        {
            "Común",
            "Enano",
            "Elfico",
            "Gigante",
            "Gnomico",
            "Goblin",
            "Mediano",
            "Orco"
        };

        public static string elegirLenguaje()
        {
            string eleccion = "";
            using (var form = new frmComboEleccion(Lenguajes.lenguajes, "Elija un lenguaje para aprender..."))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    eleccion = form.eleccion;

                }
                form.Close();

            }
            return eleccion;
        }
    }


}
