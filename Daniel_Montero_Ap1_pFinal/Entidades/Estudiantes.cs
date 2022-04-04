using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Daniel_Montero_Ap1_pFinal.Entidades
{
    public partial class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
      
        public string? Sexo { get; set; }

        public string? Direccion { get; set; }

        public int Telefono { get; set; }

        public string? Email { get; set; }



    }
}