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
using PrimerParcialLabo_Intento2.Forms;
using PrimerParcialLabo_Intento2.Interfaces;

namespace PrimerParcialLabo_Intento2
{
    public partial class frmExportar : Form, ITema
    {
        ListaPersonajes personajeList;
        Personaje personaje;
        Usuario usuario;
        frmLoading loading;
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
            Thread threadAnimacion = new Thread(() => showLoading());
            threadAnimacion.Start();
            ControladorArchivos.ExportacionCompletada += ExportacionCompletada;
            Thread threadExportacion = new Thread(() => ControladorArchivos.ExportarAPDF(personaje, this.loading));
            threadExportacion.Start();
        }

        private void ExportacionCompletada(object sender, EventArgs e)
        {

            this.loading.Invoke(new Action(() =>
            {
                this.loading.Close();
                this.loading.Dispose();
                this.loading = null;
            }));

        }


        private void showLoading()
        {
            this.loading = new Forms.frmLoading();
            loading.ShowDialog();
        }





        private void btmExportarDB_Click(object sender, EventArgs e)
        {
            if (((frmMainMenu)this.Owner).config.Sql)
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
