using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3P_Examen___Ana_Belén_Díaz_Castañeda
{
    public partial class Inicio : Form
    {       
        Acciones acc=new Acciones();
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgDatos.DataSource = null;
            dgDatos.DataSource = acc.MostrarPropiedades();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (acc.EliminarPropiedades(Convert.ToInt32(txbId.Text)))
                MessageBox.Show("Eliminado con exito");
            else
                MessageBox.Show("Fallo al eliminar");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (acc.InsertarPropiedades(Convert.ToInt32(txbNewId.Text), txbNombre.Text, Convert.ToDateTime(txbFechaRegistro.Text), Convert.ToBoolean(txbActivo.Text), txbColorInterfaz.Text))
                MessageBox.Show("Agregado con exito");
            else
                MessageBox.Show("Fallo al agregar");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (acc.ActualizarPropiedades(Convert.ToInt32(txbNewId.Text), txbNombre.Text, Convert.ToDateTime(txbFechaRegistro.Text), Convert.ToBoolean(txbActivo.Text), txbColorInterfaz.Text))
            {
                MessageBox.Show("Actualizado con exito");
                dgDatos.DataSource = null;
                dgDatos.DataSource = acc.MostrarPropiedades();  
            }
            else
            {
                MessageBox.Show("Fallo al actualizar");
            }

        }
    }
}
