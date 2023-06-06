using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft;

namespace PrimerParcialLabo_Intento2
{
    internal class Serializador
    {
        private readonly List<Personaje> _listaPersonajes;
        
        
        public Serializador(List<Personaje> listaPersonajes)
        {
            _listaPersonajes = listaPersonajes;
        }

        public static string Serializar(List<Personaje> listaPersonajes)
        {
            string retorno;
            Newtonsoft.Json.JsonSerializerSettings settings = new Newtonsoft.Json.JsonSerializerSettings()
            {
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
            TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto
            };



            retorno = Newtonsoft.Json.JsonConvert.SerializeObject(listaPersonajes, settings);
            return retorno;
        
        }
        //Utilizar herencia para poder deserealizar tanto personajes como personajes.
        public static List<Personaje> Deserealizar(string info)
        {
            List<Personaje> listaPersonajes = new List<Personaje>();
            
            
            listaPersonajes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Personaje>>(info, new Newtonsoft.Json.JsonSerializerSettings
            {
                TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
            });
            
            return listaPersonajes;
        }
    }
}
