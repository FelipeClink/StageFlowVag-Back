using Microsoft.EntityFrameworkCore;
using StageFlowVag.Domain.Entities.AtendimentosDepartamentos;
using StageFlowVag.Domain.Enums;
using StageFlowVag.Domain.Interfaces;

namespace StageFlowVag.Repository.Repositories
{
    public class AtendimentoDepartamentoRepository : BaseRepository<AtendimentoDepartamento>, IAtendimentoDepartamentoRepository
    {
        public AtendimentoDepartamentoRepository(StageFlowVagDbContext context) : base(context) { }

        public async Task<IEnumerable<AtendimentoDepartamento>> GetByDepartamentoAsync(DepartamentoEnum departamento)
        {
            return await _dbSet
                .Include(a => a.Solicitacao)
                .Where(a => a.Departamento == departamento && a.IsActive)
                .ToListAsync();
        }

        public async Task<IEnumerable<AtendimentoDepartamento>> GetByStatusAsync(StatusAtendimentoEnum status)
        {
            return await _dbSet
                .Include(a => a.Solicitacao)
                .Where(a => a.Status == status && a.IsActive)
                .ToListAsync();
        }

        public async Task<IEnumerable<AtendimentoDepartamento>> GetBySolicitacaoIdAsync(int solicitacaoId)
        {
            return await _dbSet
                .Include(a => a.Responsavel)
                .Where(a => a.SolicitacaoId == solicitacaoId && a.IsActive)
                .ToListAsync();
        }
    }
}
