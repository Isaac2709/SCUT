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
    public partial class Usuarios : Form
    {

        
        public Usuarios()
        {
            InitializeComponent();
            llenarComboBox();
        }

        public void llenarComboBox()
        {
            comboBox5.Items.Add("A1");
            comboBox5.Items.Add("A2");
            comboBox5.Items.Add("A3");
            comboBox5.Items.Add("A4");
            comboBox5.Items.Add("B1");
            comboBox5.Items.Add("B2");
            comboBox5.Items.Add("B3");
            comboBox5.Items.Add("B4");
            comboBox5.Items.Add("C1");
            comboBox5.Items.Add("C2");
            comboBox5.Items.Add("D1");
            comboBox5.Items.Add("D2");
            comboBox5.Items.Add("D3");
            comboBox5.Items.Add("E1");
            comboBox5.Items.Add("E2");            
        }

        public void SetMyCustomFormat()
        {
            fecha.Format = DateTimePickerFormat.Custom;
            fecha.CustomFormat = "dd-MM-yyyy";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Data.Usuario metodosDatos = new Data.Usuario();
            string respuesta = metodosDatos.insertarLicencias(textBox15.Text, comboBox5.Text);
            MessageBox.Show(respuesta);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox15.Clear();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }       

        private void button7_Click(object sender, EventArgs e)
        {
            SetMyCustomFormat();
            Data.Usuario metodosDatos = new Data.Usuario();
            char genero='M';
            if (radioButton4.Checked) genero = 'M';
            if (radioButton3.Checked) genero = 'F';
            string fecha2 = fecha.Text;
            string respuesta = metodosDatos.insertarUsuarios(textID.Text, texcedula.Text, texnombre.Text, texapellido1.Text, texapellido2.Text, fecha.Text, genero, texdirreccion.Text, texemail.Text, combo2.Text, 'A', textBox9.Text);            
            MessageBox.Show(respuesta);
        }

        private void button11_Click(object sender, EventArgs e)
        {            
            Data.Usuario metodosDatos = new Data.Usuario();                    
            string respuesta = metodosDatos.insertarTelefonos(textBox14.Text, textBox16.Text);
            MessageBox.Show(respuesta);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox14.Clear(); textBox16.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valBuscar = textBox7.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //editar información
            /*
            SetMyCustomFormat();
            Data.Usuario metodosDatos = new Data.Usuario();
            char genero='M';
            if (radioButton1.Checked) genero = 'M';
            if (radioButton2.Checked) genero = 'F';
            string fecha2 = dateTimePicker1.Text;

            string valCedula = textBox1.Text;
            string valNombre = textBox2.Text;
            string valApellido1 = textBox3.Text;
            string valApellido2 = textBox4.Text;
            string valEmail = textBox5.Text;

            string valdeparta = textBox8.Text;
            string puesto = comboBox2.Text;

            string dirrecion = textBox6.Text;


            //string respuesta = metodosDatos.insertarUsuarios(textID.Text, texcedula.Text, texnombre.Text, texapellido1.Text, texapellido2.Text, fecha.Text, genero, texdirreccion.Text, texemail.Text, combo2.Text, 'A', textBox9.Text);            
            //MessageBox.Show(respuesta);
            */
            
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {


            /*SetMyCustomFormat();
            Data.Usuario metodosDatos = new Data.Usuario();
            char genero = 'M';
            if (radioButton1.Checked) genero = 'M';
            if (radioButton2.Checked) genero = 'F';
            string fecha2 = dateTimePicker1.Text;

            string valCedula = textBox1.Text;
            string valNombre = textBox2.Text;
            string valApellido1 = textBox3.Text;
            string valApellido2 = textBox4.Text;
            string valEmail = textBox5.Text;

            string valdeparta = textBox8.Text;
            string puesto = comboBox2.Text;

            string dirrecion = textBox6.Text;*/

            //string respuesta = metodosDatos.insertarUsuarios(textID.Text, texcedula.Text, texnombre.Text, texapellido1.Text, texapellido2.Text, fecha.Text, genero, texdirreccion.Text, texemail.Text, combo2.Text, 'A', textBox9.Text);            
            //MessageBox.Show(respuesta);
            


        }
    }
}
