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
    public partial class ConsultaViaticos : Form
    {
        public ConsultaViaticos()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.consultaIntervaloFechaViaticosTableAdapter.Fill(this.sCUTDataSet.ConsultaIntervaloFechaViaticos, fechaInicialToolStripTextBox.Text, fechaFinalToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
