using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Daniel_Montero_Ap1_pFinal.Entidades
{
    public class Nacionalida
    {
         [Key]
        public int NacionalidaId {get; set;}
        public string? Nacionalidad {get; set;}
        
    }
}