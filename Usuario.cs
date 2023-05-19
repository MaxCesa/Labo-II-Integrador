﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2
{
    public abstract class Usuario
    {
        public string username { get; set; }
        public string contraseña { get; set; }
        public string tipo { get; set; }
        public Usuario() { }
        public Usuario(string usuario, string contraseña)
        {
            this.username = usuario;
            this.contraseña = contraseña;
        }
        public bool validacion(string usuario, string contraseña)
        {
            return (usuario == this.username && contraseña == this.contraseña);
        }
    }

    public class Jugador : Usuario
    {
        public Jugador(string usuario, string contraseña) : base(usuario, contraseña)
        {
            this.tipo = "Jugador";
        }
    }
    public class SuperAdmin : Usuario
    {
        public SuperAdmin(string usuario, string contraseña) : base(usuario, contraseña)
        {
            this.tipo = "SuperAdmin";
        }
    }
}
