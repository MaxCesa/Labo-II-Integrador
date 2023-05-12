using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialLabo_Intento2
{
    public partial class frmMainMenu : Form
    {
        Usuario usuario;
        public List<Personaje> personajes = new List<Personaje>();
        Personaje personajeSeleccionado;
        string archivoPersonajes;

        //lista de campañas de pruba

        private frmMainMenu()
        {
            InitializeComponent();
        }

        public frmMainMenu(List<Usuario> usuarios, Usuario usuario) : this()
        {
            this.usuario = usuario;
            this.lblUsuario.Text += usuario.usuario;
            archivoPersonajes = ControladorArchivos.Leer();
            if (archivoPersonajes != "404")
            {
                personajes = Serializador.Deserealizar(archivoPersonajes);
            }
            foreach (Personaje elem in personajes)
            {
                lstPersonajes.Items.Add(elem);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCrearPersonaje menuCreacion = new frmCrearPersonaje(usuario);
            menuCreacion.ShowDialog();
            this.Hide();
            if (menuCreacion.DialogResult == DialogResult.OK)
            {
                personajes.Add(menuCreacion.personaje);
                actualizarLista();
            }
            menuCreacion.Close();
            this.Show();

        }

        private void actualizarLista()
        {
            this.lstPersonajes.Items.Clear();
            foreach (Personaje elem in personajes)
            {
                lstPersonajes.Items.Add(elem);
            }
        }

        private void btnSeleccionarPersonaje_Click(object sender, EventArgs e)
        {
            if (lstPersonajes.SelectedItem != null)
            {
                personajeSeleccionado = (Personaje)lstPersonajes.SelectedItem;
                lblPersonajeSeleccionado.Text = "Personaje seleccionado: " + lstPersonajes.SelectedItem.ToString();
                this.btnJugar.Enabled = true;
                this.btnInformacion.Enabled = true;
                this.btnExportar.Enabled = true;
            }


        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            frmJugar menuCreacion = new frmJugar(personajeSeleccionado);
            menuCreacion.ShowDialog();
            this.Hide();
            if (menuCreacion.DialogResult == DialogResult.OK)
            {
                menuCreacion.Close();
            }

            this.Show();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            frmExportar form = new frmExportar(personajes, personajeSeleccionado);
            form.ShowDialog();
        }
    }
}
