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
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
            llenarComboBox();
            SetMyCustomFormat();
        }

        public void llenarComboBox()
        {
            //SqlConnection conn = new SqlConnection("Data Source=Isaac-PC;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345");
            comboBoxMantenimiento.Items.Clear();
            comboBoxMantenimiento.Items.Add("Mantenimiento");
            comboBoxMantenimiento.Items.Add("Reparacion");
            SqlConnection conn = new SqlConnection("Data Source=MAFALDA;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345");
            conn.Open();
            string consulta = string.Format("select placa from vehiculos");
            SqlCommand cmd = new SqlCommand(consulta, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            comboBoxVehiculo.Items.Clear();
            while (dr.Read())
            {
                comboBoxVehiculo.Items.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();
        }
        public void llenarComboBoxAgencia()
        {            
            SqlConnection conn = new SqlConnection("Data Source=MAFALDA;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345");
            conn.Open();
            string consulta = string.Format("select nombre+' |'+cedula_jur_ag from agencia");
            SqlCommand cmd = new SqlCommand(consulta, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            comboBox.Items.Clear();
            while (dr.Read())
            {
                comboBox.Items.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();
        }
        public void llenarComboBoxTalleres()
        {
            SqlConnection conn = new SqlConnection("Data Source=MAFALDA;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345");
            conn.Open();
            string consulta = string.Format("select nombre+' |'+cedula_jur_talleres from talleres");
            SqlCommand cmd = new SqlCommand(consulta, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            comboBox.Items.Clear();
            while (dr.Read())
            {
                comboBox.Items.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();
        }

        public void SetMyCustomFormat()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.Mantenimiento metodosMantenimiento = new Data.Mantenimiento();
            String respuesta="Debe seleccionar un taller o agencia";
            if (checkBoxTalleres.Checked == true) {   
                String monto = textBoxMonto.Text;
                String detalle = textBoxDetalle.Text;
                String tipoMantenimento = comboBoxMantenimiento.Text;
                int numeroFactura=Int32.Parse(textBoxNumeroFactura.Text);
                String fecha = dateTimePicker1.Text;
                String cedula_jur_talleres = comboBox.Text;

                String[] CedulaJurTalleres;
                CedulaJurTalleres = cedula_jur_talleres.Split('|');  

                String placa_Vehiculo = comboBoxVehiculo.Text;
                respuesta = metodosMantenimiento.insertarMantenimiento(monto, detalle, tipoMantenimento, numeroFactura, fecha, CedulaJurTalleres[1], "null", placa_Vehiculo);
                
            }
            else if(checkBoxAgencia.Checked == true){
                String detalle = textBoxDetalle.Text;
                String tipoMantenimento = comboBoxMantenimiento.Text;
                int numeroFactura=Int32.Parse(textBoxNumeroFactura.Text);
                String fecha = dateTimePicker1.Text;
                String cedula_jur_ag = comboBox.Text;
                String[] CedulaJurAgencia;
                CedulaJurAgencia = cedula_jur_ag.Split('|'); 
                String placa_Vehiculo = comboBoxVehiculo.Text;
                respuesta = metodosMantenimiento.insertarMantenimiento("null", detalle, tipoMantenimento, numeroFactura, fecha, "null", CedulaJurAgencia[1], placa_Vehiculo);
            }
            MessageBox.Show(respuesta);
        }

        private void checkBoxAgencia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAgencia.Checked) {
                comboBox.Text = null;
                comboBox.Items.Clear();
                llenarComboBoxAgencia();
                textBoxMonto.Enabled = false;
                checkBoxTalleres.Checked = false;                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTalleres.Checked)
            {
                comboBox.Text = null;
                comboBox.Items.Clear();
                llenarComboBoxTalleres();                
                if (textBoxMonto.Enabled == false) {                    
                    textBoxMonto.Enabled = true;
                    checkBoxAgencia.Checked = false;                    
                }
            }
        }
    }
}
