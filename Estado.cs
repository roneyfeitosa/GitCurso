using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDVacinas.Models
{
    public class Estado
    {
        [Key]
        public int CodEstado { get; set; }
        
        [Required]
        [StringLength(25)]
        public string Nome {get; set; }      
        
        [Required]
        [StringLength(2, MinimumLength = 2)]
        public string Sigla { get; set; }
        
        public int Populacao { get; set; }
        public DateTime Fundacao { get; set; }
        public List<Cidade> Cidades { get; set; }
    }
}
