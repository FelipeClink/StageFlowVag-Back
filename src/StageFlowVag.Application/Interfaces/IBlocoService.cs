using StageFlowVag.Communication.Requests.Blocos;
using StageFlowVag.Communication.Responses.Blocos;

namespace StageFlowVag.Application.Interfaces
{
    public interface IBlocoService
    {
        Task<BlocoResponse> CriarAsync(BlocoRequest request);
        Task<IEnumerable<BlocoResponse>> ObterTodosAsync();
        Task<BlocoResponse?> ObterPorIdAsync(int id); 
        Task<IEnumerable<BlocoResponse>> ObterDisponiveisAsync(DateTime inicio, DateTime fim);
        Task<IEnumerable<BlocoResponse>> ObterPorCapacidadeAsync(int capacidade); 
    }
}
