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

        public static void abilityScoreImprovement(Personaje personaje)
        {
            List<string> opciones = new List<string>()
                        {
                            "Fuerza", "Destreza","Constitucion","Carisma","Inteligencia","Sabiduria"
                        };
            using (var form = new frmListEleccion(opciones, "Elija atributos a mejorar (Maximo 2).", 2))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    List<string> eleccion = form.eleccion;
                    if (eleccion.Count == 1)
                    {
                        personaje.atributos[eleccion[0]] += 2;
                    }
                    else
                    {
                        foreach (string ele in eleccion)
                        {
                            personaje.atributos[ele] += 1;
                        }
                    }
                }
                else if (form.DialogResult == DialogResult.Cancel)
                {
                    throw new Exception("Operacion cancelada");
                }
                form.Close();
            }
        }
    }
}
