﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Base_de_datos
{
    public partial class Dashboard : Form
    {


        /// <summary>
        /// Metodos para desactivar el boton de cerrar [X]
        /// </summary>
        [DllImport("user32.dll", EntryPoint = "GetSystemMenu")]
        private static extern IntPtr GetSystemMenu(IntPtr hwnd, int revert);
        [DllImport("user32.dll", EntryPoint = "GetMenuItemCount")]
        private static extern int GetMenuItemCount(IntPtr hmenu);
        [DllImport("user32.dll", EntryPoint = "RemoveMenu")]
        private static extern int RemoveMenu(IntPtr hmenu, int npos, int wflags);
        [DllImport("user32.dll", EntryPoint = "DrawMenuBar")]
        private static extern int DrawMenuBar(IntPtr hwnd);
        private const int MF_BYPOSITION = 0x0400;
        private const int MF_DISABLED = 0x0001;


        public Dashboard()
        {
            
            InitializeComponent();
            //this.ControlBox = false;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        IntPtr hmenu = GetSystemMenu(this.Handle, 0);
        int cnt = GetMenuItemCount(hmenu);
        // remove 'close' action
        RemoveMenu(hmenu, cnt - 1, MF_DISABLED | MF_BYPOSITION);
        // remove extra menu line
        RemoveMenu(hmenu, cnt - 2, MF_DISABLED | MF_BYPOSITION);

        DrawMenuBar(this.Handle);               
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VentanaUsuarios_MouseHover(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(ThreadProc));
            t.Start();
            VentanaUsuarios.BackColor=System.Drawing.Color.Black;
            
            //Thread.Sleep(1);
            //this.VentanaUsuarios.Size = new System.Drawing.Size(127, 154);
            t.Join();
            this.salirToolStripMenuItem.Text = "Salir";
        }

        public void ThreadProc()
        {
            //this.VentanaUsuarios.Size.Height;  
            this.salirToolStripMenuItem.Text = "OLA";
            //VentanaUsuarios.Width += 10;// = new Size(300, VentanaUsuarios.Size.Height);
            Thread.Sleep(900);            
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.salirToolStripMenuItem.Text = "OLA";
            this.buttonViaticos.Location = new System.Drawing.Point(145, 23);            
            this.buttonViaticos.Width += 6;
            this.buttonViaticos.Height += 4;    
            
            //Thread t = new Thread(new ThreadStart(hilo1));
            //t.Start();
            //t.Join();
            
        }
        public void hilo1()
        {
            for (int n = 0; n != 8; n+=2) {
                this.buttonViaticos.Width += n;
                this.buttonViaticos.Height += 6;
                Thread.Sleep(10);
            }
            //VentanaUsuarios.Width += 10;// = new Size(300, VentanaUsuarios.Size.Height);
            //Thread.Sleep(400);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Thread.Sleep(100);            
            this.buttonViaticos.Width -= 6;
            this.buttonViaticos.Height -= 4;
            this.buttonViaticos.Location = new System.Drawing.Point(148, 25);
        }

    }
}
