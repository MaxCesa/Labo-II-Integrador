using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialLabo_Intento2
{
    public partial class frmExportar : Form
    {
        List<Personaje> personajeList;
        Personaje personaje;
        public frmExportar()
        {
            InitializeComponent();
        }

        public frmExportar(List<Personaje> personajeList, Personaje personajeSeleccionado) : this()
        {
            this.personajeList = personajeList;
            this.personaje = personajeSeleccionado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string datos = Serializador.Serializar(personajeList);
            ControladorArchivos.Escribir(datos);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ControladorArchivos.ExportarAPDF(personaje);
        }
    }
}
