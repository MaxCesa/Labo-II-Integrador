using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2.Interfaces
{
    internal interface ISerializador
    {
        public string SerializarJson();
        public static T DeserializarJson<T>(string json)
        {
            throw new NotImplementedException();
        }
        //public string SerializarXml();
        
    }
}
