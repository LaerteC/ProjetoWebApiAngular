using System.Collections.Generic;
using System.Threading.Tasks;
using sistemaFilme_API.Models;

namespace sistemaFilme_API.Data
{
    public interface IRepository
    {
        
    
      //GERAL
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;

       
        Task<bool> SaveChangesAsync();


        //Filme
         Task<Filme> GetIdFilme(int id);

         Task<Filme[]> GetAllFilme();

         Task<Ator[]> GetAllAtor();

         Task<Ator> GetIdAtor(int id);

    }
         
    
}