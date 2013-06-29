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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }        

        public void iniciarSeccion() {
            if (textBox1.Text == "TEC" && textBox2.Text == "123")
            {
                this.Hide();
                Dashboard NuevaPrincipal = new Dashboard();
                NuevaPrincipal.Show();
            }
            else
            {
                label5.Text = "El usuario es incorrecto";
                //System.Threading.Thread.Sleep(100);
                //label5.Text = null;                
            }
        }

        public void Entrar(object sender, System.Windows.Forms.KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
            {
                iniciarSeccion();
            }
        }


        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            iniciarSeccion();          
        }
    }
}
