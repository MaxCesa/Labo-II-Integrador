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
        public Usuario usuario;
        public List<Personaje> personajes = new List<Personaje>();
        Personaje personajeSeleccionado;
        string archivoPersonajes;
        public List<Usuario> usuarios;

        //lista de campañas de pruba

        private frmMainMenu()
        {
            InitializeComponent();
        }

        public frmMainMenu(List<Usuario> usuarios, Usuario usuario) : this()
        {
            this.usuario = usuario;
            this.usuarios = usuarios;
            this.lblUsuario.Text += usuario.username;
            if (ControladorArchivos.ExisteArchivo())
            {
                personajes = ControladorArchivos.Leer();
                actualizarLista();
            }
            
            
            
            if (usuario is SuperAdmin)
            {
                btnUsuarios.Visible = true;
                btnUsuarios.Enabled = true;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCrearPersonaje form = (frmCrearPersonaje)abrirSubForm(new frmCrearPersonaje());
            if (form.DialogResult == DialogResult.OK)
            {
                personajes.Add(form.personaje);
            }
            /* frmCrearPersonaje menuCreacion = new frmCrearPersonaje(usuario);
            menuCreacion.ShowDialog();
            */
        }

        public void actualizarLista()
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
            abrirSubForm(new frmJugar(personajeSeleccionado));
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            frmExportar form = new frmExportar(personajes, personajeSeleccionado);
            form.ShowDialog();
        }

        private Form abrirSubForm(object subForm)
        {
            if (panelContenedor.Controls.Count > 0)
            {
                panelContenedor.Controls.Clear();
            }
            Form fh = subForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
            return fh;
        }

        private Form abrirSubForm(object subForm, object tag)
        {
            if (panelContenedor.Controls.Count > 0)
            {
                panelContenedor.Controls.Clear();
            }
            Form fh = subForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Tag = tag;
            fh.Show();
            return fh;
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            abrirSubForm(new frmInformacion(personajeSeleccionado));
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La funcion de administracion de usuarios esta bajo desarrollo.", "Lo sentimos...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
