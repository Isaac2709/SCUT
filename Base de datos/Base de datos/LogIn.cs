﻿using System;
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iniciarSeccion();          
        }
    }
}
