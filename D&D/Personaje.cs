using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;
using DnD;
using IronSoftware;
using Newtonsoft.Json;
using PrimerParcialLabo_Intento2.Interfaces;

namespace PrimerParcialLabo_Intento2;

public class Personaje : ISerializador
{
    public string nombre { set; get; }
    public string clase { set; get; } = string.Empty;
    public int nivel { set; get; } = 0;
    public string raza { set; get; } = string.Empty;
    //public Background background;
    public bool inspiracion { set; get; } = false;
    public Dictionary<string, int> atributos { set; get; } //Los atributos al ser mostrados se le deben sumar los bonus por clase
    public Dictionary<string, bool> habilidades { set; get; }
    public List<Item> equipamiento { set; get; } = new List<Item>();
    public List<string> proeficiencias { set; get; } = new List<string>();
    public List<string> caracteristicas { set; get; } = new List<string>();
    public List<string> lenguajes { set; get; } = new List<string>();
    public List<string> savingThrows { set; get; } = new List<string>();
    public int hitPointsMaximos { set; get; } = 0;
    public int hitPointsActuales { set; get; } = 0;
    public int velocidad { set; get; } = 0;
    public Dado dadoHP { set; get; }
    public Dictionary<int, int> spellSlots { set; get; } = new Dictionary<int, int>();
    public string dueño { set; get; }

    public Personaje()
    {

    }
    public Personaje(string nombre, Dictionary<string, int> atributos, Usuario usuario)
    {
        this.nombre = nombre;
        this.atributos = atributos;
        habilidades = Habilidad.listaHabilidadesVacia;
        equipamiento = new List<Item>();
        dueño = usuario.ToString();
    }

    public override string ToString()
    {
        return this.nombre + " - " + this.clase + " " + this.nivel.ToString();
    }
    public int bonusProeficiencia()
    {
        if(nivel < 5)
        {
            return 2;
        }
        else if(nivel < 9)
        {
            return 3;
        }
        else if(nivel < 13)
        {
            return 4;
        }
        else if(nivel < 17)
        {
            return 5;
        }
        else { return 6;}
    }

    /// <summary>
    /// Retorna un booleano indicando si el personaje es proeficiente en la habilidad pasada por parametro
    /// </summary>
    /// <param name="habilidad"> un string indicando el nombre de la habilidad</param>
    /// <returns></returns>
    public bool esProeficiente(string habilidad) 
    {
        return (this.habilidades[habilidad]);
    }
    /// <summary>
    /// Retorna el modificador que se utiliza en una tirada de dado basado en la puntuacion del atributo dado
    /// del personaje.
    /// </summary>
    /// <param name="atributo"> un string indicando el nombre del atributo a evaluar</param>
    /// <returns></returns>
    public int modificadorDeAtributo(string atributo)
    {
        return (int)Math.Truncate((double)(-5 + (this.totalAtributo(atributo) / 2)));
    }
    /// <summary>
    /// Retorna el valor total de un atributo tomando en cuenta los bonus de clase y raza.
    /// </summary>
    /// <param name="atributo">un string indicando el nombre del atributo a evaluar</param>
    /// <returns></returns>
    public int totalAtributo(string atributo)
    {
        return atributos[atributo];
    }
    /// <summary>
    /// Retorna el modificador que se utiliza en una tirada de dado basado en la habilidad siendo evaluada.
    /// </summary>
    /// <param name="habilidad"></param>
    /// <returns></returns>
    public int modificadorDeHabilidad(string habilidad)
    {
        int retorno = 0;
        if(esProeficiente(habilidad))
        {
            retorno += this.bonusProeficiencia();
        }
        retorno += modificadorDeAtributo(Habilidad.atributoAsociado(habilidad));
        return retorno;
    }
    //Mover a clase Usuario
    public bool esDueño(Usuario usuarioAValidar)
    {
        return (usuarioAValidar == null);
    }

    public string SerializarJson()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

    public static Personaje DeserializarJson<Personaje>(string json)
    {

        try
        {
            return JsonConvert.DeserializeObject<Personaje>(json);
        }
        catch (Exception ex)
        {
            throw Logger.LogAndThrow(ex);

        }
        return default(Personaje);
    }

    public string SerializarXml()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Personaje));
        StringWriter sw = new StringWriter();
        serializer.Serialize(sw, this);

        return sw.ToString();
    }
}
