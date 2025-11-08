using StageFlowVag.Domain.Entities;
using StageFlowVag.Domain.Entities.Usuarios;

namespace StageFlowVag.Domain.Interfaces;

public interface IUsuarioRepository : IBaseRepository<Usuario>
{
    Task<Usuario?> GetByEmailAsync(string email);
    Task<bool> MatriculaExistsAsync(string matricula);
}
