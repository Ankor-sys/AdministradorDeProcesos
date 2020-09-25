namespace AdminProcesos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pbRAM = new MetroFramework.Controls.MetroProgressBar();
            this.pbCPU = new MetroFramework.Controls.MetroProgressBar();
            this.lblPorcentajeRAM = new MetroFramework.Controls.MetroLabel();
            this.lblPorcentajeCPU = new MetroFramework.Controls.MetroLabel();
            this.lblRAM = new MetroFramework.Controls.MetroLabel();
            this.lblCPU = new MetroFramework.Controls.MetroLabel();
            this.dgvProceso = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProceso)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRAM
            // 
            this.pbRAM.Location = new System.Drawing.Point(106, 132);
            this.pbRAM.Name = "pbRAM";
            this.pbRAM.Size = new System.Drawing.Size(507, 23);
            this.pbRAM.Style = MetroFramework.MetroColorStyle.Silver;
            this.pbRAM.TabIndex = 33;
            this.pbRAM.Visible = false;
            // 
            // pbCPU
            // 
            this.pbCPU.Location = new System.Drawing.Point(106, 103);
            this.pbCPU.Name = "pbCPU";
            this.pbCPU.Size = new System.Drawing.Size(507, 23);
            this.pbCPU.Style = MetroFramework.MetroColorStyle.Silver;
            this.pbCPU.TabIndex = 32;
            this.pbCPU.Visible = false;
            // 
            // lblPorcentajeRAM
            // 
            this.lblPorcentajeRAM.AutoSize = true;
            this.lblPorcentajeRAM.BackColor = System.Drawing.Color.Teal;
            this.lblPorcentajeRAM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPorcentajeRAM.Location = new System.Drawing.Point(619, 135);
            this.lblPorcentajeRAM.Name = "lblPorcentajeRAM";
            this.lblPorcentajeRAM.Size = new System.Drawing.Size(27, 19);
            this.lblPorcentajeRAM.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblPorcentajeRAM.TabIndex = 31;
            this.lblPorcentajeRAM.Text = "0%";
            this.lblPorcentajeRAM.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblPorcentajeRAM.UseStyleColors = true;
            this.lblPorcentajeRAM.Visible = false;
            // 
            // lblPorcentajeCPU
            // 
            this.lblPorcentajeCPU.AutoSize = true;
            this.lblPorcentajeCPU.BackColor = System.Drawing.Color.Teal;
            this.lblPorcentajeCPU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPorcentajeCPU.Location = new System.Drawing.Point(619, 103);
            this.lblPorcentajeCPU.Name = "lblPorcentajeCPU";
            this.lblPorcentajeCPU.Size = new System.Drawing.Size(27, 19);
            this.lblPorcentajeCPU.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblPorcentajeCPU.TabIndex = 30;
            this.lblPorcentajeCPU.Text = "0%";
            this.lblPorcentajeCPU.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblPorcentajeCPU.UseStyleColors = true;
            this.lblPorcentajeCPU.Visible = false;
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.BackColor = System.Drawing.Color.Teal;
            this.lblRAM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRAM.Location = new System.Drawing.Point(65, 135);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(38, 19);
            this.lblRAM.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblRAM.TabIndex = 29;
            this.lblRAM.Text = "RAM";
            this.lblRAM.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblRAM.UseStyleColors = true;
            this.lblRAM.Visible = false;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.BackColor = System.Drawing.Color.Teal;
            this.lblCPU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCPU.Location = new System.Drawing.Point(65, 107);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(35, 19);
            this.lblCPU.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblCPU.TabIndex = 28;
            this.lblCPU.Text = "CPU";
            this.lblCPU.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblCPU.UseStyleColors = true;
            this.lblCPU.Visible = false;
            // 
            // dgvProceso
            // 
            this.dgvProceso.AllowUserToAddRows = false;
            this.dgvProceso.AllowUserToDeleteRows = false;
            this.dgvProceso.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvProceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProceso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5,
            this.col6});
            this.dgvProceso.Location = new System.Drawing.Point(23, 63);
            this.dgvProceso.Name = "dgvProceso";
            this.dgvProceso.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProceso.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProceso.Size = new System.Drawing.Size(659, 413);
            this.dgvProceso.TabIndex = 27;
            // 
            // col1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.col1.DefaultCellStyle = dataGridViewCellStyle1;
            this.col1.HeaderText = "# Proceso";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            // 
            // col2
            // 
            this.col2.HeaderText = "Proceso";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            // 
            // col3
            // 
            this.col3.HeaderText = "Prioridad del Proceso";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            // 
            // col4
            // 
            this.col4.HeaderText = "ID";
            this.col4.Name = "col4";
            this.col4.ReadOnly = true;
            // 
            // col5
            // 
            this.col5.HeaderText = "Memoria Fisica";
            this.col5.Name = "col5";
            this.col5.ReadOnly = true;
            // 
            // col6
            // 
            this.col6.HeaderText = "Memoria Virtual";
            this.col6.Name = "col6";
            this.col6.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblContador);
            this.panel1.Controls.Add(this.btnGrafica);
            this.panel1.Controls.Add(this.btnFinalizar);
            this.panel1.Controls.Add(this.btnVer);
            this.panel1.Location = new System.Drawing.Point(688, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 413);
            this.panel1.TabIndex = 26;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContador.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(3, 325);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(149, 18);
            this.lblContador.TabIndex = 3;
            this.lblContador.Text = "Numero de procesos: ";
            // 
            // btnGrafica
            // 
            this.btnGrafica.BackColor = System.Drawing.Color.PowderBlue;
            this.btnGrafica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrafica.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafica.Location = new System.Drawing.Point(3, 213);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(140, 62);
            this.btnGrafica.TabIndex = 2;
            this.btnGrafica.Text = "Grafica CPU y RAM";
            this.btnGrafica.UseVisualStyleBackColor = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(3, 120);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(140, 62);
            this.btnFinalizar.TabIndex = 1;
            this.btnFinalizar.Text = "Finalizar Proceso";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.PowderBlue;
            this.btnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(3, 29);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(140, 62);
            this.btnVer.TabIndex = 0;
            this.btnVer.Text = "Visualizar Procesos";
            this.btnVer.UseVisualStyleBackColor = false;
            // 
            // grafica
            // 
            this.grafica.BackColor = System.Drawing.Color.Teal;
            chartArea1.BackColor = System.Drawing.Color.PowderBlue;
            chartArea1.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafica.Legends.Add(legend1);
            this.grafica.Location = new System.Drawing.Point(34, 165);
            this.grafica.Name = "grafica";
            this.grafica.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.grafica.Series.Add(series1);
            this.grafica.Series.Add(series2);
            this.grafica.Size = new System.Drawing.Size(636, 300);
            this.grafica.TabIndex = 34;
            this.grafica.Text = "grafica";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 488);
            this.Controls.Add(this.grafica);
            this.Controls.Add(this.pbRAM);
            this.Controls.Add(this.pbCPU);
            this.Controls.Add(this.lblPorcentajeRAM);
            this.Controls.Add(this.lblPorcentajeCPU);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.dgvProceso);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "ADMINISTRADOR DE PROCESOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProceso)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar pbRAM;
        private MetroFramework.Controls.MetroProgressBar pbCPU;
        private MetroFramework.Controls.MetroLabel lblPorcentajeRAM;
        private MetroFramework.Controls.MetroLabel lblPorcentajeCPU;
        private MetroFramework.Controls.MetroLabel lblRAM;
        private MetroFramework.Controls.MetroLabel lblCPU;
        private System.Windows.Forms.DataGridView dgvProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
    }
}

