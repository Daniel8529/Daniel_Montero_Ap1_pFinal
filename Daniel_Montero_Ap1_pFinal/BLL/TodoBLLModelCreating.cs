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
    public class TodoBLLModelCreating
    {
        private Contexto contexto;

        public TodoBLLModelCreating(Contexto _contexto)
        {
            contexto = _contexto;
        }
        public bool Modificarpararestar(Estudiantes estudiantes,Asistencia asistencia)
        {
            bool paso = false;
            
            try
            {
                 foreach(var item in asistencia.asistenciadetalle){
                  
                 Estudiantes? encontrado =contexto.Estudiantes.Find(item.EstudianteId);
                     if(encontrado != null)
                    if(item.Asistio==true){
                    encontrado.Presente+=1;
                    encontrado.Ausente+=0;
                    }else
                    if(item.Asistio==false)
                    {
                        encontrado.Ausente+=1;
                        encontrado.Presente+=0;
                    }
                

                contexto.Entry(encontrado).State = EntityState.Modified; 

                paso = contexto.SaveChanges() > 0;
                 }


            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
         public bool Modificarparaeliminar(Estudiantes estudiantes,Asistencia asistencia)
        {
            bool paso = false;
            
            try
            {
                 foreach(var item in asistencia.asistenciadetalle){
                  
                 Estudiantes? encontrado =contexto.Estudiantes.Find(item.EstudianteId);
                     if(encontrado != null)
                    if(item.Asistio==true){
                    encontrado.Presente-=1;
                    encontrado.Ausente-=0;
                    }else
                    if(item.Asistio==false)
                    {
                        encontrado.Ausente-=1;
                        encontrado.Presente-=0;
                    }

                contexto.Entry(encontrado).State = EntityState.Modified; 

                paso = contexto.SaveChanges() > 0;
                 }


            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
       public Estudiantes? Buscar(int AulaId)
        {

            Estudiantes? aulas
            ;
            try
            {
                aulas = contexto.Estudiantes.Find(AulaId);
            }
            catch (Exception)
            {
                throw;
            }

            return aulas;
        }
       
          public List<Estudiantes> GetListEstudiantes(Expression<Func<Estudiantes, bool>> criterio)
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
        public List<Estudiantes> GeListaEstudiantes()
        {
            return contexto.Estudiantes.ToList();

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
        public List<Grupos> GeListaGrupos()
        {
            return contexto.Grupos.ToList();

        }
        
         public List<Profesores> GetListProfesores(Expression<Func<Profesores, bool>> criterio)
        {

            List<Profesores> lista = new List<Profesores>();
            try
            {
                lista = contexto.Profesores.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }
        public List<Profesores> GeListaProfesores()
        {
            return contexto.Profesores.ToList();

        }
    }

}