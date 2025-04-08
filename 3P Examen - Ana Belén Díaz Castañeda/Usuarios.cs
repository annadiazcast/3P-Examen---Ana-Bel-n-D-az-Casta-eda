using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Examen___Ana_Belén_Díaz_Castañeda
{
    internal class Usuarios
    {
        public Usuarios() { }
        private static List<Usuarios> usuarios = new List<Usuarios>
        {
            new Usuarios{NomUsuario="Ana",Contrasenia="1234"},
            new Usuarios{NomUsuario="Ara",Contrasenia="4321"},
        };
        public List<Usuarios> ObtenerUsuarios()
        {
            return usuarios;
        }
        public string NomUsuario { get; set; }
        public string Contrasenia { get; set; }
    }
}
