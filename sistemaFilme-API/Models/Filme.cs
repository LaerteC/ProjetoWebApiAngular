using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using sistemaFilme_API.Data;

namespace sistemaFilme_API.Models
{
    public class Filme
    {

        public Filme() {  }

        public Filme(int id, string titulo, string dataLancamento, string diretor,string genero)
        {
            this.id = id;
            this.titulo = titulo;
            this.dataLancamento = dataLancamento;
            this.diretor = diretor;
            this.genero=genero;

        }
        public int id { get; set; }


        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string titulo { get; set; }
        public string dataLancamento { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string diretor { get; set; }



        public string genero { get; set; }

    }
}