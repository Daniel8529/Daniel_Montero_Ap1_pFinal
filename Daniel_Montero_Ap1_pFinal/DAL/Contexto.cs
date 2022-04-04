using Microsoft.EntityFrameworkCore;
using Daniel_Montero_Ap1_pFinal.Entidades;
using Daniel_Montero_Ap1_pFinal.DAL;

namespace Daniel_Montero_Ap1_pFinal.DAL
{
   public class Contexto : DbContext
    { 

        public DbSet<Asistencia> Asistencia{get; set;}
        

        public DbSet<Aulas> Aulas{ get; set;}
      
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Nacionalida> Nacionalida{ get; set; }
        public DbSet<Grupos> Grupos{ get; set; }
        public DbSet<Estudiantes> Estudiantes{ get; set; }

        public DbSet<Profesores> Profesores{ get; set; }
  
        public Contexto(DbContextOptions<Contexto> options) : base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<Nacionalida>().HasData(new Nacionalida{
                NacionalidaId=1,
                Nacionalidad="Republica Dominicana"
               
              },
                new Nacionalida{NacionalidaId=2,
                Nacionalidad="Peru"},
                new Nacionalida{  NacionalidaId=3,
                Nacionalidad="Mexico"},
                new Nacionalida{  NacionalidaId=4,
                Nacionalidad="Estados Unidos"}
              );
              modelBuilder.Entity<Grupos>().HasData(new Grupos{
                GrupoId=1,
                ProfesorId=1,
                DescripcionCurso="Programacion Aplicada",
                AulaId=1,
                CursoId=1,
                Desde="01/04/2022",
                Hasta="027/04/2022",
                Tiempo=4,
                Capacidad=40,
                CuposDisponible=10

              },new Grupos{
                GrupoId=2,
                ProfesorId=2,
                DescripcionCurso="Programacion 1",
                AulaId=2,
                CursoId=2,
                Desde="02/04/2022",
                Hasta="020/04/2022",
                Tiempo=3,
                Capacidad=30,
                CuposDisponible=15
              }


              );
               modelBuilder.Entity<Estudiantes>().HasData(new Estudiantes{
                  EstudianteId=1,
                  Nombre="Pedro",
                  Apellido="Teto",
                  Sexo="M",
                  Direccion="Teteo ramires#57",
                  Telefono=809028329,
                  Email="Teteo57@gmail.com"

               },new Estudiantes{

                 EstudianteId=2,
                  Nombre="Maria",
                  Apellido="Molineo" ,
                  Sexo="F",
                  Direccion="Teteo ramires#57",
                  Telefono=809323423,
                  Email="Molineo57@gmail.com"
               }
               );
              modelBuilder.Entity<Profesores>().HasData(new Profesores{
                          
                 ProfesorId=1,
                 Nombre="Mario",
                 GrupoId=1
               },new Profesores{
                
                ProfesorId=2,
                 Nombre="Luigi",
                 GrupoId=2
         
               }
               );
             
        }
      
    }
}