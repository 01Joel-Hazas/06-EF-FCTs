namespace CapaPresentacion
{
    partial class FrmConsultasPorCiclo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboCiclos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreCiclo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAlumnosCiclo = new System.Windows.Forms.Label();
            this.dgvOfertas = new System.Windows.Forms.DataGridView();
            this.dgvAlumnosCiclo = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvAlumnosEmpresa = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAsignados = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosCiclo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciclos";
            // 
            // cboCiclos
            // 
            this.cboCiclos.BackColor = System.Drawing.Color.White;
            this.cboCiclos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiclos.FormattingEnabled = true;
            this.cboCiclos.Location = new System.Drawing.Point(137, 52);
            this.cboCiclos.Margin = new System.Windows.Forms.Padding(4);
            this.cboCiclos.Name = "cboCiclos";
            this.cboCiclos.Size = new System.Drawing.Size(155, 24);
            this.cboCiclos.TabIndex = 1;
            this.cboCiclos.SelectedIndexChanged += new System.EventHandler(this.cboCiclos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre ciclo";
            // 
            // lblNombreCiclo
            // 
            this.lblNombreCiclo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblNombreCiclo.Location = new System.Drawing.Point(420, 49);
            this.lblNombreCiclo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCiclo.Name = "lblNombreCiclo";
            this.lblNombreCiclo.Size = new System.Drawing.Size(329, 26);
            this.lblNombreCiclo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(757, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alumnos/as del ciclo";
            // 
            // lblAlumnosCiclo
            // 
            this.lblAlumnosCiclo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAlumnosCiclo.Location = new System.Drawing.Point(921, 52);
            this.lblAlumnosCiclo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlumnosCiclo.Name = "lblAlumnosCiclo";
            this.lblAlumnosCiclo.Size = new System.Drawing.Size(44, 26);
            this.lblAlumnosCiclo.TabIndex = 5;
            this.lblAlumnosCiclo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvOfertas
            // 
            this.dgvOfertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfertas.Location = new System.Drawing.Point(611, 128);
            this.dgvOfertas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOfertas.Name = "dgvOfertas";
            this.dgvOfertas.RowHeadersWidth = 51;
            this.dgvOfertas.Size = new System.Drawing.Size(587, 412);
            this.dgvOfertas.TabIndex = 7;
            // 
            // dgvAlumnosCiclo
            // 
            this.dgvAlumnosCiclo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnosCiclo.Location = new System.Drawing.Point(75, 130);
            this.dgvAlumnosCiclo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAlumnosCiclo.Name = "dgvAlumnosCiclo";
            this.dgvAlumnosCiclo.RowHeadersWidth = 51;
            this.dgvAlumnosCiclo.Size = new System.Drawing.Size(513, 279);
            this.dgvAlumnosCiclo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Alumnos/as del ciclo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 438);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Alumnos/as del ciclo con empresa ya asignada";
            // 
            // dgvAlumnosEmpresa
            // 
            this.dgvAlumnosEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnosEmpresa.Location = new System.Drawing.Point(89, 471);
            this.dgvAlumnosEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAlumnosEmpresa.Name = "dgvAlumnosEmpresa";
            this.dgvAlumnosEmpresa.RowHeadersWidth = 51;
            this.dgvAlumnosEmpresa.Size = new System.Drawing.Size(463, 279);
            this.dgvAlumnosEmpresa.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(607, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(337, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Empresas para el ciclo (ordenadas alfabétícamente)";
            // 
            // lblAsignados
            // 
            this.lblAsignados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAsignados.Location = new System.Drawing.Point(1133, 52);
            this.lblAsignados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsignados.Name = "lblAsignados";
            this.lblAsignados.Size = new System.Drawing.Size(44, 26);
            this.lblAsignados.TabIndex = 15;
            this.lblAsignados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(973, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Alumnos/as asignados";
            // 
            // FrmConsultasPorCiclo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 778);
            this.Controls.Add(this.lblAsignados);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvOfertas);
            this.Controls.Add(this.dgvAlumnosEmpresa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvAlumnosCiclo);
            this.Controls.Add(this.lblAlumnosCiclo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNombreCiclo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCiclos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConsultasPorCiclo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas por ciclo";
            this.Load += new System.EventHandler(this.FrmConsultasPorCiclo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosCiclo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCiclos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreCiclo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAlumnosCiclo;
        private System.Windows.Forms.DataGridView dgvOfertas;
        private System.Windows.Forms.DataGridView dgvAlumnosCiclo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvAlumnosEmpresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAsignados;
        private System.Windows.Forms.Label label10;
    }
}