namespace CapaPresentacion
{
    partial class FrmPrincipal
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
            this.btnConsultasCiclo = new System.Windows.Forms.Button();
            this.btnAsignarFcts = new System.Windows.Forms.Button();
            this.btnRetirarFct = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultasCiclo
            // 
            this.btnConsultasCiclo.Location = new System.Drawing.Point(66, 50);
            this.btnConsultasCiclo.Name = "btnConsultasCiclo";
            this.btnConsultasCiclo.Size = new System.Drawing.Size(110, 43);
            this.btnConsultasCiclo.TabIndex = 0;
            this.btnConsultasCiclo.Text = "Consultas por ciclo";
            this.btnConsultasCiclo.UseVisualStyleBackColor = true;
            this.btnConsultasCiclo.Click += new System.EventHandler(this.btnAlumnadoCiclo_Click);
            // 
            // btnAsignarFcts
            // 
            this.btnAsignarFcts.Location = new System.Drawing.Point(230, 50);
            this.btnAsignarFcts.Name = "btnAsignarFcts";
            this.btnAsignarFcts.Size = new System.Drawing.Size(110, 43);
            this.btnAsignarFcts.TabIndex = 1;
            this.btnAsignarFcts.Text = "Asignar FCTs";
            this.btnAsignarFcts.UseVisualStyleBackColor = true;
            this.btnAsignarFcts.Click += new System.EventHandler(this.btnAsignarRetirar_Click);
            // 
            // btnRetirarFct
            // 
            this.btnRetirarFct.Location = new System.Drawing.Point(396, 50);
            this.btnRetirarFct.Name = "btnRetirarFct";
            this.btnRetirarFct.Size = new System.Drawing.Size(110, 43);
            this.btnRetirarFct.TabIndex = 2;
            this.btnRetirarFct.Text = "Retirar FCTs";
            this.btnRetirarFct.UseVisualStyleBackColor = true;
            this.btnRetirarFct.Click += new System.EventHandler(this.btnRetirarFct_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(230, 122);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(110, 43);
            this.btnFin.TabIndex = 3;
            this.btnFin.Text = "&Fin";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 177);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnRetirarFct);
            this.Controls.Add(this.btnAsignarFcts);
            this.Controls.Add(this.btnConsultasCiclo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto para asignación y consultas de FCT\'s";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultasCiclo;
        private System.Windows.Forms.Button btnAsignarFcts;
        private System.Windows.Forms.Button btnRetirarFct;
        private System.Windows.Forms.Button btnFin;
    }
}

