using Microsoft.EntityFrameworkCore;
using StageFlowVag.Domain.Entities.Blocos;
using StageFlowVag.Domain.Enums;
using StageFlowVag.Domain.Interfaces;

namespace StageFlowVag.Repository.Repositories
{
    public class BlocoRepository : BaseRepository<Bloco>, IBlocoRepository
    {
        public BlocoRepository(StageFlowVagDbContext context) : base(context) { }

        public async Task<IEnumerable<Bloco>> GetByMinCapacidadeAsync(int capacidadeMinima)
        {
            return await _dbSet
                .Where(b => b.Capacidade >= capacidadeMinima && b.IsActive)
                .ToListAsync();
        }

        public async Task<IEnumerable<Bloco>> GetDisponiveisAsync(DateTime inicio, DateTime fim)
        {
            return await _dbSet
                .Include(b => b.Disponibilidades)
                .Where(b => b.IsActive &&
                            !b.Disponibilidades.Any(d =>
                                d.DataHoraInicio < fim &&
                                d.DataHoraFim > inicio &&
                                d.Status != StatusBlocoEnum.Disponivel))
                .ToListAsync();
        }
    }
}
