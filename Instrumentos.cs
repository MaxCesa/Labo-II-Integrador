using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2
{
    internal class Instrumento : Item
    {
        public static List<string> instrumentosComunes = new List<string>()
            {
                "Caramillo", "Cuerno","Dulcimer","Flauta","Flauta de pan","Gaita", "Laud", "Lira","Tambor","Viola"
            };

        public static string elegirInstrumento()
        {
            string eleccion = "";
            using (var form = new frmComboEleccion(Instrumento.instrumentosComunes, "Seleccione un instrumento a para aprender..."))
            {

                if (form.DialogResult == DialogResult.OK)
                {
                    eleccion = form.eleccion;

                }
                form.Close();

            }
            return eleccion;
        }

        public static List<string> elegir3DeLista()
        {
            List<string> retorno = new List<string>();
            using (var form = new frmListEleccion(Instrumento.instrumentosComunes, "Un bardo puede aprender hasta 3 instrumentos.", 3))
            {
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
