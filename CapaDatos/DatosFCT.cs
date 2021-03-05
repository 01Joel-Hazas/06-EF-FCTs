using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosFCT
    {
        public DatosFCT()
        {
            
        }

        BdFCTsEntities bdFCTsEntities = new BdFCTsEntities();

        public List<Ciclo> TodosCiclos(out string msgError)
        {
            msgError = "";
            try
            {
                var listCiclos = bdFCTsEntities.Ciclos.ToList();
                if (listCiclos == null)
                {
                    msgError = "No se encuentra ningún ciclo";
                    return null;
                }
                return listCiclos;
            }
            catch (Exception exc)
            {
                msgError = exc.Message;
                return null;
            }
        }
      

        public List<Alumno> AlumnosOrdenados(string idCiclo, out string msgError)
        {
            msgError = "";
            try
            {
                var cicloBuscar = bdFCTsEntities.Ciclos.Find(idCiclo);
                if (cicloBuscar == null)
                {
                    msgError = "No se encuentra el ciclo " + idCiclo;
                }
                return cicloBuscar.Alumnos.OrderByDescending(alm => alm.Aprobado).ThenBy(a => a.Nombre).ToList();
            }
            catch (Exception exc)
            {
                msgError = exc.Message;
                return null;
            }
        }

        public int AlumnosAsignados(string idCiclo, out string msgError)
        {
            msgError = "";
            try
            {
                var cicloBuscar = bdFCTsEntities.Ciclos.Find(idCiclo);
                if (cicloBuscar == null)
                {
                    msgError = "No se encuentra el ciclo " + idCiclo;
                }
                return cicloBuscar.Alumnos.Where(alm => alm.FCT != null).Count();
            }
            catch (Exception exc)
            {
                msgError = exc.Message;
                return -1;
            }
        }

        public List<OfertasFCT> EmpresaOfertaFCT(string idCiclo, out string msgError)
        {
            msgError = "";
            try
            {
                var cicloBuscar = bdFCTsEntities.Ciclos.Find(idCiclo);
                if (cicloBuscar == null)
                {
                    msgError = "No se encuentra el ciclo " + idCiclo;
                }
                return cicloBuscar.OfertasFCTs.OrderBy(of => of.Empresa.Nombre).ToList();

            }
            catch (Exception exc)
            {
                msgError = exc.Message;
                return null;
            }
        }

        public List<Alumno> EmpresaAlumno(string idCiclo, out string msgError)
        {
            msgError = "";
            try
            {
                var cicloBuscar = bdFCTsEntities.Ciclos.Find(idCiclo);
                if (cicloBuscar == null)
                {
                    msgError = "No se encuentra el ciclo " + idCiclo;
                }
                return cicloBuscar.Alumnos.Where(alm => alm.FCT != null).ToList();
            }
            catch (Exception exc)
            {
                msgError = exc.Message;
                return null;
            }
        }

        public List<Alumno> AlumnosSinAsignarEmpresa(out string msgError)
        {
            msgError = "";
            try
            {
                var listNoAsignadosAlumnos = bdFCTsEntities.Alumnos.Where(a => a.FCT == null).ToList();
                if (listNoAsignadosAlumnos == null)
                {
                    msgError = "Todos los alumnos tienen una empresa asignada";
                }
                return listNoAsignadosAlumnos;
            }
            catch (Exception exc)
            {
                msgError = exc.Message;
                return null;
            }
        }

        public List<Empresa> EmpresaCiclo(string idCiclo, out string msgError)
        {
            List<Empresa> listEmpresa = new List<Empresa>();
            msgError = "";
            try
            {
                var ofertasDeCiclo = bdFCTsEntities.OfertasFCTs.Where(oferta => oferta.IdCiclo == idCiclo).ToList();

                if (ofertasDeCiclo == null)
                {
                    msgError = "No hay ofertas disponibles en el ciclo " + idCiclo;
                }
                foreach (var ofertaEmpresa in ofertasDeCiclo)
                {
                    listEmpresa.Add(ofertaEmpresa.Empresa);
                }
                var listaEmpresaOrdenada = listEmpresa.OrderBy(empresa => empresa.Nombre).ToList();
                return listaEmpresaOrdenada;
            }
            catch (Exception exc)
            {
                msgError = exc.Message;
                return null;
            }
        }

        public List<Profe> TutorInstituto(out string msgError)
        {

            msgError = "";
            try
            {
                return bdFCTsEntities.Profes.ToList();
            }
            catch (Exception exc)
            {
                msgError = exc.Message;
                return null;
            }

        }

        public void AsignarEmpresaAlumno(string idCiclo, int idAlumno, int idEmpresa, string idProfe, string nombreTutorEmpresa, out string msgError)
        {
            msgError = "";
            FCT FCTNueva;

            var profe = bdFCTsEntities.Profes.Find(idProfe);
            var ciclo = bdFCTsEntities.Ciclos.Find(idCiclo);
            var alumno = bdFCTsEntities.Alumnos.Find(idAlumno);
            var empresa = bdFCTsEntities.Empresas.Find(idEmpresa);

            // POSIBLES ERRORES

            // 1.
            if (ciclo.OfertasFCTs.Count == 0)
            {
                msgError = "La empresa " + empresa.Nombre + " no ha solicitado alumnado para el ciclo " + ciclo.Nombre;
                return;
            };

            // 2
            if (alumno.Aprobado == false)
            {
                msgError = "El alumno/a " + alumno.Nombre + "no ha aprobado el ciclo " + ciclo.Nombre;
                return;
            }
            // 3
            if (alumno.FCT != null)
            {
                msgError = "El alumno / a " + alumno.Nombre + " ya tiene asignada la empresa " + alumno.FCT.Empresa.Nombre;

            }
            // 4
            var ofertasCant = bdFCTsEntities.OfertasFCTs.Where(ofFCT => ofFCT.IdEmpresa == idEmpresa && ofFCT.IdCiclo == idCiclo).SingleOrDefault();
            if (ofertasCant.Cantidad == ofertasCant.Empresa.FCTs.Count())
            {
                msgError = "La empresa " + empresa.Nombre + " ya tiene asignados el/los " + ofertasCant.Cantidad + " (cantidad) alumnos/as pedidos";
                return;
            }

            FCTNueva = new FCT(idAlumno, idEmpresa, profe.Id, nombreTutorEmpresa);
            bdFCTsEntities.FCTs.Add(FCTNueva);
            try
            {

                int asignados = bdFCTsEntities.SaveChanges();
                if (asignados == 0)
                {
                    msgError = "No se ha podido asignar ningúna empresa";
                    return;
                }

            }
            catch (Exception exc)
            {
                msgError = exc.Message;
                return;
            }
        }
        public void RetirarEmpresaAlumno(int idAlumno, out string msgError)
        {
            msgError = "";
            var alumno = bdFCTsEntities.Alumnos.Find(idAlumno);

            // POSIBLES ERRORES

            // 1.
            if (alumno.Aprobado == false)
            {
                msgError = "El alumno/a " + alumno.Nombre + " no puede tener asignada una empresa porque no ha aprobado el curso.";
                return;
            }
            // 2.
            if (alumno.FCT == null)
            {
                msgError = "El alumno/a " + alumno.Nombre + " no tiene asignada empresa";
                return;
            }
            FCT FCTaEliminar = new FCT();
            FCTaEliminar = bdFCTsEntities.FCTs.Find(idAlumno);
            if (FCTaEliminar == null)
            {
                msgError = "El alumno " + alumno.Nombre + " no tiene asignada una empresa";
                return;
            }
            bdFCTsEntities.FCTs.Remove(FCTaEliminar);
            try
            {
                int retirados = bdFCTsEntities.SaveChanges();
                if (retirados == 0)
                {
                    msgError = "No se ha podido retirar ningúna empresa";
                    return;
                }
            }
            catch (Exception exc)
            {
                msgError = exc.Message;
                return;
            }

        }
    }
}
