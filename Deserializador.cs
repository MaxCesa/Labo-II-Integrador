﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DnD;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace PrimerParcialLabo_Intento2
{
    public static class Deserializador
    {
        public static Personaje deserealizarPersonaje(string json)
        {
            Personaje retorno = JsonConvert.DeserializeObject<Personaje>(json);
            return retorno;
        }


        internal static Configuration DeserealizarConfiguracion(string json)
        {
            return JsonConvert.DeserializeObject<Configuration>(json);
        }


    }
}