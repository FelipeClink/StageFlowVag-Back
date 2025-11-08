using StageFlowVag.Communication.Enums.AudioVisualEnums;

namespace StageFlowVag.Communication.Requests.RecursosAudiosVisuais
{
    public class AtualizarRecursoAudiovisualRequest
    {
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public TipoRecursoAudiovisual Tipo { get; set; }
        public StatusRecurso Status { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public string? NumeroPatrimonio { get; set; }
        public string? Observacoes { get; set; }
    }
}
