using System.Windows.Input;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Daniel_Montero_Ap1_pFinal.Entidades
{

   public class Aulas{
        [Key]
        public int AulaId {get; set;}
        public string? Nombre { get; set; }
        public int VecesAsignada {get; set; }
     
   

   }

}