using System.Threading.Tasks;
using Core_Project.Domain;
using Core_Project.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        public readonly ICore_ProjectRepository _repository;
        public ClienteController(ICore_ProjectRepository repo)
        {
            _repository = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _repository.GetAllClientesAsync();
                return Ok(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "500 Internal Error!");
                //throw;
            }
        }

        [HttpGet("{ClienteId}")]
        public async Task<IActionResult> Get(int ClienteId)
        {
            try
            {
                var results = await _repository.GetClienteAsyncById(ClienteId);
                return Ok(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "500 Internal Error!");
                //throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Cliente model)
        {
            try
            {
                _repository.Add(model);
                if (await _repository.SaveChangesAsync()) {
                    // Status Code 201
                    return Created($"/api/cliente/{model.Id}", model);
                }
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "500 Internal Error!");
                //throw;
            }
            return BadRequest(":(");
        }

        [HttpPut("{ClienteId}")]
        public async Task<IActionResult> Put(int ClienteId, Cliente model)
        {
            try
            {
                var cliente = await _repository.GetClienteAsyncById(ClienteId);
                if (cliente == null) return NotFound();

                _repository.Update(model);

                if (await _repository.SaveChangesAsync()) {
                    return Created($"/api/cliente/{model.Id}", model);
                } 
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "500 Internal Error!");
                //throw;
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int ClienteId)
        {
            try
            {
                var cliente = await _repository.GetClienteAsyncById(ClienteId);
                if (cliente == null) return NotFound();
                _repository.Delete(cliente);

                if (await _repository.SaveChangesAsync()) {
                    // Status Code 200
                    return Ok();
                }
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "500 Internal Error!");
                //throw;
            }
            return BadRequest(":(");
        }
    }
}