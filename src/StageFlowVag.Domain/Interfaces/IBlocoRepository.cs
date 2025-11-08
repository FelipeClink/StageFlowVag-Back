using StageFlowVag.Domain.Entities.Blocos;

namespace StageFlowVag.Domain.Interfaces
{
    public interface IBlocoRepository : IBaseRepository<Bloco>
    {
        Task<IEnumerable<Bloco>> GetByMinCapacidadeAsync(int capacidadeMinima);
        Task<IEnumerable<Bloco>> GetDisponiveisAsync(DateTime inicio, DateTime fim);
    }
}
