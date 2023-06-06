using DnD;

namespace PrimerParcialLabo_Intento2
{
    public partial class frmCrearPersonaje : Form
    {
        Raza raza;
        Clase clase;
        Dictionary<string, int> atributos;
        public Personaje personaje;

        public frmCrearPersonaje()
        {
            InitializeComponent();
            this.cboRazas.DataSource = Enum.GetValues(typeof(Razas));
            this.cboClases.DataSource = Enum.GetValues(typeof(Clases));
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            switch (cboRazas.SelectedIndex)
            {
                case 0:
                    raza = new Enano();
                    break;
                case 1:
                    raza = new Elfo();
                    break;
                case 2:
                    raza = new Mediano();
                    break;
                case 3:
                    raza = new Humano();
                    break;
                case 4:
                    raza = new Gnomo();
                    break;
                case 5:
                    raza = new MedioElfo();
                    break;
                case 6:
                    raza = new MedioOrco();
                    break;
                case 7:
                    raza = new Tiefling();
                    break;
            }

            frmAsignarAtributos form = new frmAsignarAtributos();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                atributos = form.atributosGenerados;
                cboRazas.Enabled = false;
                cboClases.Enabled = true;
                numNivel.Enabled = true;
                btnContinuar2.Enabled = true;
            }
            form.Close();
        }

        private void btnContinuar2_Click(object sender, EventArgs e)
        {
            switch (cboClases.Text)
            {
                case "Barbaro":
                    clase = new Barbaro((int)numNivel.Value);
                    break;
                case "Bardo":
                    clase = new Bardo((int)numNivel.Value);
                    break;
                case "Clerigo":
                    clase = new Clerigo((int)numNivel.Value);
                    break;
                case "Druida":
                    clase = new Druida((int)numNivel.Value);
                    break;
                case "Guerrero":
                    clase = new Guerrero((int)numNivel.Value);
                    break;
                case "Explorador":
                    clase = new Explorador((int)numNivel.Value);
                    break;
                case "Paladin":
                    clase = new Paladin((int)numNivel.Value);
                    break;

            }
            btnCrear.Enabled = true;

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            personaje = new Personaje(txtNombre.Text, this.clase, this.raza, this.atributos, ((frmMainMenu)this.Parent.Parent).usuario);
            ((frmMainMenu)this.Parent.Parent).personajes.Add(personaje);
            ((frmMainMenu)this.Parent.Parent).actualizarLista();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}