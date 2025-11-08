using Microsoft.AspNetCore.Mvc;
using StageFlowVag.Application.Interfaces;
using StageFlowVag.Communication.Requests.Insumos;

namespace StageFlowVag.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsumosController : ControllerBase
    {
        private readonly IInsumoService _insumoService;

        public InsumosController(IInsumoService insumoService)
        {
            _insumoService = insumoService;
        }

        [HttpPost]
        public async Task<IActionResult> Criar(InsumoRequest request)
        {
            var response = await _insumoService.CriarAsync(request);
            return CreatedAtAction(nameof(ObterPorId), new { id = response.Id }, response);
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var response = await _insumoService.ObterTodosAsync();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var response = await _insumoService.ObterPorIdAsync(id);
            if (response == null)
                return NotFound();
            return Ok(response);
        }
    }
}
