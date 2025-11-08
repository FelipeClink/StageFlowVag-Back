using StageFlowVag.Domain.Entities.AtendimentosDepartamentos;
using StageFlowVag.Domain.Enums;

namespace StageFlowVag.Domain.Interfaces
{
    public interface IAtendimentoDepartamentoRepository : IBaseRepository<AtendimentoDepartamento>
    {
        Task<IEnumerable<AtendimentoDepartamento>> GetByDepartamentoAsync(DepartamentoEnum departamento);
        Task<IEnumerable<AtendimentoDepartamento>> GetByStatusAsync(StatusAtendimentoEnum status);
        Task<IEnumerable<AtendimentoDepartamento>> GetBySolicitacaoIdAsync(int solicitacaoId);

    }
}
