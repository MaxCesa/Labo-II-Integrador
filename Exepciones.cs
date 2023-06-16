using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exepciones
{
    public class ItemNoSeleccionadoExeption : Exception
    {
        public ItemNoSeleccionadoExeption()
        {
            MessageBox.Show("Por favor seleccione un item de la lista.");
        }
    }
}
