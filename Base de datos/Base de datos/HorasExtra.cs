using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Base_de_datos
{
    public partial class HorasExtra : Form
    {
        public HorasExtra()
        {
            InitializeComponent();
            llenarComboBox();
        }

        public void llenarComboBox()
        {
            //SqlConnection conn = new SqlConnection("Data Source=Isaac-PC;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345");
            SqlConnection conn = new SqlConnection("Data Source=MAFALDA;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345");                               
            conn.Open();
            string consulta = string.Format("select nombre+' '+apellido1+' '+apellido2+' |'+id_U from usuarios");
            string consultaCentroCosto = string.Format("select nombre+' |'+id_CC from Centro_Costo");
            SqlCommand cmd = new SqlCommand(consulta, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            comboBoxUsuario.Items.Clear();
            while (dr.Read())
            {
                comboBoxUsuario.Items.Add(dr[0].ToString());
            }
            dr.Close();

            SqlCommand cmdCentroCosto = new SqlCommand(consultaCentroCosto, conn);
            SqlDataReader drCentroCosto;
            drCentroCosto = cmdCentroCosto.ExecuteReader();
            comboBoxCentroCosto.Items.Clear();
            while (drCentroCosto.Read())
            {
                comboBoxCentroCosto.Items.Add(drCentroCosto[0].ToString());
            }
            drCentroCosto.Close();
            conn.Close();
        }

        public void SetMyCustomFormat()
        {
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }


        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SetMyCustomFormat();
            int Oficio = Int32.Parse(textBoxOficioAprobacion.Text);
            String idUsuario = comboBoxUsuario.Text;
            string[] idU;
            idU = idUsuario.Split('|');

            String idCC=comboBoxCentroCosto.Text;
            string[] id_CC;
            id_CC = idCC.Split('|');
            String fecha = dateTimePicker3.Text;
            String Actividad = textBox9.Text;
            Data.HorasExtras horasExtras = new Data.HorasExtras();
            string respuesta = horasExtras.insertarHoras_Extras(Oficio, textBoxHoraInicio.Text, textBoxHoraFin.Text, fecha, id_CC[1], idU[1], Actividad);
            MessageBox.Show(respuesta);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String buscar = textBox5.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Oficio = textBox4.Text;
            String idUsuario = textBox2.Text;
            String id = textBox1.Text;
            String fecha = dateTimePicker1.Text;
            decimal HoraI = numericUpDown4.Value;
            decimal HoraF = numericUpDown1.Value;
            String Actividad = textBox3.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String buscar = textBox5.Text;
        }

        private void textBoxHoraInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.Equals(textBoxHoraInicio.Text, "hh:mm"))
            {
                textBoxHoraInicio.Clear();
                //this.textBoxHoraInicio.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
                this.textBoxHoraInicio.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void textBoxHoraInicio_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.Equals(textBoxHoraInicio.Text, "hh:mm")) { textBoxHoraInicio.Clear(); this.textBoxHoraInicio.ForeColor = System.Drawing.SystemColors.WindowText; }
        }

        private void textBoxHoraFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.Equals(textBoxHoraFin.Text, "hh:mm")) { textBoxHoraFin.Clear(); this.textBoxHoraFin.ForeColor = System.Drawing.SystemColors.WindowText; }
        }

        private void textBoxHoraFin_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.Equals(textBoxHoraFin.Text, "hh:mm")) { textBoxHoraFin.Clear(); this.textBoxHoraFin.ForeColor = System.Drawing.SystemColors.WindowText; }
        }
    }
}
