using StageFlowVag.Domain.Entities.Audiovisual;
using StageFlowVag.Domain.Enums.AudioVisualEnum;

namespace StageFlowVag.Domain.Interfaces.AudioVisuais.Eventos
{
    public interface IEventoRepository
    {
        List<Evento> GetAll(int id);
        Task<Evento?> GetByIdAsync(int id);
        Task<Evento?> GetByIdComDetalhesAsync(int id);
        Task<IEnumerable<Evento>> GetAllAsync();
        Task<IEnumerable<Evento>> GetByPeriodoAsync(DateTime inicio, DateTime fim);
        Task<IEnumerable<Evento>> GetByCoordenadorAsync(int coordenadorId);
        Task<IEnumerable<Evento>> GetByStatusAsync(StatusEvento status);
        Task<Evento> AddAsync(Evento evento);
        Task UpdateAsync(Evento evento);
        Task DeleteAsync(int id);
        Task<bool> VerificarConflitoAgendaAsync(DateTime inicio, DateTime fim, string local, int? eventoIdExcluir = null);
    }
}
