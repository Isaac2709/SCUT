using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_de_datos.Consultas
{
    public partial class ConsultaReparaciones : Form
    {
        public ConsultaReparaciones()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.consultaIntervaloFechaReparacionesVehiculosTableAdapter.Fill(this.sCUTDataSet.ConsultaIntervaloFechaReparacionesVehiculos, fechaInicialToolStripTextBox.Text, fechaFinalToolStripTextBox.Text, consultaManRepToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
