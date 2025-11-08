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

        [HttpGet("datas-reservadas/{blocoId}")]
        public async Task<IActionResult> ObterDatasReservadas(int blocoId)
        {
            var datas = await _solicitacaoService.ObterDatasReservadasAsync(blocoId);
            return Ok(datas);
        }
        [HttpGet("horarios-reservados/{blocoId}")]
        public async Task<IActionResult> ObterHorariosReservados(int blocoId)
        {
            var horarios = await _solicitacaoService.ObterHorariosReservadosAsync(blocoId);
            return Ok(horarios);
        }
        [HttpPost("verificar-conflito")]
        public async Task<IActionResult> VerificarConflitoDeHorario([FromBody] VerificarConflitoRequest request)
        {
            var existeConflito = await _solicitacaoService.VerificarConflitoDeHorarioAsync(
                request.BlocoId, request.DataHoraInicio, request.DataHoraFim
            );

            return Ok(new { sucesso = !existeConflito });
        }
    }
}
