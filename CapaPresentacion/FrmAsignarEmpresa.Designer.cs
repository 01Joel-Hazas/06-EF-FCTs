namespace CapaPresentacion
{
    partial class FrmAsignarEmpresa
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
            this.cboCiclos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAlumnosFcts = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEmpresasCiclo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAlumnosCiclo = new System.Windows.Forms.ComboBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProfes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTutorEmpresa = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboCiclos
            // 
            this.cboCiclos.BackColor = System.Drawing.Color.White;
            this.cboCiclos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiclos.FormattingEnabled = true;
            this.cboCiclos.Location = new System.Drawing.Point(155, 55);
            this.cboCiclos.Margin = new System.Windows.Forms.Padding(4);
            this.cboCiclos.Name = "cboCiclos";
            this.cboCiclos.Size = new System.Drawing.Size(155, 24);
            this.cboCiclos.TabIndex = 3;
            this.cboCiclos.SelectedIndexChanged += new System.EventHandler(this.cboCiclos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ciclo";
            // 
            // cboAlumnosFcts
            // 
            this.cboAlumnosFcts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlumnosFcts.FormattingEnabled = true;
            this.cboAlumnosFcts.Location = new System.Drawing.Point(433, 453);
            this.cboAlumnosFcts.Margin = new System.Windows.Forms.Padding(4);
            this.cboAlumnosFcts.Name = "cboAlumnosFcts";
            this.cboAlumnosFcts.Size = new System.Drawing.Size(155, 24);
            this.cboAlumnosFcts.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 453);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(339, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Alumnos/as que aún no se les ha asignado empresa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, -63);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(337, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Empresas para el ciclo (ordenadas alfabétícamente)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(337, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Empresas para el ciclo (ordenadas alfabétícamente)";
            // 
            // cboEmpresasCiclo
            // 
            this.cboEmpresasCiclo.BackColor = System.Drawing.Color.White;
            this.cboEmpresasCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresasCiclo.FormattingEnabled = true;
            this.cboEmpresasCiclo.Location = new System.Drawing.Point(444, 105);
            this.cboEmpresasCiclo.Margin = new System.Windows.Forms.Padding(4);
            this.cboEmpresasCiclo.Name = "cboEmpresasCiclo";
            this.cboEmpresasCiclo.Size = new System.Drawing.Size(359, 24);
            this.cboEmpresasCiclo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Alumnos/as del ciclo";
            // 
            // cboAlumnosCiclo
            // 
            this.cboAlumnosCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlumnosCiclo.FormattingEnabled = true;
            this.cboAlumnosCiclo.Location = new System.Drawing.Point(573, 53);
            this.cboAlumnosCiclo.Margin = new System.Windows.Forms.Padding(4);
            this.cboAlumnosCiclo.Name = "cboAlumnosCiclo";
            this.cboAlumnosCiclo.Size = new System.Drawing.Size(229, 24);
            this.cboAlumnosCiclo.TabIndex = 19;
           
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(240, 247);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(193, 48);
            this.btnAsignar.TabIndex = 20;
            this.btnAsignar.Text = "&Asignar empresa";
            this.btnAsignar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tutor/a del instituto";
            // 
            // cboProfes
            // 
            this.cboProfes.BackColor = System.Drawing.Color.White;
            this.cboProfes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfes.FormattingEnabled = true;
            this.cboProfes.Location = new System.Drawing.Point(209, 158);
            this.cboProfes.Margin = new System.Windows.Forms.Padding(4);
            this.cboProfes.Name = "cboProfes";
            this.cboProfes.Size = new System.Drawing.Size(155, 24);
            this.cboProfes.TabIndex = 22;
        
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tutor/a de la empresa";
            // 
            // txtTutorEmpresa
            // 
            this.txtTutorEmpresa.Location = new System.Drawing.Point(625, 159);
            this.txtTutorEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTutorEmpresa.Name = "txtTutorEmpresa";
            this.txtTutorEmpresa.Size = new System.Drawing.Size(279, 22);
            this.txtTutorEmpresa.TabIndex = 24;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(524, 247);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(193, 48);
            this.btnVolver.TabIndex = 25;
            this.btnVolver.Text = "&Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmAsignarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 533);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtTutorEmpresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboProfes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.cboAlumnosCiclo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboEmpresasCiclo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboAlumnosFcts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboCiclos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAsignarEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar empresas a alumnado";
            this.Load += new System.EventHandler(this.FrmAsignarEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCiclos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAlumnosFcts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboEmpresasCiclo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAlumnosCiclo;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboProfes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTutorEmpresa;
        private System.Windows.Forms.Button btnVolver;
    }
}