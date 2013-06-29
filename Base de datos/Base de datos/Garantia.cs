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
    public partial class Garantia : Form
    {
        public Garantia()
        {
            InitializeComponent();
            SetMyCustomFormat();
        }

        public void SetMyCustomFormat()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fechaGarantia = dateTimePicker1.Text;
            int kilometrajeVencimiento = Int32.Parse(textBoxKilometrajeVencimiento.Text);
            Data.Garantia metodosDatos = new Data.Garantia();
            string respuesta=metodosDatos.insertarGarantia(kilometrajeVencimiento,fechaGarantia);
            MessageBox.Show(respuesta);
            textBox2.Paste(respuesta);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string value = dateTimePicker8.Text;
            int kilometrajeVencimientoNuevo = Int32.Parse(textBox1.Text);
        }
    }
}
