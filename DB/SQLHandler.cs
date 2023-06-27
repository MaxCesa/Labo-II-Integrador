using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PrimerParcialLabo_Intento2.Interfaces;

namespace PrimerParcialLabo_Intento2.DB
{
    internal class SQLHandler : IUsuarios
    {

        public static void exportarPersonajes(ListaPersonajes personajes)
        {
            MySqlConnection connection;
            MySqlCommand command;


            connection = new MySqlConnection("server= localhost; port= 3306; database= emporiodepersonajes; uid= root;");

            command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            var state = connection.State;
            try
            {
                command.CommandText = "INSERT INTO personajes (Dueño, personaje) VALUES (@Dueño, @personaje)";
                connection.Open();

                foreach (Personaje personaje in personajes)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Dueño", personaje.dueño.ToString());
                    command.Parameters.AddWithValue("@personaje", personaje.SerializarJson());
                    command.ExecuteNonQuery();
                }
                command.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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

        public static ListaPersonajes importarPersonajes(Usuario usuario)
        {
            ListaPersonajes import = new ListaPersonajes();
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataReader reader;

            connection = new MySqlConnection("server= localhost; port= 3306; database= emporiodepersonajes; uid= root;");

            command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.CommandText = "SELECT * FROM `personajes` WHERE `Dueño` = '" + usuario.ToString() + "'";
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var personajeJson = reader.GetString(2);
                    Personaje personaje = Deserializador.deserealizarPersonaje(personajeJson);
                    import.Add(personaje);
                }
            }
            catch (Exception e)
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

        public static async Task<ListaUsuarios> GetUsuarios()
        {
            ListaUsuarios usuarios = new ListaUsuarios();
            ListaPersonajes import = new ListaPersonajes();
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataReader reader;

            connection = new MySqlConnection("server= localhost; port= 3306; database= emporiodepersonajes; uid= root;");

            command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.CommandText = "SELECT * FROM `usuarios`";
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if(reader.GetString(1) == "SuperAdmin")
                    {
                        usuarios.Add(new SuperAdmin(reader.GetInt32(0), reader.GetString(2), reader.GetString(3)));
                    }
                    else
                    {
                        usuarios.Add(new Jugador(reader.GetInt32(0), reader.GetString(2), reader.GetString(3)));
                    }
                }
            }
            catch (Exception ex)
            {
                new Exception("Error de conexión a la base de datos");
            }
            finally { connection.Close(); }
            return usuarios;
        }

        public static void SetUsuarios(ListaUsuarios usuarios)
        {
            MySqlConnection connection;
            MySqlCommand command;


            connection = new MySqlConnection("server= localhost; port= 3306; database= emporiodepersonajes; uid= root;");

            command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            var state = connection.State;
            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO usuarios (id, tipo, username, contraseña) VALUES (@id, @tipo, @username, @contraseña) " +
                    "ON DUPLICATE KEY UPDATE tipo = @tipo, username = @username, contraseña = @contraseña";
                foreach (Usuario usuario in usuarios)
                {

                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("id", usuario.id);
                    command.Parameters.AddWithValue("@tipo", usuario.tipo);
                    command.Parameters.AddWithValue("@username", usuario.username);
                    command.Parameters.AddWithValue("@contraseña", usuario.contraseña);
                    command.ExecuteNonQuery();
                }
                command.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw new Exception("Error de conexión a la base de datos");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }
            return;
        }
    }
}
