using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Examen___Ana_Belén_Díaz_Castañeda
{
    internal class Propiedades: Consola
    {
        public Propiedades(int id, string nombre, DateTime fechaRegistro, bool activo,string colorInterfaz)
            :base(id,nombre,fechaRegistro,activo)
        {
            ColorInterfaz = colorInterfaz;
        }
        public Propiedades() { }
        public string ColorInterfaz { get; set; }
    }
}
