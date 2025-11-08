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

        public async Task<IEnumerable<DateTime>> ObterDatasReservadasAsync(int blocoId)
        {
            return await _context.Solicitacoes
                .Where(s => s.BlocoId == blocoId && s.Aprovado == true)
                .Select(s => s.DataEvento.Date)
                .Distinct()
                .ToListAsync();
        }
        public async Task<IEnumerable<(DateTime Inicio, DateTime Fim)>> ObterHorariosReservadosAsync(int blocoId)
        {
            var horarios = await _context.Solicitacoes
                .Where(s => s.BlocoId == blocoId && s.Aprovado == true && s.IsActive)
                .Select(s => new { s.DataHoraInicio, s.DataHoraFim })
                .ToListAsync();

            return horarios.Select(h => (h.DataHoraInicio, h.DataHoraFim));
        }

        public async Task<bool> VerificarConflitoDeHorarioAsync(int? blocoId, DateTime dataHoraInicio, DateTime dataHoraFim)
        {
            return await _context.Solicitacoes
                .AnyAsync(s =>
                    s.BlocoId == blocoId &&        // Verifica o bloco
                    s.Aprovado == true &&          // Somente eventos aprovados
                    s.IsActive &&                  // Somente eventos ativos
                    s.DataHoraInicio < dataHoraFim && // Se o início do evento for antes do fim
                    dataHoraInicio < s.DataHoraFim); // Se o fim do evento for depois do início
        }

    }
}
