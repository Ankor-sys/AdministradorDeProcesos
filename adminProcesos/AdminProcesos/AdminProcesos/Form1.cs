using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminProcesos
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            //Ocultamos todos los objetos para los graficos y mostramos solo la tabla Procesos
            lblCPU.Visible = false;
            lblRAM.Visible = false;
            pbCPU.Visible = false;
            pbRAM.Visible = false;
            lblPorcentajeCPU.Visible = false;
            lblPorcentajeRAM.Visible = false;
            grafica.Visible = false;
            dgvProceso.Visible = true;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //Ocultamos todos los objetos para los graficos y mostramos solo ella tabla de Procesos
            lblCPU.Visible = false;
            lblRAM.Visible = false;
            pbCPU.Visible = false;
            pbRAM.Visible = false;
            lblPorcentajeCPU.Visible = false;
            lblPorcentajeRAM.Visible = false;
            grafica.Visible = false;
            dgvProceso.Visible = true;
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            //Ocultamos todos los objetos para los graficos y mostramos solo ella tabla de Procesos
            lblCPU.Visible = true;
            lblRAM.Visible = true;
            pbCPU.Visible = true;
            pbRAM.Visible = true;
            lblPorcentajeCPU.Visible = true;
            lblPorcentajeRAM.Visible = true;
            grafica.Visible = true;
            dgvProceso.Visible = false;
        }
    }
}
