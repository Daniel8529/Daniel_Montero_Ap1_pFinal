using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System;
using Daniel_Montero_Ap1_pFinal.Entidades;
using Daniel_Montero_Ap1_pFinal.DAL;
using System.Linq.Expressions;

namespace Daniel_Montero_Ap1_pFinal.BLL
{
    public class AsistenciaBLL
    {
        private Contexto contexto;

        public AsistenciaBLL(Contexto _contexto)
        {
            contexto = _contexto;
        }
        public bool insertar(Asistencia inseta)
        {
            bool paso = false;
            try
            {
                 if ( Existes(inseta.AsistenciaId))
                    return Modificar(inseta);
                else
                contexto.Asistencia.Add(inseta);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public Asistencia? Buscar(int AsistenciaId)
        {

            Asistencia? asistencia;
            try
            {
                asistencia = contexto.Asistencia.Include(D=> D.asistenciadetalle) .Where(A => A.AsistenciaId==AsistenciaId).AsNoTracking().SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }

            return asistencia;
        }
        public bool Existes(int id)
        {
            bool encontrado = false;

            try
            {

                encontrado = contexto.Asistencia.Any(e => e.AsistenciaId == id);

            }
            catch (Exception)
            {
                throw;
            }

            return encontrado;

        }
        private bool Modificar(Asistencia asistencia)
        {
            bool paso = false;
            try
            {          
                contexto.Database.ExecuteSqlRaw($"DELETE FROM AsistenciaDetalle WHERE AsistenciaId={asistencia.AsistenciaId}");

                foreach (var Anterior in asistencia.asistenciadetalle)
                {
                    contexto.Entry(Anterior).State = EntityState.Added;
                }
                contexto.Entry(asistencia).State = EntityState.Modified;

                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public bool Eliminar(int id)
        {
            bool paso = false;


            try
            {

                var adicionales = contexto.Asistencia.Find(id);
                if (adicionales != null)
                {


                    contexto.Asistencia.Remove(adicionales);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return paso;


        }
          public List<Asistencia> GetList(Expression<Func<Asistencia, bool>> criterio)
        {

            List<Asistencia> lista = new List<Asistencia>();
            try
            {
                lista = contexto.Asistencia.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }
        public List<Estudiantes> GetListEstudiante(Expression<Func<Estudiantes, bool>> criterio)
        {

            List<Estudiantes> lista = new List<Estudiantes>();
            try
            {
                lista = contexto.Estudiantes.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }
         public List<Grupos> GetListGrupos(Expression<Func<Grupos, bool>> criterio)
        {

            List<Grupos> lista = new List<Grupos>();
            try
            {
                lista = contexto.Grupos.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }
        public List<Asistencia> GeLista()
        {
            return contexto.Asistencia.ToList();

        }
    }

}