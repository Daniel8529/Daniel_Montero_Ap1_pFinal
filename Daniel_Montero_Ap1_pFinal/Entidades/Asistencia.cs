using System.Windows.Input;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Daniel_Montero_Ap1_pFinal.Entidades
{

   public class Asistencia{
        [Key]
      [Range(0,int.MaxValue,ErrorMessage ="El id tiene que ser mayor a cero")]
       public int AsistenciaId {get; set;}
     
      public  DateTime Fecha { get; set; }= DateTime.Now;

       [Range(1,int.MaxValue,ErrorMessage ="El selecionar un grupo")]
         public int GrupoId {get; set; }

         [Required(ErrorMessage ="Es obligatorio introducir una Descripcion")]
        public int  Presente {get; set ;}
        public int Ausente {get; set ;}

        public int estudianteId {get; set ;}
        
        [ForeignKey("AsistenciaId")]
        public virtual List<AsistenciaDetalle> asistenciadetalle {get; set;} = new List<AsistenciaDetalle>();

   }

}

      
      