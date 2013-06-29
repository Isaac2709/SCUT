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
    public partial class ContultaUsuariosViaticos : Form
    {
        public ContultaUsuariosViaticos()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuariosViaticosSalidaTableAdapter.Fill(this.sCUTDataSet.UsuariosViaticosSalida, fechaInicialToolStripTextBox.Text, fechaFinalToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
