using StageFlowVag.Communication.Enums.AudioVisualEnums;
using StageFlowVag.Communication.Responses.ChecksListsItens;
using StageFlowVag.Communication.Responses.ReservasRecursos;

namespace StageFlowVag.Communication.Responses.Eventos
{
    public class EventoResponse
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Local { get; set; } = string.Empty;
        public int PublicoEstimado { get; set; }
        public StatusEvento Status { get; set; }
        public string StatusDescricao { get; set; } = string.Empty;
        public int CoordenadorId { get; set; }
        public string NomeCoordenador { get; set; } = string.Empty;
        public string EmailCoordenador { get; set; } = string.Empty;
        public string CursoVinculado { get; set; } = string.Empty;
        public TipoEvento TipoEvento { get; set; }
        public string TipoEventoDescricao { get; set; } = string.Empty;
        public bool RequerDivulgacao { get; set; }
        public bool RequerCerimonial { get; set; }
        public string? ObservacoesGerais { get; set; }
        public DateTime DataCriacao { get; set; }
        public List<ReservaRecursoResponse>? RecursosReservados { get; set; }
        public List<ChecklistItemResponse>? Checklist { get; set; }
    }
}
