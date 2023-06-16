using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2
{
    internal class SQLHandler
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        public void exportarPersonajes(List<Personaje> personajes)
        {
            connection = new SqlConnection(@"Data Source = localhost;
                                Database = emporiodepersonajes;
                                Trusted_Connection = True;");

            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.CommandText = "INSERT INTO tabla VALUES (@Dueño, @personaje)";
                connection.Open();

                foreach (Personaje personaje in personajes)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Dueño", personaje.dueño.ToString());
                    command.Parameters.AddWithValue("@personaje", Serializador.serializarPersonaje(personaje));
                    command.ExecuteNonQuery();
                }
                command.Parameters.Clear();
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
                
            }
        }

        public List<Personaje> importarPersonajes(Usuario usuario)
        {
            List<Personaje> import = new List<Personaje>();
            SqlConnection connection; 
            SqlCommand command;      
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
                    import.Add(personaje);
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
                
            }
            return import;
        }
    }
}
