using System.Windows.Input;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Daniel_Montero_Ap1_pFinal.Entidades
{

   public class AsistenciaDetalle{
        [Key]
        public int Id {get; set;}

        public int AsistenciaId { get; set; }
        
       [Required(ErrorMessage ="Tiene que selecionar uno")]
        public int EstudianteId {get; set; }
        public bool Asistio {get; set ;}
        public string Nombre {get; set ;}


        public int  Presente {get; set ;}
        public int Ausente {get; set ;}

       public AsistenciaDetalle(int id,int estudianteId, bool asistio,string nombre,int presente,int ausente){
          AsistenciaId=id;
          EstudianteId=estudianteId;
          Asistio=asistio;
          Nombre=nombre;
          Presente=presente;
          ausente=presente;
       }

   }

}
