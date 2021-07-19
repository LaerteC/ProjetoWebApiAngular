using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using sistemaFilme_API.Models;

namespace sistemaFilme_API.Data
{

    public class DataContext :DbContext

    {
      public DataContext(DbContextOptions<DataContext> options) : base (options) { }        
        public DbSet<Filme> filmes { get; set; }
        public DbSet<Ator> atores { get; set; }

       // public DbSet<Genero> generos { get; set; }
      //  public DbSet<AtorGenero> atoresGeneros { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AtorGenero>()
                .HasKey(AD => new {AD.atorId,AD.generoId });

            builder.Entity<Ator>()
                .HasData(new List<Ator>(){
                    new Ator(1, "Lauro","Fernão"),
                    new Ator(2, "Roberto","Gomes"),
                    new Ator(3, "Ronaldo","Nazario"),
                    new Ator(4, "Rodrigo","Hubert"),
                    new Ator(5, "Alexandre","Pires"),
                });
            
          
           
            builder.Entity<Filme>()
                .HasData(new List<Filme>(){
                    new Filme(1,"Vanilla Sky", "22/02/2005","Cristofer Nolan","Ficção"),
                    new Filme(2,"Batman", "22/02/2002","Cristofer Nolan","Drama"),
                    new Filme(3,"O Irlandes", "22/02/1999"," Martin Scorcese","Ação"),
                    new Filme(4,"Clube de Luta", "22/02/2001","David Linch","Romance"),
                    new Filme(5,"Magnólia", "22/02/2019","Rodrigo Padilha","Comédia"),
                    new Filme(6,"Tropa de Elite", "22/02/2021","Fernando Meirelles","Fantasia"),
                    new Filme(7,"2001 Odisseia", "22/02/2018","Stanley Kubric","Terror")
                });

        } 
    }
}