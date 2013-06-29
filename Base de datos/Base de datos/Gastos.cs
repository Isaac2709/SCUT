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
    public partial class Gastos : Form
    {
        public Gastos()
        {
            InitializeComponent();
            llenarComboBox();
        }

        private void Editar_gastos_Load(object sender, EventArgs e)
        {

        }

        public void SetMyCustomFormat()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        public void llenarComboBox()
        {
            SqlConnection conn = new SqlConnection("Data Source=Isaac-PC;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345");
            conn.Open();
            string consulta = string.Format("select nombre+' '+apellido1+' '+apellido2+' |'+id_U from usuarios");
            string consultaPlaca = string.Format("select placa from vehiculos");
            SqlCommand cmd = new SqlCommand(consulta, conn);            
            SqlDataReader dr;            
            dr = cmd.ExecuteReader();            
            comboBoxUsuario.Items.Clear();
            while (dr.Read())
            {
                comboBoxUsuario.Items.Add(dr[0].ToString());
            }
            dr.Close();

            SqlCommand cmdPlaca = new SqlCommand(consultaPlaca, conn);
            SqlDataReader drPlaca;
            drPlaca = cmdPlaca.ExecuteReader();
            comboBoxPlaca.Items.Clear();
            while (drPlaca.Read())
            {
                comboBoxPlaca.Items.Add(drPlaca[0].ToString());
            }
            drPlaca.Close();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetMyCustomFormat();
            Data.Gastos metodosDatos = new Data.Gastos();
            string id_U = comboBoxUsuario.Text;
            string[] idU;
            idU = id_U.Split('|');
            string respuesta = metodosDatos.insertarGasto_Combustible(Int32.Parse(textBoxCombustible.Text), dateTimePicker1.Text, Int32.Parse(textBoxMonto.Text), Int32.Parse(textBoxFactura.Text), comboBoxPlaca.Text, idU[1]);
            MessageBox.Show(respuesta);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxCombustible.Clear(); textBoxMonto.Clear(); textBoxFactura.Clear();
        }
    }
}
