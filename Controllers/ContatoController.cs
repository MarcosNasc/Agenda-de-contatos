using Agenda.Models;
using Agenda.Dtos;
using Microsoft.AspNetCore.Mvc;
using Agenda.Repository.Iterfaces;
using Agenda.Services.Interfaces;

namespace Agenda.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly IContatoService _contatoService;

        public ContatoController(IContatoService contatoService)
        {
            _contatoService = contatoService;
        }

        [HttpGet("Listar")]
        public async Task<IActionResult> ListarTodos()
        {
            var contatos = _contatoService.ListarTodos();
            return Ok(contatos);
        }

        [HttpGet("BuscarPorId")]
        public async Task<IActionResult> BuscarPorId(int id)
        {
            var contato = _contatoService.BuscarPorId(id);
            return Ok(contato);

        }

        [HttpPost("Adicionar")]
        public async Task<IActionResult> Adicionar(AdicionarContatoDTO dto)
        {
            var entity = new Contato().DtoToEntity(dto);
            var contato = _contatoService.Adicionar(entity);
            return Ok(contato);

        }

        [HttpPut("Atualizar")]
        public async Task<IActionResult> Atualizar(EditarContatoDTO dto)
        {
            var entity = new Contato().DtoToEntity(dto);
            var contato = _contatoService.Atualizar(entity);
            return Ok(contato);
        }

        [HttpDelete("Remover")]
        public async Task<IActionResult> Remover(int id)
        {
           _contatoService.Remover(id);
            return Ok();
        }
    }
}
