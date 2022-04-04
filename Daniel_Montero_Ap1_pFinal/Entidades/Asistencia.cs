using System.Windows.Input;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Daniel_Montero_Ap1_pFinal.Entidades
{

   public class Asistencia{
        [Key]
        
       [Range(0,int.MaxValue,ErrorMessage ="El Id tiene que ser 0")]
       public int AsistenciaId {get; set;}
     

        public  DateTime Fecha { get; set; }= DateTime.Now;
        public int GrupoId {get; set; }
        public string? Presente {get; set ;}
        public string? Ausentes {get; set ;}
        public virtual List<AsistenciaDetalle> asistenciadetalle {get; set;} = new List<AsistenciaDetalle>();

   }

}

      
      