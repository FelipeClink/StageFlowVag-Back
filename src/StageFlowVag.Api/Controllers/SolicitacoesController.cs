using Microsoft.AspNetCore.Mvc;
using StageFlowVag.Application.Interfaces;
using StageFlowVag.Communication.Requests.Solicitacoes;
using StageFlowVag.Communication.Responses.Solicitacoes;

namespace StageFlowVag.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitacoesController : ControllerBase
    {
        private readonly ISolicitacaoService _solicitacaoService;

        public SolicitacoesController(ISolicitacaoService solicitacaoService)
        {
            _solicitacaoService = solicitacaoService;
        }

        [HttpPost]
        public async Task<IActionResult> CriarSolicitacao(SolicitacaoRequest request)
        {
            var response = await _solicitacaoService.CriarSolicitacaoAsync(request);
            return CreatedAtAction(nameof(ObterPorId), new { id = response.Id }, response);
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodas()
        {
            var response = await _solicitacaoService.ObterTodasAsync();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var response = await _solicitacaoService.ObterPorIdAsync(id);
            if (response == null)
                return NotFound();
            return Ok(response);
        }

        [HttpPost("{id}/aprovar")]
        public async Task<IActionResult> AprovarSolicitacao(int id, AprovarSolicitacaoRequest request)
        {
            var response = await _solicitacaoService.AprovarSolicitacaoAsync(id, request);
            return Ok(response);
        }
    }
}
