using StageFlowVag.Domain.Entities.Audiovisual;

namespace StageFlowVag.Domain.Interfaces.AudioVisuais.ReservaRecursos
{
    public interface IReservaRecursoRepository
    {
        Task<ReservaRecurso?> GetByIdAsync(int id);
        Task<IEnumerable<ReservaRecurso>> GetByEventoIdAsync(int eventoId);
        Task<IEnumerable<ReservaRecurso>> GetByRecursoIdAsync(int recursoId);
        Task<IEnumerable<ReservaRecurso>> GetReservasAtivasAsync();
        Task<ReservaRecurso> AddAsync(ReservaRecurso reserva);
        Task UpdateAsync(ReservaRecurso reserva);
        Task DeleteAsync(int id);
        Task<int> GetQuantidadeReservadaAsync(int recursoId, DateTime inicio, DateTime fim);
    }
}
