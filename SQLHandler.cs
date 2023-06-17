﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PrimerParcialLabo_Intento2
{
    internal class SQLHandler
    {

        public static void exportarPersonajes(List<Personaje> personajes)
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
                    command.Parameters.AddWithValue("@personaje", Serializador.serializarPersonaje(personaje));
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

        public static List<Personaje> importarPersonajes(Usuario usuario)
        {
            List<Personaje> import = new List<Personaje>();
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
                    Personaje personaje = Serializador.deserealizarPersonaje(personajeJson);
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
    }
}
