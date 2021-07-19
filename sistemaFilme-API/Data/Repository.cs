using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sistemaFilme_API.Models;

namespace sistemaFilme_API.Data
{
    public class Repository : IRepository
    {
        

        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

         public async Task<Filme> GetIdFilme(int id)
        {
             return await _context.Set<Filme>().FindAsync(id);
        }

        public async Task<Filme[]> GetAllFilme(){

            return await _context.Set<Filme>().ToArrayAsync();
        }

         public async Task<Ator> GetIdAtor(int id)
        {
             return await _context.Set<Ator>().FindAsync(id);
        }

         public async Task<Ator[]> GetAllAtor(){

            return await _context.Set<Ator>().ToArrayAsync();
        }


    }
}