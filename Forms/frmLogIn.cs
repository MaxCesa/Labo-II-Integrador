using IronPdf.Logging;
using PrimerParcialLabo_Intento2.DB;

namespace PrimerParcialLabo_Intento2
{
    public partial class frmLogIn : Form
    {
        public ListaUsuarios usuarios = new ListaUsuarios()
        //{
        //    new SuperAdmin(1,"Max","123"),
        //    new Jugador(2,"test", "test")
        //};
        ;
        Configuration config = new Configuration();
        
        public frmLogIn()
        {
            InitializeComponent();
            config = ControladorArchivos.LoadConfig();
            LoadUsers(config.Sql);
        }

        internal async void LoadUsers(bool Sql)
        {
            if (Sql)
            {
                usuarios = await SQLHandler.GetUsuarios();
            }
            else
            {
                usuarios = await FirebaseHandler.GetUsuarios();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var usuario in usuarios)
            {
                if (usuario.validacion(txt_Usuario.Text, txt_Contraseña.Text))
                {
                    frmMainMenu menu = new frmMainMenu(usuarios, usuario, config);
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