using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaNegocio;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmAsignarEmpresa : Form
    {

        public FrmAsignarEmpresa()
        {
            InitializeComponent();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAsignarEmpresa_Load(object sender, EventArgs e)
        {
            Program.gFCT = new GestionFCT();

            var ciclos = Program.gFCT.TodosCiclos(out string mError);
            if (mError != "")
            {
                MessageBox.Show(mError);
                return;
            }

            cboCiclos.Items.AddRange(ciclos.ToArray());
            cboCiclos.DisplayMember = "Id";

            cboAlumnosFcts.Items.AddRange(Program.gFCT.AlumnosSinAsignarEmpresa(out string msgErrorAlumSinAsignar).ToArray());
            cboAlumnosFcts.DisplayMember = "Nombre";
            if (msgErrorAlumSinAsignar != "")
            {
                MessageBox.Show(msgErrorAlumSinAsignar);
            }

        }

        private void cboCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboAlumnosCiclo.Items.Clear();
            cboEmpresasCiclo.Items.Clear();
            cboProfes.Items.Clear();
            txtTutorEmpresa.Clear();

            Ciclo ciclo = (Ciclo)cboCiclos.SelectedItem;
            cboAlumnosCiclo.Items.AddRange(Program.gFCT.AlumnosOrdenados(ciclo.Id, out string msgErrorAlum).ToArray());
            if (msgErrorAlum != "")
            {
                MessageBox.Show(msgErrorAlum);
                return;
            }

            cboAlumnosCiclo.DisplayMember = "Nombre";
            cboEmpresasCiclo.Items.AddRange(Program.gFCT.EmpresaCiclo(ciclo.Id, out string msgErorEmpresaCiclo).ToArray());
            if (msgErorEmpresaCiclo != "")
            {
                MessageBox.Show(msgErorEmpresaCiclo);
                return;
            }

            cboEmpresasCiclo.DisplayMember = "Nombre";
            cboProfes.Items.AddRange(Program.gFCT.TutorInstituto(out string msgErrorTutorInsti).ToArray());
            if (msgErrorTutorInsti != "")
            {
                MessageBox.Show(msgErrorTutorInsti);
                return;
            }
            cboProfes.DisplayMember = "Nombre";
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (cboAlumnosCiclo.SelectedItem == null || cboCiclos.SelectedItem == null || cboEmpresasCiclo.SelectedItem == null || cboProfes.SelectedItem == null || txtTutorEmpresa.Text == "")
            {
                MessageBox.Show("No se puede dejar ningún campo vacio");
                return;
            }
            else
            {
                var ciclo = (Ciclo)cboCiclos.SelectedItem;
                var alumno = (Alumno)cboAlumnosCiclo.SelectedItem;
                var empresa = (Empresa)cboEmpresasCiclo.SelectedItem;
                var profe = (Profe)cboProfes.SelectedItem;

                Program.gFCT.AsignarEmpresaAlumno(ciclo.Id, alumno.NMatricula, empresa.Id, profe.Id, txtTutorEmpresa.Text, out string msgError);
                if (msgError != "")
                {
                    MessageBox.Show(msgError);
                    return;
                }
                else
                {
                    MessageBox.Show("La empresa se ha asignado correctamente");
                }
            }
        }
    }
}
