using DnD;

namespace PrimerParcialLabo_Intento2
{
    public partial class frmCrearPersonaje : Form
    {
        Dictionary<string, int> atributos;
        public Personaje personaje;
        public frmMainMenu.addPersonaje pasarPersonaje;
        public frmCrearPersonaje()
        {
            InitializeComponent();
            this.cboRazas.DataSource = Enum.GetValues(typeof(Razas));
            this.cboClases.DataSource = Enum.GetValues(typeof(Clases));
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {

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
            btnCrear.Enabled = true;

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            personaje = new Personaje(txtNombre.Text, this.atributos, ((frmMainMenu)this.Parent.Parent).usuario);

            switch (cboRazas.SelectedIndex)
            {
                case 0:
                    Enano.OtorgarRaza(personaje);
                    break;
                case 1:
                    Elfo.OtorgarRaza(personaje);
                    break;
                case 2:
                    Mediano.OtorgarRaza(personaje);
                    break;
                case 3:
                    Humano.OtorgarRaza(personaje);
                    break;
                case 4:
                    Gnomo.OtorgarRaza(personaje);
                    break;
                case 5:
                    MedioElfo.OtorgarRaza(personaje);
                    break;
                case 6:
                    MedioOrco.OtorgarRaza(personaje);
                    break;
                case 7:
                    Tiefling.OtorgarRaza(personaje);
                    break;
            }

            switch (cboClases.Text)
            {
                case "Barbaro":
                    Barbaro.subirDeNivel(personaje, (int)numNivel.Value);
                    break;
                case "Bardo":
                    Bardo.subirDeNivel(personaje, (int)numNivel.Value);
                    break;
                case "Clerigo":
                    Clerigo.subirDeNivel(personaje, (int)numNivel.Value);
                    break;
                case "Druida":
                    Druida.subirDeNivel(personaje, (int)numNivel.Value);
                    break;
                case "Guerrero":
                    Guerrero.subirDeNivel(personaje, (int)numNivel.Value);
                    break;
                case "Explorador":
                    Explorador.subirDeNivel(personaje, (int)numNivel.Value);
                    break;
                case "Paladin":
                    Paladin.subirDeNivel(personaje, (int)numNivel.Value);
                    break;
                case "Monje":
                    Monje.subirDeNivel(personaje, ((int)numNivel.Value));
                    break;

            }

            pasarPersonaje(this.personaje);
            
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}