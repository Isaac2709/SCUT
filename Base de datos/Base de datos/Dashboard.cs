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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios ventana = new Usuarios();
            ventana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Viaticos ventana = new Viaticos();
            ventana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gastos ventana = new Gastos();
            ventana.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HorasExtra ventana = new HorasExtra();
            ventana.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Agencias ventana = new Agencias();
            ventana.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ficha_solicitud ventana = new Ficha_solicitud();
            ventana.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Vehiculos ventana = new Vehiculos();
            ventana.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Garantia ventana = new Garantia();
            ventana.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Centro_de_costos ventana = new Centro_de_costos();
            ventana.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Mantenimiento ventana = new Mantenimiento();
            ventana.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Talleres nuevo = new Talleres();
            nuevo.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ConsultaViaticos nuevo = new ConsultaViaticos();
            nuevo.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaViaticos nuevo = new ConsultaViaticos();
            nuevo.Show();
        }

        private void viaticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaViaticos nuevo = new ConsultaViaticos();
            nuevo.Show();
        }

        private void montoDeViaticosDeLosUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.MontoViaticosUsuarios nuevo = new Consultas.MontoViaticosUsuarios();
            nuevo.Show();
        }

        private void viaticosEnUnIntervaloDeFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaViaticos nuevo = new ConsultaViaticos();
            nuevo.Show();
        }

        private void montoDeViaticosDeTodosLosUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContultaUsuariosViaticos nuevo = new ContultaUsuariosViaticos();
            nuevo.Show();
        }

        private void reparacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaReparaciones nuevo = new Consultas.ConsultaReparaciones();
            nuevo.Show();
        }

        private void combustibleGastadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaUsuariosCombustibles nuevo = new Consultas.ConsultaUsuariosCombustibles();
            nuevo.Show();
        }
    }
}
