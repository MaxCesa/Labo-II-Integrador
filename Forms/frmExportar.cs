using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimerParcialLabo_Intento2.DB;
using PrimerParcialLabo_Intento2.Interfaces;

namespace PrimerParcialLabo_Intento2
{
    public partial class frmExportar : Form, ITema
    {
        ListaPersonajes personajeList;
        Personaje personaje;
        Usuario usuario;
        public frmExportar()
        {
            InitializeComponent();
           ;
        }

        public void AplicarTema(Theme theme)
        {
            this.BackColor = theme.MainColor;
        }
        public frmExportar(ListaPersonajes personajeList, Personaje personajeSeleccionado) : this()
        {
            this.personajeList = personajeList;
            this.personaje = personajeSeleccionado;
        }

        public frmExportar(ListaPersonajes personajeList, Personaje personajeSeleccionado, Usuario usuario, Configuration config) : this(personajeList, personajeSeleccionado)
        {
            this.usuario = usuario;
            AplicarTema(config.Theme);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("La funcion de administracion de usuarios esta bajo desarrollo.", "Lo sentimos...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //string datos = Serializador.Serializar(personajeList);
            ControladorArchivos.Guardar(personajeList);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ControladorArchivos.ExportarAPDF(personaje);
        }

        private async void btnImportar_Click(object sender, EventArgs e)
        {
            ListaPersonajes nuevaLista = new ListaPersonajes();
            if (((frmMainMenu)this.Owner).sqlActive == true)
            {
                nuevaLista = SQLHandler.importarPersonajes(usuario);
            }
            else
            {
                nuevaLista = await FirebaseHandler.ImportarPersonajes(usuario);
            }
            ((frmMainMenu)this.Owner).personajes = nuevaLista;
            ((frmMainMenu)this.Owner).actualizarLista();
        }

        private void btmExportarDB_Click(object sender, EventArgs e)
        {
            if (((frmMainMenu)this.Owner).sqlActive == true)
            {
                SQLHandler.exportarPersonajes(personajeList);
            }
            else
            {
                FirebaseHandler.ExportarPersonajes(personajeList);
            }
        }
    }
}
