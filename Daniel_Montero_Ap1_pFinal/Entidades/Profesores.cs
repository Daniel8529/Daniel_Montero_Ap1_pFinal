using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Daniel_Montero_Ap1_pFinal.Entidades
{
    public class Profesores
    {
        [Key]
        public int ProfesorId { get; set; }
        public string? Nombre { get; set; }
        public int GrupoId { get; set; }
      
      

    }
}