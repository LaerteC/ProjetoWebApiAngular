using System.Collections.Generic;

namespace sistemaFilme_API.Models
{
    public class Genero
    {

        public Genero() { }


        public Genero(int id, string nome, int filmeId)
        {
            this.Id = id;
            this.Nome = nome;
            this.FilmeId = filmeId;
         
        }
        public int Id { get; set; }

        public string Nome { get; set; }

        public int FilmeId { get; set; }

        public Filme filme { get; set; }
        public IEnumerable<AtorGenero> atoresGeneros{get;set;}

    }
}