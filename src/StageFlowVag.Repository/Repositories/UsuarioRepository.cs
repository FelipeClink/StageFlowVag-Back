using Microsoft.EntityFrameworkCore;
using StageFlowVag.Domain.Entities.Usuarios;
using StageFlowVag.Domain.Interfaces;

namespace StageFlowVag.Repository.Repositories;

public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
{
    public UsuarioRepository(StageFlowVagDbContext context) : base(context) { }

    public async Task<Usuario?> GetByEmailAsync(string email) =>
        await _dbSet.FirstOrDefaultAsync(u => u.Email == email);

    public async Task<bool> MatriculaExistsAsync(string matricula) =>
        await _dbSet.AnyAsync(u => u.Matricula == matricula);
}
