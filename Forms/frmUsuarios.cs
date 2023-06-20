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
    public partial class frmUsuarios : Form
    {
        public Usuario usuarioActual;
        public List<Usuario> usuarios;
        public frmMainMenu.actualizarUsuarios guardarYSalir;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        public void conseguirUsuarios(List<Usuario> usuarios)
        {
            this.usuarios = usuarios;
        }
        public frmUsuarios(Usuario usuario) : this()
        {
            usuarioActual = usuario;
        }

        public frmUsuarios(Usuario usuarioActual, List<Usuario> usuarios) : this(usuarioActual)
        {
            this.usuarios = usuarios;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void cargarLista()
        {
            this.lstUsuarios.Items.Clear();
            foreach (Usuario usuario in usuarios)
            {
                string[] datos = new string[] { usuario.tipo, usuario.username, usuario.contraseña };
                ListViewItem aux = new ListViewItem(datos);
                this.lstUsuarios.Items.Add(aux);
            }
        }

        private void cambioIndiceLista(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedItems.Count > 0)
            {
                string tipo = lstUsuarios.SelectedItems[0].Text;
                string username = lstUsuarios.SelectedItems[0].SubItems[1].Text;
                string contraseña = lstUsuarios.SelectedItems[0].SubItems[2].Text;

                cboTipo.Text = tipo;
                txtUsername.Text = username;
                txtContraseña.Text = contraseña;
            }

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0 && txtContraseña.Text.Length > 0)
            {
                Usuario nuevoUsuario = null;
                switch (cboTipo.Text)
                {
                    case "Jugador":
                        nuevoUsuario = new Jugador(txtUsername.Text, txtContraseña.Text);
                        break;
                    case "SuperAdmin":
                        nuevoUsuario = new SuperAdmin(txtUsername.Text, txtContraseña.Text);
                        break;
                }
                if (nuevoUsuario != null)
                {
                    if (!((List<Usuario>)this.usuarios).Exists(e => e.username == nuevoUsuario.username))
                    {
                        ((List<Usuario>)this.usuarios).Add(nuevoUsuario);
                    }
                    else
                    {
                        throw new Exception("Usuario ya existe");
                    }
                }
                cargarLista();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0 && txtContraseña.Text.Length > 0)
            {
                if (lstUsuarios.SelectedItems[0].SubItems[1].Text != usuarioActual.username)
                {
                    if (!((List<Usuario>)this.usuarios).Exists(e => e.username == txtUsername.Text))
                    {
                        lstUsuarios.SelectedItems[0].SubItems[0].Text = cboTipo.Text;
                        lstUsuarios.SelectedItems[0].SubItems[1].Text = txtUsername.Text;
                        lstUsuarios.SelectedItems[0].SubItems[2].Text = txtContraseña.Text;

                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarYSalir(this.usuarios);
        }
    }
}
