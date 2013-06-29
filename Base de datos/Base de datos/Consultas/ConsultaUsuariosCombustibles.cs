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
    public partial class ConsultaUsuariosCombustibles : Form
    {
        public ConsultaUsuariosCombustibles()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuariosMontoCombustibleVehiculosTableAdapter.Fill(this.sCUTDataSet.UsuariosMontoCombustibleVehiculos, fechaInicialToolStripTextBox.Text, fechaFinalToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
