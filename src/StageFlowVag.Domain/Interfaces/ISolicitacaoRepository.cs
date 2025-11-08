using StageFlowVag.Domain.Entities.Solicitacoes;

namespace StageFlowVag.Domain.Interfaces;

public interface ISolicitacaoRepository : IBaseRepository<Solicitacao>
{
    Task<IEnumerable<Solicitacao>> GetPendentesAsync();
    Task<Solicitacao?> GetDetalhadaAsync(int id);
}
