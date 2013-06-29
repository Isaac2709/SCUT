using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_de_datos
{
    public partial class Talleres : Form
    {
        public Talleres()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //insertarTalleres(string cedula_Jur_Talleres,string nombre,string especialidad, string email,string direccion,string telefono)
            Data.Talleres metodosDatos = new Data.Talleres();
            string respuesta = metodosDatos.insertarTalleres(textBoxCedulaJuridica.Text, textBoxNombre.Text, textBoxEspecialidad.Text, textBoxEmail.Text, textBoxDireccion.Text, textBoxTelefono.Text);
            MessageBox.Show(respuesta);

        }
    }
}
