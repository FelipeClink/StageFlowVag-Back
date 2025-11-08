using StageFlowVag.Communication.Enums.AudioVisualEnums;

namespace StageFlowVag.Communication.Requests.Eventos
{
    public class CriarEventoRequest
    {
        public string Titulo { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Local { get; set; } = string.Empty;
        public int PublicoEstimado { get; set; }
        public Guid CoordenadorId { get; set; }
        public string NomeCoordenador { get; set; } = string.Empty;
        public string EmailCoordenador { get; set; } = string.Empty;
        public string CursoVinculado { get; set; } = string.Empty;
        public TipoEvento TipoEvento { get; set; }
        public bool RequerDivulgacao { get; set; }
        public bool RequerCerimonial { get; set; }
        public string? ObservacoesGerais { get; set; }

        // Lista de recursos solicitados
        public List<RecursoSolicitadoRequest>? RecursosSolicitados { get; set; }
    }
}
