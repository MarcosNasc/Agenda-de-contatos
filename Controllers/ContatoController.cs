using Agenda.Iterfaces;
using Agenda.Models;
using Agenda.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly IGenericRepository<Contato> _repository;

        public ContatoController(IGenericRepository<Contato> repository)
        {
            _repository = repository;
        }

        [HttpGet("Listar")]
        public async Task<IActionResult> ListarTodos()
        {
            var contatos = _repository.GetAll().Result;
            if (!contatos.Any())
            {
                return Ok("Não existem contatos");
            }
            return Ok(contatos);
        }

        [HttpGet("BuscarPorId")]
        public async Task<IActionResult> BuscarPorId(int id)
        {
            var contato = _repository.Get(id).Result;
            if (contato == null)
            {
                return NotFound();
            }
            return Ok(contato);

        }

        [HttpPost("Adicionar")]
        public async Task<IActionResult> Adicionar(AdicionarContatoViewModel viewModel)
        {
            var entity = new Contato().ViewModelToEntity(viewModel);
            var contato = _repository.Insert(entity).Result;
            return Ok(contato);

        }

        [HttpPut("Atualizar")]
        public async Task<IActionResult> Atualizar(EditarContatoViewModel viewModel)
        {
            var entity = new Contato().ViewModelToEntity(viewModel);
            var contato = _repository.Update(entity).Result;
            return Ok(contato);
        }

        [HttpDelete("Remover")]
        public async Task<IActionResult> Remover(int id)
        {
            _repository.Delete(id);
            return Ok();
        }

    }
}
