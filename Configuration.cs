using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2
{
    public class Configuration
    {
        public Theme Theme { get; set; }
        public bool Sql { get; set; }
        public int maxIdUser { set; get; }

        public Configuration(Theme theme, bool sql, int maxId)
        {
            this.Theme = theme;
            this.Sql = sql;
            this.maxIdUser = maxId;
        }
        
        public Configuration()
        {
            this.Theme = new Theme();
            this.Sql = true;
            this.maxIdUser = 4;
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
