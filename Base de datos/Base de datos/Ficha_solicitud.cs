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
    public partial class Ficha_solicitud : Form
    {
        public Ficha_solicitud()
        {
            InitializeComponent();
            SetMyCustomFormat();
        }

        public void SetMyCustomFormat()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker6.Format = DateTimePickerFormat.Custom;
            dateTimePicker6.CustomFormat = "dd-MM-yyyy";
            dateTimePicker7.Format = DateTimePickerFormat.Custom;
            dateTimePicker7.CustomFormat = "dd-MM-yyyy";
        }

        private void llenarInfo() {
            textBoxNumeroSolicitud.Text = "7777";
            textBoxTipoActividad.Text = "Recreo";
            textBoxSalida.Text = "08:00";
            textBoxLlegada.Text = "12:00";
            textBoxKilometrajeInicial.Text = "1000";
            textBoxKilometrajeFinal.Text = "12600";
            dateTimePicker6.Text = "03-04-2013";
            dateTimePicker7.Text = "04-04-2013";
            textBoxRuta.Text = "San Jose";
            textBoxIDUsuario.Text = "00000004";
            textBoxPlaca.Text = "444-444";
            textBoxIDCentroCosto.Text = "0000-0000-0004";
        }

        private void button14_Click(object sender, EventArgs e)
        {            
           int  NumeroSoli = Int32.Parse(textBoxNumeroSolicitud.Text);
           String TipoActividad = textBoxTipoActividad.Text;
           String FechaSalida = dateTimePicker6.Text;
           String FechaLlegada = dateTimePicker7.Text;
           int KilomInicio = Int32.Parse(textBoxKilometrajeInicial.Text);
           int kilomLlegada = Int32.Parse(textBoxKilometrajeFinal.Text);
           String HoraSalida = textBoxSalida.Text;
           String HoraLlegada = textBoxLlegada.Text;
           String Ruta = textBoxRuta.Text;
           String IdUsuario = textBoxIDUsuario.Text;
           String Placa = textBoxPlaca.Text;
           String CentroC = textBoxIDCentroCosto.Text;
           Data.SolicitudFichaSalida metodosDatos = new Data.SolicitudFichaSalida();
           string resultado = metodosDatos.insertarSolicitudFichaSalida(NumeroSoli, TipoActividad, HoraSalida, HoraLlegada, KilomInicio, kilomLlegada, Ruta, FechaSalida, FechaLlegada, IdUsuario, Placa, CentroC);
           MessageBox.Show(resultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String NumeroSoli = textBox6.Text;
            String TipoActividad = comboBox1.Text;
            String FechaSalida = dateTimePicker2.Text;
            String FechaLlegada = dateTimePicker1.Text;
            decimal KilomInicio = numericUpDown2.Value;
            decimal kiloLlegada = numericUpDown1.Value;
            String HoraSalida = textBox9.Text;
            String HoraLlegada = textBox10.Text;
            String Ruta = textBox5.Text;
            String IdUsuario = textBox4.Text;
            String Placa = textBox3.Text;
            String CentroC = textBox2.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buscar = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string buscar = textBox1.Text;
        }

        private void textBoxSalida_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.Equals(textBoxSalida.Text, "hh:mm")) { textBoxSalida.Clear(); this.textBoxSalida.ForeColor = System.Drawing.SystemColors.WindowText; }
        }

        private void textBoxSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.Equals(textBoxSalida.Text, "hh:mm")) { textBoxSalida.Clear(); this.textBoxSalida.ForeColor = System.Drawing.SystemColors.WindowText; }
        }

        private void textBoxLlegada_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.Equals(textBoxLlegada.Text, "hh:mm")) { textBoxLlegada.Clear(); this.textBoxLlegada.ForeColor = System.Drawing.SystemColors.WindowText; }
        }

        private void textBoxLlegada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.Equals(textBoxLlegada.Text, "hh:mm")) { textBoxLlegada.Clear(); this.textBoxLlegada.ForeColor = System.Drawing.SystemColors.WindowText; }
        }

        
    }
}
