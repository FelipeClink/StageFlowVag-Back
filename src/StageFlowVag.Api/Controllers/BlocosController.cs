using Microsoft.AspNetCore.Mvc;
using StageFlowVag.Application.Interfaces;
using StageFlowVag.Communication.Requests.Blocos;
using StageFlowVag.Communication.Responses.Blocos;

namespace StageFlowVag.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlocosController : ControllerBase
    {
        private readonly IBlocoService _blocoService;

        public BlocosController(IBlocoService blocoService)
        {
            _blocoService = blocoService;
        }

        [HttpPost]
        public async Task<IActionResult> Criar(BlocoRequest request)
        {
            var response = await _blocoService.CriarAsync(request);
            return CreatedAtAction(nameof(ObterPorId), new { id = response.Id }, response);
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var response = await _blocoService.ObterPorCapacidadeAsync(10);  // Exemplo de filtro
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var response = await _blocoService.ObterPorIdAsync(id);
            if (response == null)
                return NotFound();
            return Ok(response);
        }

        [HttpGet("{id}/disponibilidade")]
        public async Task<IActionResult> ObterDisponibilidade(int id, DateTime inicio, DateTime fim)
        {
            var response = await _blocoService.ObterDisponiveisAsync(inicio, fim);
            return Ok(response);
        }
    }
}
