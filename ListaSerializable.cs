using Newtonsoft.Json;
using PrimerParcialLabo_Intento2.Interfaces;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PrimerParcialLabo_Intento2
{
    public class ListaPersonajes : List<Personaje>, ISerializador
    {
        public string SerializarJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public string SerializarXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ListaPersonajes));
            StringWriter sw = new StringWriter();
            serializer.Serialize(sw, this);

            return sw.ToString();
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

        public string SerializarXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ListaUsuarios));
            StringWriter sw = new StringWriter();
            serializer.Serialize(sw, this);

            return sw.ToString();
        }
    }
}
