using StageFlowVag.Domain.Entities.Audiovisual;

namespace StageFlowVag.Domain.Interfaces.AudioVisuais.RecursoAudioVisuais
{
    public interface IRecursoAudiovisualRepository
    {
        Task<RecursoAudioVisual?> GetByIdAsync(int id);
        Task<IEnumerable<RecursoAudioVisual>> GetAllAsync();
        Task<IEnumerable<RecursoAudioVisual>> GetDisponiveisAsync();
        Task<IEnumerable<RecursoAudioVisual>> GetDisponiveisNoPeriodoAsync(DateTime inicio, DateTime fim);
        Task<RecursoAudioVisual> AddAsync(RecursoAudioVisual recurso);
        Task UpdateAsync(RecursoAudioVisual recurso);
        Task DeleteAsync(int id);
        Task<bool> VerificarDisponibilidadeAsync(int recursoId, DateTime inicio, DateTime fim, int quantidade);
    }
}
