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
    public class AulasBLL
    {
        private Contexto contexto;

        public AulasBLL(Contexto _contexto)
        {
            contexto = _contexto;
        }
        public bool insertar(Aulas inseta)
        {
            bool paso = false;
            try
            {
                 if ( Existes(inseta.AulaId))
                    return Modificar(inseta);
                else
                contexto.Aulas.Add(inseta);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public Aulas? Buscar(int AulaId)
        {

            Aulas? aulas
            ;
            try
            {
                aulas = contexto.Aulas.Find(AulaId);
            }
            catch (Exception)
            {
                throw;
            }

            return aulas;
        }
        public bool Existes(int id)
        {
            bool encontrado = false;

            try
            {

                encontrado = contexto.Aulas.Any(e => e.AulaId == id);

            }
            catch (Exception)
            {
                throw;
            }

            return encontrado;

        }
        public bool Existes(string Nombre)
        {
            bool encontrado = false;

            try
            {

                encontrado = contexto.Aulas.Any(e => e.Nombre.ToLower()== Nombre.ToLower());

            }
            catch (Exception)
            {
                throw;
            }

            return encontrado;

        }
        private bool Modificar(Aulas aulas)
        {
            bool paso = false;
            try
            {          
                /* contexto.Database.ExecuteSqlRaw($"DELETE FROM AsistenciaDetalle WHERE AsistenciaId={asistencia.AsistenciaId}");

                foreach (var Anterior in asistencia.asistenciadetalle)
                {
                    contexto.Entry(Anterior).State = EntityState.Added;
                } */
                contexto.Entry(aulas).State = EntityState.Modified;

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

                var adicionales = contexto.Aulas.Find(id);
                if (adicionales != null)
                {


                    contexto.Aulas.Remove(adicionales);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return paso;


        }
          public List<Aulas> GetList(Expression<Func<Aulas, bool>> criterio)
        {

            List<Aulas> lista = new List<Aulas>();
            try
            {
                lista = contexto.Aulas.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }
        public List<Aulas> GeLista()
        {
            return contexto.Aulas.ToList();

        }
    }

}