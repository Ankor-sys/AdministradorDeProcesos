namespace Administrador_Procesos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblContador);
            this.panel1.Controls.Add(this.btnGrafica);
            this.panel1.Controls.Add(this.btnFinalizar);
            this.panel1.Controls.Add(this.btnVer);
            this.panel1.Location = new System.Drawing.Point(645, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 393);
            this.panel1.TabIndex = 0;
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
            this.lblContador.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "ADMINISTRADOR DE PROCESOS";
            this.TransparencyKey = System.Drawing.Color.LightCyan;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnFinalizar;
    }
}

