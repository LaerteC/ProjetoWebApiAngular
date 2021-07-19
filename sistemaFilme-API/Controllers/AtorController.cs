using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sistemaFilme_API.Data;
using sistemaFilme_API.Models;

namespace sistemaFilme_API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AtorController : ControllerBase
    {
        private readonly IRepository _repo;
        public IRepository Repo { get; }



        public AtorController(IRepository repo)
        {

            _repo = repo;

        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            try
            {
                var result = await _repo.GetAllAtor();
                return Ok(result);

            }
            catch (Exception e)
            {

                return BadRequest($"Erro : {e.Message}");
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getByAtorId(int id)
        {



            var result = await _repo.GetIdAtor(id);


            if (result == null)
            {

                return NotFound();
            }
            return Ok(result);


        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<IActionResult> post(Ator ator)
        {

            try
            {

                _repo.Add(ator);

                if (await _repo.SaveChangesAsync())
                {

                    return Ok(ator);
                }

            }
            catch (Exception e)
            {

                return BadRequest($"Erro : {e.Message}");
            }
            return BadRequest(" Erro Inesperado ");
        }

        
          // PUT: api/[controller]
         [HttpPut("{atorId}")]  
         public async Task<IActionResult> put(int atorId,Ator ator)
        {
            try{
                var atores = await _repo.GetIdAtor(atorId);
                if(atores == null){
                    return NotFound(" Ator não Encontrado");
                }

               
                    _repo.Update(ator);

                if(await _repo.SaveChangesAsync()){
                    return Ok(ator);
                }

            }catch(Exception e){

                 return BadRequest($"Erro : {e.Message}");
            }

            return BadRequest();
        }

         [HttpDelete("{id}")]
         public async Task<IActionResult> delete(int id)
        {
            try{
                var ator = await _repo.GetIdAtor(id);
                if(ator == null){
                    return NotFound();
                }

                _repo.Delete(ator);
 
                if(await _repo.SaveChangesAsync()){
                    return Ok(new {message = "Deletado"});
                }

            }catch(Exception e){

                 return BadRequest($"Erro : {e.Message}");
            }

            return BadRequest();
        }
             

    }

}

 
