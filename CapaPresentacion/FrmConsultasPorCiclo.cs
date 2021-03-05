using CapaDatos;
using CapaNegocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmConsultasPorCiclo : Form
    {
        public FrmConsultasPorCiclo()
        {
            InitializeComponent();
        }

        private void FrmConsultasPorCiclo_Load(object sender, EventArgs e)
        {
            Program.gFCT = new GestionFCT();
          
            var ciclos = Program.gFCT.TodosCiclos(out string msgError);
            if (msgError != "")
            {
                MessageBox.Show(msgError);
                Close();
            }
            cboCiclos.Items.AddRange(ciclos.ToArray());
            cboCiclos.DisplayMember = "Id";
        }

        private void cboCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ciclo ciclo = (Ciclo)cboCiclos.SelectedItem;
            lblNombreCiclo.Text = ciclo.Nombre;
            lblAlumnosCiclo.Text = ciclo.Alumnos.Count().ToString();

            var numAlumAsignado = Program.gFCT.AlumnosAsignados(ciclo.Id, out string msgErrorAlumAsign);
            if (numAlumAsignado == -1)
            {
                MessageBox.Show(msgErrorAlumAsign);
                Close();
            }

            lblAsignados.Text = numAlumAsignado.ToString();

            dgvAlumnosCiclo.DataSource = (from alum in Program.gFCT.AlumnosOrdenados(ciclo.Id, out string msgErrorAlumOrdenados)
                                          select new { alum.Nombre, alum.Telefono, alum.Aprobado }).ToList();
         
            if (msgErrorAlumOrdenados != "")
            {
                MessageBox.Show(msgErrorAlumOrdenados);
                Close();
            }

            dgvAlumnosEmpresa.DataSource = (from alumEmp in Program.gFCT.EmpresaAlumno(ciclo.Id, out string msgErrorEmprAlum)
                                            select new { alumEmp.Nombre, Empresa = alumEmp.FCT.Empresa.Nombre }).ToList();
            if (msgErrorEmprAlum != "")
            {
                MessageBox.Show(msgErrorEmprAlum);
                Close();
            }

            dgvOfertas.DataSource = (from ofEmp in Program.gFCT.EmpresaOfertaFCT(ciclo.Id, out string msgErrorEmpOfertFCT)
                                     select new { ofEmp.Empresa.Nombre, ofEmp.Empresa.TelefonoContacto, ofEmp.Cantidad, Asignadas = ofEmp.Empresa.FCTs.Count() }).ToList();
            if (msgErrorEmpOfertFCT != "")
            {
                MessageBox.Show(msgErrorEmpOfertFCT);
                Close();
            }

        }
    }
}
