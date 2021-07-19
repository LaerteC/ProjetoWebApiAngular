using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sistemaFilme_API.Data;
using sistemaFilme_API.Models;

namespace sistemaFilme_API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class FilmeController : ControllerBase
    {
        private readonly IRepository _repo;
        public IRepository Repo { get; }



        public FilmeController(IRepository repo)
        {

            _repo = repo;

        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            try
            {
                var result = await _repo.GetAllFilme();
                return Ok(result);

            }
            catch (Exception e)
            {

                return BadRequest($"Erro : {e.Message}");
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getByFilmeId(int id)
        {



            var result = await _repo.GetIdFilme(id);


            if (result == null)
            {

                return NotFound();
            }
            return Ok(result);


        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<IActionResult> post(Filme filme)
        {

            try
            {

                _repo.Add(filme);

                if (await _repo.SaveChangesAsync())
                {

                    return Ok(filme);
                }

            }
            catch (Exception e)
            {

                return BadRequest($"Erro : {e.Message}");
            }
            return BadRequest(" Erro Inesperado ");
        }

        
          // PUT: api/[controller]
         [HttpPut("{id}")]
         public async Task<IActionResult> put(int id,Filme filme)
        {
            if (id !=   filme.id)
            {
                return BadRequest();
            }
             _repo.Update(filme);

             if(await _repo.SaveChangesAsync()){
                 return Ok(filme);
             }
            return NoContent();
        }

         [HttpDelete("{id}")]
         public async Task<IActionResult> delete(int id)
        {
            try{
                var filme = await _repo.GetIdFilme(id);
                if(filme == null){
                    return NotFound();
                }

                _repo.Delete(filme);
 
                if(await _repo.SaveChangesAsync()){
                    return Ok("Deletado");
                }

            }catch(Exception e){

                 return BadRequest($"Erro : {e.Message}");
            }

            return BadRequest();
        }
             

    }

}

