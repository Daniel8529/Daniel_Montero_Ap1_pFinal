using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Daniel_Montero_Ap1_pFinal.Entidades
{
    public class Grupos
    {
        [Key]
        public int GrupoId { get; set; }
        public int ProfesorId { get; set; }
        public string? DescripcionCurso { get; set; }
        public int AulaId { get; set; }
        public int CursoId { get; set; }
        public DateTime Fecha { get; set; } 
        public int Tiempo { get; set; }
        public int Capacidad { get; set; } 
        public int CuposDisponible { get; set; }

    }
}