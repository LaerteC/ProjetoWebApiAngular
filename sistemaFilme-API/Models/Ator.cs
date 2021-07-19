using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using sistemaFilme_API.Data;

namespace sistemaFilme_API.Models
{
    public class Ator 
    {

        public Ator() {    }
        
        public Ator(int id, string nome, string sobrenome)
        {
            this.id = id;
            this.nome = nome;
            this.sobrenome = sobrenome;

        }
        public int id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string nome { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string sobrenome { get; set; }

        
    }
}