using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLabo_Intento2
{
    public abstract class Usuario
    {
        public string usuario { get; }
        string contraseña;

        public Usuario(string usuario, string contraseña)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
        }
        public bool validacion(string usuario, string contraseña)
        {
            return (usuario == this.usuario && contraseña == this.contraseña);
        }
    }

    public class Jugador : Usuario
    {
        public Jugador(string usuario, string contraseña) : base(usuario, contraseña)
        {
        }
    }
    public class DungeonMaster : Usuario
    {
        public DungeonMaster(string usuario, string contraseña) : base(usuario, contraseña)
        {
        }
    }
    public class SuperAdmin : Usuario
    {
        public SuperAdmin(string usuario, string contraseña) : base(usuario, contraseña)
        {
        }
    }
}
