using Newtonsoft.Json;
using PrimerParcialLabo_Intento2.Interfaces;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2
{
    public class ListaPersonajes : List<Personaje>, ISerializador
    {
        public string SerializarJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

    public class ListaUsuarios : List<Usuario>, ISerializador
    {
        public string SerializarJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public static ListaUsuarios DeserealizarJson(string json)
        {
            
            if (json != null)
            {
                return JsonConvert.DeserializeObject<ListaUsuarios>(json);
            }
            else
            {
                throw new Exception("Json Nulo");
            }
        }
    }
}
