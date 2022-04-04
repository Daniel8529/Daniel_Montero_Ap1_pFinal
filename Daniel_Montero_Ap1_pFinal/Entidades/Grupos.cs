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
        public string? Desde { get; set; } 
        public string? Hasta { get; set; }
        public int Tiempo { get; set; }
        public decimal Capacidad { get; set; } 
        public decimal CuposDisponible { get; set; }

    }
}