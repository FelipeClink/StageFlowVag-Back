using StageFlowVag.Communication.Enums.AudioVisualEnums;

namespace StageFlowVag.Communication.Requests.Eventos
{
    public class AtualizarEventoRequest
    {
        public string Titulo { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Local { get; set; } = string.Empty;
        public int PublicoEstimado { get; set; }
        public TipoEvento TipoEvento { get; set; }
        public bool RequerDivulgacao { get; set; }
        public bool RequerCerimonial { get; set; }
        public string? ObservacoesGerais { get; set; }
    }
}
