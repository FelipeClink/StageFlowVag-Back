using StageFlowVag.Communication.Enums.AudioVisualEnums;

namespace StageFlowVag.Communication.Requests.Eventos
{
    public class AlterarStatusEventoRequest
    {
        public StatusEvento NovoStatus { get; set; }
        public string? Justificativa { get; set; }
    }
}
