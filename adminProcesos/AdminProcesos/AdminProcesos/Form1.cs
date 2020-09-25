using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; //Libreria que permite la comunicación con los procesos

namespace AdminProcesos
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //Declarando la variable que tendrá el nombre del proceso en la tabla para eliminarse
        string strNombreProceso;

        public Form1()
        {
            InitializeComponent();
        }

        private void ActualizarTabla() {
            //Limpieza del datagrid de procesos
            dgvProceso.Rows.Clear();

            //Creacion de columnas
            dgvProceso.Columns[0].Name = "# Proceso";
            dgvProceso.Columns[1].Name = "Proceso";
            dgvProceso.Columns[2].Name = "Prioridad del Proceso";
            dgvProceso.Columns[3].Name = "ID";
            dgvProceso.Columns[4].Name = "Memoria Fisica";
            dgvProceso.Columns[5].Name = "Memoria Virtual";

            //Propiedad para autoajustar el tamaño de las celdas segun su contenido
            dgvProceso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Propiedad para que el usuario seleccione solamente filas en la tabla y no celdas sueltas
            dgvProceso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Propiedad para que el usuario no pueda seleccionar mas de una fila
            dgvProceso.MultiSelect = false;

            //Declaracion de la variable que sera un contador para el total de procesos
            int intCantidadProcesos = 1;

            foreach (Process Proceso in Process.GetProcesses())
            {
                //Ingreso de los datos por proceso en el datagrid
                dgvProceso.Rows.Add(intCantidadProcesos, Proceso.ProcessName, Proceso.BasePriority, Proceso.Id, Proceso.WorkingSet64,
                    Proceso.VirtualMemorySize64);
                //aumento en 1 de la variable
                intCantidadProcesos += 1;
            }
            //El label muestra la cantidad de procesos actuales
            lblContador.Text = "Procesos Actuales: " + (intCantidadProcesos - 1);    //  cantidad de procesos   


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Evento que maneja el contador de rendimiento de la RAM y del CPU
            timer2.Start();
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

            //Llamando a la funcion de ActualizarTabla()
            ActualizarTabla();
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

            try
            {
                //Por cada proceso que haya se comparara su nombre con el nombre del proceso que se desea eliminar.
                foreach (Process proceso in Process.GetProcesses())
                {
                    if (proceso.ProcessName == strNombreProceso)
                    {
                        proceso.Kill();//Se elimina el proceso
                        ActualizarTabla();//Se llama al proceso para actualizar la tabla automaticamente
                    }
                }

            }
            //En caso no se seleccione un proceso mostrara el siguiente mensaje.
            catch (Exception x)
            {
                MessageBox.Show("Error al Detener Proceso");
            }
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

        private void dgvProceso_MouseClick(object sender, MouseEventArgs e)
        {
            //La variable obtiene el Nombre del Proceso de la Tabla al hacerle clic
            strNombreProceso = dgvProceso.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Asignamos un float a un PerformanceCounter que ya tiene asignado el contador de rendimiento de la RAM y del CPU
            float fCPU = pCPU.NextValue();
            float fRAM = pRAM.NextValue();
            //Agregamos los Valores a la Barra de progeso respectivamente
            pbCPU.Value = (int)fCPU;
            pbRAM.Value = (int)fRAM;
            //Damos el formato de porcentaje correspondiente al label de porcentaje con lo float
            lblPorcentajeCPU.Text = string.Format("{0:0.00}%", fCPU);
            lblPorcentajeRAM.Text = string.Format("{0:0.00}%", fRAM);
            //Agregamos los valores de Y que se usaran para mostrarlos en grafica
            grafica.Series["CPU"].Points.AddY(fCPU);
            grafica.Series["RAM"].Points.AddY(fRAM);
        }
    }
}
