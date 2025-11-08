using Microsoft.EntityFrameworkCore;
using StageFlowVag.Domain.Entities.Insumos;
using StageFlowVag.Domain.Enums;
using StageFlowVag.Domain.Interfaces;

namespace StageFlowVag.Repository.Repositories
{
    public class InsumoRepository : BaseRepository<Insumo>, IInsumoRepository
    {
        public InsumoRepository(StageFlowVagDbContext context) : base(context) { }

        public async Task<IEnumerable<Insumo>> GetByDepartamentoAsync(DepartamentoEnum departamento) =>
            await _dbSet.Where(i => i.Departamento == departamento && i.IsActive).ToListAsync();

        public async Task<bool> ExistsByNomeAsync(string nome) =>
            await _dbSet.AnyAsync(i => i.Nome.ToLower() == nome.ToLower());
    }

}
