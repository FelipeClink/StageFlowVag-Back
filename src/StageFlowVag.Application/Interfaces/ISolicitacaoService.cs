using StageFlowVag.Communication.Requests;
using StageFlowVag.Communication.Requests.Solicitacoes;
using StageFlowVag.Communication.Responses;
using StageFlowVag.Communication.Responses.Solicitacoes;

namespace StageFlowVag.Application.Interfaces
{
    public interface ISolicitacaoService
    {
        Task<SolicitacaoResponse> CriarSolicitacaoAsync(SolicitacaoRequest request);
        Task<SolicitacaoResponse> AprovarSolicitacaoAsync(int id, AprovarSolicitacaoRequest request);
        Task<IEnumerable<SolicitacaoResponse>> ObterTodasAsync();
        Task<SolicitacaoResponse?> ObterPorIdAsync(int id);
    }
}
