using IronSoftware;
using Newtonsoft.Json;
using PrimerParcialLabo_Intento2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2
{
    public class Configuration : ISerializador
    {
        public Theme Theme { get; set; }
        public bool Sql { get; set; }
        public int maxIdUser { set; get; }
        public bool ordenAlfabeticoPersonajes { set; get; }

        internal OrdenarPersonajes ordenarPersonajes { set; get; }
        public Configuration(Theme theme, bool sql, int maxId)
        {
            this.Theme = theme;
            this.Sql = sql;
            this.maxIdUser = maxId;
        }
        
        public Configuration()
        {
            this.Theme = new Theme();
            this.Sql = false;
            this.maxIdUser = 4;
            this.ordenAlfabeticoPersonajes = true;
            this.ordenarPersonajes = ((x, y) => string.Compare(x.nombre, y.nombre));
        }

        public string SerializarJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public static Configuration DeserializarJson<Configuration>(string json)
        {

            try
            {
                return JsonConvert.DeserializeObject<Configuration>(json);
            }
            catch (Exception ex)
            {
                throw Logger.LogAndThrow(ex);
                
            }
            return default(Configuration);
        }
    }

    public class Theme
    {
        public Color MainColor { get; set; }
        public Color SecondaryColor { get; set; }

        public Color TerciaryColor { get; set; }

        public Theme(Color mainColor, Color secondaryColor, Color terciaryColor)
        {
            this.MainColor = mainColor;
            this.SecondaryColor = secondaryColor;
            this.TerciaryColor = terciaryColor;
        }

        public Theme()
        {
            this.MainColor = Color.BlanchedAlmond;
            this.SecondaryColor = Color.NavajoWhite;
            this.TerciaryColor = Color.SaddleBrown;
        }
    }
}
