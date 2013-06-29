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
    public partial class Agencias : Form
    {
        public Agencias()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string cedulaJ =  textBox10.Text;
            String nombre = textBox26.Text;
            String email = textBox13.Text;
            String telefono = textBox6.Text;
            String direccion = textBox11.Text;
            Data.Agencia metodosDatos = new Data.Agencia();            
            string respuesta = metodosDatos.insertarAgencia(cedulaJ, direccion, telefono,email,nombre);
            MessageBox.Show(respuesta);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string cedulaJ = textBox4.Text;
            String nombre = textBox1.Text;
            String email = textBox3.Text;
            String telefono = textBox7.Text;
            String dirrecion = textBox2.Text;
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string buscar = textBox5.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buscar = textBox5.Text;
        }
    }
}
