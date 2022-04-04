using System.Windows.Input;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Daniel_Montero_Ap1_pFinal.Entidades
{

   public class Curso{
        [Key]
        [Range(0,int.MaxValue,ErrorMessage ="El Id tiene que ser 0")]
        public int CursoId {get; set;}
      
        public string? Descripcion { get; set; }
        public int VecesInscrito{get; set; }
      

   }

}