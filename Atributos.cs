using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerParcialLabo_Intento2;

namespace DnD
{
    internal class Atributos
    {
        public static List<string> atributos = new List<string>()
        {
            "Fuerza",
            "Destreza",
            "Constitucion",
            "Carisma",
            "Inteligencia",
            "Sabiduria",
        };

        public static string elegirAtributo()
        {
            string eleccion = "";
            using (var form = new frmComboEleccion(Atributos.atributos, "Seleccione un atributo a mejorar..."))
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
