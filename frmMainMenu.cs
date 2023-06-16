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
        private frmUsuarios childForm;
        public List<Usuario> usuarios;
        public delegate void actualizarUsuarios(List<Usuario> usuarios);
        public delegate void addPersonaje(Personaje personaje);


        public bool sqlActive = false;

        public void conseguirUsuarios(List<Usuario> usuarios)
        {
            this.usuarios = usuarios;
        }

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
                personajes = ControladorArchivos.LeerArchivoPersonajes();
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
            form.pasarPersonaje = new addPersonaje(this.addPersonajeFn);
            form.Show();

        }

        private void addPersonajeFn(Personaje personaje)
        {
            this.personajes.Add(personaje);
            this.actualizarLista();
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
            Form frm = abrirSubForm(new frmJugar(personajeSeleccionado));
            frm.Show();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            frmExportar form = new frmExportar(personajes, personajeSeleccionado);
            form.Owner = this;
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
            return fh;
        }


        private void btnInformacion_Click(object sender, EventArgs e)
        {
            Form frm = abrirSubForm(new frmInformacion(personajeSeleccionado));
            
            frm.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            childForm = (frmUsuarios)abrirSubForm(new frmUsuarios(usuario, usuarios));
            childForm.guardarYSalir = new actualizarUsuarios(this.actualizarUsuariosFn);
            childForm.Show();


        }

        private void actualizarUsuariosFn(List<Usuario> usuarios)
        {
            this.usuarios = usuarios;
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
