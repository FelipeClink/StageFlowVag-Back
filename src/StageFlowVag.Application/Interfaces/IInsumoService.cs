using StageFlowVag.Communication.Requests.Insumos;
using StageFlowVag.Communication.Responses.Insumos;

namespace StageFlowVag.Application.Interfaces
{
    public interface IInsumoService
    {
        Task<InsumoResponse> CriarAsync(InsumoRequest request);
        // Mude a assinatura do método para aceitar o novo parâmetro
        Task<IEnumerable<InsumoResponse>> ObterTodosAsync(int? departamento);
        Task<InsumoResponse?> ObterPorIdAsync(int id); // Método ausente
        Task<IEnumerable<InsumoResponse>> ObterPorDepartamentoAsync(int departamento); // Método ausente
    }
}
