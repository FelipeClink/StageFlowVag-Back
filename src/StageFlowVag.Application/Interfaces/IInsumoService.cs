using StageFlowVag.Communication.Requests.Insumos;
using StageFlowVag.Communication.Responses.Insumos;

namespace StageFlowVag.Application.Interfaces
{
    public interface IInsumoService
    {
        Task<InsumoResponse> CriarAsync(InsumoRequest request);
        Task<IEnumerable<InsumoResponse>> ObterTodosAsync();
        Task<InsumoResponse?> ObterPorIdAsync(int id); // Método ausente
        Task<IEnumerable<InsumoResponse>> ObterPorDepartamentoAsync(int departamento); // Método ausente
    }
}
