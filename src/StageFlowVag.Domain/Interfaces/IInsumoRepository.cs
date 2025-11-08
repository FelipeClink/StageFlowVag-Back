using StageFlowVag.Domain.Entities.Insumos;
using StageFlowVag.Domain.Enums;

namespace StageFlowVag.Domain.Interfaces
{
    public interface IInsumoRepository : IBaseRepository<Insumo>
    {
        Task<IEnumerable<Insumo>> GetByDepartamentoAsync(DepartamentoEnum departamento);
        Task<bool> ExistsByNomeAsync(string nome);

    }
}
