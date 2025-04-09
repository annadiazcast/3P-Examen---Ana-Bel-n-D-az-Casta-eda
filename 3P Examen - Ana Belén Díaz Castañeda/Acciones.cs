using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Examen___Ana_Belén_Díaz_Castañeda
{
    internal class Acciones
    {
        List<Propiedades> listapropiedades = new List<Propiedades>()
        {
            new Propiedades(1126,"Nintendo",DateTime.Today,true,"Azul"),
            new Propiedades(1145,"Ps5",DateTime.Today,false,"Rosa"),
            new Propiedades(1133,"Xbox",DateTime.Today,true,"Negro"),
            new Propiedades(1188,"Ps4",DateTime.Today,true,"Rojo"),
            new Propiedades(1122,"GameBoy",DateTime.Today,false,"Blanco")
        };
        Propiedades p = new Propiedades();
        public List<Propiedades> MostrarPropiedades()
        {
            return listapropiedades;
        }
        public bool EliminarPropiedades(int id)
        {
            try
            {
                var objeliminar = listapropiedades.Find(x => x.Id == id);
                if (objeliminar != null)
                {
                    listapropiedades.Remove(objeliminar);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool InsertarPropiedades(int id, string nombre, DateTime fechaRegistro, bool activo, string colorInterfaz)
        {
            try
            {
                listapropiedades.Add(new Propiedades(p.Id = id, p.Nombre = nombre, p.FechaRegistro = fechaRegistro, p.Activo = activo, p.ColorInterfaz = colorInterfaz));
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool ActualizarPropiedades(int id, string nombre, DateTime fechaRegistro, bool activo, string colorInterfaz)
        {
            try
            {
                var objactualizar = listapropiedades.Find(x => x.Id == id);
                if (objactualizar != null)
                {
                    objactualizar.Nombre = nombre;
                    objactualizar.FechaRegistro = fechaRegistro;
                    objactualizar.Activo = activo;
                    objactualizar.ColorInterfaz = colorInterfaz;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }
    
}
