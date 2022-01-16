﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDVacinas.Models
{
    public class Cidade
    {
        [Key]
        public int CodCidade { get; set; }
        [Required]
        [StringLength(33)]
        public string Nome { get; set; }    
        public int Populacao { get; set; }
        public Estado nomeEstado { get; set; }

        public DateTime Aniversario { get; set; }

        public int QuantidadeBairros { get; set; }



    }
}
