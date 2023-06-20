namespace PrimerParcialLabo_Intento2
{
    public partial class frmLogIn : Form
    {
        public List<Usuario> usuarios = new List<Usuario>()
        {
            new SuperAdmin("Max","123"),
            new Jugador("test", "test")
        };

        public frmLogIn()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var usuario in usuarios)
            {
                if (usuario.validacion(txt_Usuario.Text, txt_Contraseña.Text))
                {
                    frmMainMenu menu = new frmMainMenu(usuarios, usuario);
                    menu.Show();
                    this.Hide();

                }
                else
                {
                    lblIncorrecto.Visible = true;
                }
            }
        }

        private void frmLogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}