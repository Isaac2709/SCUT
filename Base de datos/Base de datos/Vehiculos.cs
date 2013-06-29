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
    public partial class Vehiculos : Form
    {
        public Vehiculos()
        {
            InitializeComponent();
            SetMyCustomFormat();
            llenarComboBox();
        }

        public void SetMyCustomFormat()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        public void llenarComboBox()
        {
            comboBoxVelocidades.Items.Add("Automatico");
            comboBoxVelocidades.Items.Add("Manual");
            comboBoxTipoCombustible.Items.Add("Regular");
            comboBoxTipoCombustible.Items.Add("Super");
            comboBoxTipoCombustible.Items.Add("Diesel");
            //SqlConnection conn = new SqlConnection("Data Source=Isaac-PC;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345");
            SqlConnection conn = new SqlConnection("Data Source=MAFALDA;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345");
            conn.Open();
            string consulta = string.Format("select nombre +' |'+ cedula_jur_ag from agencia");
            SqlCommand cmd = new SqlCommand(consulta, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            comboBoxCedulaJuridiga.Items.Clear();
            while (dr.Read())
            {
                comboBoxCedulaJuridiga.Items.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String Placa = textBox6.Text;
            String Estilo = textBoxEstilo.Text;
            int Kilometraje = Int32.Parse(textBoxKilometraje.Text);
            decimal Capacidad = numericUpDown1.Value;
            String TipoCom = comboBoxTipoCombustible.Text;
            String Marca = textBoxMarca.Text;
            int Modelo = Int32.Parse(textBox5.Text);
            String Departamento = textBoxDepartamento.Text;
            String FechaCompra = dateTimePicker1.Text;
            int IdGarantia = Int32.Parse(textBox4.Text);
            String Sucursal = textBoxSucursal.Text;
            String CedJur = comboBoxCedulaJuridiga.Text;
            String[] id;
            id = CedJur.Split('|');
            String Descripcion = textBox3.Text;
           String NumeroChasis = textBoxNumeroChasis.Text;
           String NumeroMotor = textBoxNumeroMotor.Text;
           int Cilindros = Int32.Parse(textBoxCilindros.Text);
           String Cilindrada = textBoxCilindrada.Text;
           String Color = textBoxColor.Text;
           decimal Puertas = numericUpDownPuertas.Value;
           Data.Vehiculos metodosDatos = new Data.Vehiculos();
           Char Velocidades = (comboBoxVelocidades.Text)[0];
           string respuesta = metodosDatos.insertarVehiculos(Placa, Departamento, Descripcion, Modelo, NumeroChasis, NumeroMotor, Cilindros, Cilindrada, Color, Puertas, TipoCom, Marca, Estilo, FechaCompra, Kilometraje, Capacidad, Velocidades, IdGarantia, id[1], Sucursal);
           MessageBox.Show(respuesta);           
           }                 

        private void button16_Click(object sender, EventArgs e)
        {
            String Placa = textBox12.Text;
            String Tipo = comboBox4.Text;
            decimal Kilometraje = numericUpDown5.Value;
            decimal Capacidad = numericUpDown6.Value;
            String TipoCom = comboBox5.Text;
            String Marca = comboBox6.Text;
            String Modelo = textBox14.Text;
            String Departamento = comboBox7.Text;
            String FechaCompra = dateTimePicker4.Text;
            String IdGarantia = textBox15.Text;
            String Sucursal = comboBox8.Text;
            String CedJur = comboBox9.Text;
            String Descripcion = textBox16.Text;
           

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
        }
    }
}
