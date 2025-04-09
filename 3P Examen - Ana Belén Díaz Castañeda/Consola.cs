using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Examen___Ana_Belén_Díaz_Castañeda
{
    internal class Consola
    {
        public Consola(int id, string nombre, DateTime fechaRegistro, bool activo)
        {
            Id = id;
            Nombre = nombre;
            FechaRegistro = fechaRegistro;
            Activo = activo;
        }
        public Consola() { }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }
    }
}
