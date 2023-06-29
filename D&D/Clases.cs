using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PrimerParcialLabo_Intento2;

namespace DnD
{
    enum Clases
    {
        Barbaro,
        Bardo,
        Clerigo,
        Druida,
        Guerrero,
        Monje,
        Paladin,
        Explorador
    }
    public abstract class Clase
    {
        public static void SetEspecializacion(Personaje personaje, List<string> especializaciones)
        {
            using (var form = new frmComboEleccion(especializaciones, "Elija la especializacion de su personaje..."))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    personaje.caracteristicas.Add(form.eleccion);
                }
                else if (form.DialogResult == DialogResult.Cancel)
                {
                    throw new Exception("Operacion cancelada");
                }
                form.Close();
            }
        }
        public static string GetEspecializacion(Personaje personaje, List<string> especializaciones)
        {
            string retorno = "";
            foreach(string especializacion in especializaciones)
            {
                if (personaje.caracteristicas.Contains(especializacion))
                {
                    retorno = especializacion;
                }
            }
            return retorno;
        }

        public static void aumentarHP(Personaje personaje)
        {
            personaje.hitPointsMaximos += (personaje.dadoHP.tirar(personaje.atributos["Constitucion"]));
            personaje.dadoHP.cantidad++;
        }
    }

    public class Barbaro : Clase
    {
        public static new string nombreClase = "Barbaro";
        public static void subirDeNivel(Personaje personaje, int cantidadNiveles)
        {
            
            if(personaje.clase == "")
            {
                personaje.clase = nombreClase;
            }
            for (int i = personaje.nivel; i <= (personaje.nivel + cantidadNiveles); i++)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        personaje.dadoHP = new Dado(1, 12);
                        personaje.hitPointsMaximos = 12 + personaje.atributos["Constitucion"];
                        personaje.proeficiencias.Add("Armadura mediana");
                        personaje.proeficiencias.Add("Armadura ligera");
                        personaje.proeficiencias.Add("Escudos");
                        personaje.proeficiencias.Add("Armas marciales");
                        personaje.proeficiencias.Add("Armas simples");
                        personaje.savingThrows.Add("Fuerza");
                        personaje.savingThrows.Add("Constitucion");

                        List<string> opciones = new List<string>()
                        {
                            "Manejo de animales", "Atletismo","Intimidacion","Naturaleza","Percepcion","Supervivencia"
                        };
                        foreach (string habilidad in Habilidad.elegirDeLista(opciones, 2))
                        {
                            personaje.habilidades[habilidad] = true;
                        }
                        personaje.caracteristicas.Add("Ira");
                        personaje.caracteristicas.Add("Defensa desarmada");
                        
                        break;
                    case 2:
                        aumentarHP(personaje);
                        personaje.caracteristicas.Add("Ataque Imprudente");
                        personaje.caracteristicas.Add("Sentido de peligro");
                        break;
                    case 3:
                        opciones = new List<string>()
                        {
                            "Camino del Berserker", "Camino del Guerrero de Totem"
                        };
                        using (var form = new frmComboEleccion(opciones, "Elija el camino de su barbaro..."))
                        {
                            if (form.DialogResult == DialogResult.OK)
                            {
                                string eleccion = form.eleccion;
                                personaje.caracteristicas.Add(eleccion);
                            }
                            else if (form.DialogResult == DialogResult.Cancel)
                            {
                                throw new Exception("Operacion cancelada");
                            }
                            form.Close();
                        }
                        if (personaje.caracteristicas.Contains("Camino del Berserker"))
                        {
                            personaje.caracteristicas.Add("Frenesí");
                        }
                        else
                        {
                            personaje.caracteristicas.Add("Buscador espiritual");
                            personaje.caracteristicas.Add("Espiritu del Totem");
                        }
                        aumentarHP(personaje);
                        break;
                    case 4:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 5:
                        personaje.caracteristicas.Add("Ataque extra");
                        personaje.caracteristicas.Add("Movimiento rapido");
                        aumentarHP(personaje);
                        break;
                    case 6:
                        if (personaje.caracteristicas.Contains("Camino del Berserker"))
                        {
                            personaje.caracteristicas.Add("Rabia desenfrenada");
                        }
                        else
                        {
                            personaje.caracteristicas.Add("Aspecto de la bestia");
                        }
                        aumentarHP(personaje);
                        break;
                    case 7:
                        personaje.caracteristicas.Add("Instinto salvaje");
                        aumentarHP(personaje);
                        break;
                    case 8:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 9:
                        personaje.caracteristicas.Add("Critico brutal");
                        aumentarHP(personaje);
                        break;
                    case 10:
                        if (personaje.caracteristicas.Contains("Camino del Berserker"))
                        {
                            personaje.caracteristicas.Add("Presencia intimidante");
                        }
                        else
                        {
                            personaje.caracteristicas.Add("Caminante espiritual");
                        }
                        aumentarHP(personaje);
                        break;
                    case 11:
                        personaje.caracteristicas.Add("Furia implacable");
                        aumentarHP(personaje);
                        break;
                    case 12:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 13:
                        aumentarHP(personaje);
                        break;
                    case 14:
                        if (personaje.caracteristicas.Contains("Camino del Berserker"))
                        {
                            personaje.caracteristicas.Add("Represalia");
                        }
                        else
                        {
                            personaje.caracteristicas.Add("Subtonía Totémica");
                        }
                        aumentarHP(personaje);
                        break;
                    case 15:
                        personaje.caracteristicas.Add("Furia persistente");
                        aumentarHP(personaje);
                        break;
                    case 16:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 17:
                        aumentarHP(personaje);
                        break;
                    case 18:
                        personaje.caracteristicas.Add("Fuerza indómita");
                        aumentarHP(personaje);
                        break;
                    case 19:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 20:
                        personaje.caracteristicas.Add("Campeon primario");
                        aumentarHP(personaje);
                        break;
                }
            }
            personaje.nivel += cantidadNiveles;
        }
    }

    public class Bardo : Clase
    {
        public static new string nombreClase = "Bardo";
        public static void subirDeNivel(Personaje personaje, int cantidadNiveles)
        {
            List<string> opciones = new List<string>();
            for (int i = personaje.nivel; i <= (personaje.nivel + cantidadNiveles); i++)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        personaje.dadoHP = new Dado(1, 8);
                        personaje.hitPointsMaximos = 8 + personaje.atributos["Constitucion"];
                        personaje.proeficiencias.Add("Armadura ligera");
                        personaje.proeficiencias.Add("Armas simples");
                        personaje.proeficiencias.Add("Ballesta de mano");
                        personaje.proeficiencias.Add("Espada larga");
                        personaje.proeficiencias.Add("Estoque");
                        personaje.proeficiencias.Add("Espada corta");


                        foreach (string instrumento in Instrumento.elegir3DeLista())
                        {
                            personaje.proeficiencias.Add(instrumento);
                        }
                        personaje.savingThrows.Add("Destreza");
                        personaje.savingThrows.Add("Carisma");
                        foreach (string habilidad in Habilidad.elegirDeLista(Habilidad.habilidades, 3))
                        {
                            personaje.habilidades[habilidad] = true;
                        }
                        personaje.caracteristicas.Add("Lanzamiento de hechizos");
                        personaje.caracteristicas.Add("Inspiracion de Bardo");
                        personaje.spellSlots.Add(1, 2);
                        break;
                    case 2:
                        personaje.caracteristicas.Add("Polivalente");
                        aumentarHP(personaje);
                        personaje.caracteristicas.Add("Cancion de descanso");
                        personaje.spellSlots[1] = 3;
                        break;
                    case 3:
                        opciones = new List<string>()
                        {
                            "Colegio del Conocimiento", "Colegio del Valor"
                        };
                        using (var form = new frmComboEleccion(opciones, "Elija el colegio de su bardo..."))
                        {
                            if (form.DialogResult == DialogResult.OK)
                            {
                                personaje.caracteristicas.Add(form.eleccion);
                            }
                            else if (form.DialogResult == DialogResult.Cancel)
                            {
                                throw new Exception("Operacion cancelada");
                            }
                            form.Close();
                        }
                        if (personaje.caracteristicas.Contains("Colegio del Conocimiento"))
                        {
                            foreach (string habilidad in Habilidad.elegirDeLista(Habilidad.habilidades, 3))
                            {
                                personaje.habilidades[habilidad] = true;
                            }
                            personaje.caracteristicas.Add("Palabras hirientes");
                        }
                        else
                        {
                            personaje.proeficiencias.Add("Armadura media");
                            personaje.proeficiencias.Add("Escudos");
                            personaje.proeficiencias.Add("Armas marciales");
                            personaje.caracteristicas.Add("Inspiracion de combate");
                        }
                        personaje.caracteristicas.Add("Experto");
                        personaje.spellSlots[1] = 4;
                        personaje.spellSlots.Add(2, 2);
                        aumentarHP(personaje);
                        break;
                    case 4:
                        Atributos.abilityScoreImprovement(personaje);
                        personaje.spellSlots[2] = 3;
                        aumentarHP(personaje);
                        break;
                    case 5:
                        personaje.caracteristicas.Add("Fuente de inspiracion");
                        personaje.spellSlots.Add(3, 2);
                        aumentarHP(personaje);
                        break;
                    case 6:
                        personaje.caracteristicas.Add("Contraoda");
                        if (personaje.caracteristicas.Contains("Colegio del Conocimiento"))
                        {
                            personaje.caracteristicas.Add("Secretos magicos adicionales");
                        }
                        else
                        {
                            personaje.caracteristicas.Add("Ataque adicional");
                        }
                        personaje.spellSlots[3] = 3;
                        aumentarHP(personaje);
                        break;
                    case 7:
                        personaje.spellSlots.Add(4, 1);
                        aumentarHP(personaje);
                        break;
                    case 8:
                        Atributos.abilityScoreImprovement(personaje);
                        personaje.spellSlots[4] = 2;
                        aumentarHP(personaje);
                        break;
                    case 9:
                        personaje.spellSlots.Add(5, 1);
                        aumentarHP(personaje);
                        break;
                    case 10:
                        personaje.caracteristicas.Add("Secretos magicos");
                        personaje.spellSlots[5] = 2;
                        aumentarHP(personaje);
                        break;
                    case 11:
                        personaje.spellSlots.Add(6, 1);
                        aumentarHP(personaje);
                        break;
                    case 12:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 13:
                        personaje.spellSlots.Add(7, 1);
                        aumentarHP(personaje);
                        break;
                    case 14:
                        if (personaje.caracteristicas.Contains("Colegio del Conocimiento"))
                        {
                            personaje.caracteristicas.Add("Habilidad incomparable");
                        }
                        else
                        {
                            personaje.caracteristicas.Add("Magia de batalla");
                        }
                        aumentarHP(personaje);
                        break;
                    case 15:
                        personaje.spellSlots.Add(8, 1);
                        aumentarHP(personaje);
                        break;
                    case 16:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 17:
                        personaje.spellSlots.Add(9, 1);
                        aumentarHP(personaje);
                        break;
                    case 18:
                        aumentarHP(personaje);
                        break;
                    case 19:
                        Atributos.abilityScoreImprovement(personaje);
                        personaje.spellSlots[6] = 2;
                        aumentarHP(personaje);
                        break;
                    case 20:
                        personaje.caracteristicas.Add("Inspiracion superior");
                        personaje.spellSlots[7] = 2;
                        aumentarHP(personaje);
                        break;
                }
            }
            personaje.nivel += cantidadNiveles;
        }


    }

    public class Clerigo : Clase
    {
        public static List<string> especializacionesPosibles = new List<string>() { "Dominio del conocimiento", "Dominio de la guerra", "Dominio de la luz", "Dominio de la naturaleza", "Dominio de la tempestad", "Dominio del engaño", "Dominio de la vida" };

        public static new string nombreClase = "Clerigo";
        public static void subirDeNivel(Personaje personaje, int cantidadNiveles)
        {
            for (int i = personaje.nivel; i <= (personaje.nivel + cantidadNiveles); i++)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        personaje.dadoHP = new Dado(1, 8);
                        personaje.hitPointsMaximos = 8 + personaje.atributos["Constitucion"];
                        personaje.clase = "Clerigo";
                        personaje.proeficiencias.Add("Armadura ligera");
                        personaje.proeficiencias.Add("Armadura mediana");
                        personaje.proeficiencias.Add("Escudos");
                        personaje.proeficiencias.Add("Armas simples");
                        personaje.savingThrows.Add("Sabiduria");
                        personaje.savingThrows.Add("Carisma");
                        List<string> opcionesDeClerigo = new List<string>()
                        { "Historia", "Perspicacia", "Medicina", "Persuasion", "Religion"};
                        foreach (string habilidad in Habilidad.elegirDeLista(opcionesDeClerigo, 2))
                        {
                            personaje.habilidades[habilidad] = true;
                        }
                        personaje.caracteristicas.Add("Lanzamiento de hechizos");
                        Clase.SetEspecializacion(personaje, especializacionesPosibles);
                        personaje.spellSlots.Add(1, 2);
                        break;
                    case 2:
                        personaje.caracteristicas.Add("Canalizar divinidad");
                        personaje.caracteristicas.Add("CANALIZAR DIVINIDAD: EXPULSAR MUERTOS VIVIENTES");
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Dominio del conocimiento":
                                personaje.caracteristicas.Add("Bendiciones del conocimiento");
                                personaje.lenguajes.Add(Lenguajes.elegirLenguaje());
                                personaje.lenguajes.Add(Lenguajes.elegirLenguaje());
                                List<string> _opciones = new List<string>()
                                { "Arcano", "Historia", "Naturaleza", "Religion"};
                                foreach (string habilidad in Habilidad.elegirDeLista(_opciones, 2))
                                {
                                    personaje.habilidades[habilidad] = true;
                                }
                                personaje.caracteristicas.Add("CANALIZAR DIVINIDAD: Conocimiento de las edades");
                                break;

                            case "Dominio de la vida":
                                personaje.proeficiencias.Add("Armadura pesada");
                                personaje.caracteristicas.Add("Discipulo de la vida");
                                personaje.caracteristicas.Add("CANALIZAR DIVINIDAD: Preservar vida");
                                break;
                            case "Dominio de la luz":
                                personaje.caracteristicas.Add("Truco adicional");
                                personaje.caracteristicas.Add("Fulgor protector");
                                personaje.caracteristicas.Add("CANALIZAR DIVINIDAD: Resplandor del alva");
                                break;
                            case "Dominio de la naturaleza":
                                personaje.caracteristicas.Add("CANALIZAR DIVINIDAD: Hechizar animales y plantas");
                                break;
                            case "Dominio de la tempestad":
                                personaje.caracteristicas.Add("CANALIZAR DIVINIDAD: Ira destructiva");
                                break;
                            case "Dominio del engaño":
                                personaje.caracteristicas.Add("CANALIZAR DIVINIDAD: Invocar duplicidad");
                                break;
                            case "Dominio de la guerra ":
                                personaje.caracteristicas.Add("CANALIZAR DIVINIDAD: Impacto guiado");
                                break;

                        }
                        personaje.spellSlots[1] = 3;
                        aumentarHP(personaje);
                        break;
                    case 3:
                        personaje.spellSlots[1] = 4;
                        personaje.spellSlots.Add(2, 2);
                        aumentarHP(personaje);
                        break;
                    case 4:
                        Atributos.abilityScoreImprovement(personaje);
                        personaje.spellSlots[2] = 3;
                        aumentarHP(personaje);
                        break;
                    case 5:
                        personaje.spellSlots.Add(3, 2);
                        aumentarHP(personaje);
                        break;
                    case 6:
                        personaje.spellSlots[3] = 3;
                        aumentarHP(personaje);
                        break;
                    case 7:
                        personaje.spellSlots.Add(4, 1);
                        aumentarHP(personaje);
                        break;
                    case 8:
                        Atributos.abilityScoreImprovement(personaje);
                        personaje.spellSlots[4] = 2;
                        aumentarHP(personaje);
                        break;
                    case 9:
                        personaje.spellSlots.Add(5, 1);
                        aumentarHP(personaje);
                        break;
                    case 10:
                        personaje.caracteristicas.Add("Intervencion divina");
                        personaje.spellSlots[5] = 2;
                        aumentarHP(personaje);
                        break;
                    case 11:
                        personaje.spellSlots.Add(6, 1);
                        aumentarHP(personaje);
                        break;
                    case 12:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 13:
                        personaje.spellSlots.Add(7, 1);
                        aumentarHP(personaje);
                        break;
                    case 14:
                        aumentarHP(personaje);
                        break;
                    case 15:
                        personaje.spellSlots.Add(8, 1);
                        aumentarHP(personaje);
                        break;
                    case 16:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 17:
                        personaje.spellSlots.Add(9, 1);
                        aumentarHP(personaje);
                        break;
                    case 18:
                        aumentarHP(personaje);
                        break;
                    case 19:
                        Atributos.abilityScoreImprovement(personaje);
                        personaje.spellSlots[6] = 2;
                        aumentarHP(personaje);
                        break;
                    case 20:
                        personaje.caracteristicas.Add("Intervencion divina mejorada");
                        personaje.spellSlots[7] = 2;
                        aumentarHP(personaje);
                        break;
                }
            }
            personaje.nivel += cantidadNiveles;
        }


    }

    public class Druida : Clase
    {
        public static List<string> especializacionesPosibles = new List<string>()
        {
            "Circulo de la tierra", "Circulo de la luna"
        };
        public static new string nombreClase = "Barbaro";
        public static void subirDeNivel(Personaje personaje, int cantidadNiveles)
        {
            for (int i = personaje.nivel; i <= (personaje.nivel + cantidadNiveles); i++)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        personaje.clase = "Druida";
                        personaje.dadoHP = new Dado(1, 8);
                        personaje.hitPointsMaximos = 8 + personaje.atributos["Constitucion"];
                        personaje.proeficiencias.Add("Armadura ligera");
                        personaje.proeficiencias.Add("Armadura mediana");
                        personaje.proeficiencias.Add("Escudos");
                        personaje.proeficiencias.Add("Bastones");
                        personaje.proeficiencias.Add("Cimitarras");
                        personaje.proeficiencias.Add("Clavas");
                        personaje.proeficiencias.Add("Dagas");
                        personaje.proeficiencias.Add("Dardos");
                        personaje.proeficiencias.Add("Hoces");
                        personaje.proeficiencias.Add("Hondas");
                        personaje.proeficiencias.Add("Lanzas");
                        personaje.proeficiencias.Add("Mazas");
                        personaje.proeficiencias.Add("Kit de herboristeria");

                        personaje.savingThrows.Add("Sabiduria");
                        personaje.savingThrows.Add("Inteligencia");
                        Console.WriteLine("Primer log");
                        List<string> opcionesDeDruida = new List<string>()
                        { "Arcano", "Perspicacia", "Medicina", "Naturaleza", "Percepcion", "Religion", "Supervivencia", "Manejo de animales"};
                        foreach (string habilidad in Habilidad.elegirDeLista(opcionesDeDruida, 2))
                        {
                            personaje.habilidades[habilidad] = true;
                        }
                        personaje.caracteristicas.Add("Lanzamiento de hechizos");
                        personaje.lenguajes.Add("Druidico");
                        personaje.spellSlots.Add(1, 2);
                        break;
                    case 2:
                        Clase.SetEspecializacion(personaje, especializacionesPosibles);
                        personaje.caracteristicas.Add("Forma salvaje");
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Circulo de la tierra":
                                personaje.caracteristicas.Add("Truco adicional");
                                personaje.caracteristicas.Add("Recuperacion natural");
                                break;

                            case "Circulo de la luna":
                                personaje.proeficiencias.Add("Forma salvaje de combate");
                                personaje.caracteristicas.Add("Formas del circulo");
                                break;

                        }
                        personaje.spellSlots[1] = 3;
                        aumentarHP(personaje);
                        break;
                    case 3:
                        if(Clase.GetEspecializacion(personaje, especializacionesPosibles) == "Circulo de la tierra")
                        {
                            personaje.caracteristicas.Add("Conjuros del circulo");
                        }
                        personaje.spellSlots[1] = 4;
                        personaje.spellSlots.Add(2, 2);
                        aumentarHP(personaje);
                        break;
                    case 4:
                        Atributos.abilityScoreImprovement(personaje);
                        personaje.spellSlots[2] = 3;
                        aumentarHP(personaje);
                        break;
                    case 5:
                        personaje.spellSlots.Add(3, 2);
                        aumentarHP(personaje);
                        break;
                    case 6:
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Circulo de la tierra":
                                personaje.caracteristicas.Add("Zancada forestal");
                                break;

                            case "Circulo de la luna":
                                personaje.proeficiencias.Add("Golpe primitivo");
                                break;
                        }
                        personaje.spellSlots[3] = 3;
                        aumentarHP(personaje);
                        break;
                    case 7:
                        personaje.spellSlots.Add(4, 1);
                        aumentarHP(personaje);
                        break;
                    case 8:
                        Atributos.abilityScoreImprovement(personaje);
                        personaje.spellSlots[4] = 2;
                        aumentarHP(personaje);
                        break;
                    case 9:
                        personaje.spellSlots.Add(5, 1);
                        aumentarHP(personaje);
                        break;
                    case 10:
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Circulo de la tierra":
                                personaje.caracteristicas.Add("Proteccion de la naturaleza");
                                break;

                            case "Circulo de la luna":
                                personaje.proeficiencias.Add("Forma salvaje elemental");
                                break;

                        }
                        personaje.spellSlots[5] = 2;
                        aumentarHP(personaje);
                        break;
                    case 11:
                        personaje.spellSlots.Add(6, 1);
                        aumentarHP(personaje);
                        break;
                    case 12:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 13:
                        personaje.spellSlots.Add(7, 1);
                        aumentarHP(personaje);
                        break;
                    case 14:
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Circulo de la tierra":
                                personaje.caracteristicas.Add("Santuario de la naturaleza");
                                break;

                            case "Circulo de la luna":
                                personaje.proeficiencias.Add("Mil formas");
                                break;

                        }
                        aumentarHP(personaje);
                        break;
                    case 15:
                        personaje.spellSlots.Add(8, 1);
                        aumentarHP(personaje);
                        break;
                    case 16:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 17:
                        personaje.spellSlots.Add(9, 1);
                        aumentarHP(personaje);
                        break;
                    case 18:
                        personaje.caracteristicas.Add("Cuerpo eterno");
                        personaje.caracteristicas.Add("Conjuros bestiales");
                        aumentarHP(personaje);
                        break;
                    case 19:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        personaje.spellSlots[6] = 2;
                        break;
                    case 20:
                        personaje.caracteristicas.Add("Archidruida");
                        personaje.spellSlots[7] = 2;
                        aumentarHP(personaje);
                        break;
                }
            }
            personaje.nivel += cantidadNiveles;
        }
    }

    public class Guerrero : Clase
    {
        public static List<string> especializacionesPosibles = new List<string>()
        {
            "Caballero arcano", "Campeon", "Maestro de batalla"
        };
        public static List<string> estilosDeCombate = new List<string>()
        {
            "A distancia", "Defensa", "Duelista", "Lucha con arma a dos manos", "Proteccion", "Lucha con dos armas"
        };
        public static new string nombreClase = "Barbaro";

        public static void estiloDeCombate(Personaje personaje)
        {
            using (var form = new frmComboEleccion(estilosDeCombate, "Elija un estilo de combate para su guerrero..."))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    personaje.caracteristicas.Add("Estilo de combate: " + form.eleccion);
                }
                else if (form.DialogResult == DialogResult.Cancel)
                {
                    throw new Exception("Operacion cancelada");
                }
                form.Close();
            }
        }

        public static void subirDeNivel(Personaje personaje, int cantidadNiveles)
        {
            for (int i = personaje.nivel; i <= (personaje.nivel + cantidadNiveles); i++)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        personaje.clase = "Guerrero";
                        personaje.dadoHP = new Dado(1, 10);
                        personaje.hitPointsMaximos = 10 + personaje.atributos["Constitucion"];
                        personaje.proeficiencias.Add("Armadura ligera");
                        personaje.proeficiencias.Add("Armadura mediana");
                        personaje.proeficiencias.Add("Armadura pesada");
                        personaje.proeficiencias.Add("Escudos");
                        personaje.proeficiencias.Add("Armas simples");
                        personaje.proeficiencias.Add("Armas marciales");

                        personaje.savingThrows.Add("Fuerza");
                        personaje.savingThrows.Add("Constitucion");
                        List<string> opcionesDeGuerrero = new List<string>()
                        { "Acrobacias", "Atletimo", "Perspicacia", "Historia", "Intimidacion", "Manejo de animales", "Percepcion", "Supervivencia"};
                        foreach (string habilidad in Habilidad.elegirDeLista(opcionesDeGuerrero, 2))
                        {
                            personaje.habilidades[habilidad] = true;
                        }
                        Guerrero.estiloDeCombate(personaje);
                        personaje.caracteristicas.Add("Nuevas energias");
                        aumentarHP(personaje);
                        break;
                    case 2:
                        Clase.SetEspecializacion(personaje, especializacionesPosibles);
                        personaje.caracteristicas.Add("Oleada de accion");
                        aumentarHP(personaje);
                        break;
                    case 3:
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Caballero arcano":
                                personaje.caracteristicas.Add("Lanzamiento de hechizos");
                                personaje.spellSlots.Add(1, 2);
                                personaje.caracteristicas.Add("Ligadura de arma");
                                break;
                            case "Campeon":
                                personaje.caracteristicas.Add("Critico mejorado");
                                break;
                            case "Maestro de batalla":
                                personaje.caracteristicas.Add("Superioridad en combate");
                                personaje.caracteristicas.Add("Estudiante de guerra");
                                break;
                        }
                        aumentarHP(personaje);
                        break;
                    case 4:
                        Atributos.abilityScoreImprovement(personaje);
                        if(Clase.GetEspecializacion(personaje, especializacionesPosibles) == "Caballero arcano")
                        {
                            personaje.spellSlots[1] = 3;
                        }
                        aumentarHP(personaje);
                        break;
                    case 5:
                        personaje.caracteristicas.Add("Ataque extra");
                        aumentarHP(personaje);
                        break;
                    case 6:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 7:
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Caballero arcano":
                                personaje.spellSlots[1] = 4;
                                personaje.spellSlots.Add(2, 2);
                                personaje.caracteristicas.Add("Magia de guerra");
                                break;
                            case "Campeon":
                                personaje.caracteristicas.Add("Atleta destacado");
                                break;
                            case "Maestro de batalla":
                                personaje.caracteristicas.Add("Conoce a tu enemigo");
                                break;
                        }
                        aumentarHP(personaje);
                        break;
                    case 8:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 9:
                        personaje.caracteristicas.Add("Indomable");
                        aumentarHP(personaje);
                        break;
                    case 10:
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Caballero arcano":
                                personaje.spellSlots[2] = 3;
                                personaje.caracteristicas.Add("Golpe sobrenatural");
                                break;
                            case "Campeon":
                                Guerrero.estiloDeCombate(personaje);
                                break;
                            case "Maestro de batalla":
                                personaje.caracteristicas.Add("Superioridad en combate mejorada");
                                break;
                        }
                        aumentarHP(personaje);
                        break;
                    case 11:
                        aumentarHP(personaje);
                        break;
                    case 12:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 13:
                        if(Clase.GetEspecializacion(personaje, especializacionesPosibles) == "Caballero arcano")
                        {
                            personaje.spellSlots.Add(3, 2);
                        }
                        aumentarHP(personaje);
                        break;
                    case 14:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 15:
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Caballero arcano":
                                personaje.caracteristicas.Add("Carga arcana");
                                break;
                            case "Campeon":
                                personaje.caracteristicas.Add("Critico superior");
                                break;
                            case "Maestro de batalla":
                                personaje.caracteristicas.Add("Implacable");
                                break;
                        }
                        aumentarHP(personaje);
                        break;
                    case 16:
                        Atributos.abilityScoreImprovement(personaje);
                        if (Clase.GetEspecializacion(personaje, especializacionesPosibles) == "Caballero arcano")
                        {
                            personaje.spellSlots[3] = 3;
                        }
                        aumentarHP(personaje);
                        break;
                    case 17:
                        aumentarHP(personaje);
                        break;
                    case 18:
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Caballero arcano":
                                personaje.caracteristicas.Add("Magia de guerra mejorada");
                                break;
                            case "Campeon":
                                personaje.caracteristicas.Add("Superviviente");
                                break;
                            case "Maestro de batalla":
                                //Cambio de dado de superioridad
                                break;
                        }
                        aumentarHP(personaje);
                        break;
                    case 19:
                        Atributos.abilityScoreImprovement(personaje);
                        if (Clase.GetEspecializacion(personaje, especializacionesPosibles) == "Caballero arcano")
                        {
                            personaje.spellSlots.Add(4, 1);
                        }
                        aumentarHP(personaje);
                        break;
                    case 20:
                        //Mejora de ataque extra
                        aumentarHP(personaje);
                        break;
                }
            }
            personaje.nivel += cantidadNiveles;
        }
    }

    public class Monje : Clase
    {
        public static List<string> especializacionesPosibles = new List<string>()
        {
            "Camino de la mano abierta", "Camino de la sombra", "Camino de los cuatro elementos"
        };
        public static new string nombreClase = "Monje";   

        public static void subirDeNivel(Personaje personaje, int cantidadNiveles)
        {
            for (int i = personaje.nivel; i <= (personaje.nivel + cantidadNiveles); i++)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        personaje.clase = "Monje";
                        personaje.dadoHP = new Dado(1, 8);
                        personaje.hitPointsMaximos = 8 + personaje.atributos["Constitucion"];
                        personaje.proeficiencias.Add("Armas simples");
                        personaje.proeficiencias.Add("Espada corta");

                        personaje.savingThrows.Add("Fuerza");
                        personaje.savingThrows.Add("Destreza");
                        List<string> opcionesDeGuerrero = new List<string>()
                        { "Acrobacias", "Atletimo", "Perspicacia", "Historia", "Religion", "Sigilo"};
                        foreach (string habilidad in Habilidad.elegirDeLista(opcionesDeGuerrero, 2))
                        {
                            personaje.habilidades[habilidad] = true;
                        }
                        personaje.caracteristicas.Add("Defensa sin armadura");
                        personaje.caracteristicas.Add("Artes marciales");
                        aumentarHP(personaje);
                        break;
                    case 2:
                        personaje.caracteristicas.Add("Ki");
                        personaje.caracteristicas.Add("Movimiento sin armadura");
                        aumentarHP(personaje);
                        break;
                    case 3:
                        Clase.SetEspecializacion(personaje, especializacionesPosibles);
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Camino de la mano abierta":
                                personaje.caracteristicas.Add("Tecbuca de la mano abierta");
                                break;
                            case "Camino de la sombra":
                                personaje.caracteristicas.Add("Artes sombrias");
                                break;
                            case "Camino de los cuatro elementos":
                                personaje.caracteristicas.Add("Discipulo de los elementos");
                                break;
                        }
                        personaje.caracteristicas.Add("Desviar proyectiles");
                        aumentarHP(personaje);
                        break;
                    case 4:
                        Atributos.abilityScoreImprovement(personaje);
                        personaje.caracteristicas.Add("Caida lenta");
                        aumentarHP(personaje);
                        break;
                    case 5:
                        personaje.caracteristicas.Add("Ataque extra");
                        personaje.caracteristicas.Add("Golpe aturdidor");
                        aumentarHP(personaje);
                        break;
                    case 6:
                        personaje.caracteristicas.Add("Golpes potenciados con ki");
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Camino de la mano abierta":
                                personaje.caracteristicas.Add("Integridad del cuerpo");
                                break;
                            case "Camino de la sombra":
                                personaje.caracteristicas.Add("Paso sombrio");
                                break;
                            case "Camino de los cuatro elementos":
                                break;
                        }
                        aumentarHP(personaje);
                        break;
                    case 7:
                        personaje.caracteristicas.Add("Evasion");
                        personaje.caracteristicas.Add("Quietud de la menta");
                        aumentarHP(personaje);
                        break;
                    case 8:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 9:
                        aumentarHP(personaje);
                        break;
                    case 10:
                        personaje.caracteristicas.Add("Pureza del cuerpo");
                        aumentarHP(personaje);
                        break;
                    case 11:
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Camino de la mano abierta":
                                personaje.caracteristicas.Add("Tranquilidad");
                                break;
                            case "Camino de la sombra":
                                personaje.caracteristicas.Add("Capa de sombras");
                                break;
                            case "Camino de los cuatro elementos":
                                break;
                        }
                        aumentarHP(personaje);
                        break;
                    case 12:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 13:
                        personaje.caracteristicas.Add("Lengua del sol y la luna");
                        aumentarHP(personaje);
                        break;
                    case 14:
                        Atributos.abilityScoreImprovement(personaje);
                        personaje.caracteristicas.Add("Alma diamantina");
                        aumentarHP(personaje);
                        break;
                    case 15:
                        personaje.caracteristicas.Add("Cuerpo imperecedero");
                        aumentarHP(personaje);
                        break;
                    case 16:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 17:
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Camino de la mano abierta":
                                personaje.caracteristicas.Add("Palma temblorosa");
                                break;
                            case "Camino de la sombra":
                                personaje.caracteristicas.Add("Oportunista");
                                break;
                            case "Camino de los cuatro elementos":
                                break;
                        }
                        aumentarHP(personaje);
                        break;
                    case 18:
                        personaje.caracteristicas.Add("Cuerpo vacio");
                        aumentarHP(personaje);
                        break;
                    case 19:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 20:
                        personaje.caracteristicas.Add("Perfeccion de uno mismo");
                        aumentarHP(personaje);
                        break;
                }
            }
            personaje.nivel += cantidadNiveles;
        }
    }

    public class Paladin : Clase
    {
        public static List<string> especializacionesPosibles = new List<string>()
        {
            "Juramente de devocion", "Juramento de los ancestros", "Juramento de venganza"
        };

        public static List<string> estilosDeCombate = new List<string>()
        {
            "A distancia", "Defensa", "Duelista", "Lucha con arma a dos manos", "Proteccion", "Lucha con dos armas"
        };
        public static new string nombreClase = "Paladin";
        public static void estiloDeCombate(Personaje personaje)
        {
            using (var form = new frmComboEleccion(estilosDeCombate, "Elija un estilo de combate para su guerrero..."))
            {
                if (form.DialogResult == DialogResult.OK)
                {
                    personaje.caracteristicas.Add("Estilo de combate: " + form.eleccion);
                }
                else if (form.DialogResult == DialogResult.Cancel)
                {
                    throw new Exception("Operacion cancelada");
                }
                form.Close();
            }
        }
        
        public static void subirDeNivel(Personaje personaje, int cantidadNiveles)
        {
            for (int i = personaje.nivel; i <= (personaje.nivel + cantidadNiveles); i++)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        personaje.clase = "Paladin";
                        personaje.dadoHP = new Dado(1, 10);
                        personaje.hitPointsMaximos = 10 + personaje.atributos["Constitucion"];
                        personaje.proeficiencias.Add("Armadura ligera");
                        personaje.proeficiencias.Add("Armadura mediana");
                        personaje.proeficiencias.Add("Armadura pesada");
                        personaje.proeficiencias.Add("Escudos");
                        personaje.proeficiencias.Add("Armas simples");
                        personaje.proeficiencias.Add("Armas marciales");

                        personaje.savingThrows.Add("Sabiduria");
                        personaje.savingThrows.Add("Carisma");
                        List<string> opcionesDeGuerrero = new List<string>()
                        { "Atletimo", "Perspicacia", "Intimidacion", "Medicina","Persuasion","Religion"};
                        foreach (string habilidad in Habilidad.elegirDeLista(opcionesDeGuerrero, 2))
                        {
                            personaje.habilidades[habilidad] = true;
                        }
                        personaje.caracteristicas.Add("Imposicion de manos");
                        personaje.caracteristicas.Add("Sentido divino");
                        aumentarHP(personaje);
                        break;
                    case 2:
                        Paladin.estiloDeCombate(personaje);
                        personaje.caracteristicas.Add("Lanzamiento de hechizos");
                        personaje.caracteristicas.Add("Castigo divino");
                        personaje.spellSlots.Add(1, 2);
                        aumentarHP(personaje);
                        break;
                    case 3:
                        Clase.SetEspecializacion(personaje, especializacionesPosibles);
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Juramente de devocion":
                                personaje.caracteristicas.Add("Canalizar divinidad: Devocion");
                                break;
                            case "Juramento de los ancestros":
                                personaje.caracteristicas.Add("Canalizar divinidad: Ancestros");
                                break;
                            case "Juramento de venganza":
                                personaje.caracteristicas.Add("Canalizar divinidad: Venganza");
                                break;
                        }
                        personaje.caracteristicas.Add("Salud divina");
                        personaje.spellSlots[1] = 3;
                        aumentarHP(personaje);
                        break;
                    case 4:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 5:
                        personaje.caracteristicas.Add("Ataque extra");
                        personaje.spellSlots.Add(2, 2);
                        personaje.spellSlots[1] = 4;
                        aumentarHP(personaje);
                        break;
                    case 6:
                        personaje.caracteristicas.Add("Aura de proteccion");
                        aumentarHP(personaje);
                        break;
                    case 7:
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Juramente de devocion":
                                personaje.caracteristicas.Add("Aura de devocion");
                                break;
                            case "Juramento de los ancestros":
                                personaje.caracteristicas.Add("Aura de custodia");
                                break;
                            case "Juramento de venganza":
                                personaje.caracteristicas.Add("Vengador implacable");
                                break;
                        }
                        personaje.spellSlots[2] = 3;
                        aumentarHP(personaje);
                        break;
                    case 8:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 9:
                        aumentarHP(personaje);
                        personaje.spellSlots.Add(3, 2);
                        break;
                    case 10:
                        personaje.caracteristicas.Add("Aura de coraje");
                        aumentarHP(personaje);
                        break;
                    case 11:
                        personaje.caracteristicas.Add("Castigo divino mejorado");
                        personaje.spellSlots[3] = 3;
                        aumentarHP(personaje);
                        break;
                    case 12:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 13:
                        aumentarHP(personaje);
                        personaje.spellSlots.Add(4, 1);
                        break;
                    case 14:
                        personaje.caracteristicas.Add("Toque de purificacion");
                        aumentarHP(personaje);
                        break;
                    case 15:
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Juramente de devocion":
                                personaje.caracteristicas.Add("Pureza de espiritu");
                                break;
                            case "Juramento de los ancestros":
                                personaje.caracteristicas.Add("Centinela imperecedero");
                                break;
                            case "Juramento de venganza":
                                personaje.caracteristicas.Add("Alma de venganza");
                                break;
                        }
                        personaje.spellSlots[4] = 2;
                        aumentarHP(personaje);
                        break;
                    case 16:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 17:
                        aumentarHP(personaje);
                        personaje.spellSlots.Add(5, 1);
                        break;
                    case 18:
                        //mejora de auras
                        aumentarHP(personaje);
                        break;
                    case 19:
                        Atributos.abilityScoreImprovement(personaje);
                        personaje.spellSlots[5] = 2;
                        aumentarHP(personaje);
                        break;
                    case 20:
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Juramente de devocion":
                                personaje.caracteristicas.Add("Aura sagrada");
                                break;
                            case "Juramento de los ancestros":
                                personaje.caracteristicas.Add("Campeon ancestral");
                                break;
                            case "Juramento de venganza":
                                personaje.caracteristicas.Add("Angel vengador");
                                break;
                        }
                        aumentarHP(personaje);
                        break;
                }
            }
            personaje.nivel += cantidadNiveles;
        }
    }

    public class Explorador : Clase
    {
        public static List<string> especializacionesPosibles = new List<string>()
        {
            "Cazador", "Señor de las bestias"
        };
        public static new string nombreClase = "Explorador";
        public static List<string> estilosDeCombate = new List<string>()
        {
            "A distancia", "Defensa", "Duelista", "Lucha con dos armas"
        };

        public static void estiloDeCombate(Personaje personaje)
        {
            using (var form = new frmComboEleccion(estilosDeCombate, "Elija un estilo de combate para su explorador..."))
            {
                if (form.DialogResult == DialogResult.OK)
                {
                    personaje.caracteristicas.Add("Estilo de combate: " + form.eleccion);
                }
                else if (form.DialogResult == DialogResult.Cancel)
                {
                    throw new Exception("Operacion cancelada");
                }
                form.Close();
            }
        }

        public static void subirDeNivel(Personaje personaje, int cantidadNiveles)
        {
            for (int i = personaje.nivel; i <= (personaje.nivel + cantidadNiveles); i++)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        personaje.clase = "Explorador";
                        personaje.dadoHP = new Dado(1, 10);
                        personaje.hitPointsMaximos = 10 + personaje.atributos["Constitucion"];
                        personaje.proeficiencias.Add("Armadura ligera");
                        personaje.proeficiencias.Add("Armadura mediana");
                        personaje.proeficiencias.Add("Escudos");
                        personaje.proeficiencias.Add("Armas simples");
                        personaje.proeficiencias.Add("Armas marciales");
                        personaje.savingThrows.Add("Fuerza");
                        personaje.savingThrows.Add("Destreza");
                        List<string> opcionesDeGuerrero = new List<string>()
                        { "Atletimo", "Perspicacia", "Investigacion","Manejo de animales", "Naturaleza", "Percepcion", "Sigilo", "Supervivencia"};
                        foreach (string habilidad in Habilidad.elegirDeLista(opcionesDeGuerrero, 3))
                        {
                            personaje.habilidades[habilidad] = true;
                        }
                        personaje.caracteristicas.Add("Enemigo predilecto");
                        personaje.caracteristicas.Add("Explorador de lo natural");
                        break;
                    case 2:
                        Explorador.estiloDeCombate(personaje);
                        personaje.caracteristicas.Add("Lanzamiento de hechizos");
                        personaje.spellSlots.Add(1, 2);
                        aumentarHP(personaje);
                        break;
                    case 3:
                        Clase.SetEspecializacion(personaje, especializacionesPosibles);
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Cazador":
                                personaje.caracteristicas.Add("Presa del cazador");
                                break;
                            case "Señor de las bestias":
                                personaje.caracteristicas.Add("Compañero animal");
                                break;
                        }
                        personaje.caracteristicas.Add("Conciencia primitiva");
                        personaje.spellSlots[1] = 3;
                        aumentarHP(personaje);
                        break;
                    case 4:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 5:
                        personaje.caracteristicas.Add("Ataque extra");
                        personaje.spellSlots.Add(2, 2);
                        personaje.spellSlots[1] = 4;
                        aumentarHP(personaje);
                        break;
                    case 6:
                        aumentarHP(personaje);
                        break;
                    case 7:
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Cazador":
                                personaje.caracteristicas.Add("Tacticas defensivas");
                                break;
                            case "Señor de las bestias":
                                personaje.caracteristicas.Add("Entrenamiento excepcional");
                                break;
                        }
                        personaje.spellSlots[2] = 3;
                        aumentarHP(personaje);
                        break;
                    case 8:
                        Atributos.abilityScoreImprovement(personaje);
                        personaje.caracteristicas.Add("Zancada forestal");
                        aumentarHP(personaje);
                        break;
                    case 9:
                        aumentarHP(personaje);
                        personaje.spellSlots.Add(3, 2);
                        break;
                    case 10:
                        personaje.caracteristicas.Add("Ocultarse a plena vista");
                        aumentarHP(personaje);
                        break;
                    case 11:
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Cazador":
                                personaje.caracteristicas.Add("Ataque multiple");
                                break;
                            case "Señor de las bestias":
                                personaje.caracteristicas.Add("Furia bestial");
                                break;
                        }
                        personaje.spellSlots[3] = 3;
                        aumentarHP(personaje);
                        break;
                    case 12:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 13:
                        aumentarHP(personaje);
                        personaje.spellSlots.Add(4, 1);
                        break;
                    case 14:
                        personaje.caracteristicas.Add("Esfumarse");
                        aumentarHP(personaje);
                        break;
                    case 15:
                        switch (Clase.GetEspecializacion(personaje, especializacionesPosibles))
                        {
                            case "Cazador":
                                personaje.caracteristicas.Add("Defensa superior del cazador");
                                break;
                            case "Señor de las bestias":
                                personaje.caracteristicas.Add("Compartir conjuros");
                                break;
                        }
                        personaje.spellSlots[4] = 2;
                        aumentarHP(personaje);
                        break;
                    case 16:
                        Atributos.abilityScoreImprovement(personaje);
                        aumentarHP(personaje);
                        break;
                    case 17:
                        aumentarHP(personaje);
                        personaje.spellSlots.Add(5, 1);
                        break;
                    case 18:
                        personaje.caracteristicas.Add("Sentidos salvajes");
                        aumentarHP(personaje);
                        break;
                    case 19:
                        Atributos.abilityScoreImprovement(personaje);
                        personaje.spellSlots[5] = 2;
                        aumentarHP(personaje);
                        break;
                    case 20:
                        personaje.caracteristicas.Add("Asesino de enemigos");
                        aumentarHP(personaje);
                        break;
                }
            }
            personaje.nivel += cantidadNiveles;
        }
    }
}
