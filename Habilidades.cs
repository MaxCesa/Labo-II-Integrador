using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2
{
    internal class Habilidades
    {
        public static List<string> habilidades = new List<string>()
        {
            "Atletismo",
            "Acrobacias",
            "Juego de manos",
            "Sigilo",
            "Arcano",
            "Historia",
            "Investigacion",
            "Naturaleza",
            "Religión",
            "Manejo de animales",
            "Medicina",
            "Percepcion",
            "Perspicacia",
            "Supervivencia",
            "Engaño",
            "Intimidacion",
            "Interpretacion",
            "Persuasion"
        };

        public static string elegirHabilidad()
        {
            string eleccion = "";
            using (var form = new frmComboEleccion(Habilidades.habilidades, "Seleccione un atributo a mejorar..."))
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

        public static List<string> elegirDeLista(List<string> lista, int cantidad)
        {
            List<string> retorno = new List<string>();
            using (var form = new frmListEleccion(lista, ("Elija habilidades para ser proeficiente (Maximo " + cantidad.ToString() + ")."), cantidad))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    retorno = form.eleccion;
                }
                else if (form.DialogResult == DialogResult.Cancel)
                {
                    throw new Exception("Operacion cancelada");
                }
                form.Close();
            }
            return retorno;
        }
    }
}
