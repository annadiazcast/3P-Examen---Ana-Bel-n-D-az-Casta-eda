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
    public partial class Form1 : Form
    {
        Usuarios usuarios=new Usuarios();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user=tbxUsuario.Text;
            string password=tbxContraseña.Text;

            var lista = usuarios.ObtenerUsuarios();
            var validar=lista.FirstOrDefault(u=>u.NomUsuario==user && u.Contrasenia==password);
            if (validar!=null)
            {
                this.Hide();
                Inicio inicio= new Inicio();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Fallaste");
            }
        }
    }
}
