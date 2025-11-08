using StageFlowVag.Domain.Entities.Solicitacoes;

namespace StageFlowVag.Domain.Interfaces;

public interface ISolicitacaoRepository : IBaseRepository<Solicitacao>
{
    Task<IEnumerable<Solicitacao>> GetPendentesAsync();
    Task<Solicitacao?> GetDetalhadaAsync(int id);
    Task<IEnumerable<DateTime>> ObterDatasReservadasAsync(int blocoId);
    Task<IEnumerable<(DateTime Inicio, DateTime Fim)>> ObterHorariosReservadosAsync(int blocoId);
    Task<bool> VerificarConflitoDeHorarioAsync(int? blocoId, DateTime dataHoraInicio, DateTime dataHoraFim);

}
