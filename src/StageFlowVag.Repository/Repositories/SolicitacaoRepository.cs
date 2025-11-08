using Microsoft.EntityFrameworkCore;
using StageFlowVag.Domain.Entities.Solicitacoes;
using StageFlowVag.Domain.Interfaces;

namespace StageFlowVag.Repository.Repositories
{
    public class SolicitacaoRepository : BaseRepository<Solicitacao>, ISolicitacaoRepository
    {
        public SolicitacaoRepository(StageFlowVagDbContext context) : base(context) { }

        public async Task<IEnumerable<Solicitacao>> GetPendentesAsync()
        {
            return await _dbSet
                .Where(s => s.Aprovado == null && s.IsActive)
                .Include(s => s.Solicitante)
                .Include(s => s.Bloco)
                .ToListAsync();
        }

        public async Task<Solicitacao?> GetDetalhadaAsync(int id)
        {
            return await _dbSet
                .Include(s => s.Solicitante)
                .Include(s => s.Bloco)
                .Include(s => s.Insumos)
                    .ThenInclude(i => i.Insumo)
                .Include(s => s.Atendimentos)
                .FirstOrDefaultAsync(s => s.Id == id && s.IsActive);
        }
    }
}
