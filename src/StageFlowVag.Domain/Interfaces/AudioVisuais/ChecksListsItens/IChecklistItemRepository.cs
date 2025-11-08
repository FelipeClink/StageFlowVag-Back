using StageFlowVag.Domain.Entities;

namespace StageFlowVag.Domain.Interfaces.AudioVisuais.ChecksListsItens
{
    public interface IChecklistItemRepository
    {
        List<ChecklistItem> GetAll(int id);
        Task<ChecklistItem?> GetByIdAsync(int id);
        Task<IEnumerable<ChecklistItem>> GetByEventoIdAsync(int eventoId);
        Task<IEnumerable<ChecklistItem>> GetTarefasPendentesAsync();
        Task<ChecklistItem> AddAsync(ChecklistItem item);
        Task UpdateAsync(ChecklistItem item);
        Task DeleteAsync(int id);
        Task AddRangeAsync(IEnumerable<ChecklistItem> itens);
    }
}
