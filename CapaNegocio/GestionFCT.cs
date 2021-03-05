using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Entidades;

namespace CapaNegocio
{
    public class GestionFCT
    {

        DatosFCT datosfct = new DatosFCT();


        // Lista de todos los ciclos
        public List<Ciclo> TodosCiclos(out string msgError)
        {
            msgError = "";
            try
            {

                var misCiclos = datosfct.TodosCiclos(out string msg);

                return misCiclos;
            }
            catch (Exception exc)
            {
                msgError = exc.Message;
                return null;
            }
        }

        // Alumnos con empresa asignada
        public int AlumnosAsignados(string idCiclo, out string msgError)
        {
            msgError = "";
            try
            {
                var alumnoAsignado =  datosfct.AlumnosAsignados(idCiclo,out string msg);

                return alumnoAsignado;
            }
            catch (Exception exc)
            {
                msgError = exc.Message;
                return -1;
            }
        }

        // Alumnos Ordenados (pasado un id de ciclo)
        public List<Alumno> AlumnosOrdenados(string idCiclo, out string msgError)
        {
            msgError = "";
            try
            {
                var alumnosOrdenados = datosfct.AlumnosOrdenados(idCiclo, out string msg);

                return alumnosOrdenados;
            }
            catch (Exception exc)
            {
                msgError = exc.Message;
                return null;
            }
        }

        // Rel-Alumno-Empresa (pasado un id de ciclo)
        public List<Alumno> EmpresaAlumno(string idCiclo, out string msgError)
        {
            msgError = "";
            try
            {
                var empresaAlumno = datosfct.EmpresaAlumno(idCiclo, out string msg);
                return empresaAlumno;
            }
            catch (Exception exc)
            {
                msgError = exc.Message;
                return null;
            }
        }

        // Rel-OfertaFCT-Empresa (pasado un id de ciclo)
        public List<OfertasFCT> EmpresaOfertaFCT(string idCiclo, out string msgError)
        {
            msgError = "";
            try
            {
                var empresaOfertaFCT = datosfct.EmpresaOfertaFCT(idCiclo, out string msg);

                return empresaOfertaFCT;

            }
            catch (Exception exc)
            {
                msgError = exc.Message;
                return null;
            }
        }

        // Alumnos no asignados en la empresa
        public List<Alumno> AlumnosSinAsignarEmpresa(out string msgError)
        {
            msgError = "";
            try
            {
                var listaNoAsignados = datosfct.AlumnosSinAsignarEmpresa(out string msg);
                return listaNoAsignados;
            }
            catch (Exception exc)
            {
                msgError = exc.Message;
                return null;
            }
        }

        // Empresas para el ciclo (ordenadas alfabétícamnete)
        public List<Empresa> EmpresaCiclo(string idCiclo, out string msgError)
        {
            
            msgError = "";
            try
            {
                var empresaCiclo = datosfct.EmpresaCiclo(idCiclo, out string msg);

                return empresaCiclo;
            }
            catch (Exception exc)
            {
                msgError = exc.Message;
                return null;
            }
        }

        // Tutor/a del instituto
        public List<Profe> TutorInstituto(out string msgError)
        {

            msgError = "";
            try
            {
                return datosfct.TutorInstituto(out string msg);
            }
            catch (Exception exc)
            {
                msgError = exc.Message;
                return null;
            }


        }

        // Asignar empresas a alumnado
        public void AsignarEmpresaAlumno(string idCiclo, int idAlumno, int idEmpresa, string idProfe, string nombreTutoEmpresa, out string msgError)
        {
            msgError = "";
            try
            {
                datosfct.AsignarEmpresaAlumno( idCiclo,  idAlumno,  idEmpresa,  idProfe,  nombreTutoEmpresa, out string msg);
            }
            catch (Exception exc)
            {
                msgError = exc.Message;
            }
        }

        // Retirar la empresa a un alumno o alumna
        public void RetirarEmpresaAlumno(int idAlumno, out string msgError)
        {

            msgError = "";
            try
            {
                datosfct.RetirarEmpresaAlumno(idAlumno, out string msg);
            }
            catch (Exception exc)
            {
                msgError = exc.Message;
            }

        }

    }
}
