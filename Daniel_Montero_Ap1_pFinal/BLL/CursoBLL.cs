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
    public class CursoBLL
    {
        private Contexto contexto;

        public CursoBLL(Contexto _contexto)
        {
            contexto = _contexto;
        }
        public bool insertar(Curso inseta)
        {
            bool paso = false;
            try
            {
                 if ( Existes(inseta.CursoId))
                    return Modificar(inseta);
                else
                contexto.Curso.Add(inseta);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public Curso? Buscar(int CursoId)
        {

            Curso? curso;
            try
            {
                curso = contexto.Curso.Find(CursoId);
            }
            catch (Exception)
            {
                throw;
            }

            return curso;
        }
        public bool Existes(int id)
        {
            bool encontrado = false;

            try
            {

                encontrado = contexto.Curso.Any(e => e.CursoId == id);

            }
            catch (Exception)
            {
                throw;
            }

            return encontrado;

        }
        private bool Modificar(Curso curso)
        {
            bool paso = false;
            try
            {          
                /* contexto.Database.ExecuteSqlRaw($"DELETE FROM AsistenciaDetalle WHERE AsistenciaId={asistencia.AsistenciaId}");

                foreach (var Anterior in asistencia.asistenciadetalle)
                {
                    contexto.Entry(Anterior).State = EntityState.Added;
                } */
                contexto.Entry(curso).State = EntityState.Modified;

                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
          public bool Existes(string Descripcion)
        {
            bool encontrado = false;

            try
            {

                encontrado = contexto.Curso.Any(e => e.Descripcion.ToLower()== Descripcion.ToLower());

            }
            catch (Exception)
            {
                throw;
            }

            return encontrado;

        }
        public bool Eliminar(int id)
        {
            bool paso = false;


            try
            {

                var adicionales = contexto.Curso.Find(id);
                if (adicionales != null)
                {


                    contexto.Curso.Remove(adicionales);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return paso;


        }
          public List<Curso> GetList(Expression<Func<Curso, bool>> criterio)
        {

            List<Curso> lista = new List<Curso>();
            try
            {
                lista = contexto.Curso.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }
        public List<Curso> GeLista()
        {
            return contexto.Curso.ToList();

        }
    }

}