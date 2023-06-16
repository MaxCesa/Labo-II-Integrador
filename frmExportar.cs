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

namespace PrimerParcialLabo_Intento2
{
    public partial class frmExportar : Form
    {
        List<Personaje> personajeList;
        Personaje personaje;
        Usuario usuario;
        public frmExportar()
        {
            InitializeComponent();
        }

        public frmExportar(List<Personaje> personajeList, Personaje personajeSeleccionado) : this()
        {
            this.personajeList = personajeList;
            this.personaje = personajeSeleccionado;
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

        private void btnImportar_Click(object sender, EventArgs e)
        {
            List<Personaje> nuevaLista = new List<Personaje>();
            if (((frmMainMenu)this.Owner).sqlActive == true)
            {
                SqlConnection connection; // Puente.
                SqlCommand command;      // Quien lleva la consulta.
                SqlDataReader reader;

                connection = new SqlConnection(@"Data Source = localhost;
                                Database = emporiodepersonajes;
                                Trusted_Connection = True;");

                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                try
                {
                    command.CommandText = "SELECT * FROM 'personajes' WHERE 'Dueño' = '" + usuario.ToString() + "'";
                    connection.Open();
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var personajeJson = reader.GetString(2);
                        Personaje personaje = Serializador.deserealizarPersonaje(personajeJson);
                        nuevaLista.Add(personaje);
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Error de conexión a la base de datos");
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                    ((frmMainMenu)this.Owner).personajes = nuevaLista;
                }
            }
            else
            {
                // TODO: Firebase connection
            }
        }

        private void btmExportarDB_Click(object sender, EventArgs e)
        {
            if (((frmMainMenu)this.Owner).sqlActive == true)
            {
                //SQLHandler.exportarPersonajes(personajes);
            }
        }
    }
}
