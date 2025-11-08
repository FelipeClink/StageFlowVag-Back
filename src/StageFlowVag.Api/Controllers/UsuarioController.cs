using Microsoft.AspNetCore.Mvc;
using StageFlowVag.Application.Interfaces;
using StageFlowVag.Communication.Requests.Usuarios;
using StageFlowVag.Communication.Responses.Usuarios;

namespace StageFlowVag.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public async Task<IActionResult> Criar(UsuarioRequest request)
        {
            var response = await _usuarioService.CriarAsync(request);
            return CreatedAtAction(nameof(ObterPorId), new { id = response.Id }, response);
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var response = await _usuarioService.ObterTodosAsync();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var response = await _usuarioService.ObterPorIdAsync(id);
            if (response == null)
                return NotFound();
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, UsuarioRequest request)
        {
            var response = await _usuarioService.AtualizarAsync(id, request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletar(int id)
        {
            await _usuarioService.DeletarAsync(id);
            return NoContent();
        }
    }
}
