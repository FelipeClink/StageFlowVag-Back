using StageFlowVag.Domain.Base;
using StageFlowVag.Domain.Enums.AudioVisualEnum;

namespace StageFlowVag.Domain.Entities.Audiovisual
{
    public class Evento : BaseEntity
    {
        public string Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Local { get; set; } = string.Empty;
        public int PublicoEstimado { get; set; }
        public StatusEvento Status { get; set; }

        public int CoordenadorId { get; set; }
        public string NomeCoordenador { get; set; } = string.Empty;
        public string EmailCoordenador { get; set; } = string.Empty;
        public string CursoVinculado { get; set; } = string.Empty;

        public TipoEvento TipoEvento { get; set; }
        public bool RequerDivulgacao { get; set; }
        public bool RequerCerimonial { get; set; }
        public string? ObservacoesGerais { get; set; }

        public ICollection<ReservaRecurso> RecursosReservados { get; set; } = new List<ReservaRecurso>();
        public ICollection<ChecklistItem> Checklist { get; set; } = new List<ChecklistItem>();
    }
}
