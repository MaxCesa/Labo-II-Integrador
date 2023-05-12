using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2
{
    internal class Serializador
    {
        private readonly List<Personaje> _listaPersonajes;
        private static readonly JsonSerializerOptions _opciones = new()
        {
            WriteIndented = true
        };
        
        public Serializador(List<Personaje> listaPersonajes)
        {
            _listaPersonajes = listaPersonajes;
        }

        public static string Serializar(List<Personaje> listaPersonajes)
        {
            string retorno = JsonSerializer.Serialize(listaPersonajes, Serializador._opciones);
            return retorno;
        }

        public static List<Personaje> Deserealizar(string info)
        {
            List<Personaje> listaPersonajes = new();
            if(JsonSerializer.Deserialize<List<Personaje>>(info) != null)
            {
                listaPersonajes = JsonSerializer.Deserialize<List<Personaje>>(info);
            }
            return listaPersonajes;
        }
    }
}
