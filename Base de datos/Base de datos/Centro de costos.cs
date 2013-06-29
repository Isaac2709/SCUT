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
    public partial class Centro_de_costos : Form
    {
        string nombreCC;
        public Centro_de_costos()
        {
            InitializeComponent();
            llenarComboBox();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void llenarComboBox()
        {
            SqlConnection conn = new SqlConnection("Data Source=Isaac-PC;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345");
            conn.Open();
            string consulta = string.Format("select id_CC from Centro_Costo");
            SqlCommand cmd = new SqlCommand(consulta, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            comboBoxElimModCC.Items.Clear();
            while (dr.Read())
            {
                comboBoxElimModCC.Items.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Data.CentroCosto metodosDatos = new Data.CentroCosto();            
            string respuesta = metodosDatos.insertarCentroCosto(textBoxIDCentroCosto.Text,textBoxCentroCosto.Text);
            MessageBox.Show(respuesta);
            llenarComboBox();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!string.Equals(textBoxElimModNomCC.Text, nombreCC))
            {
                Data.CentroCosto metodosDatos = new Data.CentroCosto();
                string respuesta = metodosDatos.modificarCentroCosto(comboBoxElimModCC.Text, textBoxElimModNomCC.Text);
                comboBoxElimModCC.Text=null; llenarComboBox(); textBoxElimModNomCC.Clear();
                MessageBox.Show(respuesta);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {            
            Data.CentroCosto metodosDatos = new Data.CentroCosto();
            string respuesta = metodosDatos.borrarCentroCosto(comboBoxElimModCC.Text);
            llenarComboBox(); textBoxElimModNomCC.Clear();
            MessageBox.Show(respuesta);
        }

        private void comboBoxElimModCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=Isaac-PC;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345");
            conn.Open();
            string consulta = string.Format("select nombre from Centro_Costo where id_CC='" + comboBoxElimModCC.Text+"'");
            SqlCommand cmd = new SqlCommand(consulta, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            textBoxElimModNomCC.Clear();            
            if (dr.Read())
            {
                nombreCC = dr[0].ToString();
                textBoxElimModNomCC.Text = dr[0].ToString();
            }
            dr.Close();
            conn.Close();
        }
    }
}
