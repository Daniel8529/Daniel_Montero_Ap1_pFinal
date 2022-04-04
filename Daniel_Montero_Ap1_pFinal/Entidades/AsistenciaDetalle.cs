using System.Windows.Input;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Daniel_Montero_Ap1_pFinal.Entidades
{

   public class AsistenciaDetalle{
        [Key]
        public int Id {get; set;}
        [Range(0,int.MaxValue,ErrorMessage ="El Id tiene que ser 0")]
        public int AsistenciaId { get; set; }
        public int EstudianteId {get; set; }
        public string Asistio {get; set ;}
       public AsistenciaDetalle(int id,int estudianteId, string asistio){
          AsistenciaId=id;
          EstudianteId=estudianteId;
          Asistio=asistio;
       }

   }

}
