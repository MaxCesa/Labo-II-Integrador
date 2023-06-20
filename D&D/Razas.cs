using PrimerParcialLabo_Intento2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    enum Razas
    {
        Enano,
        Elfo,
        Mediano,
        Humano,
        Gnomo,
        MedioElfo,
        MedioOrco,
        Tiefling
    }

    public static class Enano
    {
        public static void OtorgarRaza(Personaje personaje)
        {
            personaje.raza = "Enano";
            personaje.velocidad = 25;
            personaje.caracteristicas.Add("Darkvision");
            personaje.caracteristicas.Add("Resistencia enana");
            personaje.caracteristicas.Add("Stonecutting");
            personaje.lenguajes.Add("Enano");
            personaje.atributos["Constitucion"] += 2;
        }
    }

    public static class Elfo
    {

        public static void OtorgarRaza(Personaje personaje)
        {
            personaje.raza = "Enano";
            personaje.velocidad = 30;
            personaje.caracteristicas.Add("Darkvision");
            personaje.caracteristicas.Add("Keen senses");
            personaje.caracteristicas.Add("Fey ancestry");
            personaje.caracteristicas.Add("Trance");
            personaje.lenguajes.Add("Elfico");
            personaje.atributos["Destreza"] += 2;
        }
    }

    public static class Mediano
    {
        public static void OtorgarRaza(Personaje personaje)
        {
            personaje.raza = "Mediano";
            personaje.velocidad = 25;
            personaje.caracteristicas.Add("Suertudo");
            personaje.caracteristicas.Add("Valiente");
            personaje.caracteristicas.Add("Agilidad de Mediano");
            personaje.lenguajes.Add("Mediano");
            personaje.atributos["Destreza"] += 2;
        }
    }
    public static class Humano
    {
        public static void OtorgarRaza(Personaje personaje)
        {
            personaje.raza = "Humano";
            personaje.velocidad = 30;
            personaje.lenguajes.Add(Lenguajes.elegirLenguaje());
            personaje.atributos["Destreza"] += 1;
            personaje.atributos["Fuerza"] += 1;
            personaje.atributos["Inteligencia"] += 1;
            personaje.atributos["Sabiduria"] += 1;
            personaje.atributos["Constitucion"] += 1;
            personaje.atributos["Carisma"] += 1;
        }
    }

    public static class Gnomo
    {
        public static void OtorgarRaza(Personaje personaje)
        {
            personaje.raza = "Gnomo";
            personaje.velocidad = 25;
            personaje.lenguajes.Add("Gnómico");
            personaje.atributos["Inteligencia"] += 2;
            personaje.caracteristicas.Add("Darkvision");
            personaje.caracteristicas.Add("Astucia de Gnomo");
        }
    }
    public static class MedioElfo
    {
        public static void OtorgarRaza(Personaje personaje)
        {
            personaje.raza = "Medio-Elfo";
            personaje.velocidad = 30;
            personaje.caracteristicas.Add("Darkvision");
            personaje.caracteristicas.Add("Fey ancestry");
            personaje.lenguajes.Add("Elfico");
            personaje.lenguajes.Add(Lenguajes.elegirLenguaje());
            personaje.atributos["Carisma"] += 2;
            personaje.atributos[Atributos.elegirAtributo()] += 1;
            personaje.atributos[Atributos.elegirAtributo()] += 1;
            personaje.habilidades[Habilidad.elegirHabilidad()] = true;
            personaje.habilidades[Habilidad.elegirHabilidad()] = true;

        }
    }
    public static class MedioOrco
    {

        public static void OtorgarRaza(Personaje personaje)
        {
            personaje.raza = "Medio-Orco";
            personaje.velocidad = 30;
            personaje.caracteristicas.Add("Darkvision");
            personaje.caracteristicas.Add("Amenazante");
            personaje.caracteristicas.Add("Resistencia implacable");
            personaje.caracteristicas.Add("Ataques salvajes");
            personaje.lenguajes.Add("Orco");
            personaje.atributos["Fuerza"] += 2;
            personaje.atributos["Constitucion"] += 1;
        }
    }
    public static class Tiefling
    {
        public static void OtorgarRaza(Personaje personaje)
        {
            personaje.raza = "Tiefling";
            personaje.velocidad = 30;
            personaje.caracteristicas.Add("Darkvision");
            personaje.caracteristicas.Add("Resistencia infernal");
            personaje.caracteristicas.Add("Legado infernal");
            personaje.lenguajes.Add("Infernal");
            personaje.atributos["Carisma"] += 2;
            personaje.atributos["Inteligencia"] += 1;
        }
    }
}
