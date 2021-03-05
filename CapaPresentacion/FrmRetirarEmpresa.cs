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
    public partial class FrmRetirarEmpresa : Form
    {
        public FrmRetirarEmpresa()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmRetirarEmpresa_Load(object sender, EventArgs e)
        {
            Program.gFCT = new GestionFCT();
             
            var todosCiclos = Program.gFCT.TodosCiclos(out string msgError);

            if (msgError != "")
            {
                MessageBox.Show(msgError);
                return;
            }

            cboCiclos.Items.AddRange(todosCiclos.ToArray());
            cboCiclos.DisplayMember = "Id";
        }

        private void cboCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboAlumnosCiclo.Items.Clear();
            Ciclo ciclo = (Ciclo)cboCiclos.SelectedItem;
            cboAlumnosCiclo.Items.AddRange(Program.gFCT.AlumnosOrdenados(ciclo.Id, out string msgErrorAlum).ToArray());

            if (msgErrorAlum != "")
            {
                MessageBox.Show(msgErrorAlum);
                return;
            }
            cboAlumnosCiclo.DisplayMember = "Nombre";
        }

        private void btnRetirarEmpresa_Click(object sender, EventArgs e)
        {
            if (cboAlumnosCiclo.SelectedItem == null || cboCiclos.SelectedItem == null)
            {
                MessageBox.Show("No se puede dejar ningún campo vacio");
                return;
            }
            else
            {
                var alumno = (Alumno)cboAlumnosCiclo.SelectedItem;

                DialogResult dialog = MessageBox.Show(" El alumno/a " + alumno.Nombre + " tiene asignada la empresa " + alumno.FCT.Empresa.Nombre + "¿Deseas Eliminar la asignación?", "Atención", MessageBoxButtons.YesNo);
                
                if (dialog == DialogResult.Yes)
                {
                    Program.gFCT.RetirarEmpresaAlumno(alumno.NMatricula, out string msgErrorRetirar);
                    if (msgErrorRetirar != "")
                    {
                        MessageBox.Show(msgErrorRetirar);
                        return;
                    }
                    MessageBox.Show("La empresa se ha retirado correctamente");
                }
            }
        }
    }
    }
    

