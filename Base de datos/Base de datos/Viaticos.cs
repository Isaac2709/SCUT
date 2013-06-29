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
    public partial class Viaticos : Form
    {
        public Viaticos()
        {
            InitializeComponent();
            llenarComboBox();
            SetMyCustomFormat();
        }

        public void llenarComboBox() {
            //SqlConnection conn = new SqlConnection("Data Source=Isaac-PC;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345");
            SqlConnection conn = new SqlConnection("Data Source=MAFALDA;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345");                               
            conn.Open();
            string consulta = string.Format("select nombre+' '+apellido1+' '+apellido2+' |'+id_U from usuarios");
            SqlCommand cmd = new SqlCommand(consulta, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            comboBox1.Items.Clear();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void SetMyCustomFormat()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            Data.Viaticos metodosDatos = new Data.Viaticos();
            string id_U = comboBox1.Text;
            string[] id;
            id = id_U.Split('|');         
            
            string respuesta = metodosDatos.insertarViaticos(textBox1.Text, dateTimePicker1.Text, Int32.Parse(textBox3.Text), id[1]);
            MessageBox.Show(respuesta);

        }

    }
}
